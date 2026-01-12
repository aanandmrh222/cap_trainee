using System;
using System.Collections.Generic;
using System.Linq;

namespace AutonomousRobot.AI;

public enum RobotAction
{
    Stop, SlowDown, Reroute, Continue
}

public class SensorReading
{
    public int SensorId {get; set; }
    public string Type {get; set; }
    public double Value {get; set; }
    public DateTime Timestamp {get; set; }
    public double Confidence {get; set; }
}

public class DecisionEngine
{
    public static List<SensorReading> GetRecentReadings(List<SensorReading> sensorHistory, DateTime fromTime)
    {
        return sensorHistory.Where(r => r.Timestamp >= fromTime).ToList();
    }

    public static bool IsBatteryCritical(List<SensorReading> readings)
    {
        return readings.Any(r => r.Type == "Battery" && r.Value < 20);
    }

    public static double GetNearestObstacleDistance(List<SensorReading> readings)
    {
        var distance = readings.Where(r => r.Type == "Distance").Select(r => r.Value);
        return distance.Any() ? distance.Min() : double.MaxValue;
    }

    public static bool IsTemperatureSafe(List<SensorReading> readings)
    {
        return readings.Where(r => r.Type=="Temperature").All(r => r.Value<90);
    }

    public static double GetAverageVibration(List<SensorReading> readings)
    {
        var vibration = readings.Where(r => r.Type=="Vibration").Select(r => r.Value);
        return vibration.Any() ? vibration.Average() : 0;
    }

    public static Dictionary<string,double> CalculateSensorHealth(List<SensorReading> sensorHistory)
    {
        return sensorHistory.GroupBy(r => r.Type).ToDictionary(
            g => g.Key, 
            g => g.Average(r => r.Confidence)
            );
    }

    public static List<string> DetectFaultySensors(List<SensorReading> sensorHistory)
    {
        return sensorHistory.GroupBy(r => r.Type)
                            .Where(g => g.Count(r => r.Confidence < 0.4)>2)
                            .Select(g => g.Key)
                            .ToList();
    }

    public static bool IsBatteryDrainingFast(List<SensorReading> sensorHistory)
    {
        var batteyValues = sensorHistory.Where(r => r.Type=="Battery")
                                        .OrderBy(r => r.Timestamp)
                                        .Select(r => r.Value)
                                        .ToList();
        return batteyValues.Zip(batteyValues.Skip(1), (a,b) => b<a).All(x => x);
    }

    public static double GetWeightedDistance(List<SensorReading> readings)
    {
        var distances = readings.Where(r => r.Type=="Distance");
        double totalConfidence = distances.Sum(r => r.Confidence);

        if(totalConfidence == 0) return double.MaxValue;
        return distances.Sum(r => r.Value*r.Confidence)/totalConfidence;
    }

    public static RobotAction DecideRobotAction(List<SensorReading> recentReadings, List<SensorReading> sensorHistory)
    {
        if (IsBatteryCritical(recentReadings)) return RobotAction.Stop;

        if (GetNearestObstacleDistance(recentReadings) < 1.0) return RobotAction.Reroute;

        if (!IsTemperatureSafe(recentReadings) || GetAverageVibration(recentReadings) > 7) return RobotAction.SlowDown;

        return RobotAction.Continue;
    }

}


using System;
using System.Collections.Generic;
using System.Linq;

using AutonomousRobot.AI;

class RobotSensorCaller
{
    public static void RobotSensorCallerM()
    {
        DateTime now = DateTime.Now;

        List<SensorReading> sensorHistory = new List<SensorReading>
        {
            new SensorReading {SensorId=1, Type="Distance", Value=0.8, Confidence=0.9, Timestamp=now.AddSeconds(-8)},
            new SensorReading {SensorId=2, Type="Battery", Value=18, Confidence=0.8, Timestamp=now.AddSeconds(-7)},
            new SensorReading {SensorId=3, Type="Temperature", Value=92, Confidence=0.7, Timestamp=now.AddSeconds(-6)},
            new SensorReading {SensorId=4, Type="Vibration", Value=8.2, Confidence=0.6, Timestamp=now.AddSeconds(-5)},
            new SensorReading {SensorId=5, Type="Battery", Value=75, Confidence=0.9, Timestamp=now.AddSeconds(-4)},
            new SensorReading {SensorId=6, Type="Distance", Value=2.5, Confidence=0.5, Timestamp=now.AddSeconds(-3)},
        };

        var recentReadings = DecisionEngine.GetRecentReadings(sensorHistory, now.AddSeconds(-10));

        bool batteryCritical  = DecisionEngine.IsBatteryCritical(recentReadings);
        double nearestObstacle = DecisionEngine.GetNearestObstacleDistance(recentReadings);
        bool temperatureSafe = DecisionEngine.IsTemperatureSafe(recentReadings);
        double avgVibration = DecisionEngine.GetAverageVibration(recentReadings);

        var sensorHealth = DecisionEngine.CalculateSensorHealth(sensorHistory);
        var faultySensors = DecisionEngine.DetectFaultySensors(sensorHistory);
        bool batteryDrainFast  = DecisionEngine.IsBatteryDrainingFast(sensorHistory);

        double weightedDistance  = DecisionEngine.GetWeightedDistance(recentReadings);

        RobotAction action = DecisionEngine.DecideRobotAction(recentReadings, sensorHistory);

        Console.WriteLine($"Robot Action: {action}");
    }
}
using System;
using System.Collections.Generic;

public class CreatorStats
{
    public string CreatorName{get; set;}
    public double[] WeeklyLikes{get; set;}

}

public class StreamBuzz
{
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();

    public void RegisterCreator(CreatorStats record)
    {
        EngagementBoard.Add(record);
        Console.WriteLine("Creator registered successfully...");
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> res = new Dictionary<string, int>();
        foreach(CreatorStats creator in records)
        {
            int totalWeekLike = 0;
            foreach(double likes in creator.WeeklyLikes)
            {
                if(likes >= likeThreshold) totalWeekLike++;
            }
            if(totalWeekLike > 0)
            {
                res.Add(creator.CreatorName, totalWeekLike);
            }
        }
        return res;
    }

    public double CalculateAverageLikes()
    {
        double totalLikes = 0;
        int totalWeeks = 0;
        foreach(CreatorStats creator in EngagementBoard)
        {
            foreach(double likes in creator.WeeklyLikes)
            {
                totalLikes += likes;
                totalWeeks++;
            }
        }
        if(totalWeeks == 0) return 0;
        return totalLikes/totalWeeks;
    }


    public static void StreamBuzzCallerMethod()
    {
        StreamBuzz sb = new StreamBuzz();
        bool running = true;

        while(running)
        {
            Console.WriteLine("\n1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                CreatorStats creator = new CreatorStats();
                creator.WeeklyLikes = new double[4]; 

                Console.Write("Enter Creator Name: ");
                creator.CreatorName = Console.ReadLine();

                Console.WriteLine("Enter weekly likes (Week 1 to 4): ");
                for(int i=0; i<4; i++)
                {
                    creator.WeeklyLikes[i] = Convert.ToDouble(Console.ReadLine());
                }

                sb.RegisterCreator(creator);
                break;

                case 2:
                Console.Write("Enter like threshold: ");
                double threshold = Convert.ToDouble(Console.ReadLine());

                Dictionary<string, int> res =  sb.GetTopPostCounts(EngagementBoard, threshold);
                if(res.Count==0)
                {
                    Console.WriteLine("No top-performing posts this week");
                } else
                {
                    foreach(var item in res){
                           Console.WriteLine(item.Key + " -> " + item.Value); 
                    }    
                }
                break;

                case 3:
                double avg = sb.CalculateAverageLikes();
                Console.WriteLine("Overall average weekly likes: " + avg);
                break;

                case 4:
                Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                running = false;
                break;

            }
        }
    }
}
using System;
using System.Numerics;

namespace _11.SnowBalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfBalls = sbyte.Parse(Console.ReadLine());
            BigInteger bestQualityball = BigInteger.MinusOne;
            int snow = 0;
            int time = 0;
            int quality = 0;

            for (int i = 1; i <= numberOfBalls; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger score = BigInteger.Pow((snowBallSnow / snowBallTime),snowBallQuality);
                if (score > bestQualityball)
                {
                    bestQualityball = score;
                    snow = snowBallSnow;
                    time = snowBallTime;
                    quality = snowBallQuality;
                }

            }
            Console.WriteLine($"{snow} : {time} = {bestQualityball} ({quality})");
        }
    }
}

using System;

namespace q1AuroraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] balls = {"green","yellow","red","yellow","red","yellow","red","green", "green", "green", "green", "red", "red" };
            foreach (var ball in balls)
            {
                Console.Write(ball + " ");
            }
             withAdditionalMemory(balls);
            Console.WriteLine( " ");
            foreach (var ball in balls)
            {
                Console.Write(ball + " ");
            }
        }
     
        public static void withAdditionalMemory(string[] balls)
        {
            int countG = 0, countR = 0, countY = 0, i = 0;
            while(i<= balls.Length - countY - 1)
            { 
                switch (balls[i])
                {
                    case "yellow":
                        balls[i] = balls[balls.Length - countY - 1];
                        balls[balls.Length - countY - 1] = "yellow";
                        if (balls[i] == "green")
                            i--;
                        countY++;
                        break;
                    case "green":
                        balls[i] = balls[countG];
                        balls[countG] = "green";
                        countG++;
                        break;
                    default:
                        countR++;
                        break;
                }
                i++;

            }
            Console.Write("countG={0}, countR = {1}, countY ={2}", countG , countR, countY);
        }
    }
}

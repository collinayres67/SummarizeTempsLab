using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename;

            Console.WriteLine("Enter file name");
            filename = Console.ReadLine();

            if (File.Exists(filename))
            {
               
                Console.WriteLine("File exist");
                Console.WriteLine("enter threshold");
                string input;
                int threshold;
                input = Console.ReadLine();
                threshold = int.Parse(input);
                int sumTemps = 0;
                int numAbove = 0;
                int numBelow = 0;
                int tempCount = 0;

                using (StreamReader sr = File.OpenText(filename))
                {
                    string line = sr.ReadLine();
                    int temp;


                    while (line != null)
                    {



                        temp = int.Parse(line);
                        sumTemps += temp;
                        tempCount += 1;

                        if (temp >= threshold)
                        {
                            numAbove += 1;

                        }
                        else
                        {
                            numBelow += 1;

                        }

                        line = sr.ReadLine();
                    }

                }
                Console.WriteLine("Temperature above = " + numAbove);

                Console.WriteLine("Temperature below = " + numBelow);

                int average = sumTemps / tempCount;

                Console.WriteLine("average temp = " + average);
            }
            
               

            else
            {
                Console.WriteLine("file does not exist");
            }


       

            

        }
    }
}

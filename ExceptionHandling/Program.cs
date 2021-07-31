using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * ##########################################################################################
             *
             * Basic / general example
             *
             * ##########################################################################################
             */
            try
            {
                Console.WriteLine(Calculator.Divide(2, 0));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message + "\n" + e.GetType());
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.GetType());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block! Mostly used for managed resources (not managed by CLR --> No garbage collection applied by CLR.\n");
            }

            /*
             * ##########################################################################################
             *
             * Example for IDisposable usage in finally block and using-statement
             *
             * ##########################################################################################
             */
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"C:\Users\HAL9000\file.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                streamReader?.Dispose();
            }

            // Improved with using-statement
            try
            {
                using var sr = new StreamReader("TestFile.txt");
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n");


            /*
             * ##########################################################################################
             *
             * Custom Exception example
             *
             * ##########################################################################################
             */

            try
            {
                var api = new YoutubeApi();
                api.GetVideos("Olli");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.InnerException);
            }

        }
    }
}

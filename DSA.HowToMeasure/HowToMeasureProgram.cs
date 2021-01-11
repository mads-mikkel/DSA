﻿/* Author: Mads Mikkel Rasmussen, copyright 2021, all rights reserved.
 * Repo: 
 * Instructions: Use Visual Studio RELEASE configuration for most accurate results. The generated
 * application should not be started from Visual Studio, but from its location in the 
 * bin/release/net5.0 folder
 * 
 * This program illustrates how to perform measurements on an algorithm. Here we want to measure
 * how the .NET array sort algorithm performs. We start by arranging the necessary variables to 
 * perform the measurements. Then we generate random data. The measurement itself is a StopWatch
 * instance started as the last operation before the sort algorithm is called on the array instance,
 * and stopped immediately after. Then we present the results of the mesurements, individually and 
 * as an average. This average is used as the measurement of the performance of the algorithm, to
 * flatten out any inconsistent measurements. */

using System;
using System.Diagnostics;
using System.Linq;
using static System.Console;

namespace DSA.HowToMeasure
{
    class HowToMeasureProgram
    {
        static void Main()
        {
            // Arrange:
            int runs = 10;                                          // Number of measurements
            long[] ticks = new long[runs];                          // Array to hold the measuments
            int elements = 10_000_000;                              // Number of elements

            // Generate data:
            for(int i = 0; i < runs; i++)                           // Loop for each run
            {
                Random generator = new Random();                    // Random number generator
                int[] array = new int[elements];                    // Array to hold the generated numbers
                for(int j = 0; j < array.Length - 1; j++)           // Loop for each generated number
                {
                    array[j] = generator.Next(0, Int32.MaxValue);   // Save generated number to array entry  
                }

                // Measure:
                Stopwatch stopwatch = new Stopwatch();              // Create stop watch
                stopwatch.Start();                                  // Start measurement
                Array.Sort(array);                                  // PERFORM ALGORITHM
                stopwatch.Stop();                                   // Stop measurement

                // Measurement presentation:
                long measuredTicks = stopwatch.Elapsed.Ticks;       // Save measurement
                ticks[i] = measuredTicks;                           // Save mesurem
                string runResult = $"Run {i + 1}: {measuredTicks}"; // Textualized measurement
                WriteLine(runResult);                               // Print mesurement
            }

            WriteLine($"Avg: {ticks.Average()}");                   // Print average of measurements
            ReadLine();                                             // Keep console open
        }
    }
}
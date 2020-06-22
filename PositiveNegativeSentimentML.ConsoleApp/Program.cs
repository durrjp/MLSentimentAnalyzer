// This file was auto-generated by ML.NET Model Builder. 

using System;
using PositiveNegativeSentimentML.Model;

namespace PositiveNegativeSentimentML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Comment = @"  ==He is a Rapist!!!!!== Please edit the article to include this important fact. Thank You.  — Preceding unsigned comment added by   •   ",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");
            Console.WriteLine($"Comment: {sampleData.Comment}");
            Console.WriteLine($"\n\nPredicted Label value {predictionResult.Prediction} \nPredicted Label scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}

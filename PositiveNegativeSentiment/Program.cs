using PositiveNegativeSentimentML.Model;
using System;

namespace PositiveNegativeSentiment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            input.Comment = Console.ReadLine();

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            if(result.Prediction == "1")
            {
                Console.WriteLine($"Text: {input.Comment}\nThis feedback is negative");
            }
            else
            {
                Console.WriteLine($"Text: {input.Comment}\nThis feedback is positive!");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOopDataStructuresDesignPatterns
{
    internal class FactoryDesignPattern
    {
        //Factory
        public interface ICar
        {
            void Drive();
        }

        public class Sedan : ICar
        {
            public void Drive() => Console.WriteLine("Driving Sedan");
        }

        public class CarFactory
        {
            public static ICar CreateCar(string type)
            {
                if (type == "Sedan")
                    return new Sedan();
                // Add other types here
                throw new ArgumentException("Invalid car type");
            }
        }
        //var car = CarFactory.CreateCar("Sedan");
        //car.Drive();  // Output: Driving Sedan
    }

    //strategy pattern to handle different algorithms in a system?
    public class StrategyPattern
    {
        public interface ISortingStrategy
        {
            void Sort(List<int> data);
        }

        public class QuickSort : ISortingStrategy
        {
            public void Sort(List<int> data) { }
        }

        public class MergeSort : ISortingStrategy
        {
            public void Sort(List<int> data) { }

        }

        public class DataProcessor
        {
            private ISortingStrategy _sortingStrategy;

            public DataProcessor(ISortingStrategy sortingStrategy)
            {
                _sortingStrategy = sortingStrategy;
            }

            public void ProcessData(List<int> data)
            {
                _sortingStrategy.Sort(data);
            }
        }

        // Usage:
        // var processor = new DataProcessor(new QuickSort());
        // processor.ProcessData(myData);  // Sorts data using QuickSort
    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10ExerciseOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialData = { 10, 20, 30, 40, 50 };
            using (Class1 largeDataCollection = new Class1(initialData))
            {
                //demonstrate adding elements to the collection
                largeDataCollection.AddElement(60);
                largeDataCollection.AddElement(70);

                //demonstrates accessing elements in the collection
                largeDataCollection.AccessElement(2);

                //demonstrate removing elements from the collection
                largeDataCollection.RemoveElement(40);

                //accessing elements after removing elements from the collection
                largeDataCollection.AccessElement(3);

                //till here the largeDataCollection object has been disposed of automatically due to 'using' statement
                Console.ReadKey();
            }
        }
    }
}

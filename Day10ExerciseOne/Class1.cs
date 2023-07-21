using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10ExerciseOne
{
    public class Class1 : IDisposable
    {
        private bool disposed = false;
        private int[] data;

        public Class1(int[] initialData)
        {
            data = initialData;
        }

        public void AddElement(int element)
        {
            //adding the element at the end of the array
            int[] newData = new int[data.Length + 1];
            data.CopyTo(newData, 0);
            newData[newData.Length - 1] = element;
            data = newData;
        }

        public void RemoveElement(int element)
        {
            int index = Array.IndexOf(data, element);
            if(index >= 0)
            {
                //removing the element at the end of the array
                int[] newData = new int[data.Length - 1];
                if(index > 0)
                Array.Copy(data, 0, newData, 0, index);
                if(index < data.Length - 1)
                Array.Copy(data, index + 1, newData, index, data.Length - index - 1);
                data = newData;
            }
            else
            {
                Console.WriteLine($"Element {element} not found in the collection.");
            }
        }

        public void AccessElement(int index)
        {
            if (index >= 0 && index < data.Length)
            {
                int element = data[index];
                Console.WriteLine($"Elemenr at index {index} : {element}");
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //release any managed resources here
                }
                //release any unmanaged resources here
                data = null;
                disposed = true;
            }
        }

    }
}

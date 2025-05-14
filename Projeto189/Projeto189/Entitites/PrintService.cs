using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto189.Entitites
{
    internal class PrintService<T>
    {
        private T[] values = new T[10];
        private int count = 0;

        public void AddValue(T value)
        {
            if (count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }

            values[count] = value;
            count++;
        }

        public T First()
        {
            return values[0];
        }

        public void Print() 
        {
            Console.Write("[");
            for (int i = 0; i < count - 1; i++) 
            {
                Console.Write(values[i] + ", ");
            }
            if (count > 0)
            {
                Console.Write(values[count - 1]);
            }
            Console.Write("]");
        }
    }
}

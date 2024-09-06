using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Scrambler
    {
        private static Scrambler instance;
        private Random random;

        private Scrambler()
        {
            random = new Random();
        }

        public static Scrambler GetInstance()
        {
            if (instance == null)
                instance = new Scrambler();

            return instance;
        }

        public void Scramble<T>(List<T> numbers)
        {
            int count = numbers.Count;
            
            while(count > 1)
            {
                count--;
                int k = random.Next(count + 1);
                T value = numbers[k];
                numbers[k] = numbers[count];
                numbers[count] = value;
            }
        }


    }
}

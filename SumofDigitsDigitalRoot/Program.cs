using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofDigitsDigitalRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine(program.DigitalRoot(999999999999));
            Console.ReadKey();
        }

        public int DigitalRoot(long n)
        {
            Console.WriteLine(n);
            string count = n.ToString();
            long result = 0;
            for (int i = 0; i < count.Length; i++)
            {
                
                    result += Math.Abs(n % 10);
                    n /= 10;
                
            }
                string countTheEnd = result.ToString();
                int over = (int)result;
            if (countTheEnd.Length>1)
            {
                over = 0;
                for (int j = 0; j < countTheEnd.Length; j++)
                {
                    over += (int)result % 10;
                    result /= 10;
                }
            }

            return over;
        }

        public int DigitalRoot1(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }

        public int DigitalRoot2(long n)
        {
            if (n < 10) return (int)n;
            long r = 0;
            while (n > 0)
            {
                r += n % 10;
                n /= 10;
            }
            return DigitalRoot2(r);
        }

        public long DigitalRoot3(long n)
        {
            return n < 10 ? n : DigitalRoot3(n / 10 + n % 10);
        }
    }
}

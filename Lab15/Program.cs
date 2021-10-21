using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arPr = new ArithProgression();
            arPr.setStart(3);
            arPr.getNext();
            arPr.reset();
            arPr.getNext();
            GeomProgression geomPr = new GeomProgression();
            geomPr.setStart(3);
            geomPr.getNext();
            geomPr.reset();
            geomPr.getNext();

            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int step;
        int a;
        int n;
        int start;

        public int getNext()
        {
            Console.Write("Количество членов арифметической прогрессии = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Шаг прогрессии = ");
            step = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Полученная арифметическая прогрессия:");
            for (int i = 1; i < n + 1; i++)
            {
                a = start + (i - 1) * step;
                Console.WriteLine(a);
            }
            return a;
        }

        public void reset()
        {
            Console.WriteLine("Начальное значение ={0}", start);
        }

        public void setStart(int x)
        {
            Console.WriteLine("Начальное значение ={0}", x);
            start = x;
        }
    }

    class GeomProgression : ISeries
    {
        int ratio;
        int a;
        int n;
        int start;

        public int getNext()
        {
            Console.Write("Количество членов геометрической прогрессии = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Шаг прогрессии = ");
            ratio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Полученная геометрической прогрессия:");
            for (int i = 1; i < n + 1; i++)
            {
                a = start * (int)Math.Pow(ratio, i - 1);
                Console.WriteLine(a);
            }
            return a;
        }

        public void reset()
        {
            Console.WriteLine("Начальное значение ={0}", start);
        }

        public void setStart(int x)
        {
            Console.WriteLine("Начальное значение ={0}", x);
            start = x;
        }
    }

}


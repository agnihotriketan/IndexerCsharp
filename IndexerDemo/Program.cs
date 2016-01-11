using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc[0] = "Ketan";
            mc[1] = "India";
            mc[2] = "Nashik";
            mc[3] = "Pune";
            mc[4] = "Mumbai";
            Console.WriteLine("{0},{1},{2},{3},{4}", mc[0], mc[1], mc[2], mc[3], mc[4]);
            Console.WriteLine("Overloaded indexer gives index of 'Nashik' string in list i.e. --> " + mc["Nashik"]);
            Console.ReadLine();
        }
    }

    class MyClass
    {
        private string[] data = new string[5];
        public string this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }


        // Overloaded indexer
        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < data.Length)
                {
                    if (data[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }

        }
    }

}

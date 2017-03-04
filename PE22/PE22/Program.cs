using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE22
{
    class Program
    {
        static void Main(string[] args)
        {
            // attributes
            Tree demo = new Tree();
            Random rando = new Random();
            const int LOOP_NUM = 12;

            // loop to create 12 random numbers and put them in the tree
            for(int x = 0; x < LOOP_NUM; x++)
            {
                demo.Insert(rando.Next(0, 101));
            }

            // print out tree
            demo.Print();
            
        }
    }
}

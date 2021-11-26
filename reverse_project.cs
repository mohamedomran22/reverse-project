using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> MoList = new LinkedList<string>();

            LinkedListNode<string> MoNode = MoList.AddFirst("X1");
            MoList.AddFirst("x2");
            MoList.AddFirst("x3");
            MoList.AddBefore(MokshNode, "X4");
            MoList.AddLast("Losted");

            Console.WriteLine("Before reversing linked list:  ");

            foreach (var item in MoList)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();
            Console.WriteLine("After reversing linked list: ");

            foreach (var item in MoList.Reverse())
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

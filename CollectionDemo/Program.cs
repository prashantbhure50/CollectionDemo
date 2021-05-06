using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            doList();
            doStackDemo();
            doQueueDemo();
            doSETDemo();
            doDictonaryDemo();
        }
        private static void doList()
        {
            Console.WriteLine("***************");
            Console.WriteLine("** LIST **");
            List<string> list = new List<string>();
            list.Add("alok");
            list.Add("bhure");
            list.Add("prashant");
            list.Add("bhure");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
        private static void doStackDemo()
        {
            Console.WriteLine("***************");
            Console.WriteLine("** STACK **");
            Stack<string> stack = new Stack<string>();
            stack.Push("alok");
            stack.Push("bhure");
            stack.Push("prashant");
            stack.Push("bhure");

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
        private static void doQueueDemo()
        {
            Console.WriteLine("***************");
            Console.WriteLine("** Queue **");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("alok");
            queue.Enqueue("bhure");
            queue.Enqueue("prashant");
            queue.Enqueue("bhure");

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string s = queue.Dequeue();
            Console.WriteLine("deque element is  "+ s);
            Console.WriteLine("***************");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }

        }
        private static void doSETDemo()
        {
            Console.WriteLine("***************");
            Console.WriteLine("** SET **");
            var set = new HashSet<string>();
            set.Add("alok");
            set.Add("bhure");
            set.Add("prashant");
            set.Add("bhure");

            foreach (var element in set)
            {
                Console.WriteLine(element);
            }
        }
        private static void doDictonaryDemo()
        {
            Console.WriteLine("***************");
            Console.WriteLine("** Dictonary **");
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(1,"alok");
            dic.Add(2,"bhure");
            dic.Add(3,"prashant");
            dic.Add(4,"bhure");

            foreach (var element in dic)
            {
                Console.WriteLine(element);
            }
        }
    }
}

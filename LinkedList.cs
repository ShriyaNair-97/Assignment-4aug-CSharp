using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAndList
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<string> lList = new LinkedList<string>(new string[] {"quick","fox","the","lazy"});
          
            Console.WriteLine("After Add First method");

            lList.AddFirst("the");

            Console.WriteLine("After Find and AddAfter method");

            LinkedListNode<String> temp = lList.Find("quick");

            lList.AddAfter(temp,"brown");

            Console.WriteLine("After Find and AddBefore method");

            LinkedListNode<String> temp1 = lList.FindLast("the");

            lList.AddBefore(temp1, "over");

            Console.WriteLine("After Find and AddBefore method");

            LinkedListNode<String> temp2 = lList.FindLast("over");
            
            lList.AddBefore(temp2, "jumps");

            Console.WriteLine("AfterLast method");

            lList.AddLast("fox");

            Console.WriteLine("The final output :");
         
            foreach (var i in lList)
            {
                Console.WriteLine(i);
            }

        }
    }
}

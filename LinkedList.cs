using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lList = new LinkedList<string>(new string[] {"quick","fox","the","lazy"});
            //a.AddFirst()
            //b.AddLast()
            //c.AddAfter()
            //d.AddBefore()
            //e.Find()
            //f.FindLast()
        

            
            lList.AddFirst("the");
            LinkedListNode<String> temp = lList.Find("quick");
            lList.AddAfter(temp,"brown");
            LinkedListNode<String> temp1 = lList.FindLast("the");
            lList.AddBefore(temp1, "over");
            LinkedListNode<String> temp2 = lList.FindLast("over");
            lList.AddBefore(temp2, "jumps");
            lList.AddLast("fox");
            
         
            foreach (var i in lList)
            {
                Console.WriteLine(i);
            }

        }
    }
}

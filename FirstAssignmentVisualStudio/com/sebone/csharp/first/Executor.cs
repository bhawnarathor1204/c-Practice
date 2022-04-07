using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignmentVisualStudio.com.sebone.csharp.first
{
    internal class Executor
    {
        public static void Main(String[] args)
        {
            Occurence occurence = new Occurence();
            Console.WriteLine(occurence.countOccurence("bhawna", 'a'));
        }
    }
}

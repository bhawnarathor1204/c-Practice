using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignmentVisualStudio.com.sebone.csharp.first
{
    public class Occurence
    {
        public int countOccurence(String s,char ch)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == ch)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

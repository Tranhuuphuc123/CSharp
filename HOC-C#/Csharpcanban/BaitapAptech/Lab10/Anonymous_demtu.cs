using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*sử dụng Anonymous để đếm từ*/

namespace Lab10_Anonymous
{
    delegate int GetWords(String s);
     class Anonymous_demtu
    {
        static void Main(String[] args)
        {
            GetWords doantu = delegate (String s)
            {
                int count = 0;
                if (s[0] != ' ')
                {
                    count = 1;
                }
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == ' ' && s[i + 1] != ' ')
                    {
                        count++;
                    }
                }
                return count;
            };


        }
    }
}

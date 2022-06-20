using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExtendido
    {
        public static bool TieneDiezCaracteres(this String s)
        {
            if(s.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool MenorA(this String s, int num)
        {
            if (s.Length < num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

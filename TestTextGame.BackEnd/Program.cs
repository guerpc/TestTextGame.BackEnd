using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestTextGame.BackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor a1 = new Actor();
            a1.modifyAc(10);
            a1.modifyHp(10);

            a1.modifySta(10);
            a1.modifyAgi(10);
            a1.modifyStr(10);

            Console.WriteLine(a1.Ac);
            Console.WriteLine(a1.Hp);
            Console.WriteLine(a1.showStats());
            //Console.WriteLine(a1.showStats());
        }
    }
}

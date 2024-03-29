using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Present<ICreat> pres=new Present<ICreat>("попугай");

            Human human=new Human();
            Elf elf=new Elf();
            Gnom gnom=new Gnom();
            Console.OutputEncoding=Encoding.UTF8;

            pres.OpenBAG(human);
            pres.OpenBAG(gnom);
            pres.OpenBAG(elf);
            pres.OpenBAG(gnom);
            pres.OpenBAG(elf);
            pres.OpenBAG(human);

        }

    }
}

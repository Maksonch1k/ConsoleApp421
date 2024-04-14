using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Human : ITalk, IThink
    {
        public void TalkLoud()
        {
            Console.WriteLine("Говорит громко - Я люблю программирование !");
        }

        public void IThink()
        {
            Console.WriteLine("Думает - А C# больше всего");
        }

        public void TalkNormal()
        {
            Console.WriteLine("Говорит нормально - Меньше люблю компьютерные игры");
        }
    }
}

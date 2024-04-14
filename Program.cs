using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DerivedClass dClass = new DerivedClass();
            //dClass.Method();
            Console.ReadKey();
            // Создаем объект класса MyClass
            MyClass myClass = new MyClass();

            // Вызываем методы интерфейса
            //Console.WriteLine("Число PI: " + myClass.GetPI());
            //Console.WriteLine("Целое число: " + myClass.GetInt());
            //Console.WriteLine("Квадрат числа 5: " + myClass.Square(5));
            //Console.WriteLine("Корень квадратный из 25: " + myClass.SquareRoot(25));
            //DerivedClass dClass = new DerivedClass();
            //dClass.Method1();
            //dClass.Method2();
            //dClass.Method3();
            Human person = new Human();

            Console.WriteLine("Человек:");
            person.TalkLoud();
            ((IThink)person).IThink();
            person.TalkNormal();
        }
    }
    }
    
        

    


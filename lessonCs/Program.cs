using lessonCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//      Инкапсуляция

namespace Lesson
{
    class Gun
    {
        private bool isLoaded;
        private void Reload()
        {
            Console.WriteLine("Заряжаю");
            isLoaded= true;
            Console.WriteLine("Заряжено");

        }
        public void Shoot()
        {
            if(!isLoaded)
            {
                Console.WriteLine("Оружие не заряжено");

                Reload();
            }
            Console.WriteLine("ПИФ-ПАФ!!!!");
            isLoaded= false;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
           Gun gun = new Gun(); 
            gun.Shoot();
            gun.Shoot();
            gun.Shoot();
            gun.Shoot();
            gun.Shoot();


            Console.ReadLine();
        }

        
    }
}

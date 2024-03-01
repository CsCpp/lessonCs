using lessonCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
//      Конструктор

namespace Lesson
{
    class Gun
    {
        public Gun(bool isLoaded=false)
        {
            if(isLoaded) Reload();
                
        }


        private bool _isLoaded;
        private void Reload()
        {
            Console.WriteLine("Заряжаю");
            _isLoaded= true;
            Console.WriteLine("Заряжено");

        }
        public void Shoot()
        {
            if(!_isLoaded)
            {
                Console.WriteLine("Оружие не заряжено");

                Reload();
            }
            Console.WriteLine("ПИФ-ПАФ!!!!");
            _isLoaded= false;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
           Gun gun = new Gun(isLoaded:true); 
            gun.Shoot();
            gun.Shoot();
           
            Console.ReadLine();
        }

        
    }
}

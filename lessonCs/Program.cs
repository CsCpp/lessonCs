using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
// наследование интерфейсов



namespace Lesson
{
    interface IWeapon
    {
        void Fire();
    }
    interface ITrowWeapon: IWeapon
    {
        void Trow();
    }
    class Gun : IWeapon
    {
        public void Fire()
        {

            Console.WriteLine($"{GetType().Name}: Пыщ!");
        }
    }
    class LaserGun : IWeapon
    {
        public void Fire()
        {

            Console.WriteLine($"{GetType().Name}: Пиу!");
        }

       
    }
    class Knife : ITrowWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: ШлЁп!");
        }
        public void Trow()
        {
            Console.WriteLine($"{GetType().Name}: СВИЩЬЬЬ!");
        }
    }
    class Player
    {
        public void Fire(IWeapon wepon) 
        {
        wepon.Fire();
        }
        public void Throw(ITrowWeapon weapon)
        {
           weapon.Trow();

        }
    }
    class Program
    {       
        static void Main(string[] args)
        {
          Player player = new Player();
            IWeapon[] inventory = {new Gun(), new LaserGun(), new Knife() };
            foreach (var item in inventory)
            {
                player.Fire(item);
            }
            player.Throw(new Knife());  
            Console.ReadLine();
        }
               
    }
}

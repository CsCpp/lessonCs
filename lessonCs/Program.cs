using lessonCs;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      OOП
// полтморфизм
// обстрактный класс, метод, свойство


namespace Lesson
{
    abstract class Weapon
    {
        public abstract void Fire();
        public abstract int Damage { get; }

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage: {Damage}");

        }
        
    }
   class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
        public void ShowInfo(Weapon weapon)
        {
        weapon.ShowInfo();  
        }
    }
    class Gun : Weapon
    {
        public override int Damage { get { return 23; } }

        public override void Fire()
        {
            Console.WriteLine("BUM!");
        }
    }
    class Bow : Weapon
    {
        public override int Damage => 3;
        public override void Fire()
        {
            Console.WriteLine("Fiuxxx!");
        }
    }

    class Program
    {       
        static void Main(string[] args)
        {
           Player player = new Player();
            Weapon[] inwentory = {new Gun(),new Bow()};
            foreach (var iter in inwentory) 
            {
                player.ShowInfo(iter);
                player.Fire(iter);
                Console.WriteLine();
            }
            



            Console.ReadLine();
        }
               
    }
}

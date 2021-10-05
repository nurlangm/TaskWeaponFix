using System;

namespace Weapon
{
    class Program
    {
        static void Main(string[] args)
        {
            Rifle rf1 = new Rifle();
            Console.WriteLine("Gulle sayi:");
            int T_ammo = int.Parse(Console.ReadLine());
            rf1.MaxAmmo = T_ammo;
            Console.WriteLine("Tutum:");
            int cap = int.Parse(Console.ReadLine());
            rf1.Daraq = cap;

            if (T_ammo >= cap)
            {
                Console.WriteLine("Istifade olunacaq gulle sayi:");
                int usedammo = int.Parse(Console.ReadLine());
                rf1.UAmmo = usedammo;
                rf1.Reload();
            }
            rf1.Shot();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon
{
    class Rifle
    {
        public int MaxAmmo;
        public int UAmmo;
        private int _capacity;
        public Rifle()
        {

        }
        public Rifle(int cap, int maxAmmo, int uAmmo)
        {
            _capacity = cap;
            MaxAmmo = maxAmmo;
            UAmmo = uAmmo;
        }
        public int Daraq
        {
            get
            {
                if (_capacity == 0)
                {
                    return -1;
                }
                return _capacity;
            }
            set
            {
                if (value < 10 || value > 40)
                {
                    Console.WriteLine("10 ile 40 arasi olmalidir");
                    return;
                }
                _capacity = value;
            }
        }

        public void Shot()
        {
            for (int i = 0; i < MaxAmmo; i++)
            {
                if (i == Daraq && Daraq > UAmmo)
                {
                    MaxAmmo -= Daraq - (Daraq - UAmmo);
                }
                if (MaxAmmo < Daraq)
                {
                    Console.WriteLine("Yeterince gulleniz yoxdur");
                    break;
                }if (MaxAmmo < Daraq)
                {
                    Console.WriteLine("Daraq tutumdan Boyuk Ola bilmez");
                    break;

                }
            }

            Console.WriteLine($"Gulleniz ne qederdi : {MaxAmmo - UAmmo + Daraq - UAmmo}");
        }
        public void Reload()
        {
            if (Daraq >= UAmmo)
            {
                if (Daraq == UAmmo)
                {
                    Console.WriteLine("Yenilendi");
                }
                else
                    Console.WriteLine($"Daraqda {Daraq - UAmmo} gulle qalib");
            }
            else Console.WriteLine("Tutum,istifade olunacaq gulle sayindan az ola bilmez");
            
        }
    }
}
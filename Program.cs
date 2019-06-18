using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MotorVeicle
    {
        public string Targa { get; set; }
        public int LivelloCarburante { get; set; }
    }

    class Car : MotorVeicle
    {
        public Car(string targa) => Targa = targa;

        public void Acelera()
        {
            if (LivelloCarburante == 0)
            {
                throw new NotImplementedException("devo ancora implementare l'eccezione customizzata");
            }
            else
            {
                Console.WriteLine("wwwrrroomm");
                LivelloCarburante -= 1;
            }
        }

    }
}

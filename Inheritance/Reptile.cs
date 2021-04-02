using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }

        public bool HaveTeeth { get; set; }
        public bool Coldblooded { get; set; }
        public bool LaysEggs { get; set; }
        public bool Camoflauges { get; set; }
    }
}

using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
        }

        public bool Wings { get; set; }
        public bool Beaks { get; set; }
        public string WingSize { get; set; }
        public bool CanFly { get; set; }
    }
}

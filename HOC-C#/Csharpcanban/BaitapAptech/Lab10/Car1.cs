using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Anonymous
{
    partial class Car
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        private string color;
        public string Color
        {
            get { return color; }
            set
            {
                 color = value;
            }
        }

        private string maker;
        public string Maker
        {
            get { return maker; }
            set
            {
                maker = value;
            }
        }

        // contructor
        public Car() { }

        public Car(string name, string color, string maker, DateTime buydate)
        {
            this.name = name;
            this.Color = color;
            this.Maker = maker;
           
        }
    }
}

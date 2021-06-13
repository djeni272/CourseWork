using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Work_1
{
    public class Stars : Galaxy
    {

        public string parentName
        {
            get { return this.parentName; }
            set
            {
                this.parentName = value;
            }
        }
        public string klas
        {
            get { return this.klas; }
            set
            {
                this.klas = value;
            }
        }
        public double size
        {
            get { return this.size; }
            set
            {
                this.size = value;
            }

        }
        public int temperature
        {
            get { return this.temperature; }
            set
            {
                this.temperature = value;
            }
        }
        public double luminosity
        {
            get { return this.luminosity; }
            set
            {
                this.luminosity = value;
            }

        }
        public int mass
        {
            get { return this.mass; }
            set
            {
                this.mass = value;
            }
        }
        public Stars()
        {

        }
        public Stars(string parentName, string klas, double size, int temperature, double luminosity, int mass)
        {
            this.parentName = parentName;
            this.klas = klas;
            this.size = size;
            this.temperature = temperature;
            this.luminosity = luminosity;
            this.mass = mass;

            if (temperature >= 30.00
                && luminosity >= 30000
                && mass >= 16
                && size >= 6.6)
            {
                this.klas = "O";

            }
            if (temperature >= 10000 && temperature >= 30000
                && luminosity >= 25 && luminosity >= 30000
                && mass >= 2.1 && mass >= 16
                && size >= 1.8 && size >= 6.6)
            {
                this.klas = "B";

            }
            if (temperature >= 10000 && temperature >= 30000
                && luminosity >= 25 && luminosity >= 30000
                && mass >= 2.1 && mass >= 16
                && size >= 1.8 && size >= 6.6)
            {
                this.klas = "B";

            }
            if (temperature >= 7500 && temperature >= 10000
                && luminosity >= 5 && luminosity >= 25
                && mass >= 1.4 && mass >= 2.1
                && size >= 1.4 && size >= 1.8)
            {
                this.klas = "A";

            }
            if (temperature >= 6000 && temperature >= 75000
                && luminosity >= 1.5 && luminosity >= 5
                && mass >= 1.04 && mass >= 1.4
                && size >= 1.15 && size >= 1.4)
            {
                this.klas = "F";

            }
            if (temperature >= 5200 && temperature >= 6000
                && luminosity >= 0.6 && luminosity >= 1.5
                && mass >= 0.8 && mass >= 1.04
                && size >= 0.96 && size >= 1.15)
            {
                this.klas = "G";

            }
            if (temperature >= 3700 && temperature >= 52000
                && luminosity >= 0.08 && luminosity >= 0.6
                && mass >= 0.45 && mass >= 0.8
                && size >= 0.7 && size >= 0.96)
            {
                this.klas = "K";

            }
            if (temperature >= 2400 && temperature >= 37000
                && luminosity <= 0.08
                && mass >= 0.8 && mass >= 0.45
                && size <= 0.7)
            {
                this.klas = "M";

            }

        }
    }
}



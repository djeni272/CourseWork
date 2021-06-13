using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Work_1
{
    public class Planet : Stars
    {
        public string Data { get; set; }


        public string terrestrial
        {
            get { return this.terrestrial; }
            set
            {
                this.terrestrial = value;
            }
        }
        public string giant
        {
            get { return this.giant; }
            set
            {
                this.giant = value;
            }
        }
        public string icegiant
        {
            get { return this.icegiant; }
            set
            {
                this.icegiant = value;
            }
        }
        public string mesoplanet
        {
            get { return this.mesoplanet; }
            set
            {
                this.mesoplanet = value;
            }
        }
        public string minineptune
        {
            get { return this.minineptune; }
            set
            {
                this.minineptune = value;
            }
        }
        public string planetar
        {
            get { return this.planetar; }
            set
            {
                this.planetar = value;
            }
        }
        public string superjupiter
        {
            get { return this.superjupiter; }
            set
            {
                this.superjupiter = value;
            }
        }
        public string superearth
        {
            get { return this.superearth; }
            set
            {
                this.superearth = value;
            }
        }
        public string subearth
        {
            get { return this.subearth; }
            set
            {
                this.subearth = value;

            }
        }

        public Planet()
        {

        }

        public Planet(string terrestrial, string giant,
            string icegiant, string mesoplanet, string minineptune, string planetar, string superjupiter, string superearth, string subearth)
        {
            this.terrestrial = terrestrial;
            this.giant = giant;
            this.icegiant = icegiant;
            this.mesoplanet = mesoplanet;
            this.minineptune = minineptune;
            this.planetar = planetar;
            this.superjupiter = superjupiter;
            this.superearth = superearth;
            this.subearth = subearth;

        }
    }
}

}

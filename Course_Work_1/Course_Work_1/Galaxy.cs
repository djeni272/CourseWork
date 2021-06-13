using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Work_1
{
    public class Galaxy
    {
        public string name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }

        public string age
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }
        }

        public string type
        {
            get { return this.type; }
            set
            {
                switch (type)
                {
                    case "elliptical":
                        Console.WriteLine("Type: elliptical");
                        break;
                    case "lenticular":
                        Console.WriteLine("Type: lenticular");
                        break;
                    case "spiral":
                        Console.WriteLine("Type: spiral");
                        break;
                    case "irregular":
                        Console.WriteLine("Type: irregular");
                        break;
                }
                this.type = value;
            }
        }

        public string Stars
        {
            get { return this.Stars; }
            set
            {
                this.Stars = value;
            }
        }

        public Galaxy()
        {

        }
        public Galaxy(string name, string age, string type)
        {
            this.name = name;
            this.age = age;
            this.type = type;
        }
    }
}



using System;
using System.Collections.Generic;

namespace Course_Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Galaxy> Galaxies = new List<Galaxy>();
            List<Stars> Stars = new List<Stars>();
            List<Planet> Planets = new List<Planet>();
            List<Moons> Moons = new List<Moons>();

            for (; ; )
            {
                string input = Console.ReadLine().Trim();
                string[] data = input.Split(' ');
                if (data[0] == "add")
                {
                    switch (data[1])
                    {
                        case "galaxy":
                            string[] galaxyTypes = { "elliptical", "lenticular", "spiral", "irregular" };
                            Galaxy newGalaxy = new Galaxy();
                            newGalaxy.name = input.Split('[')[1].Split(']')[0];
                            if (Array.Exists(galaxyTypes, element => element == input.Split(']')[1].Split(' ')[1]))
                            {
                                newGalaxy.type = input.Split(']')[1].Split(' ')[1];
                            }

                            newGalaxy.age = input.Split(']')[1].Split(' ')[2];
                            Galaxies.Add(newGalaxy);
                            break;

                        case "star":
                            Stars newStar = new Stars();
                            newStar.parentName = input.Split('[')[1].Split(']')[0];
                            newStar.name = input.Split('[')[2].Split(']')[0];
                            newStar.klas = input.Split(']')[2].Trim();
                            Stars.Add(newStar);
                            break;

                        case "planet":
                            string[] planetTypes = { "terrestrial", "giant planet ", "ice planet",
                                "mesoplanet", "mini-neptune","planetar", "super-earth","super-jupiter", "sub-earth"};
                            Planet newPlanet = new Planet();
                            newPlanet.parentName = input.Split('[')[1].Split(']')[0];
                            newPlanet.name = input.Split('[')[2].Split(']')[0];
                            string Data = input.Split(']')[2].Trim();
                            if (Array.Exists(planetTypes, value => value == Data.Remove(Data.Length - 3).Trim()))
                            {
                                newPlanet.Data = Data;
                            }
                            Planets.Add(newPlanet);
                            break;
                        case "moon":
                            Moons newMoon = new Moons();
                            newMoon.parentName = input.Split('[')[1].Split(']')[0];
                            newMoon.name = input.Split('[')[1].Split(']')[0];
                            Moons.Add(newMoon);
                            break;
                        default:
                            continue;
                    }

                }
                else if ("stats".Equals(data[0]))
                {
                    Console.WriteLine("--- Stats ---");
                    Console.WriteLine($"Galaxies: {Galaxies.Count}");
                    Console.WriteLine($"Stars: {Stars.Count}");
                    Console.WriteLine($"Planet: {Planets.Count}");
                    Console.WriteLine($"Moons: {Moons.Count}");
                    Console.WriteLine("--- End of Stats ---");
                }
                else if ("list".Equals(data[0]))
                {
                    string allObjectsFromType = "";
                    switch (data[1])
                    {
                        case "galaxies":
                            Console.WriteLine("--- List of all researched galaxies ---");
                            foreach (var galaxy in Galaxies)
                            {
                                allObjectsFromType += galaxy.name + ", ";
                            }
                            Console.WriteLine(allObjectsFromType.Remove(allObjectsFromType.Length - 2, 2));
                            Console.WriteLine("--- End of galaxies list ---");
                            break;
                        case "stars":
                            Console.WriteLine("--- List of all researched stars ---");
                            foreach (var star in Stars)
                            {
                                allObjectsFromType += star.name + ", ";
                            }
                            Console.WriteLine(allObjectsFromType.Remove(allObjectsFromType.Length - 2, 2));
                            Console.WriteLine("--- End of stars list ---");
                            break;
                        case "planets":
                            Console.WriteLine("--- List of all researched planets ---");
                            foreach (var planet in Planets)
                            {
                                allObjectsFromType += planet.name + ", ";
                            }
                            Console.WriteLine(allObjectsFromType.Remove(allObjectsFromType.Length - 2, 2));
                            Console.WriteLine("--- End of planets list ---");
                            break;
                        case "moons":
                            Console.WriteLine("--- List of all researched moons ---");
                            foreach (var moon in Moons)
                            {
                                allObjectsFromType += moon.name + ", ";
                            }
                            Console.WriteLine(allObjectsFromType.Remove(allObjectsFromType.Length - 2, 2));
                            Console.WriteLine("--- End of moons list ---");
                            break;
                        default:
                            Console.WriteLine("none");
                            break;
                    }
                }
                else if ("print".Equals(data[0]))
                {
                    string print = input.Split('[')[1].Split(']')[0];
                    Galaxy foundGalaxy = Galaxies.Find(currentGalaxy => currentGalaxy.name == print);
                    if (foundGalaxy != null)
                    {
                        Console.WriteLine($"--- Data for {foundGalaxy.name} galaxy ---");
                        Console.WriteLine("Type: " + foundGalaxy.type);
                        Console.WriteLine("Age: " + foundGalaxy.age);
                        Console.WriteLine("Stars: ");
                    }
                    else
                    {
                        Console.WriteLine("none");
                    }
                    if (Stars.Exists(star => star.parentName == print))
                    {
                        foreach (Stars star in Stars)
                        {
                            if (star.parentName == print)
                            {
                                Console.WriteLine("Name: " + star.name);
                                Console.WriteLine("Class: " + star.Stars);
                                Console.WriteLine("Planets: ");

                                if (Planets.Exists(planet => planet.parentName == star.name))
                                {
                                    foreach (Planet planet in Planets)
                                    {
                                        if (planet.parentName == star.name)
                                        {
                                            Console.WriteLine("Name: " + planet.name);
                                            Console.WriteLine("Type: " + planet.Data.Remove(planet.Data.Length - 3).Trim());
                                            Console.WriteLine("Support life: " + planet.Data.Split(' ')[^1]);
                                            Console.WriteLine("Moons: ");

                                            if (Moons.Exists(moon => moon.parentName == planet.name))
                                            {
                                                foreach (Moons moon in Moons)
                                                {
                                                    if (moon.parentName == planet.name)
                                                    {
                                                        Console.WriteLine(" " + moon.name);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("none");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("none");
                                    Console.WriteLine("Moons: ");
                                    Console.WriteLine("none");
                                }
                            }
                        }
                        Console.WriteLine($"--- End of data for {print} galaxy ---");
                    }
                    else
                    {
                        Console.WriteLine("none");
                        Console.WriteLine("Planets: ");
                        Console.WriteLine("none");
                        Console.WriteLine("Moons: ");
                        Console.WriteLine("none");
                    }
                }
                input = Console.ReadLine().Trim();
                data = input.Split(' ');
            }

        }
    }
}

        
    

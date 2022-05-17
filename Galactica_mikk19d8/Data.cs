using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_mikk19d8
{
    internal class Data
    {

        List<Planet> planets;


        public Data()
        {
            planets = new();
            PlanetCreation();
            Star sun = new()
            {
                Id = 0,
                Name = "Sun",
                Position = new() { X = 0, Y = 0 },
                Type = StarType.White,
                Temperature = 15700000,
                Planets = planets
            };
            Printout();

        }
        public void PlanetCreation()
        {


            Planet mercury = new()
            {
                Id = 0,
                Name = "Mercury",
                Diameter = 4879,
                Moons = new() { },
                Position = new Position() { X = 0, Y = 1 },
                Revolution = 88,
                Rotation = 1407,
                Type = PlanetType.Terrestial
            };
            planets.Add(mercury);
            Planet venus = new()
            {
                Id = 1,
                Name = "Venus",
                Diameter = 12184,
                Moons = new(),
                Position = new Position() { X = 0, Y = -2 },
                Revolution = 224,
                Rotation = -5832,
                Type = PlanetType.Terrestial
            };
            planets.Add(venus);
            Planet earth = new Planet()
            {
                Id = 2,
                Name = "Earth",
                Diameter = 12756,
                Moons = new(),
                Position = new Position() { X = 2, Y = -1 },
                Revolution = 365,
                Rotation = 24,
                Type = PlanetType.Terrestial
            };
            planets.Add(earth);
            earth.Moons = new()
            {
                new Moon
                {
                    Name = "Luna",
                    Orbiting = earth,
                    Position = new Position() { X = 2, Y = 0 }
                }
            };
            Planet mars = new Planet()
            {
                Id = 3,
                Name = "Mars",
                Diameter = 6792,
                Moons = new(),
                Position = new Position() { X = -1, Y = 3 },
                Revolution = 687,
                Rotation = 24,
                Type = PlanetType.Terrestial
            }; mars.Moons = new()
            {
                new Moon
                {
                    Name = "Deimos",
                    Orbiting = mars,
                    Position = new Position() { X = 0, Y = 3 }
                },
                new Moon
                {
                    Name = "Phobos",
                    Orbiting = mars,
                    Position = new Position() { X = -2, Y = 2 }
                }
            };
            planets.Add(mars);
            Planet jupiter = new Planet()
            {
                Id = 4,
                Name = "Jupiter",
                Diameter = 142984,
                Moons = new(),
                Position = new Position() { X = -5, Y = -1 },
                Revolution = 4331,
                Rotation = 10,
                Type = PlanetType.GasGiant
            };
            jupiter.Moons = new()
            {
                new Moon
                {
                    Name = "Io",
                    Orbiting = jupiter,
                    Position = new Position() { X = -6, Y = 0 }
                },
                new Moon
                {
                    Name = "Europa",
                    Orbiting = jupiter,
                    Position = new Position() { X = -5, Y = -2 }
                },
                new Moon
                {
                    Name = "Ganymede",
                    Orbiting = jupiter,
                    Position = new Position() { X = -4, Y = 0 }
                }
            };
            planets.Add(jupiter);
            Planet saturn = new Planet()
            {
                Id = 5,
                Name = "Saturn",
                Diameter = 120536,
                Moons = new(),
                Position = new Position() { X = -6, Y = -3 },
                Revolution = 10747,
                Rotation = 11,
                Type = PlanetType.GasGiant
            };
            planets.Add(saturn);
            saturn.Moons = new()
            {
                new Moon
                {
                    Name = "Titan",
                    Orbiting = saturn,
                    Position = new Position() { X = -7, Y = -3 }
                },
                new Moon
                {
                    Name = "Mimas",
                    Orbiting = saturn,
                    Position = new Position() { X = -6, Y = -4 }
                }
            };
            Planet uranus = new Planet()
            {
                Id = 6,
                Name = "Uranus",
                Diameter = 51118,
                Moons = new(),
                Position = new Position() { X = -7, Y = 5 },
                Revolution = 30587,
                Rotation = -17,
                Type = PlanetType.GasGiant
            };
            planets.Add(uranus);
            Planet neptune = new Planet()
            {
                Id = 7,
                Name = "Neptune",
                Diameter = 49528,
                Moons = new(),
                Position = new Position() { X = -10, Y = -1 },
                Revolution = 59800,
                Rotation = 16,
                Type = PlanetType.GasGiant
            };
            planets.Add(neptune);

        }
        public void Printout()
        {
            Console.WriteLine("Planets in solar system:");
            foreach (Planet p in planets)
            {
                Console.WriteLine($"{p.Name}\n" +
                    $"Type: {p.Type}\n" +
                    $"Diameter: {p.Diameter}\n" +
                    $"Revolution time: {p.Revolution} days\n" +
                    $"Rotation time: {p.Rotation} hours\n" +
                    $"Distance from sun: {p.Distance}\n");
                if(p.Moons != null && p.Moons.Any())
                {
                    Console.WriteLine("Moons:\n");
                    foreach (Moon m in p.Moons)
                    {
                        Console.WriteLine($"{m.Name}\n" +
                            $"Distance from planet: {m.Distance(p)}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"{p.Name} has no moons recorded in this system\n");
                }
            }
        }
    }
}

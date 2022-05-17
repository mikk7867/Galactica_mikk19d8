using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_mikk19d8
{
    public abstract class SpaceObjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
    }
    public  class Position
    {
        public virtual int X { get; set; }
        public virtual int Y { get; set; }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        Position(int x, int y) 
        { 
            X = x;
            Y = y;
        }
    }
    public enum StarType
    {
        Yellowdwarf,
        White,
        BlueNeutron,
        RedGiant
    }
    public class Star : SpaceObjects
    {
        public StarType Type { get; set; }
        public double Temperature { get; set; }
        public List<Planet> Planets { get; set; }
        public Star(int id, string name, Position position, StarType type, double temperature, List<Planet> planets)
        {
            Id = id;
            Name = name;
            Position.X = 0;
            Position.Y = 0;
            Type = type;
            Temperature = temperature;
            Planets = planets;
        }

    }
    public enum PlanetType
    {
        Terrestial,
        Giant,
        Dwarf,
        GasGiant
    }
    public class SpaceObj2 : SpaceObjects
    {
        public int Diameter { get; set; }
        public int Rotation { get; set; }//timer
        public int Revolution { get; set; }//døgn
    }
    public class Planet : SpaceObj2
    {
        public PlanetType Type { get; set; }
        public List<Moon> Moons { get; set; }
        public int Distance
        {
            get
            {
                return Distance;
            }
            set
            {
                Distance = value;
            }
        }
        public Planet(int id, string name, Position postion, int diameter, int rotation, int revolution, PlanetType type, List<Moon> moons)
        {
            Id = id;
            Name = name;
            Position.X = postion.X;
            Position.Y = postion.Y;
            Diameter = diameter;
            Rotation = rotation;
            Revolution = revolution;
            Type = type;
            Moons = moons;
        }
    }
    public class Moon : SpaceObj2
    {

        public Moon(int id, string name, Position postion, int diameter, int rotation, int revolution, )
        {
            Id = id;
            Name = name;
            Position.X = postion.X;
            Position.Y = postion.Y;
            Diameter = diameter;
            Rotation = rotation;
            Revolution = revolution;
        }
    }

}

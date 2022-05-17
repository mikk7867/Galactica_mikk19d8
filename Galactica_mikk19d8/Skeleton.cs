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
        public string? Name { get; set; }
        public Position? Position { get; set; }
    }
    public  class Position
    {
        public double X { get; set; }
        public double Y { get; set; }
        public override string ToString()
        {
            return $"({X},{Y})";
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
        public List<Planet>? Planets { get; set; }

    }
    public enum PlanetType
    {
        Terrestial,
        Giant,
        Dwarf,
        GasGiant
    }
    public class Planet : SpaceObjects
    {
        public double Diameter { get; set; }
        public PlanetType Type { get; set; }
        public List<Moon>? Moons { get; set; }
        public double Rotation { get; set; }//timer
        public double Revolution { get; set; }//døgn
        public double? Distance()//distance=√((x_2-x_1)²+(y_2-y_1)²)
        {
            if (Position != null)
            {
                return Math.Sqrt(Math.Pow(Position.X, 2) + Math.Pow(Position.Y, 2));
            }
            else
            {
                return null;
            }
        }
    }
    public class Moon : Planet
    {
        public Planet? Orbiting { get; set; }
        public double? Distance(Planet planet)//distance=√((x_2-x_1)²+(y_2-y_1)²)
        {
            if (Position != null && planet.Position != null)
            {
                return Math.Sqrt((Math.Pow(Position.X - planet.Position.X, 2)) + 
                    (Math.Pow(Position.X - planet.Position.X, 2)));
            }
            else
            {
                return null;
            }
        }
    }

}

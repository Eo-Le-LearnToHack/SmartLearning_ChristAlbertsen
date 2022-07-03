
namespace Co2BesparelseWindows
{
    /// <summary>
    /// Repræsenterer et sæt GPS-koordinater
    /// </summary>
    internal class Koordinatset
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public override string ToString()
        {
            return $"({Longitude};{Latitude})";
        }
    }
}

namespace OhSyTe
{
    public class City
    {
        public string Name;
        public Coordinates Location;
        public City(string name, Coordinates location)
        {
            Name = name;
            Location = location;
        }
        public override string ToString()
        {
            return string.Format("{0} @ {1},{2}", Name, Location.Latitude, Location.Longitude);
        }
        public double DistanceTo(City other)
        {
            return this.Location.DistanceTo(other.Location);
        }
    }

    public class Coordinates
    {
        public double Latitude;
        public double Longitude;

        public Coordinates(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        public override string ToString()
        {
            return string.Format("{0},{1}", Latitude, Longitude);
        }
        static double DegreesToRadians(double degrees)
        {
            return (Math.PI / 180) * degrees;
        }
        public double DistanceTo(Coordinates other)
        {
            const double EarthEquatorialRadius = 6378.1370; // km
            double lat1 = DegreesToRadians(this.Latitude);
            double lon1 = DegreesToRadians(this.Longitude);
            double lat2 = DegreesToRadians(other.Latitude);
            double lon2 = DegreesToRadians(other.Longitude);
            double dlon = lon2 - lon1;
            double dlat = lat2 - lat1;
            double a = Math.Pow(Math.Sin(dlat / 2), 2)
            + Math.Cos(lat1) * Math.Cos(lat2)
            * Math.Pow(Math.Sin(dlon / 2), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = EarthEquatorialRadius * c;
            return Math.Round(distance, 1);
        }
    }
}
namespace OhSyTe
{
    public class Country
    {
        private string _code;
        private string _name;
        private double _area;
        private int _population;
        public Country(string code, string name, double area,
        int population)
        {
            Code = code;
            Name = name;
            Area = area;
            Population = population;
        }
        public string Code
        { 
            get => _code;     
            set 
            { 
                if (value.Length != 2 || value.Any(char.IsLower))
                {
                    throw new ArgumentException("Country code must be 2 chars long and all uppercase!", nameof(value));
                }
                _code = value;
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Country name can not be empty", nameof(value));
                }
                _name = value;
            }
        }
        public double Area
        {
            get => _area;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Country area must be positive value", nameof(value));
                }
                _area = value; ;
            }
        }
        public int Population
        {
            get => _population;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Country population must be positive value", nameof(value));
                }
                _population = value;
            }
        }
        public double PopulationDensity
        {
            get
            {
                return Population / Area;
            }
        }
        public override string ToString()
        {
            return $"{Code} {Name}";
        }
    }
}
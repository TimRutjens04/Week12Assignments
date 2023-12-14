using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BickingTrip
{
    public class Destination
    {
        public string Name
        {
            get; private set;
        }

        public double Rating
        {
            get; private set;

        }

        public string Transport
        {
            get; private set;
        }

        public double Distance
        {
            get; private set;
        }

        public Destination(string newName, double newRating, string newTransport, double newDistance)
        {
            this.Name = newName;
            this.Rating = newRating;
            this.Transport = newTransport;
            this.Distance = newDistance;
        }

        public string GetInfo()
        {
            return $"{Name} - {Rating}/5\r\n{Transport} - {Math.Round(Distance, 3)}KM";
        }

        public override string ToString()
        {
            return $"{Name} - {Math.Round(Distance, 3)}KM";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BickingTrip
{
    public class Destinations
    {
        List<Destination> _destinations;
        
        public Destinations()
        {
            _destinations = new List<Destination>();
        }

        public void Add(Destination newDestination)
        {
            _destinations.Add(newDestination);
        }

        public bool Remove(string itemToRemove)
        {
            foreach (Destination dest in _destinations)
            {
                if (itemToRemove == dest.ToString())
                {
                    return _destinations.Remove(dest);
                }
            }
            return false;
        }

        public string SortByRatings()
        {
            return "";
        }

        public string GetInfo(int index)
        {
            return _destinations[index].GetInfo();
        }

        public int Count()
        {
            return _destinations.Count;
        }

        public Destination GetDestination(int index)
        {
            return _destinations[index];
        }

        public string ToString(int index)
        {
            return _destinations[index].ToString();
        }
    }
}

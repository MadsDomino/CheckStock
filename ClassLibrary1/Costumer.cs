using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PrettyHairSolution
{
    interface ICostumer
    {
        int GetCostumerNumber();
        string GetName();
        string GetAddress();
    }

    class Costumer : ICostumer
    {
        public int CostumerNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string GetAddress()
        {
            return Address;
        }

        public int GetCostumerNumber()
        {
            return CostumerNumber;
        }

        public string GetName()
        {
            return Name;
        }
    }
}

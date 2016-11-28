using System;

namespace _PrettyHairSolution
{
    public interface Iware
    {
        int GetID();
        int GetPrice();
        string GetDesignation();
    }
    public class ware : Iware
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public string Designation { get; set; }

        public ware()
        {
        }

        public int GetID()
        {
            return ID;
        }

        public int GetPrice()
        {
            return Price;
        }

        public string GetDesignation()
        {
            return Designation;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PrettyHairSolution
{
    interface ICostumerRepository
    {
        ICostumer FindCostumer(int CostumerNumber);
    }

    class CostumerRepository : ICostumerRepository
    {
        public List<ICostumer> CostumerList;
        public ICostumer FindCostumer(int CostumerNumber)
        {
            foreach(ICostumer Costumer in CostumerList)
            {
                if (Costumer.GetCostumerNumber() == CostumerNumber)
                {
                    return Costumer;
                }
            }
            return null;
        }
    }
}

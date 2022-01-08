using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints.Service
{
    class CalculationService
    {
        public Generic Max<Generic>(List<Generic> ListOfProducts) where Generic : IComparable
        {
            if (ListOfProducts.Count == 0)
            {
                throw new ArgumentException("Argument error: The list is empty");
            }

            Generic maxProduct = ListOfProducts[0];
            for (int i = 1; i < ListOfProducts.Count; i++)
            {
                if(ListOfProducts[i].CompareTo(maxProduct) > 0){
                    maxProduct = ListOfProducts[i];
                }

            }

            return maxProduct;

        }
    }
}

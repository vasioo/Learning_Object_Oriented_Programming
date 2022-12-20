using System;
using System.Collections.Generic;
using System.Text;
using InterfacesAndAbstraction.Contracts;

namespace InterfacesAndAbstraction
{
    class Lion:IFeedable
    {
        public void Doze()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {

        }

        public void FoodType()
        {
            throw new NotImplementedException();
        }

        int IFeedable.Doze()
        {
            throw new NotImplementedException();
        }

        FoodType IFeedable.FoodType()
        {
            throw new NotImplementedException();
        }
    }
}

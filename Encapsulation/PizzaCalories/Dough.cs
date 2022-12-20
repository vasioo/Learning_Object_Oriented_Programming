using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private double finalRes;
        public string FlourType { get; set; }
        //white - 1.5|| wholegrain - 1.0
        public string BakingTechnique { get; set; }
        //crispy - 0.9 || chewy- 1.1|| homemade - 1.0
        public Dough(string flourType,string bakingTechnique,double grams)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            if (grams>200)
            {
                throw new ArgumentException
                    ("Dough weight should be in the range [1..200].");
            }
            Checker(grams);
        }
        private void Checker(double grams)
        {
            switch (FlourType)
            {
                case "White":
                    grams *= 1.5;
                    break;
                case "Wholegrain":
                    grams *= 1;
                    break;
                default:
                    throw new ArgumentException("Invalid type of dough.");
            }
            switch (BakingTechnique)
            {
                case "Chewy":
                    grams *= 1.1;
                    break;
                case "Crispy":
                    grams *= 0.9;
                    break;
                case "Homemade":
                    grams *= 1;
                    break;
                default:
                    throw new ArgumentException("Invalid type of dough.");
            }
            finalRes = grams * 2;
        }
        public override string ToString()
        {
            return $"{finalRes:f2}";
        }
    }
}

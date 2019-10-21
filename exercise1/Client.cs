using System;

namespace exercise1
{
    public abstract class IClient
    {

        public int id;
        public int WantsBigComboProbability;
        public int WantsExtraCheeseProbability;
        public int WantsExtraMeatProbability;
        public int WantsNoVegetablesProbability;
        public int WantsSauceProbability;
        public int WantsBBQProbability;
        public int WantsIceCreamProbability;
        public int WantsDessertProbability;

        Random random = new Random();

        public abstract string GetDescription();

        public bool WantsBigCombo()
        {
            return random.Next(100) <= WantsBigComboProbability;

        }
        public bool WantsExtraCheese()
        {
            return random.Next(100) <= WantsExtraCheeseProbability;
        }
        public bool WantsExtraMeat()
        {
            return random.Next(100) <= WantsExtraMeatProbability;

        }
        public bool WantsNoVegetables()
        {
            return random.Next(100) <= WantsNoVegetablesProbability;

        }
        public bool WantsSauce()
        {
            return random.Next(100) <= WantsSauceProbability;

        }
        public bool WantsBBQ()
        {
            return random.Next(100) <= WantsBBQProbability;
        }
        public bool WantsDessert()
        {
            return random.Next(100) <= WantsBigComboProbability;
        }
        public bool WantsIceCream()
        {
            return random.Next(100) <= WantsIceCreamProbability;
        }

    }

    public class YoungClient : IClient
    {

        public YoungClient()
        {
            WantsBigComboProbability = 30;
            WantsExtraCheeseProbability = 20;
            WantsExtraMeatProbability = 15;
            WantsNoVegetablesProbability = 30;
            WantsSauceProbability = 25;
            WantsBBQProbability = 50;
            WantsDessertProbability = 20;
            WantsIceCreamProbability = 50;
        }

        public override string GetDescription()
        {
            return "Cliente 'joven' [" + id + "]";
        }
    }

    public class AdultClient : IClient
    {
        public AdultClient()
        {
            WantsBigComboProbability = 100;
            WantsExtraCheeseProbability = 15;
            WantsExtraMeatProbability = 10;
            WantsNoVegetablesProbability = 15;
            WantsSauceProbability = 10;
            WantsBBQProbability = 50;
            WantsDessertProbability = 30;
            WantsIceCreamProbability = 50;
        }

        public override string GetDescription()
        {
            return "Cliente 'adulto' [" + id + "]";
        }
    }

    public class OldClient : IClient
    {
        public OldClient()
        {
            WantsBigComboProbability = 15;
            WantsExtraCheeseProbability = 10;
            WantsExtraMeatProbability = 5;
            WantsNoVegetablesProbability = 5;
            WantsSauceProbability = 5;
            WantsBBQProbability = 50;
            WantsDessertProbability = 20;
            WantsIceCreamProbability = 50;
        }

        public override string GetDescription()
        {
            return "Cliente 'adulto mayor' [" + id + "]";
        }
    }
}

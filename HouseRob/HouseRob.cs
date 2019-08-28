using System;

namespace HouseRob
{
    public class HouseRobClass
    {
        static void Main(string[] args)
        {
            HouseRobClass houseRobObject = new HouseRobClass();
            int[] Houses = { 1, 3, 5, 9, 15, 10 };
            Console.WriteLine("Max amount that can be looted tonight is {0}",houseRobObject.FindMaxAmount(Houses));
            Console.Read();
        }
        public int FindMaxAmount(int[] Houses)
        {
            int OddHouseAmount = 0, EvenHouseAmount = 0;
            if (Houses.Length == 0)
            {
                return -1;
            }
            for(int i=0;i<Houses.Length;i++)
            {
                if(Houses[i]<0)
                {
                    throw new NegativeAmountException();
                }
            }
            for (int i = 0; i < Houses.Length; i++)
            {
                if (i % 2 == 0)
                {
                    EvenHouseAmount += Houses[i];
                }
                else
                {
                    OddHouseAmount += Houses[i];
                }
            }
            
            if(OddHouseAmount>EvenHouseAmount)
            {
                return OddHouseAmount;
            }
            return EvenHouseAmount;
        }
    }

    public class NegativeAmountException:Exception
    {
        public string GetErrorMessage()
        {
            return "Amount cannot be negative";
        }
    }
}

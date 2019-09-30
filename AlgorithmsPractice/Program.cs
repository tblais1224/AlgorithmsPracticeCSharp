using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsPractice
{
    public class FoodBill
    {
        public List<int> Bill { get; set; }
        public int Charged { get; set; }
        public int IndexOfFoodNotEaten { get; set; }

        public FoodBill(List<int> bill, int indexOfFoodNotEaten, int charged)
        {
            Bill = bill;
            Charged = charged;
            IndexOfFoodNotEaten = indexOfFoodNotEaten;
        }

        public void SplitBill()
        {
            var itemsEaten = new List<int>(Bill);
            itemsEaten.RemoveAt(IndexOfFoodNotEaten);
            if (Charged <= itemsEaten.Sum() / 2)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(Charged - (itemsEaten.Sum() / 2));
        }
    }


    class Solution
    {
        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b)
        {
            new FoodBill(bill, k, b).SplitBill();
        }

        static void Main(string[] args)
        {

            int n = 4;

            int k = 1;

            List<int> bill = new List<int>() { 4, 10, 2, 9 };

            int b = 12;

            bonAppetit(bill, k, b);
        }
    }
}
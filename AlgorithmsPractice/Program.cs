using System;
using System.Collections.Generic;

class Solution
{

    // Complete the sockMerchant function below.
    public class Merchant
    {
        public int NumberOfSocks { get; set; }
        public List<int> Socks { get; set; }
        public int Pairs { get; set; }
        public Merchant(int numberOfSocks, int[] socks)
        {
            if (numberOfSocks <= 100 && numberOfSocks >= 1)
            {
                NumberOfSocks = numberOfSocks;
                Socks = new List<int>(socks);
                Pairs = 0;
            }
            else
            {
                throw new InvalidOperationException("doesn't fit constraints");
            }
        }

        private void MatchSocks()
        {
            List<int> socksCopy = new List<int>();
            foreach (var sock in Socks)
            {
                if (socksCopy.Contains(sock))
                {
                    Pairs++;
                    socksCopy.Remove(sock);
                }
                else
                {
                    socksCopy.Add(sock);
                }
            }
        }

        public int GetPairs()
        {
            MatchSocks();
            return Pairs;
        }
    }
    static int SockMerchant(int n, int[] ar)
    {
        var merchant = new Merchant(n, ar);
        return merchant.GetPairs();
    }

    static void Main(string[] args)
    {

        int n = 9;
        int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

        int result = SockMerchant(n, ar);
        Console.WriteLine(result);
    }
}
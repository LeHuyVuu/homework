// See https://aka.ms/new-console-template for more information

int[] prices = { 7, 1, 5, 3, 6, 4 };
int maxProfit = 0;
int minPrice = prices[0];

for (int i = 1; i < prices.Length; i++)
{
    if (prices[i] < minPrice)
    {
        minPrice = prices[i];
    }
    else
    {
        int profit = prices[i] - minPrice;
        maxProfit = Math.Max(maxProfit, profit);
    }
}

Console.WriteLine("Max profit: " + maxProfit);
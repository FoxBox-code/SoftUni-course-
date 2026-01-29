using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> listofOrders = new Dictionary<string, List<decimal>>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] strings = command.Split(' ');

                List<decimal> listprices = new List<decimal>();
                bool change = false;

                string product = strings[0];
                decimal price = decimal.Parse(strings[1]);
                decimal quantity = decimal.Parse(strings[2]);

                decimal newprice = 0;
                decimal newquantity = 0;
                decimal oldquantity = 0;

                decimal[] decimals = {price, quantity};


                if (!listofOrders.ContainsKey(product))
                {
                    listofOrders.Add(product, new List<decimal>());
                    listofOrders[product].Add(price);
                    listofOrders[product].Add(quantity);
                    
                }
                else if (listofOrders.ContainsKey(product))
                {
                    foreach(decimal c in listofOrders[product])
                    {
                        listprices.Add(c);
                        oldquantity = c;
                    }
                    change = true;
                }
                if (change)
                {
                    newprice = price;
                    newquantity = quantity;
                    newquantity += oldquantity;

                    listofOrders[product].Clear();
                    listofOrders[product].Add((decimal)newprice);
                    listofOrders[product].Add(newquantity);

                }
            }
            
            SortedDictionary<string, decimal> definitivelist = new SortedDictionary<string, decimal>();

            

            foreach( var item in listofOrders)
            {
                definitivelist.Add(item.Key, 0);
                decimal value = item.Value[0];
                decimal quantity = item.Value[1];
                decimal sum = value * quantity;
                definitivelist[item.Key] = sum;

                Console.WriteLine($"{item.Key} -> {sum:f2}");




            }

            


        }
    }
}

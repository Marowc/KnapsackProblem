using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("test1"), InternalsVisibleTo("GUI")]
namespace plecakowy1
{
    internal class Problem
    {
        private int Number = 0;
        public int Seed = 0;
        public List<Item> Items = new List<Item>();

        public Problem(int n, int seed)
        {
            Number = n;
            Seed = seed;
            int TmpV = 0;
            int TmpW = 0;

            Random random = new Random(seed);

            for (int i = 0; i < n; i++)
            {
                TmpV = random.Next(1, 11);
                TmpW = random.Next(1, 11);
                Items.Add(new Item(TmpV, TmpW, i));
            }
        }

        public Problem(int n, List<Item> items)
        {
            Number = n;
            Items = items;
        }

        public override string ToString()
        {
            string Display = "";
            foreach (Item item in Items)
            {
                Display += item.ToString() + @"
";
            }
            return Display;
        }

        public Result Solve(int Capacity)
        {
            int i = 0, Filled = 0;
            List<Item> AddedItems = new List<Item>();
            Items.Sort((item1, item2) => item2.getRatio().CompareTo(item1.getRatio()));
            while (i < Number && Filled + Items[i].getWeight() <= Capacity) 
            {
                AddedItems.Add(Items[i]);
                Filled += Items[i].getWeight();
                i++;
            }
            Result result = new Result(AddedItems);
            return result;
        }
    }
}

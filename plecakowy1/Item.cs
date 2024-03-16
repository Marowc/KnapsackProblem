using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace plecakowy1
{
    internal class Item
    {
        private int Value = 0;
        private int Weight = 0;
        private int Index = 0;

    public Item(int v, int w, int index)
        {
            Value = v;
            Weight = w;
            Index = index;
        }

        public int getWeight() { return Weight; }
        public int getValue() { return Value; }
        public int getIndex() { return Index; } 
        public double getRatio() { return Value/(double)Weight; }

        public override string ToString()
        {
            return $"No.: {getIndex()}, Value: {getValue()}, Weight: {getWeight()}";
        }

        public double CompareByRatio(Item A, Item B)
        {
            double RatioA = A.getValue() / A.getWeight();
            double RatioB = B.getValue() / B.getWeight();

            if (RatioA > RatioB) { return -1; }
            else if (RatioA < RatioB) { return 1; }
            else { return 0; }
        }

    }
}

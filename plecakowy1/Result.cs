using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plecakowy1
{
    internal class Result
    {
        private List<int> Index = new List<int>();
        private int SumValue = 0;
        private int SumWeight = 0;

        public Result(List<Item> Items)
        {
            foreach (Item item in Items)
            {
                SumValue += item.getValue();
                SumWeight += item.getWeight();
                Index.Add(item.getIndex());
            }
        }

        public override string ToString()
        {
            string Display = "";
            foreach (int index in Index)
            {
                Display += $"{index} ";
            }
            return @$"Items: {Display} 
Total value: {SumValue} 
Total weight: {SumWeight}";
        }

        public override bool Equals(object? obj)
        {

            Result other = (Result)obj;

            if (!Index.SequenceEqual(other.Index) || SumValue != other.SumValue || SumWeight != other.SumWeight)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



    }
}

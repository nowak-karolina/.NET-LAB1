using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Tests"), InternalsVisibleTo("App")]

namespace Lab1 {
    internal class Problem {
        int NumberOfItems;
        public List<Item> items;
        int seed;

        public Problem(int n, int s) {
            NumberOfItems = n;
            items = new List<Item>();
            seed = s;

            Random random = new Random(seed);

            for (int i = 0; i < NumberOfItems; i++) {
                items.Add(new Item(random.Next(1, 10), random.Next(1, 10), i));
            }
        }

        public void ForceItem(int v, int w, int i) {
            items[i].value = v;
            items[i].weight = w;
        }

        private int compare(Item item1, Item item2) {
            if (item1.vwRatio > item2.vwRatio) {
                return -1;
            } else if (item1.vwRatio < item2.vwRatio) {
                return 1;
            } else {
                return 0;
            }
        }

        public Result Solve(int capacity) {
            Result result = new Result();
            items.Sort(compare);

            foreach (var item in items) {
                if (item.value > 0) {
                    if (item.weight + result.sumWeight <= capacity) {
                        result.id.Add(item.id);
                        result.sumWeight += item.weight;
                        result.sumValue += item.value;
                    }
                }

            }
            return result;
        }

        public override string ToString() {
            string s = "";
            foreach (var item in items) {
                s+=("id: " + item.id + " value: " + item.value + " weight: " + item.weight + " ratio: " + item.vwRatio) + Environment.NewLine;
            }

            return s;
        }

        public int CheckRatio() {
            int id = -1;
            float ratio = -1;
            for (int i = 0; i < items.Count; i++) {
                if (items[i].vwRatio > ratio) {
                    id = i;
                    ratio = items[i].vwRatio;
                }
            }

            return id;
        }
    }
}

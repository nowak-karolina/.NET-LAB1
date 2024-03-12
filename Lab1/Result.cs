using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Tests"), InternalsVisibleTo("App")]

namespace Lab1 {
    internal class Result {
        public int sumWeight;
        public int sumValue;
        public List<int> id;

        public Result() {
            sumValue = 0;
            id = new List<int>();
            sumWeight = 0;
        }
        public override string ToString() {
            string s = "items: ";

            foreach (var item in id) {
                s += item + " ";
            }

            s += Environment.NewLine + "total weight: " + sumWeight;
            s += Environment.NewLine+"total value: " + sumValue;

            return s;
        }

        public void PrintList() {
            foreach (var item in id) {
                Console.WriteLine(item);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndCollectionsExercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComparer<Duck> sizeComparer = new DuckComparerBySize();
            IComparer<Duck> kindComparer = new DuckComparerByKind();
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 13 },
            };
            ducks.Sort(sizeComparer);
            ducks.Sort(kindComparer);
            PrintDucks(ducks);
        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                Console.WriteLine($"{duck.Size} inch {duck.Kind}");
        }
    }
}

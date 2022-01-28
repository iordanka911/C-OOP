using System;
using System.Collections.Generic;

namespace CustomRandomList
{

    public class RandomList : List<string>
    {
        private Random random;
        public RandomList()
        {
            random = new Random();
        }
        public string GetRandomElement()
        {
            var index = random.Next(0, this.Count);
            return this[index];
        }

        public void RemoveRandomElement()
        {
            var index = random.Next(0, Count);
            RemoveAt(index);
        }
    }



}

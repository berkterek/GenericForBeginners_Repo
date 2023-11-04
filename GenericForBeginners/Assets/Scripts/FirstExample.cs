using System.Collections.Generic;
using UnityEngine;

namespace GenericForBeginners
{
    public class FirstExample
    {
        private void FirstExampleMethod()
        {
            List<string> strings = new List<string>();
            
            strings.Add("asdfasfd");
            strings.Add("asdfasfds");
            strings.Add("asdfasfdf");
            strings.Add("asdfasfdg");

            if (strings.Contains("asdfasfd"))
            {
                strings.Remove("asdfasfd");    
            }

            List<int> ints = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            if (ints.Contains(1))
            {
                ints.Remove(1);
            }
        }
    }
}


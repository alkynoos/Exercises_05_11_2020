using Exercises_05_11_2020.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_05_11_2020.Models
{
    class House : IHouse
    {
        public House()
        {
           
        }

        public void Location()
        {
            Console.Write("in the countryside ");
        }

        public void HasABigdoor()
        {
            Console.Write("\nThe house had a large door at its entrance ");
        }

        
    }
}

using Exercises_05_11_2020.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_05_11_2020.Models
{
    class Giannakis : Walking ,IJohn
    {
        public Giannakis()
        {

        }
        public void Being()
        {
            Console.Write("It used to be a boy Giannakis ");
        }

        public void HasAHouse()
        {
            Console.Write("and he had a house ");
        }
        public void IsInside()
        {
            Console.Write("\nOne day when John was inside ");
        }


        public void AnsweringTheDoor()
        {
            Console.WriteLine("\nJohn: Who is there? ");
        }

        public void CommingForAnoula()
        {
            Console.WriteLine("John: Annoula IIIIIIIIIIII am coming!!! ");
        }

        public void Leaves()
        {

            Console.Write( ", leaves the house. ");
        }
        public void ClosesDoor()
        {
            Console.Write("\nJohn closes the ");
        }

        public void TakesAnoulaHand()
        {
            Console.Write("takes Annoula by the hand ");
        }

        public override void GoForWalk()
        {
            Console.WriteLine("and they go for a walk.");
        }

        
    }
}

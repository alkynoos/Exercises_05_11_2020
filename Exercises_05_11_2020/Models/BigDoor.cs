using Exercises_05_11_2020.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_05_11_2020.Models
{
    class BigDoor : IBigDoor
    {
        public BigDoor()
        {
        }

        

        public void HasALatch()
        {
            Console.Write("with a latch you could knock on the door. ");
        }

        public void LachKnock()
        {
            Console.Write("the door latch knocked. ");
        }

        public void Open()
        {
            Console.Write("John opens the door ");
        }
        public void Close()
        {
            Console.Write("door behind him and ");
        }
    }
}

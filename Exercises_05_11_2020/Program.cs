using Exercises_05_11_2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_05_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Giannakis giannakis = new Giannakis();
            Annoyla annoyla = new Annoyla();
            House house = new House();
            BigDoor bigDoor = new BigDoor();

            giannakis.Being();
            giannakis.HasAHouse();
            house.Location();
            house.HasABigdoor();
            bigDoor.HasALatch();
            giannakis.IsInside();
            bigDoor.LachKnock();
            giannakis.AnsweringTheDoor();
            annoyla.AnswerignToJohn();
            giannakis.CommingForAnoula();
            bigDoor.Open();
            giannakis.Leaves();
            giannakis.ClosesDoor();
            bigDoor.Close();
            giannakis.TakesAnoulaHand();
            annoyla.GoForWalk();
        }
    }
}

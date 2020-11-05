using Exercises_05_11_2020.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_05_11_2020.Models
{
    class Annoyla : Walking, IAnnoyla
    {
        public Annoyla()
        {
        }

        public void KnockingTheDoor()
        {
            throw new NotImplementedException();
        }
        public void AnswerignToJohn()
        {
            Console.WriteLine("Annoula: It's me John! ");
        }

        public override void GoForWalk()
        {
            Console.Write("and they go for a walk. \n");
        }
    }
}

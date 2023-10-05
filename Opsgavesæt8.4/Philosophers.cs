using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opsgavesæt8._4
{
    public class Philosophers
    {
        public int Id { get; set; }

        public Chopstick LeftChopstick { get; set; }

        public Chopstick RightChopstick { get; set; }

        public bool IsEating { get; set; }

        public Philosophers(int id, Chopstick leftChopstick, Chopstick rightChopstick) 
        { 
            Id = id;
            LeftChopstick = leftChopstick;
            RightChopstick = rightChopstick; 
            IsEating = false;
        }
    }
}

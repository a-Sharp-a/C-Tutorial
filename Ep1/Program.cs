using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep1
{
    class Creature
    {
        public string ID;
        public float Health;
        public float MoveSpeed;
        public Creature(float health = (float)5.5, float movespeed = 4, string id = "Gizz")
        {
            Health = health;
            MoveSpeed = movespeed;
        }
        public void Attack()
        {
            Console.WriteLine("The creature" + ID + " has attacked!");
            Console.ReadKey();
        }
        public void Wait()
        {
            Console.WriteLine("The creature" + ID +" has waited!");
        }
    }
    class Program
    {
        static Creature[] carray; 
        static void Main(string[] args)
        {
            carray = new Creature[3] { new Creature(4, (float)5.5, "MeSaying"), new Creature((float)2.5, 7, "Jimbo"), new Creature((float)5.5, 4, "2400Times") };
            carray[1].Attack();
        }
    }
}

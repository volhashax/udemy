﻿using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Character
    {
        private const int speed;
        public int Health { get; private set; } = 100;

        public string Race { get; private set; }

        public int Armor { get; private set; }

        public Character(string race)
        {
            Race = race;
            Armor = 30;
        }


        public Character(string race, int armor)
        {
            Race = race;
            Armor = armor;
        }

        //public Character(string race, int armor, int speed)
        //{
        //    Race = race;
        //    Armor = armor;
        //    this.speed = speed;
        //}
        public void Hit(int damage)
        {
            if (damage > Health)
                damage = Health;

            //health -= damage;
            Health -= damage;

        }

        public int PrintSpeed()
        {
            return speed;
        }

        public void IncreaseSpeed()
        {
            speed += 10;
        }
    }
}

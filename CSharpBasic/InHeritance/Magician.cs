﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InHeritance
{
    internal class Magician : Character
    {
        public override void UniqueSkill()
        {
            Console.WriteLine("Knight 고유스킬 발동!");
        }
    }
}

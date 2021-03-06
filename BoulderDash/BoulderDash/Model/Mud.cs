﻿using BoulderDash.Model.Interfaces_Abstract;
using System;

namespace BoulderDash
{
    internal class Mud : NonMoveableObject
    {
        public override bool Sticks => true;
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Magenta;
        }

        public override char GetSymbol()
        {
            return 'M';
        }

        public override bool Trigger(Direction dir)
        {
            return true;
        }
    }
}
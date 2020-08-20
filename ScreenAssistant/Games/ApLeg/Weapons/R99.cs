﻿namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class R99 : UniqueLogicWeapon
    {
        public R99(string name, double burstSeconds, string recognizedName, int numOfMods) 
            : base(name, burstSeconds, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 32);
            var horizontalOffset = Rnd.NextDouble() * -1 - 1;
            var verticalOffset = Rnd.NextDouble() + 7.5;
            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime(1d);
        }
    }
}
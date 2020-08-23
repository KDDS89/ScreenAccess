namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class Alternator : UniqueLogicWeapon
    {
        public Alternator(string name, double burstSeconds, string recognizedName, int numOfMods)
            : base(name, burstSeconds, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            double horizontalOffset;
            double verticalOffset;
            this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 27);
            if (shotNumber % 2 == 0)
            {
                horizontalOffset = Rnd.NextDouble() - 4;
            }
            else
            {
                horizontalOffset = Rnd.NextDouble() + 3;
            }

            if (shotNumber < 6)
            {
                verticalOffset = Rnd.NextDouble() + 7.4d;
            }
            else if (shotNumber < 17)
            {
                verticalOffset = Rnd.NextDouble() + 5.4d;
            }
            else if (shotNumber < 22)
            {
                verticalOffset = Rnd.NextDouble() + 6.4d;
            }
             else
            {
                verticalOffset = Rnd.NextDouble() + 15.6d;
                horizontalOffset += 3d;
            }

            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime(1d);
        }
    }
}
namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    // ReSharper disable once IdentifierTypo
    internal sealed class Flatline : UniqueLogicWeapon
    {
        // ReSharper disable once IdentifierTypo
        public Flatline(string name, double burstSeconds, string recognizedName, int numOfMods) 
            : base(name, burstSeconds, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            double horizontalOffset;
            double verticalOffset; 
            this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 30);
            if (shotNumber < 3)
            {
                verticalOffset = Rnd.NextDouble() + 7d;
                horizontalOffset = Rnd.NextDouble() + 1d;
            }
            else if (shotNumber < 7)
            {
                verticalOffset = Rnd.NextDouble() + 5d;
                horizontalOffset = Rnd.NextDouble() + 1d;
            }
            else if (shotNumber < 11)
            {
                verticalOffset = 0;
                horizontalOffset = -1d * (Rnd.NextDouble() + 2d);
            }
            else if (shotNumber < 16)
            {
                verticalOffset = Rnd.NextDouble() + 2d;
                horizontalOffset = Rnd.NextDouble() + 1d;
            }
            else if (shotNumber < 21)
            {
                verticalOffset = Rnd.NextDouble() + 2d;
                horizontalOffset = Rnd.NextDouble() + 2d;
            }
            else if (shotNumber < 23)
            {
                verticalOffset = Rnd.NextDouble() + 2d;
                horizontalOffset = Rnd.NextDouble() + 8d;
            }
            else
            {
                verticalOffset = Rnd.NextDouble() + 12d;
                horizontalOffset = -1d * (Rnd.NextDouble() + 6d);
            }


            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime(1d);
        }
    }
}
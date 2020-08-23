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
                horizontalOffset = Rnd.NextDouble() + 2d;
            }
            else if (shotNumber < 11)
            {
                verticalOffset = 0;
                horizontalOffset = Rnd.NextDouble() - 3d;
            }
            else if (shotNumber < 16)
            {
                verticalOffset = Rnd.NextDouble() + 2d;
                horizontalOffset = Rnd.NextDouble() + 2d;
            }
            else if (shotNumber < 20)
            {
                verticalOffset = Rnd.NextDouble() + 2d;
                horizontalOffset = Rnd.NextDouble() + 6d;
            }
            else if (shotNumber < 24)
            {
                verticalOffset = Rnd.NextDouble() + 4d;
                horizontalOffset = Rnd.NextDouble() + 3d;
            }
            else
            {
                verticalOffset = Rnd.NextDouble() + 9d;
                horizontalOffset = Rnd.NextDouble() - 7d;
            }


            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime(1d);
        }
    }
}
namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class Spitfire : RpsWeaponBased
    {
        private const double SpitfireRps = 12.5;
        public Spitfire(string name, string recognizedName, int numOfMods) 
            : base(name, SpitfireRps, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 55);

            double horizontalOffset;
            double verticalOffset;
            if (shotNumber <= 8)
            {
                horizontalOffset = Rnd.NextDouble() * 0.1d + 1d;
                verticalOffset = Rnd.NextDouble() * 0.2d + 4d;
            }
            else if (shotNumber <= 10)
            {
                horizontalOffset = -1 * (Rnd.NextDouble() * 0.1d + 1.8d);
                verticalOffset = Rnd.NextDouble() * 0;
            }
            else if (shotNumber <= 12)
            {
                horizontalOffset = Rnd.NextDouble() * 0.1d + 0.2d;
                verticalOffset = Rnd.NextDouble() * 0.2d + 3d;
            }
            else if (shotNumber < 15)
            {
                horizontalOffset = Rnd.NextDouble() * 0.1d + 3.5d;
                verticalOffset = Rnd.NextDouble() * 0.2d + 1d;
            }
            else if (shotNumber < 19)
            {
                horizontalOffset = Rnd.NextDouble() * 0.1d;
                verticalOffset = Rnd.NextDouble() * 0.2d + 4d;
            }
            else if (shotNumber < 21)
            {
                horizontalOffset = Rnd.NextDouble() * 0.1d + 4.5d;
                verticalOffset = Rnd.NextDouble() * 0.2d;
            }
            else if (shotNumber < 32)
            {
                horizontalOffset = -1 * (Rnd.NextDouble() * 0.1d + 3.5d);
                verticalOffset = Rnd.NextDouble() * 0.2d + 2d;
            }
            else if (shotNumber < 33)
            {
                horizontalOffset = Rnd.NextDouble() * 0.1d;
                verticalOffset = Rnd.NextDouble() * 0.2d + 1d;
            }
            else if (shotNumber < 38)
            {
                horizontalOffset = Rnd.NextDouble() * 0.1d + 1.8d;
                verticalOffset = Rnd.NextDouble() * 0.05d;
            }
            else if (shotNumber < 41)
            {
                horizontalOffset = Rnd.NextDouble() * 0.2d + 0.5d;
                verticalOffset = Rnd.NextDouble() * 0.2d + 5.25d;
            }
            else if (shotNumber < 42)
            {
                horizontalOffset = Rnd.NextDouble() * 0.4d;
                verticalOffset = Rnd.NextDouble() * 0.3d + 5d;
            }
            else if (shotNumber < 50)
            {
                horizontalOffset = -1 * (Rnd.NextDouble() * 0.1d + 2.5d);
                verticalOffset = Rnd.NextDouble() * 0.3d + 4d;
            }
            else
            {
                horizontalOffset = Rnd.NextDouble() * 0.3d;
                verticalOffset = Rnd.NextDouble() * 0.2d + 3d;
            }

            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime();
        }
    }
}
namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class R301 : UniqueLogicWeapon
    {
        public R301(string name, double burstSeconds, string recognizedName, int numOfMods) 
            : base(name, burstSeconds, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            double horizontalOffset;
            double verticalOffset;
            this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 15);

            var hAdj = shotNumber > 10 ? 3 : -1;

            if (shotNumber >= 15)
            {
                verticalOffset = Rnd.NextDouble() + 2d; 
                horizontalOffset = 0;
            }
            else if (shotNumber >= 22)
            {
                verticalOffset = Rnd.NextDouble() + 1d;
                horizontalOffset = 0.5 * (Rnd.NextDouble() * 1 + 1);
            }
            else if (shotNumber >= 26)
            {
                verticalOffset = Rnd.NextDouble() + 2d;
                horizontalOffset = 2 * (Rnd.NextDouble() * 1 + 1);
            }
            else
            {
                verticalOffset = Rnd.NextDouble() + 4d; 
                horizontalOffset = hAdj * (Rnd.NextDouble() * 1 + 1);
            }

            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime(1d);
        }
    }
}
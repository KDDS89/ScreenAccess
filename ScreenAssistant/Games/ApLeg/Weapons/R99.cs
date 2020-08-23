namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class R99 : UniqueLogicWeapon
    {
        public R99(string name, double burstSeconds, string recognizedName, int numOfMods) 
            : base(name, burstSeconds, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            double horizontalOffset;
            double verticalOffset;
            this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 30);
            if (shotNumber < 13)
            {
                verticalOffset = Rnd.NextDouble() + 7.5;
                horizontalOffset = Rnd.NextDouble() * -1 - 1;
            }
            else if (shotNumber < 16)
            {
                verticalOffset = 0;
                horizontalOffset = Rnd.NextDouble() * -1 - 1;
            }
            else if (shotNumber < 20)
            {
                verticalOffset = Rnd.NextDouble() - 1;
                horizontalOffset = 0;
            }
            else
            {
                verticalOffset = 0;
                horizontalOffset = 0;
            }

            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime(1d);
        }
    }
}
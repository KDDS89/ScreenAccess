namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class Volt : UniqueLogicWeapon
    {
        public Volt(string name, double burstSeconds, string recognizedName, int numOfMods) 
            : base(name, burstSeconds, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            double horizontalOffset;
            double verticalOffset;
            this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 26);
            if (shotNumber < 10)
            {
                horizontalOffset = 0;
                verticalOffset = Rnd.NextDouble() + 7;
            }
            else if (shotNumber < 15)
            {
                horizontalOffset = Rnd.NextDouble() + 1;
                verticalOffset = Rnd.NextDouble() + 2;
            }
            else if (shotNumber < 19)
            {
                horizontalOffset = Rnd.NextDouble() - 3;
                verticalOffset = Rnd.NextDouble() + 2;
            }
            else
            {
                horizontalOffset = Rnd.NextDouble() +1;
                verticalOffset = Rnd.NextDouble() + 2;
            }

            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime(1d);
        }
    }
}
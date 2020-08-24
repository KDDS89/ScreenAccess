namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class Prowler : UniqueLogicWeapon
    {
        public Prowler(string name, double burstSeconds, string recognizedName, int numOfMods) 
            : base(name, burstSeconds, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            double horizontalOffset;
            double verticalOffset;
            this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 35);

            if (shotNumber < 1)
            {
                verticalOffset = Rnd.NextDouble() + 9d;
                horizontalOffset = 0;
            }
            else if (shotNumber < 6)
            {
                verticalOffset = Rnd.NextDouble()  + 7d;
                horizontalOffset = Rnd.NextDouble() + 0.5d;
            }
            else if (shotNumber < 13)
            {
                verticalOffset = Rnd.NextDouble() + 3.5d;
                horizontalOffset = Rnd.NextDouble() + 2d;
            }
            else if (shotNumber < 18)
            {
                verticalOffset = Rnd.NextDouble() + 4d;
                horizontalOffset = Rnd.NextDouble() - 6d;
            }
            else if (shotNumber < 29)
            {
                verticalOffset = Rnd.NextDouble() + 5d;
                horizontalOffset = 0;
            }
            else if (shotNumber < 33)
            {
                verticalOffset = Rnd.NextDouble();
                horizontalOffset = Rnd.NextDouble() - 9d;
            }
            else
            {
                verticalOffset = Rnd.NextDouble() + 6d;
                horizontalOffset = Rnd.NextDouble() + 1d;
            }

            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime(1d);
        }
    }
}
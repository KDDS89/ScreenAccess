namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class Repeater : UniqueLogicWeapon
    {
        public Repeater (string name, double burstSeconds, string recognizedName, int numOfMods)
            : base(name, burstSeconds, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 1);
            var horizontalOffset = 0;
            var verticalOffset = Rnd.NextDouble()*2d + 4d;
            this.MoveMouse(horizontalOffset, verticalOffset);
            return this.GetAdjustmentTime(1d);
        }
    }
}
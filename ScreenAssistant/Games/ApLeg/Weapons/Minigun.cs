namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class Minigun : UniqueLogicWeapon
    {
        public Minigun(string name, double burstSeconds, string recognizedName, int numOfMods) 
            : base(name, burstSeconds, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            var horizontalOffset = 0; 
            var verticalOffset = Rnd.NextDouble() * (4) + 50;

            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime(1d);
        }
    }
}
using TiqSoft.ScreenAssistant.ScreenInfoRecognition.Recognizers.ApexLegends;

namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class Havoc : UniqueLogicWeapon
    {
        public Havoc(string name, double burstSeconds, string recognizedName, int numOfMods) 
            : base(name, burstSeconds, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            var notOffsettingDelay = this.GetModuleType(3) == WeaponModuleType.Legendary ? 0 : 6;
            if (shotNumber > notOffsettingDelay)
            {
                double horizontalOffset;
                double verticalOffset; 
                this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 36);

                if (shotNumber < 12)
                {
                    verticalOffset = Rnd.NextDouble() + 9d;
                    horizontalOffset = Rnd.NextDouble() - 1d;
                }
                else if (shotNumber < 20)
                {
                    verticalOffset = Rnd.NextDouble();
                    horizontalOffset = Rnd.NextDouble() - 3d;
                }
                else if (shotNumber < 28)
                {
                    verticalOffset = Rnd.NextDouble() + 4d;
                    horizontalOffset = 0;
                }
                else
                {
                    verticalOffset = Rnd.NextDouble() + 20d;
                    horizontalOffset = Rnd.NextDouble() + 2d;
                }

                this.MoveMouse(horizontalOffset, verticalOffset);
            }

            return this.GetAdjustmentTime(1d);
        }
    }
}
using TiqSoft.ScreenAssistant.ScreenInfoRecognition.Recognizers.ApexLegends;

namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class Devotion : RpsWeaponBased
    {
        private const double DevotionRps = 18d;
        private const double DevotionChargedRps = 25d;
        private bool _isCharged = false;
        public Devotion(string name, string recognizedName, int numOfMods) 
            : base(name, DevotionRps, recognizedName, numOfMods)
        {
        }

        public override void SetModule(int id, WeaponModuleType moduleType)
        {
            base.SetModule(id, moduleType);
            if (id == 4)
            {
                this._isCharged = moduleType == WeaponModuleType.Legendary;
                this.Rps = this._isCharged ? DevotionChargedRps : DevotionRps;
            }
        }

        public override double AdjustMouse(int shotNumber)
        {
            double horizontalOffset;
            double verticalOffset;
            this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 48);
            if (shotNumber <= 4)
            {
                verticalOffset = Rnd.NextDouble() + 10.5d;
                horizontalOffset = 0;
            }
            else if (shotNumber <= 10)
            {
                verticalOffset = Rnd.NextDouble() + 7;
                horizontalOffset = Rnd.NextDouble() + 3;
            }
            else if (shotNumber <= 15)
            {
                verticalOffset = Rnd.NextDouble() + 2;
                horizontalOffset = Rnd.NextDouble() + 3;
            }
            else if (shotNumber <= 18)
            {
                verticalOffset = 0;
                horizontalOffset = Rnd.NextDouble() + 2;
            }
            else if (shotNumber <= 27)
            {
                verticalOffset = Rnd.NextDouble() + 3;
                horizontalOffset = 0;
            }
            else if (shotNumber <= 38)
            {
                verticalOffset = Rnd.NextDouble() + 3;
                horizontalOffset = Rnd.NextDouble() - 6;
            }
            else
            {
                verticalOffset = Rnd.NextDouble() + 3;
                horizontalOffset = Rnd.NextDouble() +2;
            }

            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime();
        }
    }
}
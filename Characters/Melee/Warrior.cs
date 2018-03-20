using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string faction;
        private string name;
        private Chainlink bodyArmor;
        private Axe weapon;
        public int AbilityPoints { 
            get{
                return abilityPoints;
            }
            set{
                if(value >= 0 && value <=10)
                {
                abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Innapropraite Value, should be >= to 0 and <= 10.");
                }
            }
        }
          public int HealthPoints { 
            get{
                return abilityPoints;
            }
            set{
                if(value >= 0 && value <=10)
                {
                healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Innapropraite Value, should be higher or equal to 0 and <= 10.");
                }
            }
        }
          public int Level { 
            get{
                return abilityPoints;
            }
            set{
                if(value >= 0 && value <=10)
                {
                level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Innapropriate Value, should be higher or equal to 0 and <= 10.");
                }
            }
        }

        

        public Warrior()
        {

        }

        public void Strike()
        {
            throw new NotImplementedException();

        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}
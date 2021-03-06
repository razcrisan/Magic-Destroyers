using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight
    {
        
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private Chainlink bodyArmor;
        private Hammer weapon;
        
        public Knight()
            : this("Galahad", 1 )
        {

        }

        public Knight(string name, int level)
            : this("Paladin", 100, 120, 1)
        {
        }
        public Knight(string name, int abilityPoints, int healthPoints, int level)
        {
            this.name = name;
            this.abilityPoints = 100;
            this.healthPoints = 120;
            this.level = 1;
            this.faction = "Melee";
            this.bodyArmor = new Chainlink();
            this.weapon = new Hammer();
            
        }

        public int AbilityPoints { 
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if(value >= 0 && value <=10)
                {
                this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Innapropraite Value, should be >= to 0 and <= 10.");
                }
            }
        }

        public int HealthPoints {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if(value >= 0 && value <=10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Wrong Value, should be >= 0  and <= 10");
                }
            }
        }
        public int Level { 
            get
            {
                return this.level;
            }
            set
            {
                if(value >= 0 && value <=10)
                {
                this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Innapropriate Value, should be higher or equal to 0 and <= 10.");
                }
            }
        }
            public string Name { 
            get
            {
                return this.name;
            }
            set
            {
                if(value.Length >= 3 && value.Length <=12)
                {
                this.name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Innapropriate Value, should be higher or equal to 0 and <= 10.");
                }
            }
        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}
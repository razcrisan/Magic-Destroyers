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
        public Warrior()
        {
            
        }
        public Warrior(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }
        public Warrior(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = 100;
            this.Faction = "Melee";
            this.BodyArmor = new Chainlink();
            this.Weapon = new Axe();
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
                this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Innapropraite Value, should be higher or equal to 0 and <= 10.");
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
            public string Faction { 
            get
            {
                return this.faction;
            }
            set
            {
                if(value == "Melee" || value == "Spellcaster")
                {
                this.faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Innapropriate Value, should be higher or equal to 0 and <= 10.");
                }
            }
        }

        public Chainlink BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
          public Axe Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
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
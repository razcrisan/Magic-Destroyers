using System;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        private const string DEFAULT_NAME = "All Might";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const string DEFAULT_FACTION = "Melee";
        private const int DEFAULT_ABILITY_POINTS = 100;
        private readonly Chainlink DEFAULT_BODY_ARMOR =  new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string faction;
        private string name;
        private Chainlink bodyArmor;
        private Axe weapon;
        public Warrior()
            : this(DEFAULT_NAME, 1)
        {
        }
        public Warrior(string name, int level)
            :this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }
        public Warrior(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = DEFAULT_HEALTH_POINTS;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
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
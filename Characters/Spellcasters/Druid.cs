using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private LightLeatherVest bodyArmor;
        private Staff weapon;
        
        public Druid()
            : this("Sylveon", 120)
        {
        }
        public Druid(string name, int healthPoints)
            : this(name, 120, 1, 100)
        {
        }
        public Druid(string name, int healthPoints, int level, int abilityPoints)
        {
            this.name = name;
            this.healthPoints = healthPoints;
            this.level = 1;
            this.abilityPoints = 100;
            this.bodyArmor = new LightLeatherVest();
            this.weapon = new Staff();
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
        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}
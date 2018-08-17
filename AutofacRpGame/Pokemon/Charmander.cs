namespace AutofacRpGame.Pokemon
{
    using AutofacRpGame.Pokemon;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Charmander : IFirePokemon
    {
        string Name { get; set; }

        string Type { get; set; }

        int Level { get; set; }

        int Healt { get; set; }

        public Charmander(string _name, string _type,int _level, int _baseAttack, int _healt)
        {
            Name = _name;
            Level = 1;
            
        }

        public void Ember()
        {
            throw new NotImplementedException();
        }

        public void FireBlast()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Escape()
        {
            throw new NotImplementedException();
        }

        public void UseObject()
        {
            throw new NotImplementedException();
        }

        string IPokemon.Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        string IPokemon.Type
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        int IPokemon.Level
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int BaseAttack
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        int IPokemon.Healt
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}

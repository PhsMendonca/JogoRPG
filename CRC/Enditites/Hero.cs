using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG.CRC.Enditites
{
    public abstract class Hero
    {
        public Hero(string nome, int level, string HeroiType)
        {
            this.nome = nome;
            this.level = level;
            this.HeroiType = HeroiType;

        }

        public string nome;
        public int level;
        public string HeroiType;


        public override string ToString()
        {
            return this.nome + " " + this.level + " " + this.HeroiType;
        }

        public virtual string Attack()
        {
            return this.nome + "Atacou com a sua espada";
        }
    }
}

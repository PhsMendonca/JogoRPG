using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG.CRC.Enditites
{
    public class Wizard : Hero
    {
        public Wizard(string nome, int level, string HeroiType)
        {
            this.nome = nome;
            this.level = level;
            this.HeroiType = HeroiType;
        }

        public override string Attack()
        {
            return this.nome + "Lançou Magia";
        }
 
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.nome + "Lançou Magia super efetiva com " + Bonus;
            }
            else
            {
                return this.nome + "Lançou Magia com força fraca " + Bonus;
            }
            
        }
    }
}

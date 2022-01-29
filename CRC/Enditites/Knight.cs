using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG.CRC.Enditites
{
    class Knight : Hero
    {
        public Knight(string nome, int level, string HeroiType)
        {
            this.nome = nome;
            this.level = level;
            this.HeroiType = HeroiType;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa4_Dobble.Frander.Regalo_Envenenado
{
    class PGController
    {
        PGController()
        {
            poisonedGift titulo = new poisonedGift();
            titulo.Show();
            Carta me = new Carta();
            Carta jogador1 = new Carta();
            Carta jogador2 = new Carta();
            Carta jogador3 = new Carta();
        }
    }
}

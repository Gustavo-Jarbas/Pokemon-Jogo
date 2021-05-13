using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Treinador;
using Jogo.Entidades.Pokemon.Pokemons;
using Jogo.Entidades.Pokemon;

namespace Jogo.Entidades.Historia.Fases.Inimigos
{
    class Inimigo1 : TreinadorClass
    {
        //Crie um pokemon para o inimigo1, se baseie em um dos pokemon já criado, só tente pegar o pokemon caracteristico do vilão.
        //(por enquanto não se preocupe com a vida/  força do pokemon.  Para seguir a historia e ver se está tudo certo, crie oponentes que podemos vencer.)
        Bulbassauro bulbassauro = new Bulbassauro();
        public Inimigo1()
        {
            this.Nome = " Inimigo generico ";
            this.Pokemons.Add(bulbassauro);
            this.Dinheiro = 20;
        }
    }
}

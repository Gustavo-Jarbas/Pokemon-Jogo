using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.Entidades
{
    class Treinador
    {
        public string Nome { get; set; }

        public int Dinheiro = 10;
        public int PokeBalls = 3;
        public int Potion = 3;

        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

        public Treinador()
        {
        }

        public Treinador(string nome)
        {
            Nome = nome;
        }
        public void Deposito(int dinheiro)
        {
            Dinheiro += dinheiro;
        }
        
        public void MaisPokeball(int quantidade)
        {
            PokeBalls += quantidade;
        }

        public void MeusPokemon()
        {
            foreach (Pokemon pok in Pokemons)
            {
                Console.WriteLine(pok.Nome);
            }
        }

        public void Pokedex()
        {
            Console.WriteLine("Pokedex do "+ Nome);
            foreach (Pokemon pok in Pokemons)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("------------------------------------------------------------");
                sb.AppendLine($"Nome: {pok.Nome}");
                sb.AppendLine($"Tipo: {pok.TipoPokemon}");
                sb.AppendLine($"Descrição: {pok.Descricao}");
                sb.AppendLine("------------------------------------------------------------");

                Console.WriteLine(sb);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Pokemon;


namespace Jogo.Entidades.Treinador
{
    class TreinadorClass
    {
        public string Nome { get; set; }

        public int Dinheiro = 10;
        public int PokeBalls = 3;
        public int Potion = 3;
        public PokemonClass PokemonEscolhido { get; set; }
        public List<PokemonClass> Pokemons { get; set; } = new List<PokemonClass>();

        public TreinadorClass()
        {
        }

        public TreinadorClass(string nome)
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
            int contador = 0;

            foreach (PokemonClass pok in Pokemons)
            {
                Console.WriteLine(contador + " - " + pok.Nome);
                contador++;
            }
        }

        public void Pokedex()
        {
            Console.WriteLine("Pokedex do " + Nome);
            foreach (PokemonClass pok in Pokemons)
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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Threading.Tasks;
using Jogo.Entidades.Enums;
using Jogo.Entidades.Pokemons;
using System.Media;
using Jogo.Entidades.FuncoesGame;

namespace Jogo.Entidades
{
    class Historia
    {
        public string NomeJogador;
        public string Sexo;
        public double Dinheiro = 10;
        public Tipo TipoPokemon;
        private int EscolhaPokemon;
        public Pokemon PokemonEscolhido;


        public Historia()
        {
        }

        public Historia(string nomeJogador, string sexo, Tipo tipoPokemon)
        {

            this.NomeJogador = nomeJogador;
            this.Sexo = sexo;
            this.TipoPokemon = tipoPokemon;

        }





        public void SolicitandoDadosJogador()
        {

            Game.Musicas(1);
            Game.Introducao();

            Game.ImprimirTextos("\nBem-vindo ao mundo POKEMON!\n\n" +
             "Antes de iniciarmos o game, fale me um pouco sobre voce >D\n\n\n");


            Console.Clear();
            Console.Write("\nVoce é um garoto ou uma garota?\nR:");
            Sexo = Console.ReadLine().ToUpper();
            Console.Write("\n\nMuito bem e qual seu nome?\nR:");
            NomeJogador = Console.ReadLine().ToUpper();

            Console.Write("\n\nUAUUUUUU!!!! Que lindo nome, agora escolha o tipo de pokemon que deseja iniciar\n(0)Fogo\n(1)Agua\n(2)Planta\nR:");
            this.EscolhaPokemon = int.Parse(Console.ReadLine());


            if (EscolhaPokemon == 0)
            {
                TipoPokemon = Tipo.Fogo;
                PokemonEscolhido = new Charmander();


            }
            if (EscolhaPokemon == 1)
            {
                TipoPokemon = Tipo.Agua;
                PokemonEscolhido = new Squirtle();

            }
            if (EscolhaPokemon == 2)
            {
                TipoPokemon = Tipo.Planta;
                PokemonEscolhido = new Bulbassauro();
            }


        }

        public void Apresentacao()
        {

            var textos = new List<string>();
            textos.Add($"\nOlá jovem {NomeJogador} saudavel! desculpe por mantê-lo(a) esperando!\n\n\n");
            textos.Add("\nMeu nome é Robertinho\n" + "Mas pode me chamar de Professor Pokémon, todo mundo me chama assim :D\n\n");
            textos.Add("\nNós humanos vivemos ao lado de Pokémons, às vezes como companheiros amistosos e\nàs vezes como colegas de trabalho cooperativos\n");
            textos.Add("\n\n\nEntão você está pronto para essa aventura? :)\n\n");
            Console.Clear();
            foreach (var texto in textos)
            {
                Game.ImprimirTextos(texto);
            }





        }

        public void PrimeiraFase()
        {
            Console.Clear();
            Game.ImprimirDinheiro(this.Dinheiro);
            Game.ImprimirTextos($"Você escolheu o tipo de Pokemon de {PokemonEscolhido.TipoPokemon}, essa foi uma boa e fabulosa escolha" +
                $"\nCom essa especialidade o nome de seu Pokemon é {PokemonEscolhido.Nome} \n");
            Game.ImprimirTextos("\n\nRepare que ao lado direito está seu dinheiro e conforme você ir vencendo batalhas vai ganhando mais e" +
            "\nutilizqar para comprar pokebolas e poçoes de cura\n");
                Game.ImprimirTextos("\n\n\nEntao... oque você acha de iniciarmos com um breve duelo para testar suas habilidades? \n\n");

            Game.ImprimirTextos("\n\n\nTem um cara maluquinho da cabeça que está atacando a vila, vamos lá acabar com ele?\n\n");


            Console.Clear();

            Treinador treinador = new Treinador(NomeJogador);
            Treinador treinador2 = new Treinador("Carinha Maluko");

            Pokemon DoInimigo = new Bulbassauro();

            Pokemon pokemons = new Pokemon();
            treinador.Pokemons.Add(PokemonEscolhido);
            treinador2.Pokemons.Add(DoInimigo);

            Batalha batalha = new Batalha(treinador, treinador2);
            Treinador vencedor = batalha.IniciarBatalha();

            Console.WriteLine($"O treinador {vencedor.Nome} e seu {vencedor.Pokemons[0].Nome} ganharam!!!");






        }

    }
}
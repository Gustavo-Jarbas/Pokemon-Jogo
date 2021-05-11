﻿using System;
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
using Jogo.Entidades.Fases.Inimigos;
using Jogo.Entidades.Fases;

namespace Jogo.Entidades
{
       class Historia
        {
            static public string NomeJogador;
            static public string Sexo;
            static public double Dinheiro = 10;
            static public Tipo TipoPokemon;
            static private int EscolhaPokemon;
            static public Pokemon PokemonEscolhido;


            public Historia()
            {
            }

        public void Menu() // APOS CADA BATALHA/FASE SERA INICIALIZADA ESSA FUNÇÃO. (ainda em construção)
        {
            Console.WriteLine("[1] - Ir para a proxima batalha");
            Console.WriteLine("[2] - Ver seus pokemon");
            Console.WriteLine("[3] - Comprar na loja");
            Console.Write("R: ");
            int resposta = int.Parse(Console.ReadLine());


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
                EscolhaPokemon = int.Parse(Console.ReadLine());


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


          // fases do game :D
            public void PrimeiraFase()
            {
            Fase1.Executar();

            }



        }
    }



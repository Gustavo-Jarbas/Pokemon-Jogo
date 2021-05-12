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

         


            public void Executar()
            {
            Fase1.Executar();

            if (Fase1.proximafase == true)
            {


            }
            
            }



        }
    }



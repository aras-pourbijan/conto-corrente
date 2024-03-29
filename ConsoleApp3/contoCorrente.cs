﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class contoCorrente
    {

        public string nome { get; set; } 
        public string cognome { get; set; }
        public decimal saldo = 0;


        
        public void menuStart()
        {
            
            
            Console.WriteLine("******************    BANCA BIANCA !    *******************");
            Console.WriteLine("******************    By Aras Pourbijan - esercizio EPICODE     *******************");
            Console.WriteLine("1 - Aprire il conto");
            Console.WriteLine("2 - Fare un versamento");
            Console.WriteLine("3 - Fare un prelevamento");
            Console.WriteLine("***********************************************************");

            string scelta = Console.ReadLine();

            if(scelta== "1") { Console.WriteLine("Apertura del conto:"); ApriUnConto();}
            else if(scelta== "2") { Console.WriteLine(); Versamento();} 
            else if(scelta== "3") { Console.WriteLine(); Prelievo();}
            else { Console.WriteLine("scelta sbagliata! riprova"); menuStart();}
        }




        private void ApriUnConto()
        {
            
            Console.WriteLine("inserchi nome:");
           nome= Console.ReadLine();
            Console.WriteLine("inserchi cognome:");
            cognome = Console.ReadLine();
            Console.WriteLine("fai primo versamento:");
            saldo = int.Parse(Console.ReadLine());
            Console.WriteLine($"nuovo conto corrente per {nome} {cognome} con saldo iniziale di {saldo} euro");
            menuStart();
        }

        private void Versamento() {
           if(nome == null && cognome == null) { 
           
                Console.WriteLine("Prima apri un conto");
                ApriUnConto();

            }
            else
            {
                Console.WriteLine("inserchi cifra che vuoi versare:");
                saldo += int.Parse(Console.ReadLine());
                Console.WriteLine($"Nuovo saldo:{saldo} euro");
            }
            menuStart();
        }
        
        private void Prelievo() {
            if (nome == null && cognome == null)
            {

                Console.WriteLine("Prima apri un conto");
                ApriUnConto();

            }
            else { 
                Console.WriteLine("inserchi cifra che vuoi prelevare:");
            saldo -= int.Parse(Console.ReadLine());
            Console.WriteLine($"Nuovo saldo:{saldo} euro");
            }
            menuStart();
        }
    }
}
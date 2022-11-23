using System;
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
        public decimal saldo { get; set; }


        
        public void menuStart()
        {
            
            Console.WriteLine("***********************************************************");
            Console.WriteLine("******************    BANCA BIANCA !    *******************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("1 - Aprire il conto");
            Console.WriteLine("2 - Fare un versamento");
            Console.WriteLine("3 - Fare un prelevamento");
          
            string scelta = Console.ReadLine();

            if(scelta== "1") { Console.WriteLine("Apertura del conto:"); ApriUnConto();}
            else if(scelta== "2") { Console.WriteLine(); Versamento();} 
            else if(scelta== "3") { Console.WriteLine(); Prelievo();}
            else { Console.WriteLine("scelta sbagliata! riprova"); menuStart();}
        }




        public void ApriUnConto()
        {
            
            Console.WriteLine("inserchi nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("inserchi cognome:");
            string cognome = Console.ReadLine();
            Console.WriteLine("fai primo versamento:");
            int saldo = int.Parse(Console.ReadLine());
            Console.WriteLine($"nuovo conto corrente per {nome} {cognome} con saldo iniziale di{saldo} euro");
            menuStart();
        }

        public void Versamento() {
            Console.WriteLine("inserchi cifra che vuoi versare:");
           saldo += int.Parse(Console.ReadLine());
        }

        public void Prelievo() { }
    }
}
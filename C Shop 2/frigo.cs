using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdottiEstesi
{
    // SOTTOCLASSE COMPLESSA che estende Prodotto
    // Tutti gli attributi e metodi dichiarati qui NON sono visibili nella SUPERCLASSE!
    internal class Frigo : Prodotto
    {
        // ------------- ATTRIBUTI SPECIFICI DI BEVANDA ----------------------
        private double kg;
        private string marca;


        // ------------- COSTRUTTORI DI BEVANDA -------------------------------
        // Quando dichiaro più costruttori sto facendo L'OVERLOADING dei costruttori
        // COSTRUTTORE SPECIFICO DI frigo senza prezzo ed iva che usa il costruttore senza prezzo ed iva di Prodotto
        public Frigo(string nomeFrigo, string descrizione, double kg, string marca) : base(nomeFrigo, descrizione)
        {

            this.kg = kg;
            this.marca = marca;
        }

        // COSTRUTTORE SPECIFICO DI frigo che usa il costruttore completo di Prodotto
        public Frigo(string nomeFrigo, string descrizione, double kg, string marca, double prezzo, int iva) : base(nomeFrigo, descrizione, prezzo, iva)
        {

            this.kg = kg;
            this.marca = marca;
        }

        // ------------------ METODI SPECIFICI DELLA CLASSE BEVANDA ------------

        // OVERRIDE (letteralemente SOVRASCRITTURA di un METODO) di NomeEsteso di Prodotto. Override perchè questo metodo esisteva già in Prodotto!
        public override void NomeEsteso()
        {
            // CODICE - NOME - LITRI
            Console.WriteLine("Il nome esteso del frigo è: " + base.PadLeft() + " - " + base.nome + " - " + this.kg + " kg");
        }

        public void pesoTotale(double kgdelfrigo)
        {
            if (kgdelfrigo == 340)
            {
                this.kg = this.kg = kgdelfrigo;
                Console.WriteLine("Il tuo frigo pesa" + kgdelfrigo);
            }
        }

        public void  MarcaFrigo()
        {
            
            Console.WriteLine("La marca sarà Bosch");
        }





    }
}

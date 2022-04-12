using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdottiEstesi
{
    // SOTTOCLASSE COMPLESSA che estende Prodotto
    // Tutti gli attributi e metodi dichiarati qui NON sono visibili nella SUPERCLASSE!
    internal class Acqua : Prodotto
    {
        // ------------- ATTRIBUTI SPECIFICI DI BEVANDA ----------------------
        private double litri;
        private string materialeContenitore;


        // ------------- COSTRUTTORI DI BEVANDA -------------------------------
        // Quando dichiaro più costruttori sto facendo L'OVERLOADING dei costruttori
        // COSTRUTTORE SPECIFICO DI BEVANDA senza prezzo ed iva che usa il costruttore senza prezzo ed iva di Prodotto
        public Acqua(string nomeBevanda, string descrizione, double litri, string materiale) : base(nomeBevanda, descrizione)
        {

            this.litri = litri;
            this.materialeContenitore = materiale;
        }

        // COSTRUTTORE SPECIFICO DI BEVANDA che usa il costruttore completo di Prodotto
        public Acqua(string nomeBevanda, string descrizione, double litri, string materiale, double prezzo, int iva) : base(nomeBevanda, descrizione, prezzo, iva)
        {

            this.litri = litri;
            this.materialeContenitore = materiale;
        }

        // ------------------ METODI SPECIFICI DELLA CLASSE BEVANDA ------------

        // OVERRIDE (letteralemente SOVRASCRITTURA di un METODO) di NomeEsteso di Prodotto. Override perchè questo metodo esisteva già in Prodotto!
        public override void NomeEsteso()
        {
            // CODICE - NOME - LITRI
            Console.WriteLine("Il nome esteso dell'acqua è: " + base.PadLeft() + " - " + base.nome + " - " + this.litri + " litri");
        }

        public void litritotali(double litriDaBere)
        {
            if (litriDaBere == 1.5)
            {
                this.litri = this.litri = litriDaBere;
                Console.WriteLine("Hai a disposizione" + litriDaBere);
            }
            else
            {
                Console.WriteLine("hai bevuto tutta l'acqua, mi dispiace hai finito la bottiglia");
                this.litri = 0;
            }
        }

    }
}

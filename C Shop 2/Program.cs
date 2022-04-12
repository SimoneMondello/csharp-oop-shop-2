// See https://aka.ms/new-console-template for more information
using ProdottiEstesi;


Acqua miaBevanda = new Acqua("Lete", "Bevanda", 1.5, "plastica");
miaBevanda.NomeEsteso();
miaBevanda.litritotali(1.5);
miaBevanda.litritotali(0);

//------------------------

Frigo mioFrigo = new Frigo("Frigo", "Frigo", 340, "marcaFrigo");
mioFrigo.NomeEsteso();
mioFrigo.pesoTotale(0);
mioFrigo.MarcaFrigo();
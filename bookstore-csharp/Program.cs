//-Titolo | stringa
//- Autore | stringa
//- ISBN | numerico intero
//- Numero pagine | numerico intero
//- Peso del libro | numerico float
//- Larghezza, Altezza e Profondità del libro | numerico float
//- Valutazione media | numerico float
//- Numero di recensioni | intero
//- se è disponibile in versione Kindle | boolean
//- se la copertina flessibile è disponibile | boolean

string titolo = "Clean Code: A Handbook of Agile Software Craftmanship";
string author = "Robert C. Martin";
long isbn = 9780132350884;
uint pageNumber = 431;
float bookWeight = 660;
double bookHeight = 23.5;
double bookWidth = 17.91;
double bookDepth = 2.54;
double bookScore = 4.7;
long bookReviewNumber = 3310;
bool versioneKindle = true;
bool copertinaFlessibile = true;

//viva l'autocompletamento di VisualStudio
Console.WriteLine("Il titolo del libro è " + titolo);
Console.WriteLine("L'autore del libro è " + author);
Console.WriteLine("L'ISBN è " + isbn);
Console.WriteLine("Il libro ha " + pageNumber + " pagine");
Console.WriteLine("Peso: " + bookWeight + "g");
Console.Write("Dimensioni: " + bookHeight);
Console.Write("cm x " + bookWidth);
Console.WriteLine("cm x " + bookDepth + "cm");
Console.WriteLine("Valutazione: " + bookScore);
Console.WriteLine("Recensioni: " + bookReviewNumber);
Console.WriteLine("Disponibilità Kindle: " + versioneKindle);
Console.WriteLine("Copertina Flessibile: " + copertinaFlessibile);



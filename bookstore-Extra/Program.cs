// See https://aka.ms/new-console-template for more information

Console.Write("Titolo Libro: ");
string titolo = Console.ReadLine();
Console.Write("Autore: ");
string author = Console.ReadLine();
Console.Write("Numero di pagine: ");
uint pageNumber = uint.Parse(Console.ReadLine()); //posso parsare inline come JS
Console.Write("L'ISBN è: ");
long isbn = long.Parse(Console.ReadLine());
Console.Write("Peso del Libro: ");
float bookWeight = float.Parse(Console.ReadLine());
Console.Write("Altezza libro: ");
double bookHeight = double.Parse(Console.ReadLine());
Console.Write("Larghezza libro: ");
double bookWidth = double.Parse(Console.ReadLine());
Console.Write("Spessore libro: ");
double bookDepth = double.Parse(Console.ReadLine());
Console.Write("Punteggio recensioni: ");
float bookScore = float.Parse(Console.ReadLine());
Console.Write("Numero di Review: ");
long bookReviewNumber = long.Parse(Console.ReadLine());
Console.Write("Presente versione Kindle? true/false : ");
bool versioneKindle = bool.Parse(Console.ReadLine());
Console.Write("Presente copertina Flessibile? true/false : ");
bool copertinaFlessibile = bool.Parse(Console.ReadLine());

//e se ora stampo?

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
// See https://aka.ms/new-console-template for more information


long bookReviewNumber;
bool versioneKindle;
bool copertinaFlessibile;

Console.Write("Titolo Libro: ");
string titolo = Console.ReadLine();
Console.Write("Autore: ");
string author = Console.ReadLine();
Console.Write("Numero di pagine: ");
uint pageNumber = uint.Parse(Console.ReadLine()); //posso parsare inline come JS
Console.Write("L'ISBN è: ");
long isbn = long.Parse(Console.ReadLine());
Console.Write("Peso del Libro:");
float bookWeight = float.Parse(Console.ReadLine());
Console.Write("Altezza libro:");
double bookHeight = double.Parse(Console.ReadLine());
Console.Write("Larghezza libro:");
double bookWidth = double.Parse(Console.ReadLine());
Console.Write("Spessore libro:");
double bookDepth = double.Parse(Console.ReadLine());


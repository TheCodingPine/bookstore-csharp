// See https://aka.ms/new-console-template for more information


float bookWeight;
double bookHeight;
double bookWidth;
double bookDepth;
double bookScore;
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


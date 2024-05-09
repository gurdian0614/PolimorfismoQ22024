
using PolimorfismoQ22024;

// Polimorfismo mediante Listas
List<Edificio> edificioLista = new List<Edificio>();
string opcion = "";
do
{
    Edificio edificio = new Edificio();
    Console.WriteLine("Ingrese tipo de edificio:");
    edificio.Tipo = Console.ReadLine();
    Console.WriteLine("Ingrese precio:");
    edificio.Precio = double.Parse(Console.ReadLine());
    edificioLista.Add(edificio);
    Console.WriteLine("Desea continuar? (S/N)");
    opcion = Console.ReadLine();
} while (opcion != "N");

Console.WriteLine("\n\n********** Lista de Edificios **********");
foreach (Edificio e in edificioLista)
{
    e.Vender();
}
Console.WriteLine("********** Fin Lista de Edificios **********");
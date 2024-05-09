
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

//Polimorfismo mediante herencia y sobrecarga
Console.WriteLine("\n\n********** Objeto Casa **********");
Casa casa = new Casa();
casa.TipoInmueble = "Apartamento";
casa.Precio = 100000;
casa.Ubicacion = "SPS";
casa.AreaTerreno = 50;
casa.Vender();
Console.WriteLine("********** Fin Objeto Casa **********");

Console.WriteLine("\n\n********** Objeto Departamento **********");
Departamento depto = new Departamento(75000);
depto.TipoInmueble = "Departamento Fino";
depto.Ubicacion = "SPS";
depto.AreaTerreno = 50;
depto.Vender();
Console.WriteLine("********** Fin Objeto Departamento **********");

Console.WriteLine("\n\n********** Objeto Terreno **********");
Terreno terreno = new Terreno("Terreno", 75000, "Santa Barbara", 100);
terreno.Vender();
terreno.Vender("Roger");
terreno.Vender("Roger", 50000);
terreno.Vender(50000);
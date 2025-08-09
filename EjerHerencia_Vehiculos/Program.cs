using EjerHerencia_Vehiculos;

Carro carro1 = new Carro
{
    Marca = "Toyota",
    Modelo = "Corolla",
    Anno = 2020,
    NumeroPuertas = 4,
    TipoCombustible = "Gasolina"
};

Carro carro2 = new Carro
{
    Marca = "Tesla",
    Modelo = "Model S Plaid",
    Anno = 2021,
    NumeroPuertas = 4,
    TipoCombustible = "Electrico"
};

Moto moto1 = new Moto
{
    Marca = "Yamaha",
    Modelo = "MT-07",
    Anno = 2019,
    Cilindrada = 689,
    TieneMaletero = true
};

Moto moto2 = new Moto
{
    Marca = "Kawasaki",
    Modelo = "Ninja 650",
    Anno = 2020,
    Cilindrada = 649,
    TieneMaletero = false
};

Bicicleta bicicleta1 = new Bicicleta
{
    Marca = "Giant",
    Modelo = "Talon 3",
    Anno = 2022,
    Tipo = "Montaña"
};

Bicicleta bicicleta2 = new Bicicleta
{
    Marca = "Trek",
    Modelo = "Domane AL 2",
    Anno = 2021,
    Tipo = "Carretera"
};

Console.WriteLine("*** Informacion del Primer Carro ***");
carro1.MostrarInformacion();
Console.WriteLine("\n*** Informacion del Segundo Carro ***");
carro2.MostrarInformacion();
Console.WriteLine("\n*** Información de la Primera Moto ***");
moto1.MostrarInformacion();
Console.WriteLine("\n*** Información de la Segunda Moto ***");
moto2.MostrarInformacion();
Console.WriteLine("\n*** Información de la Primera Bicicleta ***");
bicicleta1.MostrarInformacion();
Console.WriteLine("\n*** Información de la Segunda Bicicleta ***");
bicicleta2.MostrarInformacion();
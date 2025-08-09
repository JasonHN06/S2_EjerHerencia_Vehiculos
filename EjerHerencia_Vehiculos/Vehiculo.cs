namespace EjerHerencia_Vehiculos
{
    internal class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anno { get; set; }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Anno}");
        }
    }
}

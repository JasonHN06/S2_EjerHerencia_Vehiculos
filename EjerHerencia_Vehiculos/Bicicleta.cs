namespace EjerHerencia_Vehiculos
{
    internal class Bicicleta : Vehiculo
    {
        public string Tipo { get; set; } 
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Tipo: {Tipo}");
        }
    }
}

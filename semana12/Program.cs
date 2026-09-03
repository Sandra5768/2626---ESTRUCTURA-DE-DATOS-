class Program
{
    static void Main()
    {
        Conjuntos conjunto = new Conjuntos();
        Mapas mapa = new Mapas();
        Diccionarios diccionario = new Diccionarios();
 
        // Registro de equipos
        conjunto.RegistrarEquipo("Barcelona");
        conjunto.RegistrarEquipo("Emelec");
        conjunto.RegistrarEquipo("Barcelona");
 
        // Registro de los equipos en el mapa
        mapa.RegistrarEquipo("Barcelona");
        mapa.RegistrarEquipo("Emelec");
 
        // Registro de jugadores
        mapa.RegistrarJugador("Barcelona", "Carlos Perez");
        mapa.RegistrarJugador("Barcelona", "Juan Lopez");
        mapa.RegistrarJugador("Emelec", "Pedro Gomez");
 
        // Registro de jugadores en el diccionario
        diccionario.RegistrarJugador("Carlos Perez", "Barcelona");
        diccionario.RegistrarJugador("Juan Lopez", "Barcelona");
        diccionario.RegistrarJugador("Pedro Gomez", "Emelec");
 
        // Mostrar equipos
        Console.WriteLine("\n--- EQUIPOS REGISTRADOS ---");
 
        foreach (string equipo in conjunto.ObtenerEquipos())
        {
            Console.WriteLine("- " + equipo);
        }
 
        // Mostrar jugadores
        Console.WriteLine("\n--- JUGADORES POR EQUIPO ---");
 
        mapa.MostrarJugadores("Barcelona");
        mapa.MostrarJugadores("Emelec");
 
        // Consulta mediante diccionario
        Console.WriteLine("\n--- CONSULTA DE JUGADOR ---");
 
        diccionario.ConsultarJugador("Carlos Perez");
    }
}
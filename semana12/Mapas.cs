public class Mapas
{
    private Dictionary<string, List<string>> mapaEquipos =
        new Dictionary<string, List<string>>();
 
    public void RegistrarEquipo(string equipo)
    {
        if (!mapaEquipos.ContainsKey(equipo))
        {
            mapaEquipos[equipo] = new List<string>();
        }
    }
 
    public void RegistrarJugador(string equipo, string jugador)
    {
        if (mapaEquipos.ContainsKey(equipo))
        {
            mapaEquipos[equipo].Add(jugador);
            Console.WriteLine("Jugador registrado correctamente.");
        }
    }
 
    public void MostrarJugadores(string equipo)
    {
        if (mapaEquipos.ContainsKey(equipo))
        {
            Console.WriteLine($"\nEquipo: {equipo}");
 
            foreach (string jugador in mapaEquipos[equipo])
            {
                Console.WriteLine("- " + jugador);
            }
        }
    }
}
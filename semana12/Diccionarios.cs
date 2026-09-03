public class Diccionarios
{
    private Dictionary<string, string> jugadores =
        new Dictionary<string, string>();
 
    public void RegistrarJugador(string jugador, string equipo)
    {
        jugadores[jugador] = equipo;
    }
 
    public void ConsultarJugador(string jugador)
    {
        if (jugadores.ContainsKey(jugador))
        {
            Console.WriteLine(
                $"Jugador: {jugador} | Equipo: {jugadores[jugador]}"
            );
        }
        else
        {
            Console.WriteLine("No se encontró el jugador.");
        }
    }
}
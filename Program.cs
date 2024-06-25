//<>//
using personajes;
int numeroPersonaje = 1;
//lista de personajes vivos//
List<Personaje> listaPersonajes = new List<Personaje>();
listaPersonajes.Add(fabricaPersonajes.generarPersonaje(numeroPersonaje));
numeroPersonaje++;
listaPersonajes.Add(fabricaPersonajes.generarPersonaje(numeroPersonaje));
numeroPersonaje++;
listaPersonajes.Add(fabricaPersonajes.generarPersonaje(numeroPersonaje));
numeroPersonaje++;
listaPersonajes.Add(fabricaPersonajes.generarPersonaje(numeroPersonaje));
numeroPersonaje++;
listaPersonajes.Add(fabricaPersonajes.generarPersonaje(numeroPersonaje));
foreach(Personaje personaje in listaPersonajes){
    personaje.mostrarPersonaje();
}

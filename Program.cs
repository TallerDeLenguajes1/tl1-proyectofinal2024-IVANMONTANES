using personajes;
int numeroPersonaje = 1;
Personaje personaje1 = new Personaje(new Caracteristicas(numeroPersonaje),new Datos(numeroPersonaje));
numeroPersonaje++;
Personaje personaje2 = new Personaje(new Caracteristicas(numeroPersonaje),new Datos(numeroPersonaje));
personaje1.mostrarPersonaje();
personaje2.mostrarPersonaje();
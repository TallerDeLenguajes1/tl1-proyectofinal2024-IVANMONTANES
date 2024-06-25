namespace personajes;
public class Datos{
    public Datos(string tipo, string nombre, string apodo, DateTime fechaNac, int edad)
    {
        Tipo = tipo;
        Nombre = nombre;
        Apodo = apodo;
        FechaNac = fechaNac;
        Edad = edad;
    }

    public string Tipo {get;set;}
    public string Nombre {get;set;}
    public string Apodo {get;set;}
    public DateTime FechaNac {get;set;}
    public int Edad {get;set;}

    public void mostrarDatos(){
        Console.WriteLine("----------DATOS PERSONAJE----------");
        Console.WriteLine("tipo: "+Tipo);
        Console.WriteLine("nombre: "+Nombre);
        Console.WriteLine("apodo: "+Apodo);
        Console.WriteLine("nacimiento: "+FechaNac.ToString("dd/MM/yyyy"));
        Console.WriteLine("edad: "+Edad);
    }

}

public class Caracteristicas{
    public Caracteristicas(int velocidad, int destreza, int fuerza, int nivel, int armadura, int salud)
    {
        Velocidad = velocidad;
        Destreza = destreza;
        Fuerza = fuerza;
        Nivel = nivel;
        Armadura = armadura;
        Salud = salud;
    }

    public int Velocidad {get;set;}
    public int Destreza {get;set;}
    public int Fuerza {get;set;}
    public int Nivel {get;set;}
    public int Armadura {get;set;}
    public int Salud {get;set;}

    public void mostrarCaracteristicas(){
        Console.WriteLine("----------CARACTERISITCAS PERSONAJE----------");
        Console.WriteLine("velocidad: "+Velocidad);
        Console.WriteLine("destreza: "+Destreza);
        Console.WriteLine("fuerza: "+Fuerza);
        Console.WriteLine("nivel: "+Nivel);
        Console.WriteLine("armadura: "+Armadura);
        Console.WriteLine("salud: "+Salud);
    }
}

public class Personaje{
    public Caracteristicas CaracteristicasPersonaje {get;set;}
    public Datos DatosPersonaje {get;set;}

    public void mostrarPersonaje(){
        DatosPersonaje.mostrarDatos();
        CaracteristicasPersonaje.mostrarCaracteristicas();
    }
}
public static class fabricaPersonajes{
   
    public static Personaje generarPersonaje(int numeroPersonaje){
        Personaje nuevoPersonaje = new Personaje();
        switch(numeroPersonaje){
            case 1:
            Datos datos1 =new Datos ("humano","raftor","destructor",new DateTime(1999,3,24),25);
            Caracteristicas caracteristicas1 = new Caracteristicas(4,5,3,8,7,100);
            nuevoPersonaje.DatosPersonaje=datos1;
            nuevoPersonaje.CaracteristicasPersonaje = caracteristicas1;
            break;

            case 2:
            Datos datos2 =new Datos ("humano","elias","loco",new DateTime(1977,5,30),44);
            Caracteristicas caracteristicas2 = new Caracteristicas(3,3,6,10,2,100);
            nuevoPersonaje.DatosPersonaje=datos2;
            nuevoPersonaje.CaracteristicasPersonaje = caracteristicas2;
            break;

            case 3:
            Datos datos3 =new Datos ("bestia","aazumic","asesino",new DateTime(1555,1,15),546);
            Caracteristicas caracteristicas3 = new Caracteristicas(7,2,9,5,1,100);
            nuevoPersonaje.DatosPersonaje=datos3;
            nuevoPersonaje.CaracteristicasPersonaje = caracteristicas3;
            break;

            case 4:
            Datos datos4 =new Datos ("bestia","belzec","embargue",new DateTime(1000,3,24),1453);
            Caracteristicas caracteristicas4 = new Caracteristicas(10,4,10,1,1,100);
            nuevoPersonaje.DatosPersonaje=datos4;
            nuevoPersonaje.CaracteristicasPersonaje = caracteristicas4;
            break;

            case 5:
            Datos datos5 =new Datos ("mago","euclides","clerigo",new DateTime(1455,1,1),654);
            Caracteristicas caracteristicas5 = new Caracteristicas(2,2,4,8,10,100);
            nuevoPersonaje.DatosPersonaje=datos5;
            nuevoPersonaje.CaracteristicasPersonaje = caracteristicas5;
            break;
        }
        return nuevoPersonaje;
    }
}
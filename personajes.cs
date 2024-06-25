namespace personajes;
public class Caracteristicas{
    public string Tipo {get;set;}
    public string Nombre {get;set;}
    public string Apodo {get;set;}
    public DateTime FechaNac {get;set;}
    public int Edad {get;set;}

    public Caracteristicas(int numeroPersonaje){
        switch(numeroPersonaje){
            case 1:
            Tipo = "humano";
            Nombre = "braith";
            Apodo = "demoledor";
            FechaNac = new DateTime(1999,4,12);
            Edad = 35;
            break;

            case 2:
            Tipo = "mago";
            Nombre = "astraid";
            Apodo = "clerigo";
            FechaNac = new DateTime(567,4,24);
            Edad = 1567;
            break;
        }
    }

    public void mostrarCaracteristicas(){
        Console.WriteLine("tipo: "+Tipo);
        Console.WriteLine("nombre: "+Nombre);
        Console.WriteLine("apodo: "+Apodo);
        Console.WriteLine("fecha nacimiento: "+FechaNac.ToString("dd/MM/yyyy"));
        Console.WriteLine("edad: "+Edad);
    }
}

public class Datos{
    public int Velocidad {get;set;}
    public int Destreza {get;set;}
    public int Fuerza {get;set;}
    public int Nivel {get;set;}
    public int Armadura {get;set;}
    public int Salud {get;set;}

    public Datos(int numeroPersonaje){
        switch(numeroPersonaje){
            case 1:
            Velocidad = 3;
            Destreza = 5;
            Fuerza = 6;
            Nivel = 2;
            Armadura = 9;
            Salud = 100;
            break;

            case 2:
            Velocidad = 2;
            Destreza = 3;
            Fuerza = 10;
            Nivel = 6;
            Armadura = 3;
            Salud = 100;
            break;
        }
    }

    public void mostrarDatos(){
        Console.WriteLine("velocidad: "+Velocidad);
        Console.WriteLine("destreza: "+Destreza);
        Console.WriteLine("fuerza: "+Fuerza);
        Console.WriteLine("nivel: "+Nivel);
        Console.WriteLine("armadura: "+Armadura);
        Console.WriteLine("salud: "+Salud);
    }
}

public class Personaje{
    Caracteristicas caracteristicasPersonaje;
    Datos datosPersonaje;
    
    public Personaje(Caracteristicas CaracteristicasPersonaje,Datos DatosPersonaje){
        caracteristicasPersonaje = CaracteristicasPersonaje;
        datosPersonaje = DatosPersonaje;
    }

    public void mostrarPersonaje(){
        Console.WriteLine("----------CARACTERISTICAS----------");
        caracteristicasPersonaje.mostrarCaracteristicas();
        Console.WriteLine("----------DATOS----------");
        datosPersonaje.mostrarDatos();
    }
}
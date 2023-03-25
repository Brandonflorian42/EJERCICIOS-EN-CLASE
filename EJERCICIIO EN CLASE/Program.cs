void Adivina()
{
    const int Oportunidades = 4;
    int numeroCPU, numeroUsuario;
    byte Intentos, BanderaControl;
    string Linea;

     Random rand = new Random();

    do
    {

        numeroCPU= Convert.ToInt32(rand.Next(100));
        //Console.WriteLine(numeroCPU);
    } while(!(((numeroCPU>= 1) &(numeroCPU <= 20))));
    //proceso

    Intentos = 1;
    BanderaControl = 0;
    do
    {
        Console.WriteLine("Hola estoy pensando en un numero, cual crees que es: ");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());
        if ((numeroUsuario == numeroCPU))
        {
            Console.WriteLine("yes! adivinaste");
            BanderaControl= 1;
        }else
        {
            if (numeroUsuario > numeroCPU){
              Console.WriteLine("Llegaste");
            }else
            {
                Console.WriteLine("Te pasaste");
            }
        }
        Intentos++;
    }while(((Intentos <= Oportunidades) & (BanderaControl == 0)));
    if (BanderaControl ==0)
    {
        Console.WriteLine("El numero que pense era: "  + numeroCPU);
    }
}


void buscarMayor()
{
    int mayor = 0;
    int menor = 100;
    int numero = 0;
    Random numerito = new Random();

    for (int i = 0; i < 5; i++)
    {
        numero = numerito.Next(100);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor = numero;
        }
        Console.WriteLine(numero);
        if (numero < menor)
        {
            menor = numero;
        }

    }
    Console.WriteLine("El numero mayor es: " + mayor);
    Console.WriteLine("El numero menor es: " + menor);


}


void nombres()
{
    string[] nombre = new string[11];
    nombre[0] = "Jairo";
    nombre[1] = "Brandon";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";
    nombre[5] = "Carlos";
    nombre[6] = "Selvin";
    nombre[7] = "Rosa";
    nombre[8] = "Estefany";
    nombre[9] = "Pedro";
    nombre[10] ="jeremias";

    Random rnd = new Random();

    int primerLugarIndex = rnd.Next(0, nombre.Length);

    int segundoLugarIndex;
    do
    {
        segundoLugarIndex = rnd.Next(0, nombre.Length);
    } while (segundoLugarIndex == primerLugarIndex);

    string primerLugar = nombre[primerLugarIndex];
    string segundoLugar = nombre[segundoLugarIndex];

    Console.WriteLine("El ganador del primer lugar es: " + primerLugar + " y se ha ganado el primer premio de una pijama de cerdo.");
    Console.WriteLine("El ganador del segundo lugar es: " + segundoLugar + " y se ha ganado el segundo premio una pierna.");
}


  nombres();
 //arreglos
 //buscarMayor();
 //Adivina();


    void arreglos()
    {
        int[] notas = new int[16];
        Random rnd = new Random();
        Console.WriteLine("Cargando informacion");

        for (int i = 0; i < notas.Length; i++)
        {
            notas[i] = rnd.Next(100);
        }
        Console.WriteLine("desplegando informacion:");
        int mayor = 0;
        int promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine(notas[i]);
        }
        Console.WriteLine("Nota Mayor=" + mayor);
    }



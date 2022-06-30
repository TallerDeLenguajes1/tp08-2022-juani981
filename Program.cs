// See https://aka.ms/new-console-template for more information
using System.IO;
using System;
using System.Text.Json;

public class ListadoFormateado
{
    public int Registro {get;set;}
    public string NombredelArchivo{get;set;}
    public string Extension{get;set;}
}
class programa{
public static void Main(){

//Console.WriteLine("Ingrese un nombre de ruta a buscar:");
string ruta =@"C:\Users\Juan Ignacio Carrizo\Desktop";
//MostrarDirectorio(ruta);
EscribirArchivo(ruta);
}

static void MostrarDirectorio(string ruta){
    List<string> ListarCarpetas = Directory.GetDirectories(ruta).ToList();
    List<string> ListarArchivos = Directory.GetFiles(ruta).ToList();
    int n=0;
        //Console.WriteLine("Archivos en Carpetas:");
        foreach (string Carpeta in ListarCarpetas)
        {
            //Console.WriteLine(Carpeta);
            foreach (string item in Directory.GetFiles(Carpeta))
            {
                n++;
                Console.WriteLine(item);
            }
        }
        //Console.WriteLine("Archivos Sueltos:");
        foreach (string archivo in ListarArchivos)
        {
            n++;
            Console.WriteLine(archivo);
        }
}

static void EscribirArchivo(string ruta){ 
    List<string> ListarCarpetas = Directory.GetDirectories(ruta).ToList();
    List<string> ListarArchivos = Directory.GetFiles(ruta).ToList();
    StreamWriter sr = new StreamWriter(ruta+@"index.csv");

    if (!File.Exists(ruta+@"index.csv"))
    {
        sr.WriteLine("Nro de Registro;Nombre del Archivo;Extension;");
    }
        int n=0;
        /*//Console.WriteLine("Archivos en Carpetas:");
        foreach (string Carpeta in ListarCarpetas)
        {
            //Console.WriteLine(Carpeta);
            foreach (string item in Directory.GetFiles(Carpeta))
            {
                sr.WriteLine(n+";"+Path.GetFileNameWithoutExtension(archivo)+";"Path.GetExtension(archivo)+";");
                n++;
            }
        }*/
        //Console.WriteLine("Archivos Sueltos:");
        foreach (string archivo in ListarArchivos)
        {  
            sr.WriteLine(n+";"+Path.GetFileNameWithoutExtension(archivo)+";"+Path.GetExtension(archivo)+";");
            n++;
        }   
    sr.Close();
}
}
// See https://aka.ms/new-console-template for more information
//Console.WriteLine($"Despues del saludos");
//TipoDatos();
//InvertirPalabra();
using System.Collections;
using Newtonsoft.Json;

LoadJson();
void LoadJson(){
    using (StreamReader r = new StreamReader("customers.json"))
    {
        string json = r.ReadToEnd();
        List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(json);
        //var resp1 = customers.Find(it => it.city == "London");
        //var resp2 = customers.FindAll(it => it.city == "London");
        var resp3 = customers.FindAll(it => it.companyName.StartsWith("P"));
        //Console.WriteLine($"Tipo de resp es: {resp.GetType()}");

 

        // MostrarEmpresa(resp);
        ListarEmpresas(resp3);
    }

}
void ListarEmpresas(List<Customer> datos){
    foreach (var item in datos)
    {
        Console.WriteLine($"Empresa : {item.companyName}");
        Console.WriteLine($"Nombre Contacto : {item.contactName}");
        Console.WriteLine($"Direccion : {item.address}");
    }

}
//Arreglos();
//Boxing();
NoRepetidos();

void Boxing(){


ArrayList Salarios = new ArrayList();
    Salarios.Add(1500);
    Salarios.Add(2500);
    Salarios.Add(1800);

    int total = (int)Salarios[0] + (int)Salarios[1] + (int)Salarios[2]; 
    Console.WriteLine($"El Total es = {total}");
}

void Arreglos(){
    ushort size = 10;
    var vocales =new char[]{ 'a', 'e', 'i', 'o', 'u' };
    var consonantes =new char[]{ 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
    var digitos =new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
    var alfabeto = vocales.Union(consonantes).ToArray();
    IDictionary<string,char[]> dic = new Dictionary<string,char[]>();
    dic.Add("vocales",vocales);
    dic.Add("consonantes",consonantes);
    dic.Add("alfabeto",alfabeto);

    
    string res ="";
    for(ushort i = 0;i < size;i++)
    {
        bool letra = new Random().Next(0,100) <=50? true:false;
        if(letra){
            int k = new Random().Next(0,alfabeto.Length - 1);
            bool lower = new Random().Next(0,100) <=50? true:false;
            res += lower ? alfabeto[k]:alfabeto[k].ToString().ToUpper();
        }else
        {
            int n = new Random().Next(0,9);
            res += digitos[n].ToString();

        }


    }
    Console.WriteLine(" El String Aleatorio es {0}",res);
    ArrayList caracteres = new ArrayList();
    caracteres.Add(vocales);
    caracteres.Add(consonantes);
    caracteres.Add(alfabeto);
    caracteres.Add(digitos);
    foreach(var item in caracteres)
    {
        Console.WriteLine($"Valor {item} ");
    }
    




}

void NoRepetidos(){

    string[] palabras = { "Hola", "Casa", "Hola", "Perro", "Casa", "Hola", "Casa", "Hola", "Gato", "Perro" };
    var noRepetidos=palabras.ToHashSet().ToList();
    foreach( var item in noRepetidos)
    {
        Console.WriteLine($"{item}");
    }

}

void Contar(){

string[] palabras = { "Hola", "Casa", "Hola", "Perro", "Casa", "Hola", "Casa", "Hola", "Gato", "Perro" };
Dictionary<string,int> dic = new Dictionary<string, int>();
foreach (var palabra in palabras){
    
    if (dic.Keys.Contains(palabra))
        dic[palabra]+=1;
    else 
        dic.Add(palabra,1);
        
    }

    foreach (var item in dic){

            Console.WriteLine($"El elemento es: {item.Key} : {item.Value}");
        }

}






void InvertirPalabra()
{

    Console.WriteLine($"Ingrese la palabra a Invertir");
    string? palabra=Console.ReadLine();
    if(palabra is not null)
    {
       
        string palabraInvertida = "";
        for(int i = palabra.Length-1; i>= 0 ; i--)
        {
            palabraInvertida += palabra[i];
            

        }
        
        string res =palabraInvertida.ToUpper()==palabra.ToUpper()? "Es Palindromo":"No es palindromo";
        Console.WriteLine($"La palabra {res}");
        Console.WriteLine($"Palabra Invertida es={palabraInvertida}");


    }
    


}

void TipoDatos(){
ushort minUshort= ushort.MinValue;
ushort maxUshort= ushort.MaxValue;
short minShort= short.MinValue;
short maxShort= short.MaxValue;
ulong minUlong= ulong.MinValue;
ulong maxUlong= ulong.MaxValue;

Console.WriteLine($"Rango de ushort: {minUshort} a {maxUshort}");
Console.WriteLine($"Rango de Short: {minShort} a {maxShort}");
Console.WriteLine($"Rango de uLong: {minUlong} a {maxUlong}");


}
void Saludo(string nombre)


{

string apellido = "Ceveriche";
Console.WriteLine($"Saludo desde metodo soy {nombre} {apellido}");

}


public class Customer {
    public string id {get;set;}
    public string companyName { get;set; }
    public  string contactName {get;set;}
    public string contactTitle {get;set;}
    public string address {get;set;}
    public  string city {get;set;}
    public  string postalCode {get;set;}
    public string country {get;set;}
    public string phone {get;set;}
    public  string fax {get;set;}
   
     

    
    
    
    
    
     
    

}
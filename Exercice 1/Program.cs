// See https://aka.ms/new-console-template for more information


/*private static int Sum(IEnumerable<object> values){ 
    var sum = 0;
    foreach(var item in values){
        switch(item){
            case 0; 
            break;
            case int val;
            sum += val;
            break;
            case IEnumerable<object> subList when subList.Any();
            sum += Sum(subList)
        }
    }
    return sum;
}*/

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        string? s = null;
        Console.WriteLine(s);
        var array = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 ,17, 18, 19, 20};
        var maRange = array[4..^2];
        Console.WriteLine(string.Join(", ",  maRange));
    }
}

public class Eleve(){
    // En c# on utilise les proriétés et les champs
    // Les propriétés donnent acces a des méthodes qui permettent de manipuler les champs
    // les champs sont des variables qui stockent des valeurs
    // c'est les propriétés
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Age { get; set; }
}

public class Professeur(){
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Age { get; set; }
}

public interface ISelfLunch{
    public void SelfLunch();
    public void SelfLunch(string plat);
    public void SelfLunch(string plat, string boisson);
    public void SelfLunch(string plat, string boisson, string desert);
}
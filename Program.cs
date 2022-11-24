namespace string_methods;
class Program
{
    static void Main(string[] args)
    {
        string cumle= "dersimiz C# evlere şenlik";
        string cumle2="C#";

        //Length
        Console.WriteLine(cumle.Length);

        //ToUpper , ToLower
        Console.WriteLine(cumle.ToUpper());
        Console.WriteLine(cumle.ToLower());

        //Concat
        Console.WriteLine(String.Concat(cumle," Merhaba!"));

        //Compare, CompareTo

        Console.WriteLine(cumle2.CompareTo(cumle));
        Console.WriteLine(String.Compare(cumle,cumle2,true));
        Console.WriteLine(String.Compare(cumle,cumle2,false));

        //Contains
        Console.WriteLine(cumle.Contains(cumle2));
        Console.WriteLine(cumle.EndsWith("C#"));
        Console.WriteLine(cumle.StartsWith("C#"));

        //IndexOf
        Console.WriteLine(cumle.IndexOf("C"));
        Console.WriteLine(cumle.LastIndexOf("i"));

        //Insert
        Console.WriteLine(cumle.Insert(0,"Merhaba! "));

        //PadLeft, PadRight
        Console.WriteLine(cumle+cumle2.PadLeft(30,'*'));
        Console.WriteLine(cumle.PadRight(30,'*')+cumle2);

        //Remove

        Console.WriteLine(cumle.Remove(10));
        Console.WriteLine(cumle.Remove(5,3));

        //Replace
        Console.WriteLine(cumle.Replace("C#","Csharp"));

        //Split
        Console.WriteLine(cumle.Split(' ')[1]);

        //SubString
        Console.WriteLine(cumle.Substring(4));


    }
}

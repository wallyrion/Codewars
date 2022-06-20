// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hello, World!");

Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
Kata.PigIt("Hello world !");     // elloHay orldway !

public class Kata
{
    public static string PigIt(string str)
    {

        var words = str.Split(" ");

        var mapped = words.Select(w =>
        {
            if (w.Length == 1)
            {
                return w;
            }

            var sb = new StringBuilder();
            sb.Append(w.Substring(1));
            sb.Append(w[0]);
            sb.Append("ay");
            return sb.ToString();
        });

        var joined = string.Join(' ', mapped);
    
        return joined;
    }
}
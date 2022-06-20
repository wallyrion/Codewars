// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

class Kata
{
    public static int binaryArrayToNumber(int[] BinaryArray)
    {
        //Code here
        return Convert.ToInt32(string.Join("", BinaryArray), 2);
    }
}
namespace Practice5.Extensions;

public static class ColorCW
{

    public static void RedColor(string text) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void GreenColor(string text) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void WhiteColor(string text) {
        Console.WriteLine(text);
    }
}

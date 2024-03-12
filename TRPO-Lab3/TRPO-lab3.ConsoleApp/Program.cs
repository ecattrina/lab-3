public static class SquareTrapecia
{
    public static void Main()
    {
        Console.WriteLine("ПРИЛОЖЕНИЕ ДЛЯ РАСЧЕТА ПЛОЩАДИ ТРАПЕЦИИ");
        Console.Write("Введите первое основание трапеции: ");
        double base1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе основание трапеции: ");
        double base2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту трапеции: ");
        double height = Convert.ToDouble(Console.ReadLine());

        try
        {
            double result;
            result = TRPO_Lab3.Library.SquareTrapecia.Calculate(base1, base2, height);
            Console.Write("Площадь трапеции равна "+result+"\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.Write("Чтобы начать заново введите <<1>> ");
        if (Console.ReadLine() == "1")
        {
            Console.WriteLine("\n"); 
            SquareTrapecia.Main();
        }
        else
        {
            Console.WriteLine("\nДо новых встреч!");
        }
        

    }
}
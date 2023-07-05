namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Celsius = TempConverter.FarenheitToCelsius(79);
            var Farenheit = TempConverter.CelciusToFarenheit(Celsius);

            Console.WriteLine("the conversion is: ");
            Console.WriteLine($"Celsius: {Farenheit}");
            Console.WriteLine($"Farenheit: {Celsius}");







        }
    }
}

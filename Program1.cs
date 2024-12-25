using System.Text.RegularExpressions;

public class Example
{
    public static bool IsStringOnlyDigits(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return false; // Пустая строка не содержит только цифры
        }
        return Regex.IsMatch(text, @"^\d+$");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsStringOnlyDigits("12345"));     // Output: True
        Console.WriteLine(IsStringOnlyDigits("123abc45"));   // Output: False
        Console.WriteLine(IsStringOnlyDigits("   12345   "));  // Output: False
        Console.WriteLine(IsStringOnlyDigits("123.45"));    // Output: False
        Console.WriteLine(IsStringOnlyDigits("-12345"));   // Output: False
        Console.WriteLine(IsStringOnlyDigits("")); // Output: False
    }
}
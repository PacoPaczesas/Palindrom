Console.WriteLine("Program sprawdza czy wprowadzone słowo jest palindromem");
Console.Write("Wprowadź słowo do sprawdzenia: ");
string word = Console.ReadLine();

bool palindrome = true;


int length = word.Length;
for (int i = 0; i < length / 2; i++)
{
    if (word[i] != word[length - i - 1])
    {
        palindrome = false;
    }
}

if (palindrome)
{
    Console.WriteLine("Słowo '" + word + "' jest palindromem");
}
else
{
    Console.WriteLine("Słowo '" + word + "' nie jest palindromem");
}

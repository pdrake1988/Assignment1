// See https://aka.ms/new-console-template for more information

char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

Console.WriteLine("Enter a word");
string input  = Console.ReadLine();
int vowelCount = 0;
int constantCount = 0;

for (int i = 0; i < input.Length; i++)
{
    if (vowels.Contains(input[i]))
    {
        vowelCount++;
    } else
    {
        constantCount++;
    }
}
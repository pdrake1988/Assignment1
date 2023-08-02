// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a Word");
string input = Console.ReadLine();
char[] strReverse = input.ToCharArray();
bool answer = input.SequenceEqual(strReverse.Reverse());
Console.WriteLine(answer);

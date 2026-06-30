// Mason Conrad
// June 29, 2026
// Lab 7 - Pig Latin and Cryptogram

Console.WriteLine("Let's manipulate your phrase!");
Console.Write("Please enter the message: ");
string message = Console.ReadLine().ToLower();

string[] words = message.Split(' ');
string vowels = "aeiou";

string pigLatinPhrase = "";

foreach (string word in words)
{
    int firstVowelIndex = -1;

    for (int i = 0; i < word.Length; i++)
    {
        if (vowels.Contains(word[i]))
        {
            firstVowelIndex = i;
            break;
        }
    }

    if (firstVowelIndex == 0)
    {
        pigLatinPhrase += word + "way ";
    }
    else if (firstVowelIndex > 0)
    {
        string beginning = word.Substring(0, firstVowelIndex);
        string ending = word.Substring(firstVowelIndex);
        pigLatinPhrase += ending + beginning + "ay ";
    }
    else
    {
        pigLatinPhrase += word + "ay ";
    }
}

Console.WriteLine("In pig latin that's: " + pigLatinPhrase);

Random rand = new Random();
int randomOffset = rand.Next(1, 26);

string encryptedPhrase = "";

foreach (char character in message)
{
    if (character >= 'a' && character <= 'z')
    {
        int shifted = character + randomOffset;

        if (shifted > 'z')
        {
            shifted = shifted - 26;
        }

        encryptedPhrase += (char)shifted;
    }
    else
    {
        encryptedPhrase += character;
    }
}

Console.WriteLine($"We can encrypt that as: {encryptedPhrase}");
Console.WriteLine($"The random offset was: {randomOffset}");

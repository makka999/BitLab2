


static string Encrypt(string text, char[] alphabet, string key, bool enEncrypt)
{
    int newIndex;
    text = text.ToLower();
    char[] textToEncrypt = text.ToCharArray();
    key = key.ToLower();
    char[] charKey = key.ToCharArray();
    int alphabetLenght = alphabet.Length;
    int length = textToEncrypt.Length;
    char[] encryptedChar = new char[length];
    for (int i = 0; i < textToEncrypt.Length; i++)
    {
        if (!(textToEncrypt[i] == ' '))
        {
            var letter = textToEncrypt[i];
            int index = Array.IndexOf(alphabet, letter);
            var letterKey = charKey[(i)%charKey.Length];
            int indexKey = Array.IndexOf(alphabet, letterKey);
            if (enEncrypt == false) newIndex = (indexKey + index) % alphabetLenght;
            else  newIndex = (index - indexKey) % alphabetLenght;
            if (newIndex < 0) newIndex = alphabetLenght + newIndex;
            char newLetter = alphabet[newIndex];
            encryptedChar[i] = newLetter;
        }
        else encryptedChar[i] = textToEncrypt[i];
    }

    string encrypToText = String.Join("", encryptedChar);
    return encrypToText;
}



char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 
    'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
string text, result, key;

text = "jedna z najprostszych technik szyfrowania";
key = "jedna";
Console.WriteLine();
Console.WriteLine();

Console.WriteLine(text);
Console.WriteLine(key);
Console.WriteLine();
result = Encrypt(text, alphabet, key, false);
Console.WriteLine(result);
Console.WriteLine();

text = result;
result = Encrypt(text, alphabet, key, true);
Console.WriteLine(result);





static string Encrypt(string text, char[] alphabet, string key)
{
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
            int newIndex = (indexKey + index) % alphabetLenght;
            if (newIndex < 0) newIndex = alphabetLenght + newIndex;
            char newLetter = alphabet[newIndex];
            encryptedChar[i] = newLetter;
        }
        else encryptedChar[i] = textToEncrypt[i];
    }

    string encrypToText = String.Join("", encryptedChar);
    return encrypToText;
}

static string EnEncrypt(string text, char[] alphabet, string key)
{
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
            int newIndex = (index - indexKey) % alphabetLenght;
            if (newIndex < 0) newIndex = alphabetLenght + newIndex;
            char newLetter = alphabet[newIndex];
            encryptedChar[i] = newLetter;
        }
        else encryptedChar[i] = textToEncrypt[i];
    }

    string encrypToText = String.Join("", encryptedChar);
    return encrypToText;
}


char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
string text, result, key;

text = "jedna z najprostszych technik szyfrowania";
key = "jedna";
Console.WriteLine(text);
Console.WriteLine(key);
result = Encrypt(text, alphabet, key);
Console.WriteLine(result);

text = "sigaa d aastubscwclcq wrcqrlx bdbsrxadaij";
result = Encrypt(text, alphabet, key);
Console.WriteLine(result);
result = EnEncrypt(text, alphabet, key);
Console.WriteLine(result);

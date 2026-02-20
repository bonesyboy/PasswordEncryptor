namespace SimpleEthicsProject;

using System.Text.RegularExpressions;
using System.Text;
public class PasswordEncryption
{
    private string? _encryptedPassword;
    public PasswordEncryption(string password)
    {
        Encryptor(password);
    }

    private void Encryptor(string password)
    {
        StringBuilder encryptedString = new StringBuilder();
        List<string> firstHalfLettersLowerCase = ["n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];
        List<string> firstHalfLettersUpperCase = ["N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];
        List<string> secondHalfLettersLowerCase = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m"];
        List<string> secondHalfLettersUpperCase = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M"];
        foreach (char charletter in password)
        {
            string letter = "" + charletter;

            if (Regex.IsMatch(letter, @"[a-mA-M]"))
            {

                if (Regex.IsMatch(letter, @"[A-Q]"))
                {
                    encryptedString.Append("" + firstHalfLettersUpperCase[secondHalfLettersUpperCase.IndexOf(letter)]);
                }
                else
                {
                    encryptedString.Append("" + firstHalfLettersLowerCase[secondHalfLettersLowerCase.IndexOf(letter)]);
                }
            }
            else if (Regex.IsMatch(letter, @"[n-zN-Z]"))
            {
                if (Regex.IsMatch(letter, @"[N-Z]"))
                {
                    encryptedString.Append("" + secondHalfLettersUpperCase[firstHalfLettersUpperCase.IndexOf(letter)]);
                }
                else
                {
                    encryptedString.Append("" + secondHalfLettersLowerCase[firstHalfLettersLowerCase.IndexOf(letter)]);
                }
            }
            else if (Regex.IsMatch(letter, @"[0-9]"))
            {
                int number = int.Parse(letter);
                number = number * password.Length;
                encryptedString.Append("" + number);
            }
        }
        _encryptedPassword = encryptedString.ToString();
    }

    public string GetEncryptedPassword()
    {
        return _encryptedPassword;
    }
    static void Main()
    {
        string originalPassword = "ThrockNorton33";
        PasswordEncryption newEncryption = new PasswordEncryption(originalPassword);
        Console.WriteLine(newEncryption.GetEncryptedPassword());
    }

}


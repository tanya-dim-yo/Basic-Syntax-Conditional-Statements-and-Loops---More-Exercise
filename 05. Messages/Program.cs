int n = int.Parse(Console.ReadLine());
char[] message = new char[n];

for (int i = 0; i < n; i++)
{
    int numberOfDigits = 0;
    int mainDigit = 0;
    int offset = 0;
    int letterIndex = 0;
    int finalCharacter = 0;

    string currentNumber = Console.ReadLine();
    numberOfDigits = currentNumber.Length;
    char mainDigitChar = currentNumber[0];
    mainDigit = Convert.ToInt32(new string(mainDigitChar, 1));

    if (mainDigit == 8 || mainDigit == 9)
    {
        offset = ((mainDigit - 2) * 3) + 1;
    }
    else
    {
        offset = (mainDigit - 2) * 3;
    }

    letterIndex = offset + numberOfDigits - 1;

    if (mainDigit == 0)
    {
        finalCharacter = 32;
    }
    else
    {
        finalCharacter = 97 + letterIndex;
    }

    message[i] = (char)finalCharacter;
}

for (int index = 0; index < message.Length; index++)
{
    Console.Write(message[index]);
}
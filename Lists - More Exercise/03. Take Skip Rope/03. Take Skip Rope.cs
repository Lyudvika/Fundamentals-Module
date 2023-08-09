string message = Console.ReadLine();
List<int> digits = new List<int>();
List<string> encryptedMessage = new List<string>();

for (int i = 0; i < message.Length; i++)
{
    if (char.IsDigit(message[i]))
    {
        digits.Add(int.Parse(message[i].ToString()));
    }
    else
    {
        encryptedMessage.Add(message[i].ToString());
    }
}

List<int> takeList = new List<int>();
List<int> skipList = new List<int>();

for (int i = 0; i < digits.Count; i++)
{
    if (i % 2 == 0)
    {
        takeList.Add(digits[i]);
    }
    else
    {
        skipList.Add(digits[i]);
    }
}

List<string> decryptedMessage = new List<string>();
int index = 0;

for (int i = 0; i < takeList.Count; i++)
{
    for (int k = 0; k < takeList[i]; k++)
    {
        if (index >= encryptedMessage.Count)
        {
            break;
        }
        decryptedMessage.Add(encryptedMessage[index]);
        index++;
    }

    for (int k = 0; k < skipList[i]; k++)
    {
        if (index >= encryptedMessage.Count)
        {
            break;
        }
        index++;
    }
}
Console.WriteLine(string.Join("", decryptedMessage));
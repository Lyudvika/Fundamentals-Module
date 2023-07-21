int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());
int numThree = int.Parse(Console.ReadLine());

int maxNum = int.MinValue;
int minNum = int.MaxValue;
int midNum = 0;

if (numOne > maxNum)
{
    maxNum = numOne;
}
if (numTwo > maxNum)
{
    maxNum = numTwo;
}
if (numThree > maxNum)
{
    maxNum = numThree;
}

if (numOne < minNum)
{
    minNum = numOne;
}
if (numTwo < minNum)
{
    minNum = numTwo;
}
if (numThree < minNum)
{
    minNum = numThree;
}

if (numOne < maxNum && numOne > minNum)
{
    midNum = numOne;
}
if (numTwo < maxNum && numTwo > minNum)
{
    midNum = numTwo;
}
if (numThree < maxNum && numThree > minNum)
{
    midNum = numThree;
}

Console.WriteLine(maxNum);
Console.WriteLine(minNum);
Console.WriteLine(minNum);
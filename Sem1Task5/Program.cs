int numN = int.Parse(Console.ReadLine()??"0");
int evnumN = (-1) * numN;
while (evnumN < numN)
{
  Console.Write(evnumN + ",");
  evnumN = evnumN + 1;  
}
Console.WriteLine(numN);
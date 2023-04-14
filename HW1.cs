int GetValue(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

string numbersFromNToOne(int number)
{
  if (number > 0) return $"|{number}|" + numbersFromNToOne(number - 1);
  else return String.Empty;
}

int n = GetValue("Введите значение N: ");
Console.Write(numbersFromNToOne(n));

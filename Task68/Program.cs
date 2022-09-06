// Задача 68: Напишите программу 
// вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3 n = 2 -> A(m,n) = 29

int m = 3;
int n = 3;

int Ackerman(int x, int y)
{
  if (x == 0) return y + 1;
  else if (y == 0) return Ackerman(x - 1, 1);
  else return Ackerman(x - 1, Ackerman(x, y - 1));
}

int result = Ackerman(m,n);
Console.Write($"A({m},{n}) = {result}");




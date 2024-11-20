using static System.Console;
bool IsEven (int num,int a) => num % 2 == 0;
bool IsPrime (int num) {
      if (num <= 1 || num % 2 == 0) return false;
      if (num == 2) return true;
      for (int i = 3; i <= Math.Sqrt (num); i += 2)
         if (num % i == 0) return false;
      return true;
}
int num = 5;
WriteLine ($"The number {num} is {IsEven (num,0)}\nThe number {num} is {IsPrime (num)}");
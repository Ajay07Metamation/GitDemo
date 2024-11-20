using static System.Console;
bool IsEven (int num) => num % 2 == 0;
long Factorial (int num) {
   if (num < 0) throw new ArgumentException ("Factorial is not defined for negative numbers.");
   if (num == 0 || num == 1) return 1;
   return num * Factorial (num - 1);
}
int num = 5;
WriteLine ($"The number {num} is {(IsEven (num) ? "Even" : "Odd")}");
WriteLine ($"The factorial of {num} is {Factorial (num)}");
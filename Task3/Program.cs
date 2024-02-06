using Task3;

// Введіть число n для знаходження n-го числа Фібоначчі
int n = 20;

// Створення об'єкта класу, де знаходяться методи
Fibonacci fibonacci = new Fibonacci();

// Виклик ітеративного методу
long[] iterativeResult = fibonacci.FibonacciIterativeArray(n);
Console.WriteLine($"Iterative Result for Fibonacci({n}): {string.Join("\n", iterativeResult)}");

// Виклик рекурсивного методу та вивід масиву
long[] recursiveResult = fibonacci.FibonacciRecursiveArray(n);
Console.WriteLine($"\n\nRecursive Result for Fibonacci({n}): {string.Join("\n", recursiveResult)}");
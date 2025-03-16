using lab1_1;

// Примеры создания рациональных чисел
RationalNumbers r1 = new RationalNumbers(1, 2);
RationalNumbers r2 = new RationalNumbers(3, 4);
RationalNumbers r3 = new RationalNumbers(5, 0);

Console.WriteLine($"r1: {r1}"); // 1/2
Console.WriteLine($"r2: {r2}"); // 3/4
Console.WriteLine($"r3 (с 0 в знаменателе): {r3}"); // 0

// Примеры операций
RationalNumbers sum = r1 + r2;
RationalNumbers difference = r1 - r2;
RationalNumbers product = r1 * r2;
RationalNumbers quotient = r1 / r2;

Console.WriteLine($"Сумма r1 и r2: {sum}"); // 5/4
Console.WriteLine($"Разность r1 и r2: {difference}"); // -1/4
Console.WriteLine($"Произведение r1 и r2: {product}"); // 3/8
Console.WriteLine($"Частное r1 и r2: {quotient}"); // 2/3
Console.WriteLine($"r1 == r2: {r1 == r2}"); // False
Console.WriteLine($"r1 < r2: {r1 < r2}"); // True
Console.WriteLine($"r1 > r2: {r1 > r2}"); // False
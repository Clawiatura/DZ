const double NDS18 = 10.53;
const double NDS10 = 6.36;
const int coffee = 69;
const int rulet = 70;
const long KKT = 0000143873023483;
const long FN = 87100000100265168;
const int FD = 6026;
const uint FPD = 3322278314;




Console.Write("Введите кол-во кофе:");
int a = int.Parse(Console.ReadLine());
double DSN18 = NDS18 * a;
int c = a * coffee;
Console.Write("Введите кол-во рулетов:");
int b = int.Parse(Console.ReadLine());
double DSN10 = NDS10 * b;
int f = b * rulet;
int summa = c + f;
Console.WriteLine($"Кофе стандартный:{coffee} {a} {c}");
Console.WriteLine($"НДС с расчитанной ставкой:{DSN18}");
Console.WriteLine($"Рулет-спринг ТВ ИЗ:{rulet} {b} {f}");
Console.WriteLine($"НДС с расчитаной ставкой:{DSN10}");
Console.WriteLine($"Итого: {summa}");
Console.WriteLine($"Электронные средства: {summa}");
Console.WriteLine($"НДС итога чека с ставкой 18%: {DSN18}");
Console.WriteLine($"НДС итога чека с ставкой 10%: {DSN10}");
Console.WriteLine($"ВИД НАЛОГООБЛОЖЕНИЯ: ОСН \n РЕГ. Номер ККТ:{KKT} \n Завод№: \n ФН №: {FN} \n ФД №: {FD} \n ФПД: {FPD} ");





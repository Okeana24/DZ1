Console.Write("Введи цифру, обозначающую день недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (day == 6 || day== 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("ошибка, ввидите другое число");
  }
  else Console.WriteLine("(этот день выходной) -> нет");
}

CheckingTheDayOfTheWeek(day);

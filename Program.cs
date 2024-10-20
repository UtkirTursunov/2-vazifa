/*
1. Kalkulyator:
Foydalanuvchidan ikkita raqam va operatsiyani (+, -, *, /) so'raydigan kalkulyator dasturini yozing va keyin operatsiya natijasini chop eting.
Input = 5;
Input = +;
Input = 5;
Output = 10;

using System.Security.Cryptography;

System.Console.Write("Enter the 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write ("Choose on of this operation (+, -, *, /):  ");
string operation = Console.ReadLine();
System.Console.Write ("Enter the 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

string result = operation switch
{
    "+" => $"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}",
    "-" => $"{firstNumber} - {secondNumber} = {firstNumber-secondNumber}",
    "*" => $"{firstNumber} * {secondNumber} = {firstNumber*secondNumber}",
    "/" => $"{firstNumber} / {secondNumber} = {firstNumber/secondNumber}",
    _   => "Operation not found!"
};   

System.Console.WriteLine($"Result is: {result}");
*/


/*
2. Raqamlar qatorining yig‘indisini hisoblash:
Foydalanuvchidan N musbat butun sonni so‘ragan, so‘ngra 1 dan N gacha bo‘lgan barcha sonlar yig‘indisini hisoblab,
natijani ekranga chiqaradigan dastur tuzing.
Input = 10;
Output = 55;


System.Console.Write("N-musbat sonni kiriting: ");
int nSon = Convert.ToInt32(Console.ReadLine());
int summa = 0;
for (int i = 1; i <=nSon; i++)
{
    summa +=i;
}
System.Console.WriteLine($"1-dan N gacha sonlar yig'indisi = {summa}");
*/


/*
3.  Paritet tekshiruvi:
Foydalanuvchi kiritgan raqamning juft yoki toq ekanligini aniqlaydigan va shunga mos ravishda xabarni chiqaradigan
dastur tuzing.
Input = 3;
Output = “Toq”
*/

System.Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine("This number is even!");
}
else
{
    System.Console.WriteLine("This number is odd!");
}
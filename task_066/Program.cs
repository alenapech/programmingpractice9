// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Задача 066");



int numberM = 2; 
int numberN = 6; 

Console.Write($"Сумма цифр чисел от {numberM} до {numberN}:   {Recursion(numberM, numberN)}");

int Recursion(int startNumber, int endNumber, int sum = 0)
{

    if(startNumber > endNumber) 
       {
       
        return sum;
    
       }

    sum+= startNumber;

   

    return Recursion(startNumber + 1, endNumber, sum); 

}

/* Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа кратные 
3-ём в промежутке от M до N.
*/

Console.WriteLine("Задача 064");

int numberM = 5; // 1 2 3 4 5 6 7 8
int numberN = 10;


Recursion(numberM, numberN);

void Recursion(int startNumber, int endNumber)
{
    
        if(startNumber > endNumber) return ;
        if(startNumber%3 ==0)
        Console.Write(startNumber + "\t");
        

    Recursion(startNumber + 1, endNumber); 

}
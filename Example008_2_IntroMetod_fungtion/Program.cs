// тоже поиск мах из 9 ти чисел но с использованием функции: находим мах из 3х, и тд. и в финале из 3х финалистов...:)
int Max(int arg1, int arg2, int arg3)  // механизм максимума из 3х чисел          
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 15; // простой способ поиска максим. из 9ти чисел
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 78;

//int max1 = Max(a1, b1, c1); // т.е. максимум из 3х
//int max2 = Max(a2, b2, c2); 
//int max3 = Max(a3, b3, c3); 
//int max = Max(max1, max2, max3);               // финальное сравнение
// еще улучшить:
int max = Max (Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);


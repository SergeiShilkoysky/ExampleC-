// Задача про 2х друзей
Console.Clear();

int a = 1; // скорость первого друга 
int b = 2; // скорость второго друга
int c = 5; // скорость собаки 
bool f = true; // собака бежит ко второму другу
int d = 10000; // дистанция между друзьями в метрах
int count = 0;
int t = 0;

while(d > 10)
{
    if(f == false)
    {
    t = d / (a + c);
    f = true;
    }
    else
    {
    t = d / (b + c);
    f = false;
    }
    d = d - (a + b) * t;
    count++;
}
Console.Write("Собака пробежала количество раз: ");
Console.WriteLine(count);

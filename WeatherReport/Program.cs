using System;
using System.Threading;

// README.md를 읽고 아래에 코드를 작성하세요.


var weather = new[]
{
    new{ date = "월요일", high = 12, low = 3, rain = 20 },
    new{ date = "화요일", high = 8, low = -1, rain = 60 },
    new{ date = "수요일", high = 5, low = -3, rain = 80 },
    new{ date = "목요일", high = 10, low = 2, rain = 40 },
    new{ date = "금요일", high = 15, low = 5, rain = 10 }
};

Console.WriteLine($"=== 5일간 날씨 예보 ===");
Console.WriteLine($"요일     최고기온  최저기온  강수확률");
Console.WriteLine($"--------------------------------------");
foreach (var day in weather)
{
    Console.WriteLine($"{day.date,-8} {day.high,3}도 {day.low,7}도 {day.rain,7}%");
}
Console.WriteLine($"--------------------------------------");
var avg = 0;
foreach (var day in weather)
{
    avg += day.high;
}
Console.WriteLine($"최고기온 평균: {avg / (double)weather.Length:F1}도");

int count = 0;
foreach (var day in weather)
{
    if (day.rain >= 50)
    {
        count++;
    }
}
Console.WriteLine($"비 올 가능성 높은 날(50% 이상): {count}일");
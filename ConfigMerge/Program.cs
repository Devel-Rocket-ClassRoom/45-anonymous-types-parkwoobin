using System;
using System.Threading;

// README.md를 읽고 아래에 코드를 작성하세요.



var basic = new { ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = "보통" };
var custom = new { ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 80, Difficulty = "어려움" };



Console.WriteLine($"=== 게임 설정 비교 ===");
Console.WriteLine($"\n[기본 설정]");
Console.WriteLine(basic);

Console.WriteLine($"\n[사용자 설정]");
Console.WriteLine(custom);

Console.WriteLine($"\n[타입 비교]");
Console.WriteLine($"같은 타입: {basic.GetType() == custom.GetType()} (속성 구조가 동일)");

Console.WriteLine($"\n[값 비교]");
Console.WriteLine($"Equals 결과: {basic.Equals(custom)} (Volume, Difficulty 값이 다름)");

Console.WriteLine($"\n[백업 설정]");
var backup = basic;
Console.WriteLine(backup);
Console.WriteLine($"기본 설정과 Equals: {basic.Equals(backup)} (모든 값이 동일)");

Console.WriteLine($"\n=== 설정 목록 (배열) ===");
var settingList = new[]
{
    basic,
    custom,
    backup
};
int count = 1;
foreach (var setting in settingList)
{
    Console.WriteLine($"설정{count++}: {setting.ResolutionWidth}x{setting.ResolutionHeight}, 볼륨: {setting.Volume}, 난이도: {setting.Difficulty}");
}

Console.WriteLine($"\n=== 속성 순서가 다른 설정 ===");
var diff = new { Volume = 50, Difficulty = "보통", ResolutionWidth = 1920, ResolutionHeight = 1080 };
Console.WriteLine($"기본 설정과 같은 타입: {basic.GetType() == diff.GetType()} (속성 순서가 달라 다른 타입)");
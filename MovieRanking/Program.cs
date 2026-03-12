using System;

// README.md를 읽고 아래에 코드를 작성하세요.




string title = "인터스텔라";
string genre = "SF";
double rating = 9.2;
int releaseYear = 2014;

var movie = new { Title = title, Genre = genre, Rating = rating, ReleaseYear = releaseYear };
Console.WriteLine($"영화 제목: {movie.Title}");
Console.WriteLine($"장르: {movie.Genre}");
Console.WriteLine($"평점: {movie.Rating}");
Console.WriteLine($"개봉 연도: {movie.ReleaseYear}");

Console.WriteLine($"\nToString() 결과:");
Console.WriteLine($"{movie.ToString()}");

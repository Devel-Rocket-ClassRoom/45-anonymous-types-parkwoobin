using System;

// README.md를 읽고 코드를 작성하세요.



var student1 = new { name = "김철수", grade = 3, score = 95.5 };

Console.WriteLine($"이름: {student1.name}");
Console.WriteLine($"학년: {student1.grade}");
Console.WriteLine($"점수: {student1.score}");


string name = "이영희";
int age = 28;
var person = new { Name = name, Age = age };

Console.WriteLine($"person1: {person.Name}, {person.Age}");


string text = "Hello";
var info = new { text, text.Length };
Console.WriteLine($"텍스트: {info.text}");
Console.WriteLine($"길이: {info.text.Length}");



int productID = 100;
string productName = "마우스";
double price = 25000.0;

var product = new
{
    productID,
    Name = productName,
    price,
    FormattedPrice = price.ToString("N0")
};

Console.WriteLine($"ID: {product.productID}");
Console.WriteLine($"상품명: {product.Name}");
Console.WriteLine($"가격: {product.price}");
Console.WriteLine($"포맷된 가격: {product.FormattedPrice}원");

var point1 = new { X = 10, Y = 20 };
var point2 = new { X = 30, Y = 40 };

bool isSameType = point1.GetType() == point2.GetType();
Console.WriteLine($"같은 타입: {isSameType}");

point1 = point2;
Console.WriteLine($"point1: ({point1.X}, {point1.Y})");


var a = new { x = 2, y = 4 };
var b = new { x = 2, y = 4 };
var c = new { x = 2, y = 5 };

Console.WriteLine($"a.Equals(b): {a.Equals(b)}");
Console.WriteLine($"a.Equals(c): {a.Equals(c)}");


Console.WriteLine($"a == b: {a == b}");
Console.WriteLine($"a == c: {a == c}");


var student2 = new[]
{
    new { name = "김철수", score = 85 },
    new { name = "이영희", score = 92 },
    new { name = "박민수", score = 78 }
};

Console.WriteLine($"=== 학생 점수 목록 ===");
foreach (var student in student2)
{
    Console.WriteLine($"{student.name}: {student.score}점");
}


var products = new[]
{
    new{ ID = 1, Name = "키보드", Price = 50000 },
    new{ ID = 1, Name = "마우스", Price = 25000 },
    new{ ID = 1, Name = "모니터", Price = 300000 }
};

Console.WriteLine($"첫 번째 상품: {products[0].Name}");
Console.WriteLine($"상품 개수: {products.Length}");

int totalPrice = 0;
foreach (var productss in products)
{
    totalPrice += productss.Price;
}

Console.WriteLine($"총 가격: {totalPrice:n0}원");



var obj = new { ID = 1, Name = "Object1" };
Console.WriteLine($"{obj.ID} - {obj.Name}");

obj = new { ID = 1, Name = "Object2" };
Console.WriteLine($"{obj.ID} - {obj.Name}");


var anonymous1 = new { Name = "홍길동", age = 30 };
Console.WriteLine($"익명 타입: {anonymous1.Name}, {anonymous1.age}");

var tuple1 = (Name: "홍길동", Age: 30);
Console.WriteLine($"튜플: {tuple1.Name}, {tuple1.Age}");


var person2 = new { Name = "김영희", Age = 25, City = "서울" };
Console.WriteLine(person2);
Console.WriteLine(person2.ToString());

var employee = new[]
{
    new{ Name = "김철수", Department = "개발팀", Salary = 5000 },
    new{ Name = "이영희", Department = "기획팀", Salary = 4500 },
    new{ Name = "박민수", Department = "개발팀", Salary = 5500 }
};

Console.WriteLine($"=== 직원 정보 ===");
foreach (var emp in employee)
{
    Console.WriteLine($"{emp.Name} ({emp.Department}) - {emp.Salary:n0}만원");
}

string[] names = { "사과", "바나나", "오렌지" };
int[] prices = { 1000, 1500, 2000 };

var fruit = new[]{
    new{ Name = names[0], Price = prices[0] },
    new{ Name = names[1], Price = prices[1] },
    new{ Name = names[2], Price = prices[2] }
};

Console.WriteLine($"=== 과일 가격표 ===");
foreach (var fruits in fruit)
{
    Console.WriteLine($"{fruits.Name}: {fruits.Price}원");
}
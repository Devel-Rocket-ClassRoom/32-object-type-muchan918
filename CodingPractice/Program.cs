using System;

object obj1 = 42;              // int 저장
object obj2 = 3.14;            // double 저장
object obj3 = "Hello";         // string 저장
object obj4 = true;            // bool 저장
object obj5 = new int[] { 1, 2, 3 };  // 배열 저장

Console.WriteLine(obj1);       // 42
Console.WriteLine(obj2);       // 3.14
Console.WriteLine(obj3);       // Hello
Console.WriteLine(obj4);       // True


Stack stack = new Stack();

// 문자열 저장
stack.Push("sausage");
string s = (string)stack.Pop();
Console.WriteLine(s);

// 정수 저장
stack.Push(3);
int three = (int)stack.Pop();
Console.WriteLine(three);

int i = 1234;           // 값 타입(정수형) 선언
object o = i;           // 박싱: 값 타입을 참조 타입으로 변환
Console.WriteLine(o);   // 1234

o = 1234;        // 박싱된 정수를 포함하는 객체 생성
int j = (int)o;         // 언박싱: 참조 타입을 값 타입으로 변환
Console.WriteLine(j);   // 1234

i = 42;
object boxed = i;
Console.WriteLine(boxed);

Point p = new Point { X = 10, Y = 20 };
IDisplayable d = p;
Console.WriteLine(d.GetType().Name);

i = 3;
boxed = i;   // i의 값이 복사되어 박싱됨
i = 5;              // 원본 변경
Console.WriteLine($"원본: {i}");
Console.WriteLine($"박싱된 값: {boxed}");

boxed = 42;  // int 값이 박싱됨

// 올바른 언박싱
i = (int)boxed;
Console.WriteLine($"언박싱 성공: {i}");

// 잘못된 언박싱 시도 (try-catch는 에러를 처리하는 구문으로, 나중에 학습함)
try
{
    long l = (long)boxed;  // InvalidCastException 발생
}
catch (InvalidCastException)
{
    Console.WriteLine("잘못된 타입으로 언박싱 시도");
}

// 올바른 타입 변환 방법
int temp = (int)boxed;   // 먼저 int로 언박싱
long correct = temp;     // 그 다음 long으로 암시적 변환
Console.WriteLine($"올바른 변환: {correct}");

// 나쁜 예: 반복문에서 불필요한 박싱
int sum1 = 0;
for (i = 0; i < 1000; i++)
{
    boxed = i;       // 박싱 발생 (1000번)
    sum1 += (int)boxed;     // 언박싱 발생 (1000번)
}
Console.WriteLine($"박싱 사용: {sum1}");

// 좋은 예: 박싱 없이 직접 처리
int sum2 = 0;
for (i = 0; i < 1000; i++)
{
    sum2 += i;              // 박싱/언박싱 없음
}
Console.WriteLine($"직접 처리: {sum2}");

int k = 1234;
string sa = "안녕하세요";
char c = 'A';
double doa = 3.14;
o = new object();

Console.WriteLine(k.GetType());  // System.Int32
Console.WriteLine(sa.GetType());  // System.String
Console.WriteLine(c.GetType());  // System.Char
Console.WriteLine(doa.GetType());  // System.Double
Console.WriteLine(o.GetType());  // System.Object

Console.WriteLine(typeof(int));        // System.Int32
Console.WriteLine(typeof(string));     // System.String
Console.WriteLine(typeof(double));     // System.Double

Point1 p1 = new Point1 { X = 10, Y = 20 };
Console.WriteLine(p1.GetType().Name);              // Point
Console.WriteLine(typeof(Point1).Name);            // Point
Console.WriteLine(p1.GetType() == typeof(Point1));  // True
Console.WriteLine(p1.X.GetType().Name);            // Int32
Console.WriteLine(p1.Y.GetType().FullName);        // System.Int32

int number = 42;
double pi = 3.14;
bool flag = true;

Console.WriteLine(number.ToString());  // 42
Console.WriteLine(pi.ToString());      // 3.14
Console.WriteLine(flag.ToString());    // True

Panda paas = new Panda { Name = "Petey" };
Console.WriteLine(paas);         // Petey (ToString() 자동 호출)
Console.WriteLine(paas.ToString());  // Petey

Player player = new Player { Name = "Hero", Level = 10, Health = 100 };
Console.WriteLine(player);

string s1 = "Hello";
string s2 = "Hello";
string s3 = s1;

Console.WriteLine($"s1.Equals(s2): {s1.Equals(s2)}");                    // True (값 비교)
Console.WriteLine($"ReferenceEquals(s1, s2): {object.ReferenceEquals(s1, s2)}");  // True (문자열 인터닝)
Console.WriteLine($"ReferenceEquals(s1, s3): {object.ReferenceEquals(s1, s3)}");  // True

// 새 객체 생성 시
object obja1 = new object();
object obja2 = new object();
object obja3 = obj1;

Console.WriteLine($"obj1.Equals(obj2): {obja1.Equals(obja2)}");            // False
Console.WriteLine($"ReferenceEquals(obj1, obj2): {object.ReferenceEquals(obja1, obja2)}");  // False
Console.WriteLine($"ReferenceEquals(obj1, obj3): {object.ReferenceEquals(obja1, obja3)}");  // True
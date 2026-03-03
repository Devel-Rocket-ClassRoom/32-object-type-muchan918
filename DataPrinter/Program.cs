using System;

Console.WriteLine("=== 데이터 출력기 ===");
Console.WriteLine();
object[] data = { 42, 3.14, "Hello", true, 100, "World", false, 2.718 };
int isInt = 0;
int isDouble = 0;
int isString = 0;
int isBool = 0;

foreach (object o in data)
{
    PrintData(o);
}
Console.WriteLine();

Console.WriteLine("[타입별 통계]");
Console.WriteLine($"정수: {isInt}개");
Console.WriteLine($"실수: {isDouble}개");
Console.WriteLine($"문자열: {isString}개");
Console.WriteLine($"논리값: {isBool}개");

void PrintData(object data)
{
    string typeName = data.GetType().Name;

    if (typeName == "Int32")
    {
        Console.WriteLine($"정수: {data}");
        isInt++;
    }
    else if (typeName == "Double")
    {
        Console.WriteLine($"실수: {data:F2}");
        isDouble++;
    }
    else if (typeName == "String")
    {
        Console.WriteLine($"문자열: \"{data}\" (길이: {((String)data).Length})");
        isString++;
    }
    else if (typeName == "Boolean")
    {
        Console.WriteLine($"논리값: {data} -> {((bool)data ? "참" : "거짓")}");
        isBool++;
    }
    else
    {
        Console.WriteLine($"알 수 없는 타입: {data.GetType()} - {data}");
    }
}
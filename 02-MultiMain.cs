// 여러 개의 Main 함수가 있으면 어떻게 되는지 실험.

using System;

class _02_MultiMain_01
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}

class _02_MultiMain_02
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}

/* 

결과: 

02-MultiMain.cs(5,17): error CS0017: 'c:\Users\nwh63\Desktop\CSharpStudy\02-MultiMain.exe' 프로그램에 진입점이 두 개 이상 정의되어 있습니다. '_02_MultiMain_01.Main()'. /main으로 컴파일하여
        진입점이 포함된 형식을 지정하십시오.
02-MultiMain.cs(13,17): error CS0017: 'c:\Users\nwh63\Desktop\CSharpStudy\02-MultiMain.exe' 프로그램에 진입점이 두 개 이상 정의되어 있습니다. '_02_MultiMain_02.Main()'. /main으로 컴파일하여
        진입점이 포함된 형식을 지정하십시오.

궁금증 해결: Main 함수가 정의된 곳을 진입점으로 한다.

*/
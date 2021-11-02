using System;

class _04_Variable
{
    public static void Main()
    {
        int someNumber; // 변수 선언
        // [자료형] [변수 이름]으로 선언.

        Console.WriteLine(123); // 123 = 리터럴
        // 정수, 실수, 스트링 리터럴 등이 있음.

        int someBigNumber; // 마찬가지로 변수 선언
        someBigNumber = 1 << 30; // = 로 값 저장.
        // [변수 이름] = [값]으로 저장
        
        Console.WriteLine(someBigNumber); // 변수 사용

        int someSmallNumber = 0; // 변수 선언과 동시에 초기화
        // [자료형] [변수 이름] = [값]으로 선언과 동시에 저장.

        int num1 = 0, num2 = 1;
        // ','으로 연결하여 여러 변수 동시에 선언 가능. 물론 초기화도 가능

        const int immutableZero = 0;
        // const 키워드를 앞에 붙여 상수 선언 가능.
    }
}
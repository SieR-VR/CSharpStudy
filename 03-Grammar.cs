using System;

class _03_Grammar {
    public static void Main() {
        Console.WriteLine("Hello World!"); // 출력문
        // [System.]Console.WriteLine(출력할 자료)의 형태로 출력하면 된다.

        // 주석, C/C++과 동일.
        // 들여쓰기, C/C++과 동일.
        // 공백 무시, C/C++과 동일.

        // 이스케이프 문자: 유니코드 대응
        Console.WriteLine("\'"); // 0x0027, 작은 따옴표
        Console.WriteLine("\""); // 0x0022, 큰 따옴표
        Console.WriteLine("\\"); // 0x005C, 백슬래시
        Console.WriteLine("\0"); // 0x0000, 널 문자
        Console.WriteLine("\a"); // 0x0007, 경고
        Console.WriteLine("\b"); // 0x0008, 백스페이스
        Console.WriteLine("\f"); // 0x000C, 폼 피드
        Console.WriteLine("\n"); // 0x000A, 줄 바꿈
        Console.WriteLine("\r"); // 0x000D, 캐리지 리턴
        Console.WriteLine("\t"); // 0x0009, 가로 탭
        Console.WriteLine("\v"); // 0x000B, 세로 탭
        Console.WriteLine("\u00E7"); // UTF-16, u 다음에 유니코드 0000-FFFF중 하나 입력
        Console.WriteLine("\U0001F47D"); // UTF-32 U 다음에 유니코드 000000-10FFFF중 하나 입력
        Console.WriteLine("\x27"); // \u와 비슷하나 0 생략가능

        // 자리 표시자:
        Console.WriteLine("{0}", 1234); // 0부터 시작하는 인덱스로 {n}으로 표시. C/C++의 %d등과 비슷
    }
}
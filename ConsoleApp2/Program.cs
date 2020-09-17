using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0909
{
    class UpDown
    {
        static void Main(String[] args)
        {
            Random com = new Random();
            int quiz = 0;
            int answer = 0;
            int match = 0;
            int win = 0;
            int lose = 0;
            int level = 0;

            while (level < 5) // 5 이상의 수를 입력하면 종료
            {
                Console.WriteLine("난이도를 입력해주세요: 쉬움(1)  보통(2)  어려움(3)  전적(4)  종료(5~)");
                level = int.Parse(Console.ReadLine());
                if (level == 1)
                {
                    quiz = com.Next(1, 11); // 1~10사이의 쉬운난이도
                    Console.WriteLine("1~10사이의 숫자");
                }
                else if (level == 2)
                {
                    quiz = com.Next(1, 51); // 1~50사이의 보통난이도
                    Console.WriteLine("1~50사이의 숫자");
                }
                else if (level == 3)
                {
                    quiz = com.Next(1, 101); // 1~100사이의 어려운난이도
                    Console.WriteLine("1~100사이의 숫자");
                }
                else if (level == 4)
                {
                    Console.WriteLine($"총 전적({match}판) =  ({win})승 ({lose})패 \n"); // 총 전적 출력
                    continue;
                }
                else
                    break;

                int count = 1;

                for (; ; )
                {
                    Console.Write($"정답을 입력하세요({count}회): ");
                    answer = int.Parse(Console.ReadLine());

                    if (quiz == answer) // 입력값과 정답이 같다면 판수와 승에 +1을 해주고 메뉴선택으로 돌아감.
                    {
                        win++;
                        match++;
                        Console.WriteLine("정답입니다. \n");
                        break;
                    }
                    else
                    {
                        if (quiz > answer)  // 입력값이 작으면 Up출력
                            Console.WriteLine("Up");
                        else                        // 입력값이 크면 Down출력
                            Console.WriteLine("Down");
                        count++;
                        if (count == 6) // 정답 입력이 5번을 넘어가면 종료, 판수와 패에 +1을 해주고 메뉴로 돌아감.
                        {
                            Console.WriteLine("횟수를 초과했습니다. \n");
                            match++;
                            lose++;
                            level = 0;
                            break;
                        }
                        Console.WriteLine($"틀렸습니다 다시 입력해주세요({count}회)"); // 정답을 맞추지 못하면 count 증가
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
// 3일차까지 배운 C#의 기본문법을 이용하여 UpDown 게임을 작성해서
//소스코드를 수강생명_UpDown.cs로 변형하여 메일로 파일첨부 해주십시오.
//(자기가 할 수 있는 난이도에 따라서 작업하세요)
//1단계 - 1회만 게임이 실행되는 프로그램(무한 반복하여 맞출떄까지 실행)
//2단계 - 1회만 게임이 실행되는 프로그램(5번 기회를 주고, 승, 패를 결정)
//3단계 - 5회 반복해서 실행되는 프로그램(승, 패에 따라서 전적을 계산)
//4단계 - 사용자가 종료를 입력할떄까지 실행되는 프로그램(승, 패에 따라서 전적을 계산)
// 1~100사이의 숫자
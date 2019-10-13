using System;

namespace EnumStudy
{
    class Program
    {
        enum EDrection
        {
            North,
            South,
            East,
            West
        };
        static void Main(string[] args)
        {
            //Console.WriteLine("숫자를 입력하세요. [0 : North], [1 : South], [2 : East], [3 : West]");
            //EDrection direction = (EDrection)int.Parse(Console.ReadLine());
            //Console.WriteLine(direction);

            int x = 0;
            int y = 0;

            while (true)
            {
                if (x == 7 && y == 7)
                {
                    break;
                }
                Console.WriteLine("숫자를 입력하세요. [0 : North], [1 : South], [2 : East], [3 : West]");
                EDrection direction = (EDrection)int.Parse(Console.ReadLine());
                 
                switch (direction)
                {
                    case EDrection.North:
                        {
                            y += 1;
                        }
                        break;
                    case EDrection.South:
                        {
                            y -= 1;
                        }
                        break;
                    case EDrection.East:
                        {
                            x += 1;
                        }
                        break;
                    case EDrection.West:
                        {
                            x -= 1;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("You entered wrong number");
                        }
                        break;
                }
                Console.WriteLine($"현재 위치는 {x}, {y} 입니다.");
            } 
        }
    }
}

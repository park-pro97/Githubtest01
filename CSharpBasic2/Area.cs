

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. 변수선언 및 입력부
            
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            //2. 알고리즘 수식
            double result = (width * height);

            //3. 출력부
            Console.WriteLine($"넓이는 {result} 입니다.");

        }
    }
}

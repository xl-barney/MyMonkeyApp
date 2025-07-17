using MyMonkeyApp.Helpers;
using MyMonkeyApp.Models;

namespace MyMonkeyApp;

/// <summary>
/// 원숭이 정보 콘솔 앱의 메인 클래스
/// </summary>
class Program
{
    /// <summary>
    /// 앱의 진입점
    /// </summary>
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("🐵 원숭이 정보 콘솔 앱에 오신 것을 환영합니다! 🐵");
        Console.WriteLine();

        bool exit = false;
        while (!exit)
        {
            ShowMenu();
            string? choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        ShowAllMonkeys();
                        break;
                    case "2":
                        ShowMonkeyByName();
                        break;
                    case "3":
                        ShowRandomMonkey();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("앱을 종료합니다. 안녕히 가세요! 🐵");
                        break;
                    default:
                        Console.WriteLine("❌ 잘못된 선택입니다. 1-4 사이의 숫자를 입력해주세요.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ 오류가 발생했습니다: {ex.Message}");
            }

            if (!exit)
            {
                Console.WriteLine("\n계속하려면 아무 키나 누르세요...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    /// <summary>
    /// 메인 메뉴를 표시합니다
    /// </summary>
    static void ShowMenu()
    {
        Console.WriteLine("=== 원숭이 정보 메뉴 ===");
        Console.WriteLine("1. 모든 원숭이 목록 보기");
        Console.WriteLine("2. 특정 원숭이 정보 조회");
        Console.WriteLine("3. 무작위 원숭이 보기");
        Console.WriteLine("4. 종료");
        Console.WriteLine();
        Console.Write("원하시는 옵션을 선택하세요 (1-4): ");
    }

    /// <summary>
    /// 모든 원숭이 목록을 표시합니다
    /// </summary>
    static void ShowAllMonkeys()
    {
        Console.Clear();
        Console.WriteLine("🐵 모든 원숭이 목록 🐵");
        Console.WriteLine("=".PadRight(50, '='));

        var monkeys = MonkeyHelper.GetMonkeys();
        
        if (monkeys.Count == 0)
        {
            Console.WriteLine("등록된 원숭이가 없습니다.");
            return;
        }

        for (int i = 0; i < monkeys.Count; i++)
        {
            var monkey = monkeys[i];
            Console.WriteLine($"{i + 1}. {monkey.Name} (서식지: {monkey.Location}, 개체수: {monkey.Population:N0}마리)");
        }
        
        Console.WriteLine();
        Console.WriteLine($"총 {monkeys.Count}종의 원숭이 정보가 있습니다.");
    }

    /// <summary>
    /// 사용자가 입력한 이름으로 원숭이 정보를 조회합니다
    /// </summary>
    static void ShowMonkeyByName()
    {
        Console.Clear();
        Console.WriteLine("🔍 원숭이 정보 조회 🔍");
        Console.WriteLine("=".PadRight(50, '='));

        // 사용 가능한 원숭이 목록 표시
        var allMonkeys = MonkeyHelper.GetMonkeys();
        Console.WriteLine("사용 가능한 원숭이:");
        foreach (var monkey in allMonkeys)
        {
            Console.WriteLine($"- {monkey.Name}");
        }
        Console.WriteLine();

        Console.Write("조회할 원숭이의 이름을 입력하세요: ");
        string? name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("❌ 이름을 입력해주세요.");
            return;
        }

        var foundMonkey = MonkeyHelper.GetMonkeyByName(name);
        if (foundMonkey == null)
        {
            Console.WriteLine($"❌ '{name}'라는 이름의 원숭이를 찾을 수 없습니다.");
            return;
        }

        Console.WriteLine(MonkeyHelper.GetMonkeyInfo(foundMonkey));
    }

    /// <summary>
    /// 무작위로 선택된 원숭이 정보를 표시합니다
    /// </summary>
    static void ShowRandomMonkey()
    {
        Console.Clear();
        Console.WriteLine("🎲 무작위 원숭이 🎲");
        Console.WriteLine("=".PadRight(50, '='));

        var randomMonkey = MonkeyHelper.GetRandomMonkey();
        Console.WriteLine("무작위로 선택된 원숭이:");
        Console.WriteLine(MonkeyHelper.GetMonkeyInfo(randomMonkey));
    }
}

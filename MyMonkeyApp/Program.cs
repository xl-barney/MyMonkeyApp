namespace MyMonkeyApp;

/// <summary>
/// Main program class for the Monkey Information Console Application.
/// </summary>
class Program
{
    /// <summary>
    /// Main entry point of the application.
    /// </summary>
    /// <param name="args">Command line arguments.</param>
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("🐒 원숭이 정보 콘솔 앱에 오신 것을 환영합니다! 🐒");
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine();

            bool continueRunning = true;
            while (continueRunning)
            {
                ShowMenu();
                var choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        ShowAllMonkeys();
                        break;
                    case "2":
                        ShowSpecificMonkey();
                        break;
                    case "3":
                        ShowRandomMonkey();
                        break;
                    case "4":
                        continueRunning = false;
                        Console.WriteLine("프로그램을 종료합니다. 안녕히 가세요! 🐒");
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 1-4 사이의 번호를 입력해주세요.");
                        break;
                }

                if (continueRunning)
                {
                    Console.WriteLine("\n계속하려면 아무 키나 누르세요...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"오류가 발생했습니다: {ex.Message}");
            Console.WriteLine("프로그램을 종료합니다.");
        }
    }

    /// <summary>
    /// Displays the main menu options to the user.
    /// </summary>
    private static void ShowMenu()
    {
        Console.WriteLine("다음 중 원하는 작업을 선택하세요:");
        Console.WriteLine("1. 모든 원숭이 목록 보기");
        Console.WriteLine("2. 특정 원숭이 정보 보기");
        Console.WriteLine("3. 무작위 원숭이 보기");
        Console.WriteLine("4. 종료");
        Console.WriteLine();
        Console.Write("선택 (1-4): ");
    }

    /// <summary>
    /// Displays all available monkey species.
    /// </summary>
    private static void ShowAllMonkeys()
    {
        Console.Clear();
        Console.WriteLine("🐒 모든 원숭이 목록 🐒");
        Console.WriteLine("=".PadRight(30, '='));
        Console.WriteLine();

        var monkeys = MonkeyHelper.GetMonkeys();
        
        for (int i = 0; i < monkeys.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {monkeys[i].Name}");
        }

        Console.WriteLine();
        Console.WriteLine($"총 {MonkeyHelper.GetMonkeyCount()}종의 원숭이가 있습니다.");
        Console.WriteLine();
    }

    /// <summary>
    /// Displays detailed information about a specific monkey chosen by the user.
    /// </summary>
    private static void ShowSpecificMonkey()
    {
        Console.Clear();
        Console.WriteLine("🐒 특정 원숭이 정보 보기 🐒");
        Console.WriteLine("=".PadRight(35, '='));
        Console.WriteLine();

        var monkeyNames = MonkeyHelper.GetMonkeyNames();
        Console.WriteLine("사용 가능한 원숭이 종류:");
        for (int i = 0; i < monkeyNames.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {monkeyNames[i]}");
        }
        Console.WriteLine();

        Console.Write("보고 싶은 원숭이의 번호를 입력하거나 이름을 입력하세요: ");
        var input = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("잘못된 입력입니다.");
            return;
        }

        Monkey? selectedMonkey = null;

        // Try parsing as number first
        if (int.TryParse(input, out int number) && number >= 1 && number <= monkeyNames.Count)
        {
            selectedMonkey = MonkeyHelper.GetMonkeyByName(monkeyNames[number - 1]);
        }
        else
        {
            // Try finding by name
            selectedMonkey = MonkeyHelper.GetMonkeyByName(input);
        }

        if (selectedMonkey != null)
        {
            Console.Clear();
            Console.WriteLine($"🐒 {selectedMonkey.Name} 정보 🐒");
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine();
            Console.WriteLine(selectedMonkey.ToString());
        }
        else
        {
            Console.WriteLine("해당 원숭이를 찾을 수 없습니다.");
        }

        Console.WriteLine();
    }

    /// <summary>
    /// Displays information about a randomly selected monkey.
    /// </summary>
    private static void ShowRandomMonkey()
    {
        Console.Clear();
        Console.WriteLine("🐒 무작위 원숭이 🐒");
        Console.WriteLine("=".PadRight(25, '='));
        Console.WriteLine();

        var randomMonkey = MonkeyHelper.GetRandomMonkey();
        Console.WriteLine("🎲 무작위로 선택된 원숭이:");
        Console.WriteLine();
        Console.WriteLine(randomMonkey.ToString());
        Console.WriteLine();
    }
}

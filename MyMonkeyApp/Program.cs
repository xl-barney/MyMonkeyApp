using MyMonkeyApp;

namespace MyMonkeyApp;

/// <summary>
/// Main program class for the Monkey Console Application.
/// </summary>
internal class Program
{
    /// <summary>
    /// Main entry point of the application.
    /// </summary>
    /// <param name="args">Command line arguments.</param>
    static void Main(string[] args)
    {
        Console.Clear();
        ShowWelcomeMessage();
        
        bool running = true;
        while (running)
        {
            try
            {
                ShowMenu();
                var choice = GetUserChoice();
                
                switch (choice)
                {
                    case 1:
                        ShowAllMonkeys();
                        break;
                    case 2:
                        ShowSpecificMonkey();
                        break;
                    case 3:
                        ShowRandomMonkey();
                        break;
                    case 4:
                        running = false;
                        ShowGoodbyeMessage();
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다. 다시 시도해주세요.");
                        break;
                }
                
                if (running)
                {
                    WaitForUserInput();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"오류가 발생했습니다: {ex.Message}");
                WaitForUserInput();
            }
        }
    }

    /// <summary>
    /// Shows the welcome message.
    /// </summary>
    private static void ShowWelcomeMessage()
    {
        Console.WriteLine("================================");
        Console.WriteLine("      🐵 원숭이 정보 앱 🐵");
        Console.WriteLine("================================");
        Console.WriteLine($"현재 {MonkeyHelper.GetMonkeyCount()}종의 원숭이 정보를 제공합니다.");
        Console.WriteLine();
    }

    /// <summary>
    /// Shows the main menu options.
    /// </summary>
    private static void ShowMenu()
    {
        Console.WriteLine("메뉴를 선택하세요:");
        Console.WriteLine("1. 모든 원숭이 목록 보기");
        Console.WriteLine("2. 특정 원숭이 정보 보기");
        Console.WriteLine("3. 무작위 원숭이 보기");
        Console.WriteLine("4. 종료");
        Console.Write("선택 (1-4): ");
    }

    /// <summary>
    /// Gets the user's menu choice.
    /// </summary>
    /// <returns>The selected menu option as an integer.</returns>
    private static int GetUserChoice()
    {
        var input = Console.ReadLine();
        if (int.TryParse(input, out int choice))
        {
            return choice;
        }
        return -1;
    }

    /// <summary>
    /// Shows all available monkeys in a list format.
    /// </summary>
    private static void ShowAllMonkeys()
    {
        Console.Clear();
        Console.WriteLine("🐵 모든 원숭이 목록 🐵");
        Console.WriteLine("====================");
        
        var monkeys = MonkeyHelper.GetMonkeys();
        
        for (int i = 0; i < monkeys.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {monkeys[i].Name}");
        }
        
        Console.WriteLine();
        Console.WriteLine("상세 정보를 보려면 '2. 특정 원숭이 정보 보기'를 선택하세요.");
    }

    /// <summary>
    /// Shows information for a specific monkey based on user input.
    /// </summary>
    private static void ShowSpecificMonkey()
    {
        Console.Clear();
        Console.WriteLine("🔍 특정 원숭이 정보 🔍");
        Console.WriteLine("===================");
        
        var monkeys = MonkeyHelper.GetMonkeys();
        Console.WriteLine("사용 가능한 원숭이:");
        for (int i = 0; i < monkeys.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {monkeys[i].Name}");
        }
        
        Console.WriteLine();
        Console.Write("원숭이 이름을 입력하세요: ");
        var input = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("유효한 이름을 입력해주세요.");
            return;
        }
        
        var monkey = MonkeyHelper.GetMonkeyByName(input);
        if (monkey != null)
        {
            ShowMonkeyDetails(monkey);
        }
        else
        {
            Console.WriteLine($"'{input}' 이름의 원숭이를 찾을 수 없습니다.");
            Console.WriteLine("위 목록에서 정확한 이름을 선택해주세요.");
        }
    }

    /// <summary>
    /// Shows a randomly selected monkey.
    /// </summary>
    private static void ShowRandomMonkey()
    {
        Console.Clear();
        Console.WriteLine("🎲 무작위 원숭이 🎲");
        Console.WriteLine("=================");
        
        var randomMonkey = MonkeyHelper.GetRandomMonkey();
        ShowMonkeyDetails(randomMonkey);
    }

    /// <summary>
    /// Shows detailed information about a specific monkey.
    /// </summary>
    /// <param name="monkey">The monkey to display details for.</param>
    private static void ShowMonkeyDetails(Monkey monkey)
    {
        Console.Clear();
        Console.WriteLine($"🐵 {monkey.Name} 🐵");
        Console.WriteLine(new string('=', monkey.Name.Length + 6));
        Console.WriteLine();
        
        Console.WriteLine("ASCII 아트:");
        Console.WriteLine(monkey.AsciiArt);
        Console.WriteLine();
        
        Console.WriteLine("설명:");
        Console.WriteLine(monkey.Description);
        Console.WriteLine();
    }

    /// <summary>
    /// Shows the goodbye message.
    /// </summary>
    private static void ShowGoodbyeMessage()
    {
        Console.WriteLine();
        Console.WriteLine("원숭이 정보 앱을 이용해주셔서 감사합니다! 🐵");
        Console.WriteLine("좋은 하루 보내세요!");
    }

    /// <summary>
    /// Waits for user input before continuing.
    /// </summary>
    private static void WaitForUserInput()
    {
        Console.WriteLine();
        Console.WriteLine("계속하려면 아무 키나 누르세요...");
        Console.ReadKey();
        Console.Clear();
    }
}

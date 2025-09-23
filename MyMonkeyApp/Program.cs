
using MyMonkeyApp;

class Program
{
	static readonly string[] AsciiArts = new[]
	{
		@"  w  c( .. )o   (\__/)",
		@"   (..)\   (..)\   (..)\",
		@"   (o o)   (o o)   (o o)",
		@"  (  .  ) (  .  ) (  .  )",
		@"   ("""")   ("""")   ("""")"
	};

	static void Main()
	{
		var rand = new Random();
		while (true)
		{
			// 무작위 ASCII 아트 출력
			Console.WriteLine();
			Console.WriteLine(AsciiArts[rand.Next(AsciiArts.Length)]);
			Console.WriteLine();

			Console.WriteLine("===== Monkey App Menu =====");
			Console.WriteLine("1. 모든 원숭이 목록");
			Console.WriteLine("2. 이름으로 특정 원숭이 조회");
			Console.WriteLine("3. 무작위로 원숭이 조회");
			Console.WriteLine("4. 앱 종료");
			Console.Write("메뉴를 선택하세요: ");
			var input = Console.ReadLine();
			Console.WriteLine();

			switch (input)
			{
				case "1":
					ShowAllMonkeys();
					break;
				case "2":
					FindMonkeyByName();
					break;
				case "3":
					ShowRandomMonkey();
					break;
				case "4":
					Console.WriteLine("앱을 종료합니다.");
					return;
				default:
					Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
					break;
			}
		}
	}

	static void ShowAllMonkeys()
	{
		var monkeys = MonkeyHelper.GetMonkeys();
		foreach (var m in monkeys)
		{
			PrintMonkey(m);
			Console.WriteLine("--------------------------");
		}
	}

	static void FindMonkeyByName()
	{
		Console.Write("원숭이 이름을 입력하세요: ");
		var name = Console.ReadLine();
		var monkey = MonkeyHelper.GetMonkeyByName(name ?? string.Empty);
		if (monkey != null)
			PrintMonkey(monkey);
		else
			Console.WriteLine("해당 이름의 원숭이가 없습니다.");
	}

	static void ShowRandomMonkey()
	{
		var monkey = MonkeyHelper.GetRandomMonkey();
		PrintMonkey(monkey);
		Console.WriteLine($"(무작위 조회수: {MonkeyHelper.GetRandomViewCount(monkey.Name)})");
	}

	static void PrintMonkey(Monkey m)
	{
		Console.WriteLine($"이름: {m.Name}");
		Console.WriteLine($"서식지: {m.Location}");
		Console.WriteLine($"개체수: {m.Population}");
		Console.WriteLine($"설명: {m.Details}");
		Console.WriteLine($"이미지/아트: {m.Image}");
		Console.WriteLine($"좌표: {m.Latitude}, {m.Longitude}");
	}
}

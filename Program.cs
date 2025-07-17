using MyMonkeyApp;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

while (true)
{
    Console.WriteLine("\n===== Monkey App 메뉴 =====");
    Console.WriteLine("1. 모든 원숭이 목록");
    Console.WriteLine("2. 이름으로 특정 원숭이 조회");
    Console.WriteLine("3. 무작위로 원숭이 조회");
    Console.WriteLine("4. 앱 종료");
    Console.Write("메뉴 번호를 선택하세요: ");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("\n--- 모든 원숭이 목록 ---");
            foreach (var monkey in MonkeyHelper.GetMonkeys())
            {
                Console.WriteLine($"- {monkey.Name} ({monkey.Location}) | 개체수: {monkey.Population}");
            }
            break;
        case "2":
            Console.Write("조회할 원숭이 이름을 입력하세요: ");
            var name = Console.ReadLine();
            var found = MonkeyHelper.GetMonkeyByName(name ?? string.Empty);
            if (found != null)
            {
                Console.WriteLine($"\n이름: {found.Name}\n위치: {found.Location}\n개체수: {found.Population}\n설명: {found.Details}\n이미지: {found.Image}\n좌표: {found.Latitude}, {found.Longitude}\nASCII 아트: {found.AsciiArt}");
            }
            else
            {
                Console.WriteLine("해당 이름의 원숭이를 찾을 수 없습니다.");
            }
            break;
        case "3":
            var randomMonkey = MonkeyHelper.GetRandomMonkey();
            var viewCount = MonkeyHelper.GetRandomViewCount(randomMonkey.Name);
            Console.WriteLine($"\n[무작위 선택] {randomMonkey.Name}\n위치: {randomMonkey.Location}\n개체수: {randomMonkey.Population}\n설명: {randomMonkey.Details}\n이미지: {randomMonkey.Image}\n좌표: {randomMonkey.Latitude}, {randomMonkey.Longitude}\nASCII 아트: {randomMonkey.AsciiArt}\n조회 수: {viewCount}");
            break;
        case "4":
            Console.WriteLine("앱을 종료합니다.");
            return;
        default:
            Console.WriteLine("잘못된 입력입니다. 다시 시도하세요.");
            break;
    }
}

using MyMonkeyApp.Models;

namespace MyMonkeyApp.Helpers;

/// <summary>
/// 원숭이 데이터를 관리하는 정적 헬퍼 클래스
/// </summary>
public static class MonkeyHelper
{
    /// <summary>
    /// 모든 원숭이 데이터를 저장하는 리스트
    /// </summary>
    private static readonly List<Monkey> _monkeys = new()
    {
        new Monkey
        {
            Name = "침팬지",
            Location = "아프리카 중부, 서부",
            Population = 300000,
            Description = "인간과 가장 가까운 유인원으로 높은 지능을 가지고 있습니다.",
            AsciiArt = @"
      .-------.
     /         \
    |  O     O  |
    |     <>     |
    |   \____/   |
     \           /
      '-.______.-'
         |    |
         |    |
        /      \
       /        \
      /__________\"
        },
        new Monkey
        {
            Name = "오랑우탄",
            Location = "보르네오, 수마트라",
            Population = 104000,
            Description = "붉은 털을 가진 대형 유인원으로 나무 위에서 생활합니다.",
            AsciiArt = @"
        .-------.
       /         \
      |  O     O  |
      |     <>     |
      |  \._____./  |
       \___________/
        |         |
        |    ||   |
       /     ||    \
      /      ||     \
     /________________\"
        },
        new Monkey
        {
            Name = "고릴라",
            Location = "아프리카 중부, 동부",
            Population = 200000,
            Description = "가장 큰 영장류로 강력한 힘을 가지고 있습니다.",
            AsciiArt = @"
        .-------.
       /         \
      |  O     O  |
      |     <>     |
      |   \____/   |
       \           /
        '-.______.-'
           |    |
           |    |
          /      \
         /        \
        /__________\"
        },
        new Monkey
        {
            Name = "원숭이",
            Location = "전 세계 열대지역",
            Population = 2000000,
            Description = "다양한 종류가 있는 영장류의 일반적인 형태입니다.",
            AsciiArt = @"
         .----.
        /      \
       |  O  O  |
       |    <>  |
       |  \___/ |
        \       /
         '-..-'
          | |
          | |
         /   \
        /     \
       /_______\"
        },
        new Monkey
        {
            Name = "긴팔원숭이",
            Location = "동남아시아",
            Population = 50000,
            Description = "긴 팔을 가진 작은 유인원으로 나무에서 빠르게 이동합니다.",
            AsciiArt = @"
        .-------.
       /         \
      |  O     O  |
      |     <>     |
      |  \._____./  |
       \___________/
    ------|     |------
          |     |
         /       \
        /         \
       /___________\"
        },
        new Monkey
        {
            Name = "마카크",
            Location = "아시아 전역",
            Population = 1500000,
            Description = "적응력이 뛰어난 원숭이로 다양한 환경에서 생활합니다.",
            AsciiArt = @"
         .----.
        /      \
       |  O  O  |
       |    <>  |
       |  \___/ |
        \  ===  /
         '-..-'
          | |
          | |
         /   \
        /     \
       /_______\"
        }
    };

    /// <summary>
    /// 모든 원숭이 목록을 반환합니다
    /// </summary>
    /// <returns>원숭이 목록</returns>
    public static List<Monkey> GetMonkeys()
    {
        return _monkeys.ToList();
    }

    /// <summary>
    /// 이름으로 원숭이를 찾아 반환합니다
    /// </summary>
    /// <param name="name">찾을 원숭이의 이름</param>
    /// <returns>찾은 원숭이, 없으면 null</returns>
    public static Monkey? GetMonkeyByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return null;

        return _monkeys.FirstOrDefault(m => 
            m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// 무작위로 원숭이 하나를 선택하여 반환합니다
    /// </summary>
    /// <returns>무작위로 선택된 원숭이</returns>
    public static Monkey GetRandomMonkey()
    {
        var random = new Random();
        int index = random.Next(_monkeys.Count);
        return _monkeys[index];
    }

    /// <summary>
    /// 원숭이의 상세 정보를 포맷된 문자열로 반환합니다
    /// </summary>
    /// <param name="monkey">정보를 표시할 원숭이</param>
    /// <returns>포맷된 원숭이 정보</returns>
    public static string GetMonkeyInfo(Monkey monkey)
    {
        return $@"
{monkey.AsciiArt}

이름: {monkey.Name}
서식지: {monkey.Location}
개체수: {monkey.Population:N0}마리
설명: {monkey.Description}
";
    }
}
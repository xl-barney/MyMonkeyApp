namespace MyMonkeyApp;

using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 원숭이 데이터 관리 및 조회 기능을 제공하는 정적 헬퍼 클래스입니다.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys = new()
    {
        new Monkey { Name = "Baboon", Location = "Africa & Asia", Population = 10000, Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg", Latitude = -8.783195, Longitude = 34.508523, AsciiArt = "( ͡° ͜ʖ ͡°)" },
        new Monkey { Name = "Capuchin Monkey", Location = "Central & South America", Population = 23000, Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg", Latitude = 12.769013, Longitude = -85.602364, AsciiArt = "@('_')@" },
        new Monkey { Name = "Blue Monkey", Location = "Central and East Africa", Population = 12000, Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/bluemonkey.jpg", Latitude = 1.957709, Longitude = 37.297204, AsciiArt = "ʕ•ᴥ•ʔ" },
        // ... 나머지 원숭이 데이터 추가 ...
    };

    private static readonly Dictionary<string, int> randomViewCounts = new();

    /// <summary>
    /// 모든 원숭이 목록을 반환합니다.
    /// </summary>
    public static IReadOnlyList<Monkey> GetMonkeys() => monkeys;

    /// <summary>
    /// 이름으로 원숭이를 찾습니다.
    /// </summary>
    public static Monkey? GetMonkeyByName(string name) =>
        monkeys.FirstOrDefault(m => string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));

    /// <summary>
    /// 무작위 원숭이를 반환하며, 조회 수를 1 증가시킵니다.
    /// </summary>
    public static Monkey GetRandomMonkey()
    {
        var random = new Random();
        var selectedMonkey = monkeys[random.Next(monkeys.Count)];
        if (randomViewCounts.ContainsKey(selectedMonkey.Name))
            randomViewCounts[selectedMonkey.Name]++;
        else
            randomViewCounts[selectedMonkey.Name] = 1;
        return selectedMonkey;
    }

    /// <summary>
    /// 특정 원숭이의 무작위 조회 수를 반환합니다.
    /// </summary>
    public static int GetRandomViewCount(string name) =>
        randomViewCounts.TryGetValue(name, out var count) ? count : 0;
}

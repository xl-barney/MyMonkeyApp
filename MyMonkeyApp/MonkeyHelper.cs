namespace MyMonkeyApp;

/// <summary>
/// Static helper class for managing monkey data and operations.
/// </summary>
public static class MonkeyHelper
{
    /// <summary>
    /// Static collection of available monkey species.
    /// </summary>
    private static readonly List<Monkey> monkeys = new List<Monkey>
    {
        new Monkey(
            "Chimpanzee",
            "Chimpanzees are highly intelligent great apes found in the forests of Africa. They are our closest living relatives, sharing about 98.8% of their DNA with humans. They live in complex social groups and use tools.",
            @"      .-""-.
     /      \
    |  o   o  |
    |    >    |
    |   ___   |
     \  \_/  /
      '-..-'
       _||_
      /    \
     |      |
     |______|"
        ),
        new Monkey(
            "Orangutan",
            "Orangutans are large, arboreal apes found in the rainforests of Borneo and Sumatra. They are known for their distinctive reddish-brown hair and their impressive arm span. They are solitary animals and excellent climbers.",
            @"    .-.     .-.
   /   \   /   \
  |  o  | |  o  |
   \   / | \   /
    '-'  |  '-'
         |
     .---|---.
    /         \
   |    ___    |
   |   /   \   |
    \  \___/  /
     '-.....-'
        |||
       /   \
      |     |
      |_____|"
        ),
        new Monkey(
            "Baboon",
            "Baboons are Old World monkeys found in Africa and Arabia. They are highly social primates that live in large troops. They have distinctive elongated snouts and powerful jaws, and they're known for their complex social hierarchies.",
            @"      /\_/\
     ( o.o )
      > ^ <
     /     \
    (  ___  )
     |     |
     |  |  |
     |__|__|
      _| |_
     /     \
    |       |
    |_______|"
        ),
        new Monkey(
            "Capuchin",
            "Capuchin monkeys are New World monkeys found in Central and South America. They are small, intelligent primates known for their problem-solving abilities and tool use. They have distinctive facial patterns and are often kept as pets (though this is not recommended).",
            @"       .-""-.
      /       \
     |  ^   ^  |
     |    <    |
     |   ___   |
      \   U   /
       '-..-'
        |||
       /   \
      |  O  |
      |  |  |
      |__|__|
       _||_
      /    \
     |      |
     |______|"
        ),
        new Monkey(
            "Howler Monkey",
            "Howler monkeys are New World monkeys found in Central and South America. They are famous for their loud calls that can be heard up to 3 miles away. They are primarily arboreal and have strong prehensile tails.",
            @"     .-.   .-.
    /   \ /   \
   |  o  |  o  |
    \   / \   /
     '-'   '-'
        ___
       /   \
      | ^^^ |
      |  O  |
       \___/
        |||
      __|__|__
     /        \
    |    ~~    |
    |__________|"
        )
    };

    /// <summary>
    /// Gets all available monkey species.
    /// </summary>
    /// <returns>A read-only list of all monkeys.</returns>
    public static IReadOnlyList<Monkey> GetMonkeys()
    {
        return monkeys.AsReadOnly();
    }

    /// <summary>
    /// Gets a random monkey from the collection.
    /// </summary>
    /// <returns>A randomly selected monkey.</returns>
    public static Monkey GetRandomMonkey()
    {
        var random = new Random();
        return monkeys[random.Next(monkeys.Count)];
    }

    /// <summary>
    /// Gets a monkey by its name (case-insensitive).
    /// </summary>
    /// <param name="name">The name of the monkey to find.</param>
    /// <returns>The monkey with the specified name, or null if not found.</returns>
    public static Monkey? GetMonkeyByName(string name)
    {
        return monkeys.FirstOrDefault(m => 
            string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets the total number of monkey species available.
    /// </summary>
    /// <returns>The count of available monkey species.</returns>
    public static int GetMonkeyCount()
    {
        return monkeys.Count;
    }

    /// <summary>
    /// Gets the names of all available monkey species.
    /// </summary>
    /// <returns>A list of monkey names.</returns>
    public static List<string> GetMonkeyNames()
    {
        return monkeys.Select(m => m.Name).ToList();
    }
}
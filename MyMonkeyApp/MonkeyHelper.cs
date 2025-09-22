namespace MyMonkeyApp;

/// <summary>
/// Static helper class for managing monkey data.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> _monkeys = InitializeMonkeys();

    /// <summary>
    /// Gets all available monkeys.
    /// </summary>
    /// <returns>A list of all monkey species.</returns>
    public static List<Monkey> GetMonkeys()
    {
        return new List<Monkey>(_monkeys);
    }

    /// <summary>
    /// Gets a random monkey from the available species.
    /// </summary>
    /// <returns>A randomly selected monkey.</returns>
    public static Monkey GetRandomMonkey()
    {
        if (_monkeys.Count == 0)
            throw new InvalidOperationException("No monkeys available.");

        var random = new Random();
        var index = random.Next(_monkeys.Count);
        return _monkeys[index];
    }

    /// <summary>
    /// Gets a monkey by its name (case-insensitive).
    /// </summary>
    /// <param name="name">The name of the monkey to find.</param>
    /// <returns>The monkey with the specified name, or null if not found.</returns>
    public static Monkey? GetMonkeyByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return null;

        return _monkeys.FirstOrDefault(m => 
            string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets the count of available monkeys.
    /// </summary>
    /// <returns>The number of monkey species available.</returns>
    public static int GetMonkeyCount()
    {
        return _monkeys.Count;
    }

    /// <summary>
    /// Initializes the monkey data with sample species.
    /// </summary>
    /// <returns>A list of initialized monkey species.</returns>
    private static List<Monkey> InitializeMonkeys()
    {
        return new List<Monkey>
        {
            new Monkey(
                "Golden Snub-nosed Monkey",
                "The golden snub-nosed monkey is an endangered species found in the temperate forests of central and southwestern China. They are known for their distinctive upturned nose and golden fur. These primates live in large social groups and are excellent climbers, spending most of their time in trees feeding on leaves, bark, and fruits.",
                @"       .-""-._
      /       \
     |  ^   ^  |
     |    u    |
      \   ___  /
       '.___.'
        |||||
        |||||"
            ),
            new Monkey(
                "Capuchin Monkey",
                "Capuchin monkeys are among the most intelligent New World monkeys. Found in Central and South America, they are known for their problem-solving abilities and tool use. These small primates have expressive faces and are highly social, living in groups of 8-40 individuals. They are omnivores with a varied diet including fruits, insects, and small animals.",
                @"     .-""""""-.
    /          \
   |  o      o  |
   |      <     |
    \    ___   /
     '-.____.-'
      (  )_(  )
       \      /
        |    |
        |____|"
            ),
            new Monkey(
                "Howler Monkey",
                "Howler monkeys are famous for their incredibly loud vocalizations that can be heard up to 3 miles away. Native to Central and South American rainforests, they are among the largest New World monkeys. They spend most of their time in the forest canopy feeding primarily on leaves. Their calls help maintain territory and group cohesion.",
                @"      .-.   .-.
     (   )_(   )
      \  ___  /
       | o o |
       |  >  |
        \___/
       /|||||\ 
      / ||||| \
     (  |||||  )
      \ ||||| /
       \|||||/"
            ),
            new Monkey(
                "Japanese Macaque",
                "Also known as snow monkeys, Japanese macaques are the northernmost-living non-human primates. They are famous for bathing in hot springs during winter in Japan. These intelligent monkeys have complex social structures and exhibit cultural behaviors such as washing food before eating. They have thick fur that helps them survive cold temperatures.",
                @"       .-""-.
      /       \
     | () () |
     |   <>   |
      \  ___  /
       '-----'
        /|||\ 
       / ||| \
      |  |||  |
       \ ||| /
        \|||/"
            ),
            new Monkey(
                "Spider Monkey",
                "Spider monkeys are characterized by their extremely long limbs and prehensile tails that act like a fifth hand. Found in tropical rainforests of Central and South America, they are excellent brachiators, swinging through trees with remarkable agility. They live in social groups and primarily eat fruits, making them important seed dispersers for forest ecosystems.",
                @"     .-""""-.
    /        \
   |  ^    ^  |
   |     u    |
    \   ___  /
     '-.___.-'
       |||||
      /|||||\ 
     / ||||| \
    |  |||||  |
     \ ||||| /
      \|||||/"
            )
        };
    }
}
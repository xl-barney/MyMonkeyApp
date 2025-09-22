namespace MyMonkeyApp;

/// <summary>
/// Represents a monkey species with name, description, and ASCII art.
/// </summary>
public class Monkey
{
    /// <summary>
    /// Gets or sets the name of the monkey species.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description of the monkey species.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the ASCII art representation of the monkey.
    /// </summary>
    public string AsciiArt { get; set; } = string.Empty;

    /// <summary>
    /// Initializes a new instance of the Monkey class.
    /// </summary>
    public Monkey()
    {
    }

    /// <summary>
    /// Initializes a new instance of the Monkey class with specified values.
    /// </summary>
    /// <param name="name">The name of the monkey species.</param>
    /// <param name="description">The description of the monkey species.</param>
    /// <param name="asciiArt">The ASCII art representation.</param>
    public Monkey(string name, string description, string asciiArt)
    {
        Name = name;
        Description = description;
        AsciiArt = asciiArt;
    }
}
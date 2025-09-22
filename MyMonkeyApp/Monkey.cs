namespace MyMonkeyApp;

/// <summary>
/// Represents a monkey species with its characteristics and ASCII art representation.
/// </summary>
public class Monkey
{
    /// <summary>
    /// Gets or sets the name of the monkey species.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description of the monkey species including habitat and characteristics.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the ASCII art representation of the monkey.
    /// </summary>
    public string AsciiArt { get; set; } = string.Empty;

    /// <summary>
    /// Initializes a new instance of the <see cref="Monkey"/> class.
    /// </summary>
    public Monkey()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Monkey"/> class with specified values.
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

    /// <summary>
    /// Returns a string representation of the monkey with its details.
    /// </summary>
    /// <returns>A formatted string containing the monkey's information.</returns>
    public override string ToString()
    {
        return $"Name: {Name}\n\nDescription: {Description}\n\nASCII Art:\n{AsciiArt}";
    }
}
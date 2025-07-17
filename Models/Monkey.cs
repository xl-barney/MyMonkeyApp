namespace MyMonkeyApp.Models;

/// <summary>
/// 원숭이 정보를 나타내는 모델 클래스
/// </summary>
public class Monkey
{
    /// <summary>
    /// 원숭이의 이름
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 원숭이의 서식지
    /// </summary>
    public string Location { get; set; } = string.Empty;

    /// <summary>
    /// 개체수
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// 원숭이를 나타내는 ASCII 아트
    /// </summary>
    public string AsciiArt { get; set; } = string.Empty;

    /// <summary>
    /// 원숭이에 대한 추가 설명
    /// </summary>
    public string Description { get; set; } = string.Empty;
}
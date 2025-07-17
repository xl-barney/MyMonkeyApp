namespace MyMonkeyApp;

/// <summary>
/// 원숭이 정보를 나타내는 모델 클래스입니다.
/// </summary>
public class Monkey
{
    /// <summary>원숭이 이름</summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>서식지 위치</summary>
    public string Location { get; set; } = string.Empty;

    /// <summary>개체수</summary>
    public int Population { get; set; }

    /// <summary>상세 설명</summary>
    public string Details { get; set; } = string.Empty;

    /// <summary>이미지 URL</summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>위도</summary>
    public double Latitude { get; set; }

    /// <summary>경도</summary>
    public double Longitude { get; set; }

    /// <summary>ASCII 아트</summary>
    public string? AsciiArt { get; set; }
}

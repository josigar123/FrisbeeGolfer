namespace FrisbeeGolfer.api.Dtos;

public class CreatePlayerDto(string name, int score)
{
    public string PlayerId { get; } = Guid.NewGuid().ToString();
    public string Name { get; } = name;
    public int Score { get; set; } = score;
}
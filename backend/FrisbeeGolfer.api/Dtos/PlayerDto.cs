namespace FrisbeeGolfer.api.Dtos;

public class PlayerDto(string playerId, string name, int score)
{

    public string PlayerId { get; } = playerId;
    public string Name { get; } = name;
    public int Score { get; set; } = score;

}
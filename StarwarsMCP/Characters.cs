
namespace StarwarsMCP;

public class Characters
{
	public int Count { get; set; }
	public string Next { get; set; } = null!;
	public string Previous { get; set; } = null!;
	public List<Character> Results { get; set; } = null!;
}
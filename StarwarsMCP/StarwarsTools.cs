using System.ComponentModel;
using ModelContextProtocol.Server;

namespace StarwarsMCP;

[McpServerToolType]
public static class StarwarsTools
{
	[McpServerTool, Description ("Gets a list of characters from the Star Wars API.")]
	public static async Task<Characters> GetCharacters (StarwarsService starwarsService)
	{
		return await starwarsService.GetCharacters ();
	}

	[McpServerTool, Description ("Gets a character by ID from the Star Wars API.")]
	public static async Task<Character> GetCharacter (StarwarsService starwarsService, int id) => await starwarsService.GetCharacter (id);
}
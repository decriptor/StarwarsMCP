using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StarwarsMCP;

public class StarwarsService
{
	HttpClient httpClient = new HttpClient ();

	public StarwarsService ()
	{
		httpClient.BaseAddress = new Uri ("https://swapi.dev/api/");
		characters = new Characters ();
	}

	Characters characters;

	public async Task<Characters> GetCharacters ()
	{
		if (characters.Results == null || characters.Results.Count == 0) {
			var response = await httpClient.GetAsync ("people/");
			characters = await response.Content.ReadFromJsonAsync<Characters> () ?? new ();

		}
		return characters;
	}

	public async Task<Character> GetCharacter (int id)
	{
		var response = await httpClient.GetAsync ($"people/{id}/");
		return await response.Content.ReadFromJsonAsync<Character> () ?? new Character ();
	}
}

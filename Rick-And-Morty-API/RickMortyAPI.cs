using System.Net.Http;
using System.Net.Http.Json;

public class RickMortyAPI
{
	private HttpClient client;
	public RickMortyAPI()
	{
		try
		{
			client = new HttpClient();
			client.BaseAddress = new Uri("https://rickandmortyapi.com/api/");
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(
				new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(
					"application/json")
				);
		}
		catch (Exception e)
		{
			global::System.Console.WriteLine(e.ToString());
			throw;
		}

	}
	public async Task<Personaje> ObtenPersonaje(int id)
	{
		try
		{
			if (Personaje.MIN_ID <= id && id <= Personaje.MAX_ID)
			{
				Personaje personaje;
				HttpResponseMessage response = await client.GetAsync(string.Concat("character/", id.ToString()));
				if (response.IsSuccessStatusCode)
				{
					personaje = await response.Content.ReadFromJsonAsync<Personaje>();
					return personaje;
				}
			}
			
			return null;
		}
		catch (Exception e)
		{
			await global::System.Console.Out.WriteLineAsync(e.ToString());
			throw;
		}
	}
}

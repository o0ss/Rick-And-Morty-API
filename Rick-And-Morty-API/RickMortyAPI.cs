using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

public class RickMortyAPI
{
	public HttpClient client;
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
					if(personaje.image != null)
					{
						using (WebClient img_c = new WebClient())
						{
							byte[] imageData = img_c.DownloadData(personaje.image);
							using (MemoryStream stream = new MemoryStream(imageData))
							{
								/*personaje.img_data = 
									Image.FromStream(stream).GetThumbnailImage(150, 150, null, IntPtr.Zero);*/
								personaje.img_data = Image.FromStream(stream);
							}
						}

					}
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

	public async Task<Lugar> ObtenLugar(int id)
	{
		try
		{
			if (Lugar.MIN_ID <= id && id <= Lugar.MAX_ID)
			{
				Lugar loc;
				HttpResponseMessage response = await client.GetAsync(string.Concat("location/", id.ToString()));
				if (response.IsSuccessStatusCode)
				{
					loc = await response.Content.ReadFromJsonAsync<Lugar>();
					return loc;
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

	public async Task<Episodio> ObtenEpisodio(int id)
	{
		try
		{
			if (Episodio.MIN_ID <= id && id <= Episodio.MAX_ID)
			{
				Episodio ep;
				HttpResponseMessage response = await client.GetAsync(string.Concat("episode/", id.ToString()));
				if (response.IsSuccessStatusCode)
				{
					ep = await response.Content.ReadFromJsonAsync<Episodio>();
					return ep;
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

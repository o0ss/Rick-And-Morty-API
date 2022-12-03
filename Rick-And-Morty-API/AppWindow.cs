using System.Net.Http;
using System.Net.Http.Json;

namespace Rick_And_Morty_API
{
	public partial class AppWindow : Form
	{
		private int last_id_pers = Personaje.MIN_ID, id_pers = 0,
					last_id_loc = Lugar.MIN_ID, id_loc = 0,
					last_id_ep = Episodio.MIN_ID, id_ep = 0;
		private RickMortyAPI api;
		private Random random;
		Dictionary<int, Personaje> dicc_personajes;
		Dictionary<int, Lugar> dicc_lugares;
		Dictionary<int, Episodio> dicc_episodios;

		public AppWindow()
		{
			InitializeComponent();
			random = new Random();
			dicc_personajes = new Dictionary<int, Personaje>();
			dicc_lugares = new Dictionary<int, Lugar>();
			dicc_episodios = new Dictionary<int, Episodio>();
			api = new RickMortyAPI();
		}

		public async Task<bool> updatePersonaje(int nuevo)
		{
			try
			{
				if (nuevo != id_pers && 
					Personaje.MIN_ID <= nuevo && nuevo <= Personaje.MAX_ID)
				{
					last_id_pers = id_pers;
					id_pers = nuevo;
					if (!dicc_personajes.ContainsKey(nuevo))
					{
						Personaje pnuevo = await
							api.ObtenPersonaje(nuevo);
						if(!dicc_personajes.ContainsKey(nuevo))
						dicc_personajes.Add(nuevo, pnuevo);
					}

					Personaje nuevo_pers = dicc_personajes[nuevo];

					labelPersName.Text = nuevo_pers.name;
					labelPersGender.Text = nuevo_pers.gender;
					labelPersSpecies.Text = nuevo_pers.species;
					labelPersStatus.Text = nuevo_pers.status;
					labelPersType.Text = nuevo_pers.type;
					labelPersOrigin.Text = nuevo_pers.origin.name;
					labelPersLoc.Text = nuevo_pers.location.name;
					pictureBoxPers.Image = nuevo_pers.img_data;

					if (textBoxIDPers.Text != id_pers.ToString())
					{
						textBoxIDPers.Text = id_pers.ToString();
					}
					return true;
				}
				return false;
			}
			catch (Exception e)
			{
				global::System.Console.WriteLine(e.ToString());
				throw;
			}
			
		}

		public async Task<bool> updateLugar(int nuevo)
		{
			try
			{
				if (nuevo != id_loc &&
					Lugar.MIN_ID <= nuevo && nuevo <= Lugar.MAX_ID)
				{
					last_id_loc = id_loc;
					id_loc = nuevo;
					if (!dicc_lugares.ContainsKey(nuevo))
					{
						Lugar loc_nuevo = await
							api.ObtenLugar(nuevo);
						if (!dicc_lugares.ContainsKey(nuevo))
							dicc_lugares.Add(nuevo, loc_nuevo);
					}

					Lugar nuevo_lugar = dicc_lugares[nuevo];

					labelLocNombre.Text = nuevo_lugar.name;
					labelLocDim.Text = nuevo_lugar.dimension;
					labelLocType.Text = nuevo_lugar.type;
					labelLocNumResidents.Text = nuevo_lugar.residents.Length.ToString();

					if (textBoxLocID.Text != id_loc.ToString())
					{
						textBoxLocID.Text = id_loc.ToString();
					}
					return true;
				}
				return false;
			}
			catch (Exception e)
			{
				global::System.Console.WriteLine(e.ToString());
				throw;
			}
		}

		public async Task<bool> updateEpisodio(int nuevo)
		{
			try
			{
				if (nuevo != id_ep &&
					Lugar.MIN_ID <= nuevo && nuevo <= Lugar.MAX_ID)
				{
					last_id_ep = id_ep;
					id_ep = nuevo;
					if (!dicc_episodios.ContainsKey(nuevo))
					{
						Episodio ep_nuevo = await
							api.ObtenEpisodio(nuevo);
						if (!dicc_episodios.ContainsKey(nuevo))
							dicc_episodios.Add(nuevo, ep_nuevo);
					}

					Episodio ep = dicc_episodios[nuevo];

					labelEpNombre.Text = ep.name;
					labelEpAirDate.Text = ep.air_date;
					labelEpCode.Text = ep.episode;
					labelEpChars.Text = ep.characters.Length.ToString();

					if (textBoxEpID.Text != id_ep.ToString())
					{
						textBoxEpID.Text = id_ep.ToString();
					}
					return true;
				}
				return false;
			}
			catch (Exception e)
			{
				global::System.Console.WriteLine(e.ToString());
				throw;
			}

		}
		private async void buttonFirstPers_Click(object sender, EventArgs e)
		{
			await updatePersonaje(Personaje.MIN_ID);
		}

		private async void buttonPrevPers_Click(object sender, EventArgs e)
		{
			if (id_pers > Personaje.MIN_ID)
				await updatePersonaje(id_pers - 1);
		}

		private async void buttonNextPers_Click(object sender, EventArgs e)
		{
			if (id_pers < Personaje.MAX_ID)
				await updatePersonaje(id_pers + 1);
		}

		private async void buttonLastPers_Click(object sender, EventArgs e)
		{
			await updatePersonaje(Personaje.MAX_ID);
		}

		private async void textBoxLocID_TextChanged(object sender, EventArgs e)
		{
			if (!int.TryParse(textBoxLocID.Text, out int nuevo) || nuevo < Lugar.MIN_ID)
			{
				textBoxLocID.Text = "";
			}
			else
			{
				if (nuevo > Lugar.MAX_ID)
				{
					textBoxLocID.Text = id_loc.ToString();
				}
				else
				{
					await updateLugar(nuevo);
				}
			}
		}

		private async void buttonLocFirst_Click(object sender, EventArgs e)
		{
			await updateLugar(Lugar.MIN_ID);
		}

		private async void buttonLocPrev_Click(object sender, EventArgs e)
		{
			if (id_loc > Lugar.MIN_ID)
			{
				await updateLugar(id_loc - 1);
			}
		}

		private async void buttonLocNext_Click(object sender, EventArgs e)
		{
			if (id_loc < Lugar.MAX_ID)
				await updateLugar(id_loc + 1);
		}

		private async void textBoxEpID_TextChanged(object sender, EventArgs e)
		{
			if (!int.TryParse(textBoxEpID.Text, out int nuevo) || nuevo < Episodio.MIN_ID)
			{
				textBoxEpID.Text = "";
			}
			else
			{
				if (nuevo > Episodio.MAX_ID)
				{
					textBoxEpID.Text = id_ep.ToString();
				}
				else
				{
					await updateLugar(nuevo);
				}
			}
		}

		private async void buttonEpFirst_Click(object sender, EventArgs e)
		{
			await updateEpisodio(Episodio.MIN_ID);
		}

		private async void buttonEpPrev_Click(object sender, EventArgs e)
		{
			if(id_ep > Episodio.MIN_ID)
				await updateEpisodio(id_ep - 1);
		}

		private async void buttonEpNext_Click(object sender, EventArgs e)
		{
			if(id_ep < Episodio.MAX_ID)
				await updateEpisodio(id_ep + 1);

		}

		private async void buttonEpLast_Click(object sender, EventArgs e)
		{
			await updateEpisodio(Episodio.MAX_ID);
		}

		private async void buttonEpRandom_Click(object sender, EventArgs e)
		{
			int rand = random.Next(Episodio.MIN_ID, Episodio.MAX_ID + 1);
			await updateEpisodio(rand);
		}

		private async void buttonLocLast_Click(object sender, EventArgs e)
		{
			await updateLugar(Lugar.MAX_ID);
		}

		private async void buttonLocRandom_Click(object sender, EventArgs e)
		{
			int rand = random.Next(Lugar.MIN_ID, Lugar.MAX_ID+1);
			await updateLugar(rand);
		}

		private async void textBoxIDPers_TextChanged(object sender, EventArgs e)
		{
			if (!int.TryParse(textBoxIDPers.Text, out int nuevo) || nuevo < Personaje.MIN_ID)
			{
				textBoxIDPers.Text = "";
			}
			else
			{
				if (nuevo > Personaje.MAX_ID)
				{
					textBoxIDPers.Text = id_pers.ToString();
				}
				else
				{
					await updatePersonaje(nuevo);
				}
			}
		}

		private void tabPagePersonajes_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				buttonPrevPers_Click(sender, e);
			}
		}

		private async void buttonRandPers_Click(object sender, EventArgs e)
		{
			// Test api

			/*HttpClient client1;
			client1 = new HttpClient();
			client1.BaseAddress = new Uri("https://rickandmortyapi.com/api/");
			client1.DefaultRequestHeaders.Accept.Clear();
			client1.DefaultRequestHeaders.Accept.Add(
				new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(
					"application/json")
				);
			HttpResponseMessage response = await client1.GetAsync(string.Concat("character/", id.ToString()));
			if (response.IsSuccessStatusCode)
			{
				Personaje p = await response.Content.ReadFromJsonAsync<Personaje>();
			}*/

			await updatePersonaje(random.Next(Personaje.MIN_ID, Personaje.MAX_ID + 1));
		}

		/*private void textBoxIDPers_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				textBoxIDPers_TextChanged(sender, e);
			}
		}*/
	}
}
using System.Net.Http;
using System.Net.Http.Json;

namespace Rick_And_Morty_API
{
	public partial class AppWindow : Form
	{
		private int last_id = Personaje.MIN_ID, id = Personaje.MIN_ID;
		private RickMortyAPI api;
		private Random random;
		Dictionary<int, Personaje> dicc_personajes;
		public AppWindow()
		{
			InitializeComponent();
			random = new Random();
			dicc_personajes = new Dictionary<int, Personaje>();
			api = new RickMortyAPI();
		}

		public async Task<bool> updatePersonaje(int nuevo)
		{
			try
			{
				if (Personaje.MIN_ID <= nuevo && nuevo <= Personaje.MAX_ID)
				{
					last_id = id;
					id = nuevo;
					if (!dicc_personajes.ContainsKey(nuevo))
					{
						Personaje pnuevo = await
							api.ObtenPersonaje(nuevo);
						dicc_personajes.Add(nuevo, pnuevo);
					}

					Personaje pers_up = dicc_personajes[nuevo];

					labelPersName.Text = pers_up.name;
					labelPersGender.Text = pers_up.gender;
					labelPersSpecies.Text = pers_up.species;
					labelPersStatus.Text = pers_up.status;
					labelPersType.Text = pers_up.type;
					pictureBoxPers.Image = pers_up.img_data;

					if (textBoxIDPers.Text != id.ToString())
					{
						textBoxIDPers.Text = id.ToString();
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

		private async void textBoxIDPers_TextChanged(object sender, EventArgs e)
		{
			int nuevo;
			if (!int.TryParse(textBoxIDPers.Text, out nuevo) || nuevo < Personaje.MIN_ID)
			{
				textBoxIDPers.Text = "";
			}
			else
			{
				if(nuevo > Personaje.MAX_ID)
				{
					textBoxIDPers.Text = id.ToString();
				}
				else
				{
					await updatePersonaje(nuevo);
				}
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
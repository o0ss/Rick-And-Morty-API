namespace Rick_And_Morty_API
{
    public partial class Form1 : Form
    {
        private int last_id = Personaje.MIN_ID, id;
        private RickMortyAPI api;
        private Random random;
        Dictionary<int, Personaje> dic_personajes;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            dic_personajes = new Dictionary<int, Personaje>();
            api = new RickMortyAPI();
        }

        public bool updatePersonaje(int nuevo)
        {
            if (Personaje.MIN_ID <= nuevo && nuevo <= Personaje.MAX_ID)
            {
                last_id = id;
                id = nuevo;
                if ( ! dic_personajes.ContainsKey(nuevo))
                {
                    Personaje pnuevo = 
                        api.ObtenPersonaje(nuevo).GetAwaiter().GetResult();
                    dic_personajes.Add(nuevo, pnuevo);
                }
                labelPersName.Text = dic_personajes[nuevo].name;
                return true;
            }
            return false;
        }

        private void textBoxIDPers_TextChanged(object sender, EventArgs e)
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
                    updatePersonaje(nuevo);
                }
            }
        }

        private void buttonRandPers_Click(object sender, EventArgs e)
        {
            updatePersonaje(random.Next(Personaje.MIN_ID, Personaje.MAX_ID + 1));
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
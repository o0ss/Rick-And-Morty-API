namespace Rick_And_Morty_API
{
    public partial class Form1 : Form
    {
        private int last_id = 1;
        private int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxIDPers_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIDPers.Text, out id) || id < Personaje.MIN_ID)
            {
                textBoxIDPers.Text = "";
            }
            else
            {
                if(id > Personaje.MAX_ID)
                {
                    id = last_id;
                    textBoxIDPers.Text = id.ToString();
                }
                else
                {
                    last_id = id;
                }
            }
        }

        private void textBoxIDPers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                MessageBox.Show("Pressed enter");
                textBoxIDPers_TextChanged(sender, e);
            }
        }
    }
}
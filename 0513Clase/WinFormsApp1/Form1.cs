namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            string[] razasPerrosArray = new string[5];
            razasPerrosArray[0] = "Akita";
            razasPerrosArray[1] = "Golden";
            razasPerrosArray[2] = "Quiltro";
            razasPerrosArray[3] = "Chihuahua";
            razasPerrosArray[4] = "Tú xd";

            for (int i = 0; razasPerrosArray.Length > i; i++)
            {
                listaRazasPerro.Items.Add(razasPerrosArray[i]);
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ListaPaisXCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace llenadoArgumentoString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bTAdd_Click(object sender, EventArgs e)                    // Add File
        {
            richTextBox1.Clear();

            StreamWriter escribir = new StreamWriter("Documento.txt", true);
            try
            {
                //escribir.WriteLine(tBC1.Text+tBWord.Text+tBC2.Text);
                escribir.Write(tBC1.Text + tBWord.Text + tBC2.Text);
            }
            catch
            {
                MessageBox.Show("¡Error!");
            }
            escribir.Close();

            StreamReader leer = new StreamReader("Documento.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox1.AppendText(linea);
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("¡Error!");
            }

            leer.Close();
            tBWord.Clear();
        }

        private void bTClear_Click(object sender, EventArgs e)          // Clear File
        {
            tBWord.Clear();
        }

        private void bTShow_Click(object sender, EventArgs e)           // Show File
        {
            richTextBox1.Clear();
            StreamReader leer = new StreamReader("Documento.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox1.AppendText(linea);
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("¡Error!");
            }

            leer.Close();
        }
    }
}
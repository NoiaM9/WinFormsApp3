using System.Configuration;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] valori;
        int nr_elemente;
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGenerare_Click(object sender, EventArgs e)
        {
            nr_elemente = Convert.ToInt32(TxtNr.Text);
            valori = new double[nr_elemente];
            MessageBox.Show("S-a generat un vector cu" + nr_elemente + "elemente");
        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            if (i < nr_elemente)
            {
                valori[i] = Convert.ToDouble(TxtValoare.Text);
                i++;
            }
            else
            {
                MessageBox.Show("Ati introdus toate elementele!");
            }
        }

        private void BtnAfisare_Click(object sender, EventArgs e)
        {
            LblArray.Text = "";
            for (int i = 0; i < nr_elemente; i++)
            {
                LblArray.Text += valori[i] + "; ";
            }
        }

        private void BtnSortareFor_Click(object sender, EventArgs e)
        {
            LblRezultat.Text = "";
            double aux;
            for (int n = 0; n < nr_elemente - 1; n++)
            {
                for (int i = 0; i < nr_elemente - 1; i++)
                {
                    if (valori[i] > valori[i + 1])
                    {
                        aux = valori[i];
                        valori[i] = valori[i + 1];
                        valori[i + 1] = aux;
                    }
                }
            }

            LblRezultat.Text += "Rezultat: ";
            for (int i = 0; i < nr_elemente; i++)
            {
                LblRezultat.Text += valori[i] + "; ";
            }
        }

        private void BtnSortareWhile_Click(object sender, EventArgs e)
        {

            LblRezultat.Text = "";
            Boolean sw = true;
            double aux;
            while (sw == true)
            {
                sw = false;
                for (int i = 0; i < nr_elemente - 1; i++)
                {
                    if (valori[i] < valori[i + 1])
                    {
                        aux = valori[i];
                        valori[i] = valori[i + 1];
                        valori[i + 1] = aux;
                        sw = true;
                    }
                }
            }

            LblRezultat.Text += "Rezultat: ";
            for (int i = 0; i < nr_elemente; i++)
            {
                LblRezultat.Text += valori[i] + "; ";
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            LblRezultat.Text = "";
            double min = valori[0];
            for (int i = 1; i < nr_elemente; i++)
            {
                if (min > valori[i])
                {
                    min = valori[i];
                }
            }
            LblRezultat.Text += "Rezultat: ";
            LblRezultat.Text += min.ToString();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            LblRezultat.Text = "";
            double max = valori[0];
            for (int i = 1; i < nr_elemente; i++)
            {
                if (max < valori[i])
                {
                    max = valori[i];
                }
            }
            LblRezultat.Text += "Rezultat: ";
            LblRezultat.Text += max.ToString();
        }
    }
}

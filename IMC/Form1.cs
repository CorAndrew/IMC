using System;
using System.Drawing;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        // Dichiarazione dell'array e del contatore di posizione
        double[] storicoIMC = new double[100];
        int pos = 0; // Contatore effettivo degli inserimenti

        public Form1()
        {
            InitializeComponent();
            // Collegamento eventi KeyDown via codice
            txtPeso.KeyDown += new KeyEventHandler(SoloNumeri_KeyDown);
            txtAltezza.KeyDown += new KeyEventHandler(SoloNumeri_KeyDown);
        }

        private void SoloNumeri_KeyDown(object sender, KeyEventArgs e)
        {
            // Filtro per permettere solo numeri e tasti di controllo
            bool isNumber = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9);
            bool isNumPad = (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);
            bool isControl = (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete);

            if (!isNumber && !isNumPad && !isControl)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            // Controllo che i campi non siano vuoti
            if (txtNome.Text != "" && txtPeso.Text != "" && txtAltezza.Text != "")
            {
                if (pos >= 100)
                {
                    MessageBox.Show("Memoria piena!");
                    return;
                }

                // Recupero i dati
                string nome = txtNome.Text;
                double peso = Convert.ToDouble(txtPeso.Text);
                double altezzaCm = Convert.ToDouble(txtAltezza.Text);

                // Calcolo l'IMC per salvarlo nell'array (ma non lo scrivo nella listbox)
                double altezzaM = altezzaCm / 100;
                double imc = peso / (altezzaM * altezzaM);

                // Salvataggio nell'array
                storicoIMC[pos] = imc;
                pos++;

                // Visualizzazione nella ListBox: SOLO Nome, Peso e Altezza
                string riga = $"{nome} - Peso: {peso}kg - Altezza: {altezzaCm}cm";
                listBox1.Items.Add(riga);

                // Pulizia campi
                txtNome.Clear();
                txtPeso.Clear();
                txtAltezza.Clear();
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Compila tutti i campi!");
            }
        }

        // Il tasto che stampa il messaggio in base al RadioButton
        private void button2_Click(object sender, EventArgs e)
        {
            if (pos == 0)
            {
                MessageBox.Show("Inserisci almeno un dato!");
                return;
            }

            if (radioButton1.Checked) // ultimo IMC inserito
            {
                double ultimoIMC = storicoIMC[pos - 1];

                if (ultimoIMC < 16)
                {
                    MessageBox.Show("Grave magrezza");
                }
                else if (ultimoIMC < 18.5) // Tra 16 e 18.5
                {
                    MessageBox.Show("Sottopeso");
                }
                else if (ultimoIMC < 25) // Tra 18.5 e 25
                {
                    MessageBox.Show("Normopeso");
                }
                else if (ultimoIMC < 30) // Tra 25 e 30
                {
                    MessageBox.Show("Sovrappeso");
                }
                else // Oltre 30
                {
                    MessageBox.Show("Obesità");
                }
            }
            else if (radioButton2.Checked) // Media IMC
            {
                double somma = 0;
                for (int i = 0; i < pos; i++)
                {
                    somma += storicoIMC[i];
                }
                MessageBox.Show($"La media degli IMC è: {somma / pos, 2}");
            }
            else if (radioButton3.Checked) // Moda IMC
            {
                double moda = storicoIMC[0];
                int maxConteggio = 0;
                for (int i = 0; i < pos; i++)
                {
                    int conteggio = 0;
                    for (int j = 0; j < pos; j++)
                    {
                        if (storicoIMC[j] == storicoIMC[i]) conteggio++;
                    }
                    if (conteggio > maxConteggio)
                    {
                        maxConteggio = conteggio;
                        moda = storicoIMC[i];
                    }
                }
                MessageBox.Show($"La moda degli IMC è: {moda}");
            }
            else if (radioButton4.Checked) // Mediana IMC
            {
                double[] copia = new double[pos];
                Array.Copy(storicoIMC, copia, pos);
                Array.Sort(copia);

                double mediana;
                if (pos % 2 == 0)
                    mediana = (copia[pos / 2 - 1] + copia[pos / 2]) / 2;
                else
                    mediana = copia[pos / 2];

                MessageBox.Show($"La mediana degli IMC è: {mediana}");
            }
            else if (radioButton5.Checked) // Variazione IMC
            {
                if (pos < 2)
                {
                    MessageBox.Show("Servono almeno due inserimenti per calcolare la variazione");
                }
                else
                {
                    double variazione = storicoIMC[pos - 1] - storicoIMC[pos - 2];
                    MessageBox.Show($"Variazione rispetto all'ultimo dato: {variazione}");
                }
            }
            else
            {
                MessageBox.Show("Seleziona un'operazione");
            }
        }
    }
}
namespace PO1_AssuranceAuto
{
    public partial class Form1 : Form
    {
        float[] surprimeFaibleExpérience = { 0.25f, 0.15f, 0.5f};

        public Form1()
        {
            InitializeComponent();
        }

        private void button_CalculerPrime_Click(object sender, EventArgs e)
        {
            bool parseValeurOk = float.TryParse(textBox_valeur.Text, out float valeur);
            if(!parseValeurOk)
            {
                MessageBox.Show("La valeur n'est pas un nombre valide");
                return;
            }
            parseValeurOk =  int.TryParse(textBox_anneesExperience.Text, out int nbAnneesExperience);
            if (!parseValeurOk)
            {
                MessageBox.Show("Le nombre d'années d'expérience n'est pas un nombre valide");
                return;
            }
            parseValeurOk =  int.TryParse(textBox_accidentResponsable.Text, out int nbAccidentsResponsables);
            if (!parseValeurOk)
            {
                MessageBox.Show("Le nombre d'accidents responsables n'est pas un nombre valide");
                return;
            }
            parseValeurOk = int.TryParse(textBox_pointsInaptitudePerdus.Text, out int nbPointsInaptitudePerdus);
            if (!parseValeurOk)
            {
                MessageBox.Show("Le nombre de points d'inaptitude perdus n'est pas un nombre valide");
                return;
            }
            if(!radioButton_creditBon.Checked && !radioButton_creditMediocre.Checked)
            {
                MessageBox.Show("Veuillez sélectionner un type de crédit");
                return;
            }

            float prime = 250 + 0.05f * valeur;
            if (radioButton_creditMediocre.Checked)
            {
                prime = 1.25f * prime;
            }
            
            if(nbAnneesExperience < surprimeFaibleExpérience.Length)
            {
                prime = prime * (1+surprimeFaibleExpérience[nbAnneesExperience]);
            }

            if(nbAccidentsResponsables > 0)
            {
                prime = (float)(prime * Math.Pow(1 + 0.25d , nbAccidentsResponsables));
            }

            if(nbPointsInaptitudePerdus > 0)
            {
                prime = (float)(prime * Math.Pow(1 + 0.03d, nbPointsInaptitudePerdus));
            }

            MessageBox.Show("La prime est de " + prime + "$");
        }
    }
}

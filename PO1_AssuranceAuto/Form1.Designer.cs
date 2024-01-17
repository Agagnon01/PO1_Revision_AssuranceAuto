namespace PO1_AssuranceAuto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_anneesExperience = new Label();
            textBox_anneesExperience = new TextBox();
            label_valeur = new Label();
            label_accidentResponsable = new Label();
            label_pointsInaptitudePerdus = new Label();
            radioButton_creditBon = new RadioButton();
            textBox_valeur = new TextBox();
            textBox_accidentResponsable = new TextBox();
            textBox_pointsInaptitudePerdus = new TextBox();
            radioButton_creditMediocre = new RadioButton();
            label_credit = new Label();
            button_CalculerPrime = new Button();
            SuspendLayout();
            // 
            // label_anneesExperience
            // 
            label_anneesExperience.AutoSize = true;
            label_anneesExperience.Location = new Point(12, 42);
            label_anneesExperience.Name = "label_anneesExperience";
            label_anneesExperience.Size = new Size(214, 20);
            label_anneesExperience.TabIndex = 0;
            label_anneesExperience.Text = "Nombre d'années d'expérience";
            // 
            // textBox_anneesExperience
            // 
            textBox_anneesExperience.Location = new Point(309, 39);
            textBox_anneesExperience.Name = "textBox_anneesExperience";
            textBox_anneesExperience.Size = new Size(125, 27);
            textBox_anneesExperience.TabIndex = 1;
            // 
            // label_valeur
            // 
            label_valeur.AutoSize = true;
            label_valeur.Location = new Point(12, 9);
            label_valeur.Name = "label_valeur";
            label_valeur.Size = new Size(129, 20);
            label_valeur.TabIndex = 2;
            label_valeur.Text = "Valeur du véhicule";
            // 
            // label_accidentResponsable
            // 
            label_accidentResponsable.AutoSize = true;
            label_accidentResponsable.Location = new Point(13, 75);
            label_accidentResponsable.Name = "label_accidentResponsable";
            label_accidentResponsable.Size = new Size(220, 20);
            label_accidentResponsable.TabIndex = 3;
            label_accidentResponsable.Text = "Nombre d'accident responsable";
            // 
            // label_pointsInaptitudePerdus
            // 
            label_pointsInaptitudePerdus.AutoSize = true;
            label_pointsInaptitudePerdus.Location = new Point(12, 108);
            label_pointsInaptitudePerdus.Name = "label_pointsInaptitudePerdus";
            label_pointsInaptitudePerdus.Size = new Size(257, 20);
            label_pointsInaptitudePerdus.TabIndex = 5;
            label_pointsInaptitudePerdus.Text = "Nombre de point d'inaptitude perdus";
            // 
            // radioButton_creditBon
            // 
            radioButton_creditBon.AutoSize = true;
            radioButton_creditBon.Location = new Point(309, 138);
            radioButton_creditBon.Name = "radioButton_creditBon";
            radioButton_creditBon.Size = new Size(56, 24);
            radioButton_creditBon.TabIndex = 6;
            radioButton_creditBon.TabStop = true;
            radioButton_creditBon.Text = "Bon";
            radioButton_creditBon.UseVisualStyleBackColor = true;
            // 
            // textBox_valeur
            // 
            textBox_valeur.Location = new Point(309, 6);
            textBox_valeur.Name = "textBox_valeur";
            textBox_valeur.Size = new Size(125, 27);
            textBox_valeur.TabIndex = 7;
            // 
            // textBox_accidentResponsable
            // 
            textBox_accidentResponsable.Location = new Point(309, 72);
            textBox_accidentResponsable.Name = "textBox_accidentResponsable";
            textBox_accidentResponsable.Size = new Size(125, 27);
            textBox_accidentResponsable.TabIndex = 8;
            // 
            // textBox_pointsInaptitudePerdus
            // 
            textBox_pointsInaptitudePerdus.Location = new Point(309, 105);
            textBox_pointsInaptitudePerdus.Name = "textBox_pointsInaptitudePerdus";
            textBox_pointsInaptitudePerdus.Size = new Size(125, 27);
            textBox_pointsInaptitudePerdus.TabIndex = 9;
            // 
            // radioButton_creditMediocre
            // 
            radioButton_creditMediocre.AutoSize = true;
            radioButton_creditMediocre.Location = new Point(386, 138);
            radioButton_creditMediocre.Name = "radioButton_creditMediocre";
            radioButton_creditMediocre.Size = new Size(93, 24);
            radioButton_creditMediocre.TabIndex = 11;
            radioButton_creditMediocre.TabStop = true;
            radioButton_creditMediocre.Text = "Médiocre";
            radioButton_creditMediocre.UseVisualStyleBackColor = true;
            // 
            // label_credit
            // 
            label_credit.AutoSize = true;
            label_credit.Location = new Point(13, 140);
            label_credit.Name = "label_credit";
            label_credit.Size = new Size(121, 20);
            label_credit.TabIndex = 12;
            label_credit.Text = "Dossier de crédit";
            // 
            // button_CalculerPrime
            // 
            button_CalculerPrime.Location = new Point(13, 181);
            button_CalculerPrime.Name = "button_CalculerPrime";
            button_CalculerPrime.Size = new Size(156, 29);
            button_CalculerPrime.TabIndex = 13;
            button_CalculerPrime.Text = "Calculer la prime";
            button_CalculerPrime.UseVisualStyleBackColor = true;
            button_CalculerPrime.Click += button_CalculerPrime_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_CalculerPrime);
            Controls.Add(label_credit);
            Controls.Add(radioButton_creditMediocre);
            Controls.Add(textBox_pointsInaptitudePerdus);
            Controls.Add(textBox_accidentResponsable);
            Controls.Add(textBox_valeur);
            Controls.Add(radioButton_creditBon);
            Controls.Add(label_pointsInaptitudePerdus);
            Controls.Add(label_accidentResponsable);
            Controls.Add(label_valeur);
            Controls.Add(textBox_anneesExperience);
            Controls.Add(label_anneesExperience);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_anneesExperience;
        private TextBox textBox_anneesExperience;
        private Label label_valeur;
        private Label label_accidentResponsable;
        private Label label_pointsInaptitudePerdus;
        private RadioButton radioButton_creditBon;
        private TextBox textBox_valeur;
        private TextBox textBox_accidentResponsable;
        private TextBox textBox_pointsInaptitudePerdus;
        private RadioButton radioButton_creditMediocre;
        private Label label_credit;
        private Button button_CalculerPrime;
    }
}

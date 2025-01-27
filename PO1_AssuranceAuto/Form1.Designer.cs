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
            textBox_valeur = new TextBox();
            textBox_accidentResponsable = new TextBox();
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
            // button_CalculerPrime
            // 
            button_CalculerPrime.Location = new Point(13, 111);
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
            Controls.Add(textBox_accidentResponsable);
            Controls.Add(textBox_valeur);
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
        private TextBox textBox_valeur;
        private TextBox textBox_accidentResponsable;
        private Button button_CalculerPrime;
    }
}

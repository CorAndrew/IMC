namespace IMC
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
            txtNome = new TextBox();
            panel1 = new Panel();
            btnCarica = new Button();
            button2 = new Button();
            btnSalva = new Button();
            txtPeso = new TextBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnInserisci = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            txtAltezza = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(33, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnCarica);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnSalva);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(btnInserisci);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAltezza);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 1;
            // 
            // btnCarica
            // 
            btnCarica.Location = new Point(569, 385);
            btnCarica.Name = "btnCarica";
            btnCarica.Size = new Size(58, 38);
            btnCarica.TabIndex = 18;
            btnCarica.Text = "Carica";
            btnCarica.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(497, 385);
            button2.Name = "button2";
            button2.Size = new Size(66, 38);
            button2.TabIndex = 17;
            button2.Text = "Esegui";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(633, 385);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(58, 38);
            btnSalva.TabIndex = 16;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(283, 3);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(80, 23);
            txtPeso.TabIndex = 15;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(398, 395);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(93, 19);
            radioButton5.TabIndex = 14;
            radioButton5.TabStop = true;
            radioButton5.Text = "Varianza IMC";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(299, 395);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(93, 19);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "MedianaIMC";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(123, 395);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(81, 19);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Moda IMC";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(210, 395);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Media IMC";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(27, 395);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Calcolo IMC";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnInserisci
            // 
            btnInserisci.Location = new Point(697, 385);
            btnInserisci.Name = "btnInserisci";
            btnInserisci.Size = new Size(66, 38);
            btnInserisci.TabIndex = 8;
            btnInserisci.Text = "Avvia";
            btnInserisci.UseVisualStyleBackColor = true;
            btnInserisci.Click += btnInserisci_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 45);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(770, 334);
            listBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(594, 6);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 5;
            label3.Text = "Altezza (in cm)";
            // 
            // txtAltezza
            // 
            txtAltezza.Location = new Point(508, 6);
            txtAltezza.Name = "txtAltezza";
            txtAltezza.Size = new Size(80, 23);
            txtAltezza.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 6);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Peso (in kg)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 6);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome e Cognome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private Panel panel1;
        private Label label1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnInserisci;
        private ListBox listBox1;
        private Label label3;
        private TextBox txtAltezza;
        private Label label2;
        private RadioButton radioButton5;
        private TextBox txtPeso;
        private Button button2;
        private Button btnSalva;
        private Button btnCarica;
    }
}

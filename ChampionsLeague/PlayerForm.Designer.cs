namespace ChampionsLeague
{
    partial class PlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKlub = new System.Windows.Forms.ComboBox();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.textBoxGoals = new System.Windows.Forms.TextBox();
            this.buttonStorno = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Klub:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Počet gólů:";
            // 
            // comboBoxKlub
            // 
            this.comboBoxKlub.FormattingEnabled = true;
            this.comboBoxKlub.Location = new System.Drawing.Point(100, 44);
            this.comboBoxKlub.Name = "comboBoxKlub";
            this.comboBoxKlub.Size = new System.Drawing.Size(227, 28);
            this.comboBoxKlub.TabIndex = 3;
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(100, 6);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(227, 27);
            this.textBoxJmeno.TabIndex = 4;
            // 
            // textBoxGoals
            // 
            this.textBoxGoals.Location = new System.Drawing.Point(100, 81);
            this.textBoxGoals.Name = "textBoxGoals";
            this.textBoxGoals.Size = new System.Drawing.Size(227, 27);
            this.textBoxGoals.TabIndex = 5;
            // 
            // buttonStorno
            // 
            this.buttonStorno.Location = new System.Drawing.Point(12, 130);
            this.buttonStorno.Name = "buttonStorno";
            this.buttonStorno.Size = new System.Drawing.Size(94, 29);
            this.buttonStorno.TabIndex = 6;
            this.buttonStorno.Text = "Storno";
            this.buttonStorno.UseVisualStyleBackColor = true;
            this.buttonStorno.Click += new System.EventHandler(this.buttonStorno_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(253, 130);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 29);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 171);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonStorno);
            this.Controls.Add(this.textBoxGoals);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.comboBoxKlub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxKlub;
        private TextBox textBoxJmeno;
        private TextBox textBoxGoals;
        private Button buttonStorno;
        private Button buttonOK;
    }
}
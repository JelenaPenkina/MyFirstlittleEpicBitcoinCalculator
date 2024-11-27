namespace WindowsBitcoinCalculator
{
    partial class Form1
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
            this.ValiValuuta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tulemus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ValiValuuta
            // 
            this.ValiValuuta.FormattingEnabled = true;
            this.ValiValuuta.Items.AddRange(new object[] {
            "EUR",
            "GBP",
            "EEK"});
            this.ValiValuuta.Location = new System.Drawing.Point(667, 116);
            this.ValiValuuta.Name = "ValiValuuta";
            this.ValiValuuta.Size = new System.Drawing.Size(121, 21);
            this.ValiValuuta.TabIndex = 0;
            this.ValiValuuta.Text = "Vali valuuta";
            this.ValiValuuta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Arvuta bitcoin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(667, 76);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(121, 20);
            this.box2.TabIndex = 2;
            this.box2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(664, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sisesta Bitcoini arv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(664, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tulemus";
            // 
            // tulemus
            // 
            this.tulemus.BackColor = System.Drawing.SystemColors.Menu;
            this.tulemus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tulemus.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tulemus.Location = new System.Drawing.Point(667, 244);
            this.tulemus.Name = "tulemus";
            this.tulemus.Size = new System.Drawing.Size(121, 49);
            this.tulemus.TabIndex = 5;
            this.tulemus.Text = "None";
            this.tulemus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsBitcoinCalculator.Properties.Resources.Hõiva;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tulemus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ValiValuuta);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "BitcoinCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ValiValuuta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tulemus;
    }
}


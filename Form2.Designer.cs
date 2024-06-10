namespace NIko_Arar_3_C_projekt
{
    partial class korisnik
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
            this.button2 = new System.Windows.Forms.Button();
            this.izborkvizova = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prvi = new System.Windows.Forms.Button();
            this.drugi = new System.Windows.Forms.Button();
            this.treci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zaigraj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // izborkvizova
            // 
            this.izborkvizova.FormattingEnabled = true;
            this.izborkvizova.Location = new System.Drawing.Point(48, 136);
            this.izborkvizova.Name = "izborkvizova";
            this.izborkvizova.Size = new System.Drawing.Size(280, 21);
            this.izborkvizova.TabIndex = 2;
            this.izborkvizova.SelectedIndexChanged += new System.EventHandler(this.izborkvizova_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberi kviz";
            // 
            // prvi
            // 
            this.prvi.Location = new System.Drawing.Point(414, 83);
            this.prvi.Name = "prvi";
            this.prvi.Size = new System.Drawing.Size(289, 104);
            this.prvi.TabIndex = 4;
            this.prvi.Text = "Prvo Mjesto";
            this.prvi.UseVisualStyleBackColor = true;
            // 
            // drugi
            // 
            this.drugi.Location = new System.Drawing.Point(414, 221);
            this.drugi.Name = "drugi";
            this.drugi.Size = new System.Drawing.Size(289, 71);
            this.drugi.TabIndex = 5;
            this.drugi.Text = "Drugo Mjesto";
            this.drugi.UseVisualStyleBackColor = true;
            // 
            // treci
            // 
            this.treci.Location = new System.Drawing.Point(414, 323);
            this.treci.Name = "treci";
            this.treci.Size = new System.Drawing.Size(289, 40);
            this.treci.TabIndex = 6;
            this.treci.Text = "Treće mjesto";
            this.treci.UseVisualStyleBackColor = true;
            // 
            // korisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treci);
            this.Controls.Add(this.drugi);
            this.Controls.Add(this.prvi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izborkvizova);
            this.Controls.Add(this.button2);
            this.Name = "korisnik";
            this.Text = "Korisnik";
            this.Load += new System.EventHandler(this.korisnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox izborkvizova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prvi;
        private System.Windows.Forms.Button drugi;
        private System.Windows.Forms.Button treci;
    }
}
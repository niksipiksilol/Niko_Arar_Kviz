namespace NIko_Arar_3_C_projekt
{
    partial class Prijava
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Sifra_upis = new System.Windows.Forms.Label();
            this.Ime_prijava = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sifra_textbox = new System.Windows.Forms.TextBox();
            this.ime_upis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Prijavi se";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "👀";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sifra_upis
            // 
            this.Sifra_upis.AutoSize = true;
            this.Sifra_upis.Location = new System.Drawing.Point(232, 211);
            this.Sifra_upis.Name = "Sifra_upis";
            this.Sifra_upis.Size = new System.Drawing.Size(31, 13);
            this.Sifra_upis.TabIndex = 5;
            this.Sifra_upis.Text = "Šifra:";
            // 
            // Ime_prijava
            // 
            this.Ime_prijava.AutoSize = true;
            this.Ime_prijava.Location = new System.Drawing.Point(232, 147);
            this.Ime_prijava.Name = "Ime_prijava";
            this.Ime_prijava.Size = new System.Drawing.Size(24, 13);
            this.Ime_prijava.TabIndex = 6;
            this.Ime_prijava.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label1.Location = new System.Drawing.Point(276, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "PRIJAVI SE";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sifra_textbox
            // 
            this.sifra_textbox.Location = new System.Drawing.Point(270, 210);
            this.sifra_textbox.Name = "sifra_textbox";
            this.sifra_textbox.Size = new System.Drawing.Size(226, 20);
            this.sifra_textbox.TabIndex = 9;
            this.sifra_textbox.UseSystemPasswordChar = true;
            // 
            // ime_upis
            // 
            this.ime_upis.Location = new System.Drawing.Point(270, 147);
            this.ime_upis.Name = "ime_upis";
            this.ime_upis.Size = new System.Drawing.Size(226, 20);
            this.ime_upis.TabIndex = 10;
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ime_upis);
            this.Controls.Add(this.sifra_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ime_prijava);
            this.Controls.Add(this.Sifra_upis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Prijava";
            this.Text = "MEGA KVIZ, PRIJAVI SE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Sifra_upis;
        private System.Windows.Forms.Label Ime_prijava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox sifra_textbox;
        private System.Windows.Forms.TextBox ime_upis;
    }
}


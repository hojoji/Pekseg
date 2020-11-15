namespace Pekseg
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mentes = new System.Windows.Forms.CheckBox();
            this.input_ar = new System.Windows.Forms.NumericUpDown();
            this.lbPekseg = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.peksegName = new System.Windows.Forms.TextBox();
            this.peksegFelvesz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_nev = new System.Windows.Forms.TextBox();
            this.felveszbtn = new System.Windows.Forms.Button();
            this.lbPekaru = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.peksegArui = new System.Windows.Forms.ListBox();
            this.hozzaad = new System.Windows.Forms.Button();
            this.torol = new System.Windows.Forms.Button();
            this.adatok = new System.Windows.Forms.Label();
            this.peksegek = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_ar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.torol);
            this.tabPage1.Controls.Add(this.hozzaad);
            this.tabPage1.Controls.Add(this.peksegArui);
            this.tabPage1.Controls.Add(this.mentes);
            this.tabPage1.Controls.Add(this.input_ar);
            this.tabPage1.Controls.Add(this.lbPekseg);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.peksegName);
            this.tabPage1.Controls.Add(this.peksegFelvesz);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.input_nev);
            this.tabPage1.Controls.Add(this.felveszbtn);
            this.tabPage1.Controls.Add(this.lbPekaru);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(388, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mentes
            // 
            this.mentes.AutoSize = true;
            this.mentes.Location = new System.Drawing.Point(8, 66);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(88, 17);
            this.mentes.TabIndex = 15;
            this.mentes.Text = "laktózmentes";
            this.mentes.UseVisualStyleBackColor = true;
            // 
            // input_ar
            // 
            this.input_ar.Location = new System.Drawing.Point(34, 40);
            this.input_ar.Name = "input_ar";
            this.input_ar.Size = new System.Drawing.Size(90, 20);
            this.input_ar.TabIndex = 14;
            // 
            // lbPekseg
            // 
            this.lbPekseg.FormattingEnabled = true;
            this.lbPekseg.Location = new System.Drawing.Point(151, 193);
            this.lbPekseg.Name = "lbPekseg";
            this.lbPekseg.Size = new System.Drawing.Size(229, 95);
            this.lbPekseg.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "név:";
            // 
            // peksegName
            // 
            this.peksegName.Location = new System.Drawing.Point(34, 218);
            this.peksegName.Name = "peksegName";
            this.peksegName.Size = new System.Drawing.Size(62, 20);
            this.peksegName.TabIndex = 11;
            this.peksegName.TextChanged += new System.EventHandler(this.PeksegName_TextChanged);
            // 
            // peksegFelvesz
            // 
            this.peksegFelvesz.Location = new System.Drawing.Point(3, 244);
            this.peksegFelvesz.Name = "peksegFelvesz";
            this.peksegFelvesz.Size = new System.Drawing.Size(68, 33);
            this.peksegFelvesz.TabIndex = 10;
            this.peksegFelvesz.Text = "felvesz";
            this.peksegFelvesz.UseVisualStyleBackColor = true;
            this.peksegFelvesz.Click += new System.EventHandler(this.PeksegFelvesz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pékség:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ár: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "név:";
            // 
            // input_nev
            // 
            this.input_nev.Location = new System.Drawing.Point(37, 14);
            this.input_nev.Name = "input_nev";
            this.input_nev.Size = new System.Drawing.Size(87, 20);
            this.input_nev.TabIndex = 2;
            // 
            // felveszbtn
            // 
            this.felveszbtn.Location = new System.Drawing.Point(6, 105);
            this.felveszbtn.Name = "felveszbtn";
            this.felveszbtn.Size = new System.Drawing.Size(68, 33);
            this.felveszbtn.TabIndex = 1;
            this.felveszbtn.Text = "felvesz";
            this.felveszbtn.UseVisualStyleBackColor = true;
            this.felveszbtn.Click += new System.EventHandler(this.Felveszbtn_Click);
            // 
            // lbPekaru
            // 
            this.lbPekaru.FormattingEnabled = true;
            this.lbPekaru.Location = new System.Drawing.Point(151, 14);
            this.lbPekaru.Name = "lbPekaru";
            this.lbPekaru.Size = new System.Drawing.Size(229, 173);
            this.lbPekaru.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.peksegek);
            this.tabPage2.Controls.Add(this.adatok);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(388, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // peksegArui
            // 
            this.peksegArui.FormattingEnabled = true;
            this.peksegArui.Location = new System.Drawing.Point(151, 294);
            this.peksegArui.Name = "peksegArui";
            this.peksegArui.Size = new System.Drawing.Size(229, 82);
            this.peksegArui.TabIndex = 16;
            // 
            // hozzaad
            // 
            this.hozzaad.Location = new System.Drawing.Point(106, 294);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(39, 82);
            this.hozzaad.TabIndex = 17;
            this.hozzaad.Text = "+";
            this.hozzaad.UseVisualStyleBackColor = true;
            this.hozzaad.Click += new System.EventHandler(this.Hozzaad_Click);
            // 
            // torol
            // 
            this.torol.Location = new System.Drawing.Point(77, 105);
            this.torol.Name = "torol";
            this.torol.Size = new System.Drawing.Size(68, 33);
            this.torol.TabIndex = 18;
            this.torol.Text = "töröl";
            this.torol.UseVisualStyleBackColor = true;
            this.torol.Click += new System.EventHandler(this.Torol_Click);
            // 
            // adatok
            // 
            this.adatok.AutoSize = true;
            this.adatok.Location = new System.Drawing.Point(128, 6);
            this.adatok.Name = "adatok";
            this.adatok.Size = new System.Drawing.Size(35, 13);
            this.adatok.TabIndex = 1;
            this.adatok.Text = "label3";
            // 
            // peksegek
            // 
            this.peksegek.FormattingEnabled = true;
            this.peksegek.Location = new System.Drawing.Point(8, 6);
            this.peksegek.Name = "peksegek";
            this.peksegek.Size = new System.Drawing.Size(103, 134);
            this.peksegek.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 429);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_ar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_nev;
        private System.Windows.Forms.Button felveszbtn;
        private System.Windows.Forms.ListBox lbPekaru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox peksegName;
        private System.Windows.Forms.Button peksegFelvesz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbPekseg;
        private System.Windows.Forms.NumericUpDown input_ar;
        private System.Windows.Forms.CheckBox mentes;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.ListBox peksegArui;
        private System.Windows.Forms.Button torol;
        private System.Windows.Forms.Label adatok;
        private System.Windows.Forms.ListBox peksegek;
    }
}


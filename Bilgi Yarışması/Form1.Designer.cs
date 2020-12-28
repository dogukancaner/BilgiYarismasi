
namespace Bilgi_Yarışması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttona = new System.Windows.Forms.Button();
            this.buttonb = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.buttond = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelsoruno = new System.Windows.Forms.Label();
            this.labeldogru = new System.Windows.Forms.Label();
            this.labelyanlis = new System.Windows.Forms.Label();
            this.buttonsonraki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(565, 202);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttona
            // 
            this.buttona.Location = new System.Drawing.Point(82, 220);
            this.buttona.Name = "buttona";
            this.buttona.Size = new System.Drawing.Size(210, 48);
            this.buttona.TabIndex = 1;
            this.buttona.Text = "A";
            this.buttona.UseVisualStyleBackColor = true;
            this.buttona.Click += new System.EventHandler(this.buttona_Click);
            // 
            // buttonb
            // 
            this.buttonb.Location = new System.Drawing.Point(298, 220);
            this.buttonb.Name = "buttonb";
            this.buttonb.Size = new System.Drawing.Size(210, 48);
            this.buttonb.TabIndex = 2;
            this.buttonb.Text = "B";
            this.buttonb.UseVisualStyleBackColor = true;
            this.buttonb.Click += new System.EventHandler(this.buttonb_Click);
            // 
            // buttonc
            // 
            this.buttonc.Location = new System.Drawing.Point(82, 276);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(210, 48);
            this.buttonc.TabIndex = 3;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.buttonc_Click);
            // 
            // buttond
            // 
            this.buttond.Location = new System.Drawing.Point(298, 276);
            this.buttond.Name = "buttond";
            this.buttond.Size = new System.Drawing.Size(210, 46);
            this.buttond.TabIndex = 4;
            this.buttond.Text = "D";
            this.buttond.UseVisualStyleBackColor = true;
            this.buttond.Click += new System.EventHandler(this.buttond_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış Sayısı:";
            // 
            // labelsoruno
            // 
            this.labelsoruno.AutoSize = true;
            this.labelsoruno.Location = new System.Drawing.Point(755, 15);
            this.labelsoruno.Name = "labelsoruno";
            this.labelsoruno.Size = new System.Drawing.Size(25, 29);
            this.labelsoruno.TabIndex = 8;
            this.labelsoruno.Text = "0";
            // 
            // labeldogru
            // 
            this.labeldogru.AutoSize = true;
            this.labeldogru.Location = new System.Drawing.Point(755, 54);
            this.labeldogru.Name = "labeldogru";
            this.labeldogru.Size = new System.Drawing.Size(25, 29);
            this.labeldogru.TabIndex = 9;
            this.labeldogru.Text = "0";
            // 
            // labelyanlis
            // 
            this.labelyanlis.AutoSize = true;
            this.labelyanlis.Location = new System.Drawing.Point(755, 97);
            this.labelyanlis.Name = "labelyanlis";
            this.labelyanlis.Size = new System.Drawing.Size(25, 29);
            this.labelyanlis.TabIndex = 10;
            this.labelyanlis.Text = "0";
            // 
            // buttonsonraki
            // 
            this.buttonsonraki.Location = new System.Drawing.Point(583, 156);
            this.buttonsonraki.Name = "buttonsonraki";
            this.buttonsonraki.Size = new System.Drawing.Size(210, 46);
            this.buttonsonraki.TabIndex = 11;
            this.buttonsonraki.Text = "Sonraki Soru";
            this.buttonsonraki.UseVisualStyleBackColor = true;
            this.buttonsonraki.Click += new System.EventHandler(this.buttonsonraki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(604, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(706, 220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(814, 328);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonsonraki);
            this.Controls.Add(this.labelyanlis);
            this.Controls.Add(this.labeldogru);
            this.Controls.Add(this.labelsoruno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttond);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.buttonb);
            this.Controls.Add(this.buttona);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "SoruMatik";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttona;
        private System.Windows.Forms.Button buttonb;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Button buttond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelsoruno;
        private System.Windows.Forms.Label labeldogru;
        private System.Windows.Forms.Label labelyanlis;
        private System.Windows.Forms.Button buttonsonraki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


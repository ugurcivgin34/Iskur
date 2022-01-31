
namespace Ders21_WiNdowsForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.toplamtbx = new System.Windows.Forms.TextBox();
            this.deger1tbx = new System.Windows.Forms.TextBox();
            this.deger2tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carptbx = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Topla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toplamtbx
            // 
            this.toplamtbx.Location = new System.Drawing.Point(644, 111);
            this.toplamtbx.Name = "toplamtbx";
            this.toplamtbx.Size = new System.Drawing.Size(125, 27);
            this.toplamtbx.TabIndex = 1;
            // 
            // deger1tbx
            // 
            this.deger1tbx.Location = new System.Drawing.Point(158, 108);
            this.deger1tbx.Name = "deger1tbx";
            this.deger1tbx.Size = new System.Drawing.Size(125, 27);
            this.deger1tbx.TabIndex = 2;
            // 
            // deger2tbx
            // 
            this.deger2tbx.Location = new System.Drawing.Point(158, 172);
            this.deger2tbx.Name = "deger2tbx";
            this.deger2tbx.Size = new System.Drawing.Size(125, 27);
            this.deger2tbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // carptbx
            // 
            this.carptbx.Location = new System.Drawing.Point(644, 175);
            this.carptbx.Name = "carptbx";
            this.carptbx.Size = new System.Drawing.Size(125, 27);
            this.carptbx.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Çarp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(209, 235);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 164);
            this.listBox1.TabIndex = 8;
    
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.carptbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deger2tbx);
            this.Controls.Add(this.deger1tbx);
            this.Controls.Add(this.toplamtbx);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox toplamtbx;
        private System.Windows.Forms.TextBox deger1tbx;
        private System.Windows.Forms.TextBox deger2tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carptbx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}


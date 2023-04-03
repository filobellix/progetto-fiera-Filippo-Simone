namespace progetto_fiera
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
            this.buttonApri = new System.Windows.Forms.Button();
            this.buttonBaW = new System.Windows.Forms.Button();
            this.labelSaturazione = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackBarSaturazione = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturazione)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApri
            // 
            this.buttonApri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApri.Location = new System.Drawing.Point(686, 498);
            this.buttonApri.Name = "buttonApri";
            this.buttonApri.Size = new System.Drawing.Size(113, 50);
            this.buttonApri.TabIndex = 0;
            this.buttonApri.Text = "Apri";
            this.buttonApri.UseVisualStyleBackColor = true;
            this.buttonApri.Click += new System.EventHandler(this.buttonApri_Click_1);
            // 
            // buttonBaW
            // 
            this.buttonBaW.Location = new System.Drawing.Point(347, 302);
            this.buttonBaW.Name = "buttonBaW";
            this.buttonBaW.Size = new System.Drawing.Size(113, 50);
            this.buttonBaW.TabIndex = 1;
            this.buttonBaW.Text = "B and W";
            this.buttonBaW.UseVisualStyleBackColor = true;
            this.buttonBaW.Click += new System.EventHandler(this.buttonBaW_Click);
            // 
            // labelSaturazione
            // 
            this.labelSaturazione.AutoSize = true;
            this.labelSaturazione.Location = new System.Drawing.Point(12, 415);
            this.labelSaturazione.Name = "labelSaturazione";
            this.labelSaturazione.Size = new System.Drawing.Size(68, 15);
            this.labelSaturazione.TabIndex = 3;
            this.labelSaturazione.Text = "Saturazione";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(195, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 284);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBarSaturazione
            // 
            this.trackBarSaturazione.Location = new System.Drawing.Point(177, 415);
            this.trackBarSaturazione.Maximum = 255;
            this.trackBarSaturazione.Name = "trackBarSaturazione";
            this.trackBarSaturazione.Size = new System.Drawing.Size(582, 45);
            this.trackBarSaturazione.TabIndex = 5;
            this.trackBarSaturazione.Scroll += new System.EventHandler(this.trackBarSaturazione_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 560);
            this.Controls.Add(this.trackBarSaturazione);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSaturazione);
            this.Controls.Add(this.buttonBaW);
            this.Controls.Add(this.buttonApri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturazione)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonApri;
        private Button buttonBaW;
        private Label labelSaturazione;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private TrackBar trackBarSaturazione;
    }
}

namespace almaszedegetes
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
            this.components = new System.ComponentModel.Container();
            this.talaj = new System.Windows.Forms.Panel();
            this.kosar = new System.Windows.Forms.PictureBox();
            this.alma = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kosar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alma)).BeginInit();
            this.SuspendLayout();
            // 
            // talaj
            // 
            this.talaj.BackColor = System.Drawing.Color.SaddleBrown;
            this.talaj.Location = new System.Drawing.Point(0, 468);
            this.talaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.talaj.Name = "talaj";
            this.talaj.Size = new System.Drawing.Size(1048, 103);
            this.talaj.TabIndex = 0;
            // 
            // kosar
            // 
            this.kosar.Image = global::almaszedegetes.Properties.Resources.kosar;
            this.kosar.Location = new System.Drawing.Point(332, 395);
            this.kosar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kosar.Name = "kosar";
            this.kosar.Size = new System.Drawing.Size(160, 76);
            this.kosar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kosar.TabIndex = 2;
            this.kosar.TabStop = false;
            // 
            // alma
            // 
            this.alma.Image = global::almaszedegetes.Properties.Resources.alma;
            this.alma.Location = new System.Drawing.Point(368, 15);
            this.alma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alma.Name = "alma";
            this.alma.Size = new System.Drawing.Size(96, 82);
            this.alma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alma.TabIndex = 1;
            this.alma.TabStop = false;
            this.alma.Click += new System.EventHandler(this.alma_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1043, 558);
            this.Controls.Add(this.kosar);
            this.Controls.Add(this.alma);
            this.Controls.Add(this.talaj);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1061, 605);
            this.MinimumSize = new System.Drawing.Size(1061, 605);
            this.Name = "Form1";
            this.Text = "Szedd össze az almákat";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kosar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel talaj;
        private System.Windows.Forms.PictureBox alma;
        private System.Windows.Forms.PictureBox kosar;
        private System.Windows.Forms.Timer timer1;
    }
}


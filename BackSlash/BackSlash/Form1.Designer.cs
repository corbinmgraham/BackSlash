namespace BackSlash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.question = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.PictureBox();
            this.no = new System.Windows.Forms.PictureBox();
            this.load = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no)).BeginInit();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.ForeColor = System.Drawing.Color.White;
            this.question.Location = new System.Drawing.Point(41, 9);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(77, 20);
            this.question.TabIndex = 0;
            this.question.Text = "Authorize";
            // 
            // yes
            // 
            this.yes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yes.BackgroundImage")));
            this.yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yes.Location = new System.Drawing.Point(12, 32);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(64, 64);
            this.yes.TabIndex = 1;
            this.yes.TabStop = false;
            this.yes.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // no
            // 
            this.no.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("no.BackgroundImage")));
            this.no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.no.Location = new System.Drawing.Point(82, 32);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(64, 64);
            this.no.TabIndex = 2;
            this.no.TabStop = false;
            this.no.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // load
            // 
            this.load.Tick += new System.EventHandler(this.load_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(158, 114);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackSlash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.PictureBox yes;
        private System.Windows.Forms.PictureBox no;
        private System.Windows.Forms.Timer load;
    }
}


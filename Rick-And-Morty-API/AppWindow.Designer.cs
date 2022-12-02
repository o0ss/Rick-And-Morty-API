namespace Rick_And_Morty_API
{
    partial class AppWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePersonajes = new System.Windows.Forms.TabPage();
            this.textBoxIDPers = new System.Windows.Forms.TextBox();
            this.buttonLastPers = new System.Windows.Forms.Button();
            this.buttonNextPers = new System.Windows.Forms.Button();
            this.buttonPrevPers = new System.Windows.Forms.Button();
            this.buttonRandPers = new System.Windows.Forms.Button();
            this.buttonFirstPers = new System.Windows.Forms.Button();
            this.pictureBoxPers = new System.Windows.Forms.PictureBox();
            this.labelPersName = new System.Windows.Forms.Label();
            this.tabPageLugares = new System.Windows.Forms.TabPage();
            this.tabPageEpisodios = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPagePersonajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePersonajes);
            this.tabControl1.Controls.Add(this.tabPageLugares);
            this.tabControl1.Controls.Add(this.tabPageEpisodios);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 588);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePersonajes
            // 
            this.tabPagePersonajes.Controls.Add(this.textBoxIDPers);
            this.tabPagePersonajes.Controls.Add(this.buttonLastPers);
            this.tabPagePersonajes.Controls.Add(this.buttonNextPers);
            this.tabPagePersonajes.Controls.Add(this.buttonPrevPers);
            this.tabPagePersonajes.Controls.Add(this.buttonRandPers);
            this.tabPagePersonajes.Controls.Add(this.buttonFirstPers);
            this.tabPagePersonajes.Controls.Add(this.pictureBoxPers);
            this.tabPagePersonajes.Controls.Add(this.labelPersName);
            this.tabPagePersonajes.Location = new System.Drawing.Point(4, 24);
            this.tabPagePersonajes.Name = "tabPagePersonajes";
            this.tabPagePersonajes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonajes.Size = new System.Drawing.Size(743, 560);
            this.tabPagePersonajes.TabIndex = 0;
            this.tabPagePersonajes.Text = "Personajes";
            this.tabPagePersonajes.UseVisualStyleBackColor = true;
            // 
            // textBoxIDPers
            // 
            this.textBoxIDPers.Location = new System.Drawing.Point(127, 15);
            this.textBoxIDPers.MaxLength = 3;
            this.textBoxIDPers.Name = "textBoxIDPers";
            this.textBoxIDPers.PlaceholderText = "ID";
            this.textBoxIDPers.Size = new System.Drawing.Size(80, 23);
            this.textBoxIDPers.TabIndex = 8;
            this.textBoxIDPers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDPers.TextChanged += new System.EventHandler(this.textBoxIDPers_TextChanged);
            this.textBoxIDPers.Leave += new System.EventHandler(this.textBoxIDPers_TextChanged);
            // 
            // buttonLastPers
            // 
            this.buttonLastPers.Location = new System.Drawing.Point(257, 15);
            this.buttonLastPers.Name = "buttonLastPers";
            this.buttonLastPers.Size = new System.Drawing.Size(38, 23);
            this.buttonLastPers.TabIndex = 7;
            this.buttonLastPers.Text = ">>";
            this.buttonLastPers.UseVisualStyleBackColor = true;
            // 
            // buttonNextPers
            // 
            this.buttonNextPers.Location = new System.Drawing.Point(213, 15);
            this.buttonNextPers.Name = "buttonNextPers";
            this.buttonNextPers.Size = new System.Drawing.Size(38, 23);
            this.buttonNextPers.TabIndex = 6;
            this.buttonNextPers.Text = ">";
            this.buttonNextPers.UseVisualStyleBackColor = true;
            // 
            // buttonPrevPers
            // 
            this.buttonPrevPers.Location = new System.Drawing.Point(83, 15);
            this.buttonPrevPers.Name = "buttonPrevPers";
            this.buttonPrevPers.Size = new System.Drawing.Size(38, 23);
            this.buttonPrevPers.TabIndex = 5;
            this.buttonPrevPers.Text = "<";
            this.buttonPrevPers.UseVisualStyleBackColor = true;
            // 
            // buttonRandPers
            // 
            this.buttonRandPers.Location = new System.Drawing.Point(353, 15);
            this.buttonRandPers.Name = "buttonRandPers";
            this.buttonRandPers.Size = new System.Drawing.Size(75, 23);
            this.buttonRandPers.TabIndex = 4;
            this.buttonRandPers.Text = "Random";
            this.buttonRandPers.UseVisualStyleBackColor = true;
            this.buttonRandPers.Click += new System.EventHandler(this.buttonRandPers_Click);
            // 
            // buttonFirstPers
            // 
            this.buttonFirstPers.Location = new System.Drawing.Point(39, 15);
            this.buttonFirstPers.Name = "buttonFirstPers";
            this.buttonFirstPers.Size = new System.Drawing.Size(38, 23);
            this.buttonFirstPers.TabIndex = 3;
            this.buttonFirstPers.Text = "<<";
            this.buttonFirstPers.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPers
            // 
            this.pictureBoxPers.Location = new System.Drawing.Point(6, 60);
            this.pictureBoxPers.Name = "pictureBoxPers";
            this.pictureBoxPers.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxPers.TabIndex = 1;
            this.pictureBoxPers.TabStop = false;
            // 
            // labelPersName
            // 
            this.labelPersName.AutoSize = true;
            this.labelPersName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPersName.Location = new System.Drawing.Point(162, 60);
            this.labelPersName.Name = "labelPersName";
            this.labelPersName.Size = new System.Drawing.Size(81, 25);
            this.labelPersName.TabIndex = 0;
            this.labelPersName.Text = "Nombre";
            // 
            // tabPageLugares
            // 
            this.tabPageLugares.Location = new System.Drawing.Point(4, 24);
            this.tabPageLugares.Name = "tabPageLugares";
            this.tabPageLugares.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLugares.Size = new System.Drawing.Size(743, 560);
            this.tabPageLugares.TabIndex = 1;
            this.tabPageLugares.Text = "Lugares";
            this.tabPageLugares.UseVisualStyleBackColor = true;
            // 
            // tabPageEpisodios
            // 
            this.tabPageEpisodios.Location = new System.Drawing.Point(4, 24);
            this.tabPageEpisodios.Name = "tabPageEpisodios";
            this.tabPageEpisodios.Size = new System.Drawing.Size(743, 560);
            this.tabPageEpisodios.TabIndex = 2;
            this.tabPageEpisodios.Text = "Episodios";
            this.tabPageEpisodios.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 612);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Rick and Morty API - Oscar Sixtos";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePersonajes.ResumeLayout(false);
            this.tabPagePersonajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPagePersonajes;
        private TabPage tabPageLugares;
        private TabPage tabPageEpisodios;
        private Button buttonFirstPers;
        private PictureBox pictureBoxPers;
        private Label labelPersName;
        private Button buttonLastPers;
        private Button buttonNextPers;
        private Button buttonPrevPers;
        private Button buttonRandPers;
        private TextBox textBoxIDPers;
    }
}
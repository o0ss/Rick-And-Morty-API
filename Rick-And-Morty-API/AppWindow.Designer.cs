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
            this.labelPersLoc = new System.Windows.Forms.Label();
            this.labelPersOrigin = new System.Windows.Forms.Label();
            this.label_PersLoc = new System.Windows.Forms.Label();
            this.label_PersOrigin = new System.Windows.Forms.Label();
            this.labelPersGender = new System.Windows.Forms.Label();
            this.labelPersType = new System.Windows.Forms.Label();
            this.labelPersSpecies = new System.Windows.Forms.Label();
            this.labelPersStatus = new System.Windows.Forms.Label();
            this.label_PersGender = new System.Windows.Forms.Label();
            this.label_PersType = new System.Windows.Forms.Label();
            this.label_PersSpecies = new System.Windows.Forms.Label();
            this.label_PersStatus = new System.Windows.Forms.Label();
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
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagePersonajes);
            this.tabControl1.Controls.Add(this.tabPageLugares);
            this.tabControl1.Controls.Add(this.tabPageEpisodios);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 254);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePersonajes
            // 
            this.tabPagePersonajes.Controls.Add(this.labelPersLoc);
            this.tabPagePersonajes.Controls.Add(this.labelPersOrigin);
            this.tabPagePersonajes.Controls.Add(this.label_PersLoc);
            this.tabPagePersonajes.Controls.Add(this.label_PersOrigin);
            this.tabPagePersonajes.Controls.Add(this.labelPersGender);
            this.tabPagePersonajes.Controls.Add(this.labelPersType);
            this.tabPagePersonajes.Controls.Add(this.labelPersSpecies);
            this.tabPagePersonajes.Controls.Add(this.labelPersStatus);
            this.tabPagePersonajes.Controls.Add(this.label_PersGender);
            this.tabPagePersonajes.Controls.Add(this.label_PersType);
            this.tabPagePersonajes.Controls.Add(this.label_PersSpecies);
            this.tabPagePersonajes.Controls.Add(this.label_PersStatus);
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
            this.tabPagePersonajes.Size = new System.Drawing.Size(442, 226);
            this.tabPagePersonajes.TabIndex = 0;
            this.tabPagePersonajes.Text = "Personajes";
            this.tabPagePersonajes.UseVisualStyleBackColor = true;
            this.tabPagePersonajes.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tabPagePersonajes_PreviewKeyDown);
            // 
            // labelPersLoc
            // 
            this.labelPersLoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPersLoc.AutoSize = true;
            this.labelPersLoc.Location = new System.Drawing.Point(233, 195);
            this.labelPersLoc.Name = "labelPersLoc";
            this.labelPersLoc.Size = new System.Drawing.Size(53, 15);
            this.labelPersLoc.TabIndex = 20;
            this.labelPersLoc.Text = "Location";
            // 
            // labelPersOrigin
            // 
            this.labelPersOrigin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPersOrigin.AutoSize = true;
            this.labelPersOrigin.Location = new System.Drawing.Point(233, 175);
            this.labelPersOrigin.Name = "labelPersOrigin";
            this.labelPersOrigin.Size = new System.Drawing.Size(40, 15);
            this.labelPersOrigin.TabIndex = 19;
            this.labelPersOrigin.Text = "Origin";
            // 
            // label_PersLoc
            // 
            this.label_PersLoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_PersLoc.AutoSize = true;
            this.label_PersLoc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_PersLoc.Location = new System.Drawing.Point(174, 195);
            this.label_PersLoc.Name = "label_PersLoc";
            this.label_PersLoc.Size = new System.Drawing.Size(53, 15);
            this.label_PersLoc.TabIndex = 18;
            this.label_PersLoc.Text = "Location";
            // 
            // label_PersOrigin
            // 
            this.label_PersOrigin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_PersOrigin.AutoSize = true;
            this.label_PersOrigin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_PersOrigin.Location = new System.Drawing.Point(187, 175);
            this.label_PersOrigin.Name = "label_PersOrigin";
            this.label_PersOrigin.Size = new System.Drawing.Size(40, 15);
            this.label_PersOrigin.TabIndex = 17;
            this.label_PersOrigin.Text = "Origin";
            // 
            // labelPersGender
            // 
            this.labelPersGender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPersGender.AutoSize = true;
            this.labelPersGender.Location = new System.Drawing.Point(233, 115);
            this.labelPersGender.Name = "labelPersGender";
            this.labelPersGender.Size = new System.Drawing.Size(45, 15);
            this.labelPersGender.TabIndex = 16;
            this.labelPersGender.Text = "Gender";
            // 
            // labelPersType
            // 
            this.labelPersType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPersType.AutoSize = true;
            this.labelPersType.Location = new System.Drawing.Point(233, 135);
            this.labelPersType.Name = "labelPersType";
            this.labelPersType.Size = new System.Drawing.Size(31, 15);
            this.labelPersType.TabIndex = 15;
            this.labelPersType.Text = "Type";
            // 
            // labelPersSpecies
            // 
            this.labelPersSpecies.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPersSpecies.AutoSize = true;
            this.labelPersSpecies.Location = new System.Drawing.Point(233, 95);
            this.labelPersSpecies.Name = "labelPersSpecies";
            this.labelPersSpecies.Size = new System.Drawing.Size(46, 15);
            this.labelPersSpecies.TabIndex = 14;
            this.labelPersSpecies.Text = "Species";
            // 
            // labelPersStatus
            // 
            this.labelPersStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPersStatus.AutoSize = true;
            this.labelPersStatus.Location = new System.Drawing.Point(233, 155);
            this.labelPersStatus.Name = "labelPersStatus";
            this.labelPersStatus.Size = new System.Drawing.Size(39, 15);
            this.labelPersStatus.TabIndex = 13;
            this.labelPersStatus.Text = "Status";
            // 
            // label_PersGender
            // 
            this.label_PersGender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_PersGender.AutoSize = true;
            this.label_PersGender.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_PersGender.Location = new System.Drawing.Point(182, 115);
            this.label_PersGender.Name = "label_PersGender";
            this.label_PersGender.Size = new System.Drawing.Size(45, 15);
            this.label_PersGender.TabIndex = 12;
            this.label_PersGender.Text = "Gender";
            // 
            // label_PersType
            // 
            this.label_PersType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_PersType.AutoSize = true;
            this.label_PersType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_PersType.Location = new System.Drawing.Point(196, 135);
            this.label_PersType.Name = "label_PersType";
            this.label_PersType.Size = new System.Drawing.Size(31, 15);
            this.label_PersType.TabIndex = 11;
            this.label_PersType.Text = "Type";
            // 
            // label_PersSpecies
            // 
            this.label_PersSpecies.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_PersSpecies.AutoSize = true;
            this.label_PersSpecies.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_PersSpecies.Location = new System.Drawing.Point(181, 95);
            this.label_PersSpecies.Name = "label_PersSpecies";
            this.label_PersSpecies.Size = new System.Drawing.Size(46, 15);
            this.label_PersSpecies.TabIndex = 10;
            this.label_PersSpecies.Text = "Species";
            // 
            // label_PersStatus
            // 
            this.label_PersStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_PersStatus.AutoSize = true;
            this.label_PersStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_PersStatus.Location = new System.Drawing.Point(188, 155);
            this.label_PersStatus.Name = "label_PersStatus";
            this.label_PersStatus.Size = new System.Drawing.Size(39, 15);
            this.label_PersStatus.TabIndex = 9;
            this.label_PersStatus.Text = "Status";
            // 
            // textBoxIDPers
            // 
            this.textBoxIDPers.Location = new System.Drawing.Point(103, 15);
            this.textBoxIDPers.MaxLength = 3;
            this.textBoxIDPers.Name = "textBoxIDPers";
            this.textBoxIDPers.PlaceholderText = "ID";
            this.textBoxIDPers.Size = new System.Drawing.Size(80, 23);
            this.textBoxIDPers.TabIndex = 1;
            this.textBoxIDPers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDPers.TextChanged += new System.EventHandler(this.textBoxIDPers_TextChanged);
            // 
            // buttonLastPers
            // 
            this.buttonLastPers.Location = new System.Drawing.Point(233, 15);
            this.buttonLastPers.Name = "buttonLastPers";
            this.buttonLastPers.Size = new System.Drawing.Size(38, 23);
            this.buttonLastPers.TabIndex = 6;
            this.buttonLastPers.Text = ">>";
            this.buttonLastPers.UseVisualStyleBackColor = true;
            this.buttonLastPers.Click += new System.EventHandler(this.buttonLastPers_Click);
            // 
            // buttonNextPers
            // 
            this.buttonNextPers.Location = new System.Drawing.Point(189, 15);
            this.buttonNextPers.Name = "buttonNextPers";
            this.buttonNextPers.Size = new System.Drawing.Size(38, 23);
            this.buttonNextPers.TabIndex = 5;
            this.buttonNextPers.Text = ">";
            this.buttonNextPers.UseVisualStyleBackColor = true;
            this.buttonNextPers.Click += new System.EventHandler(this.buttonNextPers_Click);
            // 
            // buttonPrevPers
            // 
            this.buttonPrevPers.Location = new System.Drawing.Point(59, 15);
            this.buttonPrevPers.Name = "buttonPrevPers";
            this.buttonPrevPers.Size = new System.Drawing.Size(38, 23);
            this.buttonPrevPers.TabIndex = 4;
            this.buttonPrevPers.Text = "<";
            this.buttonPrevPers.UseVisualStyleBackColor = true;
            this.buttonPrevPers.Click += new System.EventHandler(this.buttonPrevPers_Click);
            // 
            // buttonRandPers
            // 
            this.buttonRandPers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRandPers.Location = new System.Drawing.Point(351, 14);
            this.buttonRandPers.Name = "buttonRandPers";
            this.buttonRandPers.Size = new System.Drawing.Size(75, 23);
            this.buttonRandPers.TabIndex = 2;
            this.buttonRandPers.Text = "Random";
            this.buttonRandPers.UseVisualStyleBackColor = true;
            this.buttonRandPers.Click += new System.EventHandler(this.buttonRandPers_Click);
            // 
            // buttonFirstPers
            // 
            this.buttonFirstPers.Location = new System.Drawing.Point(15, 15);
            this.buttonFirstPers.Name = "buttonFirstPers";
            this.buttonFirstPers.Size = new System.Drawing.Size(38, 23);
            this.buttonFirstPers.TabIndex = 3;
            this.buttonFirstPers.Text = "<<";
            this.buttonFirstPers.UseVisualStyleBackColor = true;
            this.buttonFirstPers.Click += new System.EventHandler(this.buttonFirstPers_Click);
            // 
            // pictureBoxPers
            // 
            this.pictureBoxPers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPers.Image = global::Rick_And_Morty_API.Properties.Resources.default_img;
            this.pictureBoxPers.InitialImage = global::Rick_And_Morty_API.Properties.Resources.default_img;
            this.pictureBoxPers.Location = new System.Drawing.Point(15, 60);
            this.pictureBoxPers.Name = "pictureBoxPers";
            this.pictureBoxPers.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxPers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPers.TabIndex = 1;
            this.pictureBoxPers.TabStop = false;
            // 
            // labelPersName
            // 
            this.labelPersName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPersName.AutoSize = true;
            this.labelPersName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPersName.Location = new System.Drawing.Point(174, 60);
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
            this.tabPageLugares.Size = new System.Drawing.Size(442, 226);
            this.tabPageLugares.TabIndex = 1;
            this.tabPageLugares.Text = "Lugares";
            this.tabPageLugares.UseVisualStyleBackColor = true;
            // 
            // tabPageEpisodios
            // 
            this.tabPageEpisodios.Location = new System.Drawing.Point(4, 24);
            this.tabPageEpisodios.Name = "tabPageEpisodios";
            this.tabPageEpisodios.Size = new System.Drawing.Size(442, 226);
            this.tabPageEpisodios.TabIndex = 2;
            this.tabPageEpisodios.Text = "Episodios";
            this.tabPageEpisodios.UseVisualStyleBackColor = true;
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 278);
            this.Controls.Add(this.tabControl1);
            this.Name = "AppWindow";
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
        private Label label_PersGender;
        private Label label_PersType;
        private Label label_PersSpecies;
        private Label label_PersStatus;
		private Label labelPersGender;
		private Label labelPersType;
		private Label labelPersSpecies;
		private Label labelPersStatus;
		private Label labelPersLoc;
		private Label labelPersOrigin;
		private Label label_PersLoc;
		private Label label_PersOrigin;
	}
}
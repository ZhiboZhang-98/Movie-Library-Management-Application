namespace MovieLibraryApplication
{
    partial class MovieLibraryForm
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
            this.labelmovietitle = new System.Windows.Forms.Label();
            this.labelduration = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelSubtitles = new System.Windows.Forms.Label();
            this.labelAct = new System.Windows.Forms.Label();
            this.labelAwards = new System.Windows.Forms.Label();
            this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxAwards = new System.Windows.Forms.TextBox();
            this.textBoxAct = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.comboBoxSubtitles = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewMovieLibrary = new System.Windows.Forms.ListView();
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDirector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnActor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubtitles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAwards = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonWriteText = new System.Windows.Forms.Button();
            this.buttonReadText = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.buttonWriteBinaryFile = new System.Windows.Forms.Button();
            this.buttonReadBinaryFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelmovietitle
            // 
            this.labelmovietitle.AutoSize = true;
            this.labelmovietitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelmovietitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelmovietitle.Location = new System.Drawing.Point(50, 42);
            this.labelmovietitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmovietitle.Name = "labelmovietitle";
            this.labelmovietitle.Size = new System.Drawing.Size(91, 20);
            this.labelmovietitle.TabIndex = 0;
            this.labelmovietitle.Text = "Movie Title :";
            // 
            // labelduration
            // 
            this.labelduration.AutoSize = true;
            this.labelduration.Location = new System.Drawing.Point(66, 83);
            this.labelduration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelduration.Name = "labelduration";
            this.labelduration.Size = new System.Drawing.Size(51, 20);
            this.labelduration.TabIndex = 1;
            this.labelduration.Text = "Time :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(466, 42);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(51, 20);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type :";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(466, 83);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(72, 20);
            this.labelCountry.TabIndex = 3;
            this.labelCountry.Text = "Country :";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(784, 42);
            this.labelDirector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(73, 20);
            this.labelDirector.TabIndex = 4;
            this.labelDirector.Text = "Director :";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(807, 83);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(51, 20);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Year :";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(112, 165);
            this.labelLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(89, 20);
            this.labelLanguage.TabIndex = 6;
            this.labelLanguage.Text = "Language :";
            // 
            // labelSubtitles
            // 
            this.labelSubtitles.AutoSize = true;
            this.labelSubtitles.Location = new System.Drawing.Point(124, 222);
            this.labelSubtitles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubtitles.Name = "labelSubtitles";
            this.labelSubtitles.Size = new System.Drawing.Size(79, 20);
            this.labelSubtitles.TabIndex = 7;
            this.labelSubtitles.Text = "Subtitles :";
            // 
            // labelAct
            // 
            this.labelAct.AutoSize = true;
            this.labelAct.Location = new System.Drawing.Point(645, 155);
            this.labelAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAct.Name = "labelAct";
            this.labelAct.Size = new System.Drawing.Size(121, 20);
            this.labelAct.TabIndex = 8;
            this.labelAct.Text = "Actor / Actress :";
            // 
            // labelAwards
            // 
            this.labelAwards.AutoSize = true;
            this.labelAwards.Location = new System.Drawing.Point(696, 219);
            this.labelAwards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAwards.Name = "labelAwards";
            this.labelAwards.Size = new System.Drawing.Size(70, 20);
            this.labelAwards.TabIndex = 9;
            this.labelAwards.Text = "Awards :";
            // 
            // textBoxMovieTitle
            // 
            this.textBoxMovieTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMovieTitle.Location = new System.Drawing.Point(186, 42);
            this.textBoxMovieTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMovieTitle.Name = "textBoxMovieTitle";
            this.textBoxMovieTitle.Size = new System.Drawing.Size(180, 26);
            this.textBoxMovieTitle.TabIndex = 10;
            // 
            // textBoxHour
            // 
            this.textBoxHour.Location = new System.Drawing.Point(186, 82);
            this.textBoxHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(41, 26);
            this.textBoxHour.TabIndex = 11;
            this.textBoxHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDuration_KeyPress);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(549, 83);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(180, 26);
            this.textBoxCountry.TabIndex = 12;
            this.textBoxCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCountry_KeyPress);
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(892, 37);
            this.textBoxDirector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(180, 26);
            this.textBoxDirector.TabIndex = 13;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(892, 83);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(180, 26);
            this.textBoxYear.TabIndex = 14;
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // textBoxAwards
            // 
            this.textBoxAwards.Location = new System.Drawing.Point(799, 216);
            this.textBoxAwards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAwards.Name = "textBoxAwards";
            this.textBoxAwards.Size = new System.Drawing.Size(180, 26);
            this.textBoxAwards.TabIndex = 15;
            // 
            // textBoxAct
            // 
            this.textBoxAct.Location = new System.Drawing.Point(799, 152);
            this.textBoxAct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAct.Name = "textBoxAct";
            this.textBoxAct.Size = new System.Drawing.Size(180, 26);
            this.textBoxAct.TabIndex = 16;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(548, 37);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(180, 28);
            this.comboBoxType.TabIndex = 17;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(264, 158);
            this.comboBoxLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(180, 28);
            this.comboBoxLanguage.TabIndex = 18;
            // 
            // comboBoxSubtitles
            // 
            this.comboBoxSubtitles.FormattingEnabled = true;
            this.comboBoxSubtitles.Location = new System.Drawing.Point(264, 217);
            this.comboBoxSubtitles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSubtitles.Name = "comboBoxSubtitles";
            this.comboBoxSubtitles.Size = new System.Drawing.Size(180, 28);
            this.comboBoxSubtitles.TabIndex = 19;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(30, 311);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(192, 35);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(276, 311);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(168, 35);
            this.buttonDisplay.TabIndex = 21;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(979, 311);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(192, 35);
            this.buttonReset.TabIndex = 22;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(504, 311);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(174, 35);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(734, 311);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 35);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1070, 634);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 35);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1036, 459);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 35);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(1003, 412);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(184, 26);
            this.textBoxSearch.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(861, 415);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Enter Movie Title :";
            // 
            // listViewMovieLibrary
            // 
            this.listViewMovieLibrary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitle,
            this.columnType,
            this.columnDirector,
            this.columnDuration,
            this.columnCountry,
            this.columnYear,
            this.columnLanguage,
            this.columnActor,
            this.columnSubtitles,
            this.columnAwards});
            this.listViewMovieLibrary.GridLines = true;
            this.listViewMovieLibrary.Location = new System.Drawing.Point(12, 400);
            this.listViewMovieLibrary.Name = "listViewMovieLibrary";
            this.listViewMovieLibrary.Size = new System.Drawing.Size(807, 280);
            this.listViewMovieLibrary.TabIndex = 30;
            this.listViewMovieLibrary.UseCompatibleStateImageBehavior = false;
            this.listViewMovieLibrary.View = System.Windows.Forms.View.Details;
            this.listViewMovieLibrary.SelectedIndexChanged += new System.EventHandler(this.listViewMovieLibrary_SelectedIndexChanged);
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Movie Title";
            this.columnTitle.Width = 88;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 57;
            // 
            // columnDirector
            // 
            this.columnDirector.Text = "Director";
            this.columnDirector.Width = 71;
            // 
            // columnDuration
            // 
            this.columnDuration.Text = "Time";
            this.columnDuration.Width = 74;
            // 
            // columnCountry
            // 
            this.columnCountry.Text = "Country";
            this.columnCountry.Width = 74;
            // 
            // columnYear
            // 
            this.columnYear.Text = "Year";
            // 
            // columnLanguage
            // 
            this.columnLanguage.Text = "Language";
            this.columnLanguage.Width = 91;
            // 
            // columnActor
            // 
            this.columnActor.Text = "Actor";
            // 
            // columnSubtitles
            // 
            this.columnSubtitles.Text = "Subtitles";
            this.columnSubtitles.Width = 83;
            // 
            // columnAwards
            // 
            this.columnAwards.Text = "Awards";
            this.columnAwards.Width = 81;
            // 
            // buttonWriteText
            // 
            this.buttonWriteText.Location = new System.Drawing.Point(850, 517);
            this.buttonWriteText.Name = "buttonWriteText";
            this.buttonWriteText.Size = new System.Drawing.Size(170, 37);
            this.buttonWriteText.TabIndex = 31;
            this.buttonWriteText.Text = "Write To Text File";
            this.buttonWriteText.UseVisualStyleBackColor = true;
            this.buttonWriteText.Click += new System.EventHandler(this.buttonWriteText_Click);
            // 
            // buttonReadText
            // 
            this.buttonReadText.Location = new System.Drawing.Point(850, 576);
            this.buttonReadText.Name = "buttonReadText";
            this.buttonReadText.Size = new System.Drawing.Size(170, 38);
            this.buttonReadText.TabIndex = 32;
            this.buttonReadText.Text = "Read From Text File";
            this.buttonReadText.UseVisualStyleBackColor = true;
            this.buttonReadText.Click += new System.EventHandler(this.buttonReadText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = ":";
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Location = new System.Drawing.Point(253, 82);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(42, 26);
            this.textBoxMinute.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = ":";
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(320, 83);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(46, 26);
            this.textBoxSecond.TabIndex = 36;
            // 
            // buttonWriteBinaryFile
            // 
            this.buttonWriteBinaryFile.Location = new System.Drawing.Point(1026, 517);
            this.buttonWriteBinaryFile.Name = "buttonWriteBinaryFile";
            this.buttonWriteBinaryFile.Size = new System.Drawing.Size(162, 37);
            this.buttonWriteBinaryFile.TabIndex = 37;
            this.buttonWriteBinaryFile.Text = "Write To Binary File";
            this.buttonWriteBinaryFile.UseVisualStyleBackColor = true;
            this.buttonWriteBinaryFile.Click += new System.EventHandler(this.buttonWriteBinaryFile_Click);
            // 
            // buttonReadBinaryFile
            // 
            this.buttonReadBinaryFile.Location = new System.Drawing.Point(1026, 576);
            this.buttonReadBinaryFile.Name = "buttonReadBinaryFile";
            this.buttonReadBinaryFile.Size = new System.Drawing.Size(162, 39);
            this.buttonReadBinaryFile.TabIndex = 38;
            this.buttonReadBinaryFile.Text = "Read From Binary File";
            this.buttonReadBinaryFile.UseVisualStyleBackColor = true;
            this.buttonReadBinaryFile.Click += new System.EventHandler(this.buttonReadBinaryFile_Click);
            // 
            // MovieLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonReadBinaryFile);
            this.Controls.Add(this.buttonWriteBinaryFile);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReadText);
            this.Controls.Add(this.buttonWriteText);
            this.Controls.Add(this.listViewMovieLibrary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxSubtitles);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxAct);
            this.Controls.Add(this.textBoxAwards);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.textBoxMovieTitle);
            this.Controls.Add(this.labelAwards);
            this.Controls.Add(this.labelAct);
            this.Controls.Add(this.labelSubtitles);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelduration);
            this.Controls.Add(this.labelmovietitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MovieLibraryForm";
            this.Text = "Movie Library Management Application";
            this.Load += new System.EventHandler(this.MovieLibraryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmovietitle;
        private System.Windows.Forms.Label labelduration;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelSubtitles;
        private System.Windows.Forms.Label labelAct;
        private System.Windows.Forms.Label labelAwards;
        private System.Windows.Forms.TextBox textBoxMovieTitle;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxAwards;
        private System.Windows.Forms.TextBox textBoxAct;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.ComboBox comboBoxSubtitles;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewMovieLibrary;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnDirector;
        private System.Windows.Forms.ColumnHeader columnDuration;
        private System.Windows.Forms.ColumnHeader columnCountry;
        private System.Windows.Forms.ColumnHeader columnYear;
        private System.Windows.Forms.ColumnHeader columnLanguage;
        private System.Windows.Forms.ColumnHeader columnActor;
        private System.Windows.Forms.ColumnHeader columnSubtitles;
        private System.Windows.Forms.ColumnHeader columnAwards;
        private System.Windows.Forms.Button buttonWriteText;
        private System.Windows.Forms.Button buttonReadText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.Button buttonWriteBinaryFile;
        private System.Windows.Forms.Button buttonReadBinaryFile;
    }
}


namespace Lab_2LPO
{
    partial class Tniap
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tniap));
            this.FieldColour = new System.Windows.Forms.Panel();
            this.ColourBlack = new System.Windows.Forms.PictureBox();
            this.ColourBlue = new System.Windows.Forms.PictureBox();
            this.ColourYellow = new System.Windows.Forms.PictureBox();
            this.ColourGreen = new System.Windows.Forms.PictureBox();
            this.ColourRed = new System.Windows.Forms.PictureBox();
            this.FieldFigure = new System.Windows.Forms.Panel();
            this.Square = new System.Windows.Forms.PictureBox();
            this.Line = new System.Windows.Forms.PictureBox();
            this.Circle = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveHaw = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FieldDrawing = new System.Windows.Forms.PictureBox();
            this.Width = new System.Windows.Forms.TrackBar();
            this.Save = new System.Windows.Forms.SaveFileDialog();
            this.Open = new System.Windows.Forms.OpenFileDialog();
            this.Cleare = new System.Windows.Forms.Panel();
            this.Fill = new System.Windows.Forms.Panel();
            this.FieldColour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourRed)).BeginInit();
            this.FieldFigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FieldDrawing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            this.SuspendLayout();
            // 
            // FieldColour
            // 
            this.FieldColour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FieldColour.Controls.Add(this.ColourBlack);
            this.FieldColour.Controls.Add(this.ColourBlue);
            this.FieldColour.Controls.Add(this.ColourYellow);
            this.FieldColour.Controls.Add(this.ColourGreen);
            this.FieldColour.Controls.Add(this.ColourRed);
            this.FieldColour.Location = new System.Drawing.Point(12, 42);
            this.FieldColour.Name = "FieldColour";
            this.FieldColour.Size = new System.Drawing.Size(180, 50);
            this.FieldColour.TabIndex = 0;
            // 
            // ColourBlack
            // 
            this.ColourBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColourBlack.Location = new System.Drawing.Point(3, 10);
            this.ColourBlack.Name = "ColourBlack";
            this.ColourBlack.Size = new System.Drawing.Size(30, 30);
            this.ColourBlack.TabIndex = 1;
            this.ColourBlack.TabStop = false;
            this.ColourBlack.Click += new System.EventHandler(this.Colour_Click);
            // 
            // ColourBlue
            // 
            this.ColourBlue.BackColor = System.Drawing.Color.Blue;
            this.ColourBlue.Location = new System.Drawing.Point(111, 10);
            this.ColourBlue.Name = "ColourBlue";
            this.ColourBlue.Size = new System.Drawing.Size(30, 30);
            this.ColourBlue.TabIndex = 1;
            this.ColourBlue.TabStop = false;
            this.ColourBlue.Click += new System.EventHandler(this.Colour_Click);
            // 
            // ColourYellow
            // 
            this.ColourYellow.BackColor = System.Drawing.Color.Yellow;
            this.ColourYellow.Location = new System.Drawing.Point(147, 10);
            this.ColourYellow.Name = "ColourYellow";
            this.ColourYellow.Size = new System.Drawing.Size(30, 30);
            this.ColourYellow.TabIndex = 1;
            this.ColourYellow.TabStop = false;
            this.ColourYellow.Click += new System.EventHandler(this.Colour_Click);
            // 
            // ColourGreen
            // 
            this.ColourGreen.BackColor = System.Drawing.Color.Lime;
            this.ColourGreen.Location = new System.Drawing.Point(75, 10);
            this.ColourGreen.Name = "ColourGreen";
            this.ColourGreen.Size = new System.Drawing.Size(30, 30);
            this.ColourGreen.TabIndex = 1;
            this.ColourGreen.TabStop = false;
            this.ColourGreen.Click += new System.EventHandler(this.Colour_Click);
            // 
            // ColourRed
            // 
            this.ColourRed.BackColor = System.Drawing.Color.Red;
            this.ColourRed.Location = new System.Drawing.Point(39, 10);
            this.ColourRed.Name = "ColourRed";
            this.ColourRed.Size = new System.Drawing.Size(30, 30);
            this.ColourRed.TabIndex = 1;
            this.ColourRed.TabStop = false;
            this.ColourRed.Click += new System.EventHandler(this.Colour_Click);
            // 
            // FieldFigure
            // 
            this.FieldFigure.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FieldFigure.Controls.Add(this.Square);
            this.FieldFigure.Controls.Add(this.Line);
            this.FieldFigure.Controls.Add(this.Circle);
            this.FieldFigure.Location = new System.Drawing.Point(209, 42);
            this.FieldFigure.Name = "FieldFigure";
            this.FieldFigure.Size = new System.Drawing.Size(180, 50);
            this.FieldFigure.TabIndex = 2;
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Square.BackgroundImage")));
            this.Square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Square.Location = new System.Drawing.Point(3, 10);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(30, 30);
            this.Square.TabIndex = 1;
            this.Square.TabStop = false;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Line.BackgroundImage")));
            this.Line.Location = new System.Drawing.Point(147, 10);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(30, 30);
            this.Line.TabIndex = 1;
            this.Line.TabStop = false;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Circle
            // 
            this.Circle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Circle.BackgroundImage")));
            this.Circle.Location = new System.Drawing.Point(75, 10);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(30, 30);
            this.Circle.TabIndex = 1;
            this.Circle.TabStop = false;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.SaveHaw,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveHaw
            // 
            this.SaveHaw.Name = "SaveHaw";
            this.SaveHaw.Size = new System.Drawing.Size(162, 22);
            this.SaveHaw.Text = "Сохранить как...";
            this.SaveHaw.Click += new System.EventHandler(this.SaveHaw_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // FieldDrawing
            // 
            this.FieldDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldDrawing.Location = new System.Drawing.Point(0, 98);
            this.FieldDrawing.Name = "FieldDrawing";
            this.FieldDrawing.Size = new System.Drawing.Size(884, 313);
            this.FieldDrawing.TabIndex = 4;
            this.FieldDrawing.TabStop = false;
            this.FieldDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FieldDrawing_MouseDown);
            this.FieldDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FieldDrawing_MouseMove);
            this.FieldDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FieldDrawing_MouseUp);
            // 
            // Width
            // 
            this.Width.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Width.Location = new System.Drawing.Point(406, 47);
            this.Width.Maximum = 25;
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(104, 45);
            this.Width.TabIndex = 5;
            // 
            // Save
            // 
            this.Save.DefaultExt = "jpg";
            // 
            // Open
            // 
            this.Open.FileName = "OpenFile";
            // 
            // Cleare
            // 
            this.Cleare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Cleare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cleare.BackgroundImage")));
            this.Cleare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cleare.Location = new System.Drawing.Point(531, 42);
            this.Cleare.Name = "Cleare";
            this.Cleare.Size = new System.Drawing.Size(50, 50);
            this.Cleare.TabIndex = 4;
            this.Cleare.Click += new System.EventHandler(this.Cleare_Click);
            // 
            // Fill
            // 
            this.Fill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fill.BackgroundImage")));
            this.Fill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Fill.Location = new System.Drawing.Point(600, 42);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(50, 50);
            this.Fill.TabIndex = 5;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // Tniap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.Cleare);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.FieldDrawing);
            this.Controls.Add(this.FieldFigure);
            this.Controls.Add(this.FieldColour);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Tniap";
            this.Text = "Tniap";
            this.FieldColour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColourBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourRed)).EndInit();
            this.FieldFigure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FieldDrawing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FieldColour;
        private System.Windows.Forms.PictureBox ColourRed;
        private System.Windows.Forms.PictureBox ColourBlack;
        private System.Windows.Forms.PictureBox ColourBlue;
        private System.Windows.Forms.PictureBox ColourYellow;
        private System.Windows.Forms.PictureBox ColourGreen;
        private System.Windows.Forms.Panel FieldFigure;
        private System.Windows.Forms.PictureBox Square;
        private System.Windows.Forms.PictureBox Line;
        private System.Windows.Forms.PictureBox Circle;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveHaw;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox FieldDrawing;
        private System.Windows.Forms.TrackBar Width;
        private System.Windows.Forms.SaveFileDialog Save;
        private System.Windows.Forms.OpenFileDialog Open;
        private System.Windows.Forms.Panel Cleare;
        private System.Windows.Forms.Panel Fill;
    }
}


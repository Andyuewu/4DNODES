namespace WindowsFormsApp2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Xchoice = new System.Windows.Forms.ComboBox();
            this.Ychoice = new System.Windows.Forms.ComboBox();
            this.xAxis = new System.Windows.Forms.Label();
            this.yAxis = new System.Windows.Forms.Label();
            this.diChoice = new System.Windows.Forms.ComboBox();
            this.dimension = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Zchoice = new System.Windows.Forms.ComboBox();
            this.order = new System.Windows.Forms.Label();
            this.OrChoice = new System.Windows.Forms.ComboBox();
            this.t = new System.Windows.Forms.Label();
            this.tChoice = new System.Windows.Forms.ComboBox();
            this.playerChoice = new System.Windows.Forms.Label();
            this.pChoice = new System.Windows.Forms.ComboBox();
            this.NewGame = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 704);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Xchoice
            // 
            this.Xchoice.FormattingEnabled = true;
            this.Xchoice.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Xchoice.Location = new System.Drawing.Point(860, 303);
            this.Xchoice.Name = "Xchoice";
            this.Xchoice.Size = new System.Drawing.Size(230, 33);
            this.Xchoice.TabIndex = 1;
            // 
            // Ychoice
            // 
            this.Ychoice.FormattingEnabled = true;
            this.Ychoice.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Ychoice.Location = new System.Drawing.Point(860, 389);
            this.Ychoice.Name = "Ychoice";
            this.Ychoice.Size = new System.Drawing.Size(230, 33);
            this.Ychoice.TabIndex = 2;
            // 
            // xAxis
            // 
            this.xAxis.AutoSize = true;
            this.xAxis.Location = new System.Drawing.Point(867, 275);
            this.xAxis.Name = "xAxis";
            this.xAxis.Size = new System.Drawing.Size(23, 25);
            this.xAxis.TabIndex = 3;
            this.xAxis.Text = "x";
            this.xAxis.Click += new System.EventHandler(this.label1_Click);
            // 
            // yAxis
            // 
            this.yAxis.AutoSize = true;
            this.yAxis.Location = new System.Drawing.Point(867, 351);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(23, 25);
            this.yAxis.TabIndex = 4;
            this.yAxis.Text = "y";
            // 
            // diChoice
            // 
            this.diChoice.FormattingEnabled = true;
            this.diChoice.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.diChoice.Location = new System.Drawing.Point(860, 136);
            this.diChoice.Name = "diChoice";
            this.diChoice.Size = new System.Drawing.Size(230, 33);
            this.diChoice.TabIndex = 5;
            this.diChoice.SelectedIndexChanged += new System.EventHandler(this.diChoice_SelectedIndexChanged);
            // 
            // dimension
            // 
            this.dimension.AutoSize = true;
            this.dimension.Location = new System.Drawing.Point(855, 108);
            this.dimension.Name = "dimension";
            this.dimension.Size = new System.Drawing.Size(110, 25);
            this.dimension.TabIndex = 6;
            this.dimension.Text = "dimension";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(867, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "z";
            // 
            // Zchoice
            // 
            this.Zchoice.FormattingEnabled = true;
            this.Zchoice.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Zchoice.Location = new System.Drawing.Point(860, 453);
            this.Zchoice.Name = "Zchoice";
            this.Zchoice.Size = new System.Drawing.Size(230, 33);
            this.Zchoice.TabIndex = 8;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(867, 190);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(62, 25);
            this.order.TabIndex = 9;
            this.order.Text = "order";
            // 
            // OrChoice
            // 
            this.OrChoice.FormattingEnabled = true;
            this.OrChoice.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.OrChoice.Location = new System.Drawing.Point(860, 218);
            this.OrChoice.Name = "OrChoice";
            this.OrChoice.Size = new System.Drawing.Size(230, 33);
            this.OrChoice.TabIndex = 10;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(872, 503);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(18, 25);
            this.t.TabIndex = 11;
            this.t.Text = "t";
            this.t.Click += new System.EventHandler(this.label2_Click);
            // 
            // tChoice
            // 
            this.tChoice.FormattingEnabled = true;
            this.tChoice.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.tChoice.Location = new System.Drawing.Point(860, 531);
            this.tChoice.Name = "tChoice";
            this.tChoice.Size = new System.Drawing.Size(230, 33);
            this.tChoice.TabIndex = 12;
            // 
            // playerChoice
            // 
            this.playerChoice.AutoSize = true;
            this.playerChoice.Location = new System.Drawing.Point(867, 567);
            this.playerChoice.Name = "playerChoice";
            this.playerChoice.Size = new System.Drawing.Size(146, 25);
            this.playerChoice.TabIndex = 13;
            this.playerChoice.Text = "Player Choice";
            this.playerChoice.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pChoice
            // 
            this.pChoice.FormattingEnabled = true;
            this.pChoice.Location = new System.Drawing.Point(860, 607);
            this.pChoice.Name = "pChoice";
            this.pChoice.Size = new System.Drawing.Size(230, 33);
            this.pChoice.TabIndex = 14;
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(855, 750);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(235, 143);
            this.NewGame.TabIndex = 15;
            this.NewGame.Text = "new game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(47, 763);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(745, 130);
            this.richTextBox.TabIndex = 16;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 942);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.pChoice);
            this.Controls.Add(this.playerChoice);
            this.Controls.Add(this.tChoice);
            this.Controls.Add(this.t);
            this.Controls.Add(this.OrChoice);
            this.Controls.Add(this.order);
            this.Controls.Add(this.Zchoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimension);
            this.Controls.Add(this.diChoice);
            this.Controls.Add(this.yAxis);
            this.Controls.Add(this.xAxis);
            this.Controls.Add(this.Ychoice);
            this.Controls.Add(this.Xchoice);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Xchoice;
        private System.Windows.Forms.ComboBox Ychoice;
        private System.Windows.Forms.Label xAxis;
        private System.Windows.Forms.Label yAxis;
        private System.Windows.Forms.ComboBox diChoice;
        private System.Windows.Forms.Label dimension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Zchoice;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.ComboBox OrChoice;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.ComboBox tChoice;
        private System.Windows.Forms.Label playerChoice;
        private System.Windows.Forms.ComboBox pChoice;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}


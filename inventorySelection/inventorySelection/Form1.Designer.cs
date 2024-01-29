namespace inventorySelection
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
            this.beginningLabel = new System.Windows.Forms.Label();
            this.endingLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.turnoverLabel = new System.Windows.Forms.Label();
            this.beginningTextBox1 = new System.Windows.Forms.TextBox();
            this.beginningTextBox2 = new System.Windows.Forms.TextBox();
            this.beginningTextBox3 = new System.Windows.Forms.TextBox();
            this.endingTextBox1 = new System.Windows.Forms.TextBox();
            this.endingTextBox2 = new System.Windows.Forms.TextBox();
            this.endingTextBox3 = new System.Windows.Forms.TextBox();
            this.totalLabel1 = new System.Windows.Forms.Label();
            this.totalLabel2 = new System.Windows.Forms.Label();
            this.totalLabel3 = new System.Windows.Forms.Label();
            this.averageLabel1 = new System.Windows.Forms.Label();
            this.averageLabel2 = new System.Windows.Forms.Label();
            this.averageLabel3 = new System.Windows.Forms.Label();
            this.turnoverLabel1 = new System.Windows.Forms.Label();
            this.turnoverLabel2 = new System.Windows.Forms.Label();
            this.turnoverLabel3 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beginningLabel
            // 
            this.beginningLabel.AutoSize = true;
            this.beginningLabel.Location = new System.Drawing.Point(12, 77);
            this.beginningLabel.Name = "beginningLabel";
            this.beginningLabel.Size = new System.Drawing.Size(114, 15);
            this.beginningLabel.TabIndex = 0;
            this.beginningLabel.Text = "Beginning Inventory";
            // 
            // endingLabel
            // 
            this.endingLabel.AutoSize = true;
            this.endingLabel.Location = new System.Drawing.Point(160, 77);
            this.endingLabel.Name = "endingLabel";
            this.endingLabel.Size = new System.Drawing.Size(97, 15);
            this.endingLabel.TabIndex = 1;
            this.endingLabel.Text = "Ending Inventory";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(287, 77);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(96, 15);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Costof Total Sold";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(418, 77);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(103, 15);
            this.averageLabel.TabIndex = 3;
            this.averageLabel.Text = "Average Inventory";
            // 
            // turnoverLabel
            // 
            this.turnoverLabel.AutoSize = true;
            this.turnoverLabel.Location = new System.Drawing.Point(554, 77);
            this.turnoverLabel.Name = "turnoverLabel";
            this.turnoverLabel.Size = new System.Drawing.Size(54, 15);
            this.turnoverLabel.TabIndex = 4;
            this.turnoverLabel.Text = "Turnover";
            // 
            // beginningTextBox1
            // 
            this.beginningTextBox1.Location = new System.Drawing.Point(12, 111);
            this.beginningTextBox1.Name = "beginningTextBox1";
            this.beginningTextBox1.Size = new System.Drawing.Size(100, 23);
            this.beginningTextBox1.TabIndex = 5;
            this.beginningTextBox1.TextChanged += new System.EventHandler(this.beginningTextBox1_TextChanged);
            // 
            // beginningTextBox2
            // 
            this.beginningTextBox2.Location = new System.Drawing.Point(12, 155);
            this.beginningTextBox2.Name = "beginningTextBox2";
            this.beginningTextBox2.Size = new System.Drawing.Size(100, 23);
            this.beginningTextBox2.TabIndex = 6;
            this.beginningTextBox2.TextChanged += new System.EventHandler(this.beginningTextBox2_TextChanged);
            // 
            // beginningTextBox3
            // 
            this.beginningTextBox3.Location = new System.Drawing.Point(12, 197);
            this.beginningTextBox3.Name = "beginningTextBox3";
            this.beginningTextBox3.Size = new System.Drawing.Size(100, 23);
            this.beginningTextBox3.TabIndex = 7;
            this.beginningTextBox3.TextChanged += new System.EventHandler(this.beginningTextBox3_TextChanged);
            // 
            // endingTextBox1
            // 
            this.endingTextBox1.Location = new System.Drawing.Point(157, 111);
            this.endingTextBox1.Name = "endingTextBox1";
            this.endingTextBox1.Size = new System.Drawing.Size(100, 23);
            this.endingTextBox1.TabIndex = 8;
            this.endingTextBox1.TextChanged += new System.EventHandler(this.endingTextBox1_TextChanged);
            // 
            // endingTextBox2
            // 
            this.endingTextBox2.Location = new System.Drawing.Point(157, 155);
            this.endingTextBox2.Name = "endingTextBox2";
            this.endingTextBox2.Size = new System.Drawing.Size(100, 23);
            this.endingTextBox2.TabIndex = 9;
            this.endingTextBox2.TextChanged += new System.EventHandler(this.endingTextBox2_TextChanged);
            // 
            // endingTextBox3
            // 
            this.endingTextBox3.Location = new System.Drawing.Point(157, 197);
            this.endingTextBox3.Name = "endingTextBox3";
            this.endingTextBox3.Size = new System.Drawing.Size(100, 23);
            this.endingTextBox3.TabIndex = 10;
            this.endingTextBox3.TextChanged += new System.EventHandler(this.endingTextBox3_TextChanged);
            // 
            // totalLabel1
            // 
            this.totalLabel1.AutoSize = true;
            this.totalLabel1.Location = new System.Drawing.Point(315, 114);
            this.totalLabel1.Name = "totalLabel1";
            this.totalLabel1.Size = new System.Drawing.Size(37, 15);
            this.totalLabel1.TabIndex = 11;
            this.totalLabel1.Text = "40000";
            this.totalLabel1.Click += new System.EventHandler(this.totalLabel1_Click);
            // 
            // totalLabel2
            // 
            this.totalLabel2.AutoSize = true;
            this.totalLabel2.Location = new System.Drawing.Point(315, 163);
            this.totalLabel2.Name = "totalLabel2";
            this.totalLabel2.Size = new System.Drawing.Size(37, 15);
            this.totalLabel2.TabIndex = 12;
            this.totalLabel2.Text = "51540";
            this.totalLabel2.Click += new System.EventHandler(this.totalLabel2_Click);
            // 
            // totalLabel3
            // 
            this.totalLabel3.AutoSize = true;
            this.totalLabel3.Location = new System.Drawing.Point(315, 205);
            this.totalLabel3.Name = "totalLabel3";
            this.totalLabel3.Size = new System.Drawing.Size(31, 15);
            this.totalLabel3.TabIndex = 13;
            this.totalLabel3.Text = "4800";
            this.totalLabel3.Click += new System.EventHandler(this.totalLabel3_Click);
            // 
            // averageLabel1
            // 
            this.averageLabel1.AutoSize = true;
            this.averageLabel1.Location = new System.Drawing.Point(444, 114);
            this.averageLabel1.Name = "averageLabel1";
            this.averageLabel1.Size = new System.Drawing.Size(52, 15);
            this.averageLabel1.TabIndex = 14;
            this.averageLabel1.Text = "52750.00";
            this.averageLabel1.Click += new System.EventHandler(this.averageLabel1_Click);
            // 
            // averageLabel2
            // 
            this.averageLabel2.AutoSize = true;
            this.averageLabel2.Location = new System.Drawing.Point(435, 155);
            this.averageLabel2.Name = "averageLabel2";
            this.averageLabel2.Size = new System.Drawing.Size(52, 15);
            this.averageLabel2.TabIndex = 15;
            this.averageLabel2.Text = "44450.00";
            this.averageLabel2.Click += new System.EventHandler(this.averageLabel2_Click);
            // 
            // averageLabel3
            // 
            this.averageLabel3.AutoSize = true;
            this.averageLabel3.Location = new System.Drawing.Point(444, 205);
            this.averageLabel3.Name = "averageLabel3";
            this.averageLabel3.Size = new System.Drawing.Size(52, 15);
            this.averageLabel3.TabIndex = 16;
            this.averageLabel3.Text = "11300.00";
            this.averageLabel3.Click += new System.EventHandler(this.averageLabel3_Click);
            // 
            // turnoverLabel1
            // 
            this.turnoverLabel1.AutoSize = true;
            this.turnoverLabel1.Location = new System.Drawing.Point(554, 119);
            this.turnoverLabel1.Name = "turnoverLabel1";
            this.turnoverLabel1.Size = new System.Drawing.Size(28, 15);
            this.turnoverLabel1.TabIndex = 17;
            this.turnoverLabel1.Text = "0.80";
            this.turnoverLabel1.Click += new System.EventHandler(this.turnoverLabel1_Click);
            // 
            // turnoverLabel2
            // 
            this.turnoverLabel2.AutoSize = true;
            this.turnoverLabel2.Location = new System.Drawing.Point(554, 155);
            this.turnoverLabel2.Name = "turnoverLabel2";
            this.turnoverLabel2.Size = new System.Drawing.Size(28, 15);
            this.turnoverLabel2.TabIndex = 18;
            this.turnoverLabel2.Text = "1.20";
            this.turnoverLabel2.Click += new System.EventHandler(this.turnoverLabel2_Click);
            // 
            // turnoverLabel3
            // 
            this.turnoverLabel3.AutoSize = true;
            this.turnoverLabel3.Location = new System.Drawing.Point(554, 205);
            this.turnoverLabel3.Name = "turnoverLabel3";
            this.turnoverLabel3.Size = new System.Drawing.Size(28, 15);
            this.turnoverLabel3.TabIndex = 19;
            this.turnoverLabel3.Text = "0.40";
            this.turnoverLabel3.Click += new System.EventHandler(this.turnoverLabel3_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 332);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(80, 40);
            this.calculateButton.TabIndex = 20;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 378);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(80, 40);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(98, 332);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(80, 40);
            this.printButton.TabIndex = 22;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(98, 378);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 40);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.turnoverLabel3);
            this.Controls.Add(this.turnoverLabel2);
            this.Controls.Add(this.turnoverLabel1);
            this.Controls.Add(this.averageLabel3);
            this.Controls.Add(this.averageLabel2);
            this.Controls.Add(this.averageLabel1);
            this.Controls.Add(this.totalLabel3);
            this.Controls.Add(this.totalLabel2);
            this.Controls.Add(this.totalLabel1);
            this.Controls.Add(this.endingTextBox3);
            this.Controls.Add(this.endingTextBox2);
            this.Controls.Add(this.endingTextBox1);
            this.Controls.Add(this.beginningTextBox3);
            this.Controls.Add(this.beginningTextBox2);
            this.Controls.Add(this.beginningTextBox1);
            this.Controls.Add(this.turnoverLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.endingLabel);
            this.Controls.Add(this.beginningLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label beginningLabel;
        private Label endingLabel;
        private Label costLabel;
        private Label averageLabel;
        private Label turnoverLabel;
        private TextBox beginningTextBox1;
        private TextBox beginningTextBox2;
        private TextBox beginningTextBox3;
        private TextBox endingTextBox1;
        private TextBox endingTextBox2;
        private TextBox endingTextBox3;
        private Label totalLabel1;
        private Label totalLabel2;
        private Label totalLabel3;
        private Label averageLabel1;
        private Label averageLabel2;
        private Label averageLabel3;
        private Label turnoverLabel1;
        private Label turnoverLabel2;
        private Label turnoverLabel3;
        private Button calculateButton;
        private Button ClearButton;
        private Button printButton;
        private Button exitButton;
    }
}
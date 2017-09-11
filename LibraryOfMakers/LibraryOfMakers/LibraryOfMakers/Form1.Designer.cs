namespace LibraryOfMakers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonISBN = new System.Windows.Forms.Button();
            this.ButtonTitle = new System.Windows.Forms.Button();
            this.ButtonAuthor = new System.Windows.Forms.Button();
            this.ButtonPublisher = new System.Windows.Forms.Button();
            this.ButtonLanguage = new System.Windows.Forms.Button();
            this.ButtonCategory = new System.Windows.Forms.Button();
            this.ButtonCity = new System.Windows.Forms.Button();
            this.ButtonShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(187)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(211, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // ButtonISBN
            // 
            this.ButtonISBN.BackColor = System.Drawing.Color.Maroon;
            this.ButtonISBN.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonISBN.ForeColor = System.Drawing.Color.DarkOrange;
            this.ButtonISBN.Location = new System.Drawing.Point(12, 184);
            this.ButtonISBN.Name = "ButtonISBN";
            this.ButtonISBN.Size = new System.Drawing.Size(82, 23);
            this.ButtonISBN.TabIndex = 1;
            this.ButtonISBN.Text = "ISBN";
            this.ButtonISBN.UseVisualStyleBackColor = false;
            this.ButtonISBN.Click += new System.EventHandler(this.ButtonISBN_Click);
            // 
            // ButtonTitle
            // 
            this.ButtonTitle.BackColor = System.Drawing.Color.Maroon;
            this.ButtonTitle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.ButtonTitle.Location = new System.Drawing.Point(121, 184);
            this.ButtonTitle.Name = "ButtonTitle";
            this.ButtonTitle.Size = new System.Drawing.Size(84, 23);
            this.ButtonTitle.TabIndex = 2;
            this.ButtonTitle.Text = "TITLE";
            this.ButtonTitle.UseVisualStyleBackColor = false;
            this.ButtonTitle.Click += new System.EventHandler(this.ButtonTitle_Click);
            // 
            // ButtonAuthor
            // 
            this.ButtonAuthor.BackColor = System.Drawing.Color.Maroon;
            this.ButtonAuthor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAuthor.ForeColor = System.Drawing.Color.DarkOrange;
            this.ButtonAuthor.Location = new System.Drawing.Point(12, 213);
            this.ButtonAuthor.Name = "ButtonAuthor";
            this.ButtonAuthor.Size = new System.Drawing.Size(82, 23);
            this.ButtonAuthor.TabIndex = 3;
            this.ButtonAuthor.Text = "AUTHOR";
            this.ButtonAuthor.UseVisualStyleBackColor = false;
            this.ButtonAuthor.Click += new System.EventHandler(this.ButtonAuthor_Click);
            // 
            // ButtonPublisher
            // 
            this.ButtonPublisher.BackColor = System.Drawing.Color.Maroon;
            this.ButtonPublisher.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPublisher.ForeColor = System.Drawing.Color.DarkOrange;
            this.ButtonPublisher.Location = new System.Drawing.Point(121, 213);
            this.ButtonPublisher.Name = "ButtonPublisher";
            this.ButtonPublisher.Size = new System.Drawing.Size(84, 23);
            this.ButtonPublisher.TabIndex = 4;
            this.ButtonPublisher.Text = "PUBLISHER";
            this.ButtonPublisher.UseVisualStyleBackColor = false;
            this.ButtonPublisher.Click += new System.EventHandler(this.ButtonPublisher_Click);
            // 
            // ButtonLanguage
            // 
            this.ButtonLanguage.BackColor = System.Drawing.Color.Maroon;
            this.ButtonLanguage.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLanguage.ForeColor = System.Drawing.Color.DarkOrange;
            this.ButtonLanguage.Location = new System.Drawing.Point(12, 242);
            this.ButtonLanguage.Name = "ButtonLanguage";
            this.ButtonLanguage.Size = new System.Drawing.Size(82, 23);
            this.ButtonLanguage.TabIndex = 5;
            this.ButtonLanguage.Text = "LANGUAGE";
            this.ButtonLanguage.UseVisualStyleBackColor = false;
            this.ButtonLanguage.Click += new System.EventHandler(this.ButtonLanguage_Click);
            // 
            // ButtonCategory
            // 
            this.ButtonCategory.BackColor = System.Drawing.Color.Maroon;
            this.ButtonCategory.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.ButtonCategory.Location = new System.Drawing.Point(121, 242);
            this.ButtonCategory.Name = "ButtonCategory";
            this.ButtonCategory.Size = new System.Drawing.Size(84, 23);
            this.ButtonCategory.TabIndex = 6;
            this.ButtonCategory.Text = "CATEGORY";
            this.ButtonCategory.UseVisualStyleBackColor = false;
            this.ButtonCategory.Click += new System.EventHandler(this.ButtonCategory_Click);
            // 
            // ButtonCity
            // 
            this.ButtonCity.BackColor = System.Drawing.Color.Maroon;
            this.ButtonCity.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCity.ForeColor = System.Drawing.Color.DarkOrange;
            this.ButtonCity.Location = new System.Drawing.Point(75, 271);
            this.ButtonCity.Name = "ButtonCity";
            this.ButtonCity.Size = new System.Drawing.Size(75, 23);
            this.ButtonCity.TabIndex = 7;
            this.ButtonCity.Text = "CITY";
            this.ButtonCity.UseVisualStyleBackColor = false;
            this.ButtonCity.Click += new System.EventHandler(this.ButtonCity_Click);
            // 
            // ButtonShowAll
            // 
            this.ButtonShowAll.BackColor = System.Drawing.Color.Maroon;
            this.ButtonShowAll.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowAll.ForeColor = System.Drawing.Color.DarkOrange;
            this.ButtonShowAll.Location = new System.Drawing.Point(45, 110);
            this.ButtonShowAll.Name = "ButtonShowAll";
            this.ButtonShowAll.Size = new System.Drawing.Size(128, 23);
            this.ButtonShowAll.TabIndex = 8;
            this.ButtonShowAll.Text = "SHOW ALL";
            this.ButtonShowAll.UseVisualStyleBackColor = false;
            this.ButtonShowAll.Click += new System.EventHandler(this.ButtonShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(55, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search BY :";
            // 
            // TextValue
            // 
            this.TextValue.BackColor = System.Drawing.Color.Tomato;
            this.TextValue.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextValue.ForeColor = System.Drawing.Color.DarkRed;
            this.TextValue.Location = new System.Drawing.Point(12, 328);
            this.TextValue.Name = "TextValue";
            this.TextValue.Size = new System.Drawing.Size(193, 21);
            this.TextValue.TabIndex = 10;
            this.TextValue.TextChanged += new System.EventHandler(this.TextValue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(85, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "VALUE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(121, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Modify Table";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Library of Makers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(31, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "-ADMINISTRATOR-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1009, 440);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonShowAll);
            this.Controls.Add(this.ButtonCity);
            this.Controls.Add(this.ButtonCategory);
            this.Controls.Add(this.ButtonLanguage);
            this.Controls.Add(this.ButtonPublisher);
            this.Controls.Add(this.ButtonAuthor);
            this.Controls.Add(this.ButtonTitle);
            this.Controls.Add(this.ButtonISBN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Library OF  Makers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonISBN;
        private System.Windows.Forms.Button ButtonTitle;
        private System.Windows.Forms.Button ButtonAuthor;
        private System.Windows.Forms.Button ButtonPublisher;
        private System.Windows.Forms.Button ButtonLanguage;
        private System.Windows.Forms.Button ButtonCategory;
        private System.Windows.Forms.Button ButtonCity;
        private System.Windows.Forms.Button ButtonShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


namespace LibraryOfMakers
{
    partial class Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert));
            this.ISBN = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Page = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.Modified = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.BackColor = System.Drawing.Color.Transparent;
            this.ISBN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.ForeColor = System.Drawing.Color.DarkOrange;
            this.ISBN.Location = new System.Drawing.Point(62, 114);
            this.ISBN.Margin = new System.Windows.Forms.Padding(3);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(39, 20);
            this.ISBN.TabIndex = 1;
            this.ISBN.Text = "ISBN";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkOrange;
            this.Title.Location = new System.Drawing.Point(62, 152);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(33, 20);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.BackColor = System.Drawing.Color.Transparent;
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.ForeColor = System.Drawing.Color.DarkOrange;
            this.Year.Location = new System.Drawing.Point(62, 189);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(43, 20);
            this.Year.TabIndex = 5;
            this.Year.Text = "Year";
            // 
            // Page
            // 
            this.Page.AutoSize = true;
            this.Page.BackColor = System.Drawing.Color.Transparent;
            this.Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page.ForeColor = System.Drawing.Color.DarkOrange;
            this.Page.Location = new System.Drawing.Point(62, 227);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(46, 20);
            this.Page.TabIndex = 7;
            this.Page.Text = "Page";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.BackColor = System.Drawing.Color.Tomato;
            this.textBoxISBN.Location = new System.Drawing.Point(150, 114);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.textBoxISBN.TabIndex = 9;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.Tomato;
            this.textBoxTitle.Location = new System.Drawing.Point(150, 152);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 10;
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.Tomato;
            this.textBoxYear.Location = new System.Drawing.Point(150, 189);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 14;
            // 
            // textBoxPage
            // 
            this.textBoxPage.BackColor = System.Drawing.Color.Tomato;
            this.textBoxPage.Location = new System.Drawing.Point(150, 227);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(100, 20);
            this.textBoxPage.TabIndex = 16;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Tomato;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(66, 286);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 28);
            this.buttonInsert.TabIndex = 18;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 229);
            this.dataGridView1.TabIndex = 19;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Tomato;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(175, 286);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Modified
            // 
            this.Modified.AutoSize = true;
            this.Modified.BackColor = System.Drawing.Color.Transparent;
            this.Modified.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modified.ForeColor = System.Drawing.Color.DarkOrange;
            this.Modified.Location = new System.Drawing.Point(54, 24);
            this.Modified.Name = "Modified";
            this.Modified.Size = new System.Drawing.Size(148, 39);
            this.Modified.TabIndex = 22;
            this.Modified.Text = "Modified";
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(924, 462);
            this.Controls.Add(this.Modified);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxPage);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ISBN);
            this.Name = "Insert";
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Page;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label Modified;
    }
}
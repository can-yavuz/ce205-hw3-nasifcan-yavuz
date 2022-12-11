namespace ce205_hw3_gui
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.valueBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Random = new System.Windows.Forms.Button();
            this.Inorder = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RandomRB = new System.Windows.Forms.Button();
            this.SearchRB = new System.Windows.Forms.Button();
            this.DeleteRB = new System.Windows.Forms.Button();
            this.InsertRB = new System.Windows.Forms.Button();
            this.valueBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1683, 695);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.valueBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Random);
            this.tabPage1.Controls.Add(this.Inorder);
            this.tabPage1.Controls.Add(this.Search);
            this.tabPage1.Controls.Add(this.Delete);
            this.tabPage1.Controls.Add(this.Insert);
            this.tabPage1.Controls.Add(this.Status);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1675, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AVLTree";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // valueBox1
            // 
            this.valueBox1.Location = new System.Drawing.Point(7, 602);
            this.valueBox1.Name = "valueBox1";
            this.valueBox1.Size = new System.Drawing.Size(117, 22);
            this.valueBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1404, 548);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(652, 603);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(117, 42);
            this.Random.TabIndex = 5;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Inorder
            // 
            this.Inorder.Location = new System.Drawing.Point(529, 602);
            this.Inorder.Name = "Inorder";
            this.Inorder.Size = new System.Drawing.Size(117, 42);
            this.Inorder.TabIndex = 4;
            this.Inorder.Text = "Inorder";
            this.Inorder.UseVisualStyleBackColor = true;
            this.Inorder.Click += new System.EventHandler(this.Inorder_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(406, 602);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(117, 42);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(283, 602);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(117, 42);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(160, 602);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(117, 42);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(7, 3);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(44, 16);
            this.Status.TabIndex = 0;
            this.Status.Text = "Status";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.RandomRB);
            this.tabPage2.Controls.Add(this.SearchRB);
            this.tabPage2.Controls.Add(this.DeleteRB);
            this.tabPage2.Controls.Add(this.InsertRB);
            this.tabPage2.Controls.Add(this.valueBox2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1675, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RedBlackTree";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // RandomRB
            // 
            this.RandomRB.Location = new System.Drawing.Point(533, 595);
            this.RandomRB.Name = "RandomRB";
            this.RandomRB.Size = new System.Drawing.Size(117, 42);
            this.RandomRB.TabIndex = 5;
            this.RandomRB.Text = "Random";
            this.RandomRB.UseVisualStyleBackColor = true;
            this.RandomRB.Click += new System.EventHandler(this.RandomRB_Click);
            // 
            // SearchRB
            // 
            this.SearchRB.Location = new System.Drawing.Point(410, 595);
            this.SearchRB.Name = "SearchRB";
            this.SearchRB.Size = new System.Drawing.Size(117, 42);
            this.SearchRB.TabIndex = 4;
            this.SearchRB.Text = "Search";
            this.SearchRB.UseVisualStyleBackColor = true;
            this.SearchRB.Click += new System.EventHandler(this.SearchRB_Click);
            // 
            // DeleteRB
            // 
            this.DeleteRB.Location = new System.Drawing.Point(287, 596);
            this.DeleteRB.Name = "DeleteRB";
            this.DeleteRB.Size = new System.Drawing.Size(117, 42);
            this.DeleteRB.TabIndex = 3;
            this.DeleteRB.Text = "Delete";
            this.DeleteRB.UseVisualStyleBackColor = true;
            this.DeleteRB.Click += new System.EventHandler(this.DeleteRB_Click);
            // 
            // InsertRB
            // 
            this.InsertRB.Location = new System.Drawing.Point(164, 595);
            this.InsertRB.Name = "InsertRB";
            this.InsertRB.Size = new System.Drawing.Size(117, 42);
            this.InsertRB.TabIndex = 2;
            this.InsertRB.Text = "Insert";
            this.InsertRB.UseVisualStyleBackColor = true;
            this.InsertRB.Click += new System.EventHandler(this.InsertRB_Click);
            // 
            // valueBox2
            // 
            this.valueBox2.Location = new System.Drawing.Point(22, 596);
            this.valueBox2.Name = "valueBox2";
            this.valueBox2.Size = new System.Drawing.Size(117, 22);
            this.valueBox2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(22, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1534, 550);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 690);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ce205-hw3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox valueBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button Random;
        public System.Windows.Forms.Button Inorder;
        public System.Windows.Forms.Button Search;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Button Insert;
        public System.Windows.Forms.Label Status;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button RandomRB;
        public System.Windows.Forms.Button SearchRB;
        public System.Windows.Forms.Button DeleteRB;
        public System.Windows.Forms.Button InsertRB;
        public System.Windows.Forms.TextBox valueBox2;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}


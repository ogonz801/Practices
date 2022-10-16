namespace NoteTakingApp
{
    partial class Notes
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noteHistory = new System.Windows.Forms.DataGridView();
            this.loadBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noteHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(437, 55);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(285, 20);
            this.titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(437, 118);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(285, 329);
            this.noteBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(437, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(434, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // noteHistory
            // 
            this.noteHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.noteHistory.BackgroundColor = System.Drawing.Color.White;
            this.noteHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noteHistory.Location = new System.Drawing.Point(156, 55);
            this.noteHistory.Name = "noteHistory";
            this.noteHistory.Size = new System.Drawing.Size(255, 318);
            this.noteHistory.TabIndex = 4;
            this.noteHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.noteHistory_CellDoubleClick);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(156, 379);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(121, 31);
            this.loadBtn.TabIndex = 5;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(296, 379);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(115, 31);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(296, 416);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(115, 31);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(156, 416);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(121, 31);
            this.newBtn.TabIndex = 7;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(274, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "History";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.noteHistory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noteHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView noteHistory;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Label label3;
    }
}


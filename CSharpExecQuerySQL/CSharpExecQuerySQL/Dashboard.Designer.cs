namespace CSharpExecQuerySQL
{
    partial class Dashboard
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
            this.searchButton = new System.Windows.Forms.Button();
            this.FirstDateLabel = new System.Windows.Forms.Label();
            this.LastDateTabel = new System.Windows.Forms.Label();
            this.exportExcelButton = new System.Windows.Forms.Button();
            this.sqlDataSet = new System.Data.DataSet();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 415);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // FirstDateLabel
            // 
            this.FirstDateLabel.AutoSize = true;
            this.FirstDateLabel.Location = new System.Drawing.Point(12, 16);
            this.FirstDateLabel.Name = "FirstDateLabel";
            this.FirstDateLabel.Size = new System.Drawing.Size(52, 13);
            this.FirstDateLabel.TabIndex = 4;
            this.FirstDateLabel.Text = "First Date";
            // 
            // LastDateTabel
            // 
            this.LastDateTabel.AutoSize = true;
            this.LastDateTabel.Location = new System.Drawing.Point(15, 61);
            this.LastDateTabel.Name = "LastDateTabel";
            this.LastDateTabel.Size = new System.Drawing.Size(50, 13);
            this.LastDateTabel.TabIndex = 5;
            this.LastDateTabel.Text = "LastDate";
            // 
            // exportExcelButton
            // 
            this.exportExcelButton.Location = new System.Drawing.Point(700, 94);
            this.exportExcelButton.Name = "exportExcelButton";
            this.exportExcelButton.Size = new System.Drawing.Size(75, 37);
            this.exportExcelButton.TabIndex = 14;
            this.exportExcelButton.Text = "Export to Excel";
            this.exportExcelButton.UseVisualStyleBackColor = true;
            this.exportExcelButton.Click += new System.EventHandler(this.exportExcelButton_Click);
            // 
            // sqlDataSet
            // 
            this.sqlDataSet.DataSetName = "NewDataSet";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DataSource = this.sqlDataSet;
            this.dataGridView.Location = new System.Drawing.Point(18, 94);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(655, 302);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.VirtualMode = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(112, 61);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.exportExcelButton);
            this.Controls.Add(this.LastDateTabel);
            this.Controls.Add(this.FirstDateLabel);
            this.Controls.Add(this.searchButton);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label FirstDateLabel;
        private System.Windows.Forms.Label LastDateTabel;
        private System.Windows.Forms.Button exportExcelButton;
        private System.Data.DataSet sqlDataSet;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}


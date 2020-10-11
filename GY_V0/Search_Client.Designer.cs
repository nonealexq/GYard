namespace GY_V0
{
    partial class Search_Client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gYardDataSetClient = new GY_V0.GYardDataSetClient();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new GY_V0.GYardDataSetClientTableAdapters.ClientTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedeathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coor1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coor2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.datebirthDataGridViewTextBoxColumn,
            this.datedeathDataGridViewTextBoxColumn,
            this.yardDataGridViewTextBoxColumn,
            this.coor1DataGridViewTextBoxColumn,
            this.coor2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(894, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // gYardDataSetClient
            // 
            this.gYardDataSetClient.DataSetName = "GYardDataSetClient";
            this.gYardDataSetClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.gYardDataSetClient;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(883, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datebirthDataGridViewTextBoxColumn
            // 
            this.datebirthDataGridViewTextBoxColumn.DataPropertyName = "date_birth";
            this.datebirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.datebirthDataGridViewTextBoxColumn.Name = "datebirthDataGridViewTextBoxColumn";
            this.datebirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.datebirthDataGridViewTextBoxColumn.Width = 130;
            // 
            // datedeathDataGridViewTextBoxColumn
            // 
            this.datedeathDataGridViewTextBoxColumn.DataPropertyName = "date_death";
            this.datedeathDataGridViewTextBoxColumn.HeaderText = "Дата смерти";
            this.datedeathDataGridViewTextBoxColumn.Name = "datedeathDataGridViewTextBoxColumn";
            this.datedeathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yardDataGridViewTextBoxColumn
            // 
            this.yardDataGridViewTextBoxColumn.DataPropertyName = "yard";
            this.yardDataGridViewTextBoxColumn.HeaderText = "Кладбище";
            this.yardDataGridViewTextBoxColumn.Name = "yardDataGridViewTextBoxColumn";
            this.yardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coor1DataGridViewTextBoxColumn
            // 
            this.coor1DataGridViewTextBoxColumn.DataPropertyName = "coor_1";
            this.coor1DataGridViewTextBoxColumn.HeaderText = "Координата 1";
            this.coor1DataGridViewTextBoxColumn.Name = "coor1DataGridViewTextBoxColumn";
            this.coor1DataGridViewTextBoxColumn.ReadOnly = true;
            this.coor1DataGridViewTextBoxColumn.Width = 130;
            // 
            // coor2DataGridViewTextBoxColumn
            // 
            this.coor2DataGridViewTextBoxColumn.DataPropertyName = "coor_2";
            this.coor2DataGridViewTextBoxColumn.HeaderText = "Координата 2";
            this.coor2DataGridViewTextBoxColumn.Name = "coor2DataGridViewTextBoxColumn";
            this.coor2DataGridViewTextBoxColumn.ReadOnly = true;
            this.coor2DataGridViewTextBoxColumn.Width = 130;
            // 
            // Search_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Search_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search_Client";
            this.Load += new System.EventHandler(this.Search_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GYardDataSetClient gYardDataSetClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private GYardDataSetClientTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedeathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coor1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coor2DataGridViewTextBoxColumn;
    }
}
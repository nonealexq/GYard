namespace GY_V0
{
    partial class YardAll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BackToMain = new System.Windows.Forms.Button();
            this.OpenYardAdd = new System.Windows.Forms.Button();
            this.YardData = new System.Windows.Forms.DataGridView();
            this.yardnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yard_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yardBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gYardDataSetYardAddress = new GY_V0.GYardDataSetYardAddress();
            this.yardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYardDataSetYardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYardDataSetYard = new GY_V0.GYardDataSetYard();
            this.yardTableAdapter = new GY_V0.GYardDataSetYardTableAdapters.YardTableAdapter();
            this.yardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yardTableAdapter1 = new GY_V0.GYardDataSetYardAddressTableAdapters.YardTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.YardData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetYardAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetYardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetYard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMain
            // 
            this.BackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMain.Location = new System.Drawing.Point(59, 436);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(110, 50);
            this.BackToMain.TabIndex = 2;
            this.BackToMain.Text = "Назад";
            this.BackToMain.UseVisualStyleBackColor = true;
            this.BackToMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenYardAdd
            // 
            this.OpenYardAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenYardAdd.Location = new System.Drawing.Point(204, 436);
            this.OpenYardAdd.Name = "OpenYardAdd";
            this.OpenYardAdd.Size = new System.Drawing.Size(190, 50);
            this.OpenYardAdd.TabIndex = 3;
            this.OpenYardAdd.Text = "Добавить кладбище";
            this.OpenYardAdd.UseVisualStyleBackColor = true;
            this.OpenYardAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // YardData
            // 
            this.YardData.AllowUserToAddRows = false;
            this.YardData.AllowUserToDeleteRows = false;
            this.YardData.AllowUserToResizeColumns = false;
            this.YardData.AllowUserToResizeRows = false;
            this.YardData.AutoGenerateColumns = false;
            this.YardData.BackgroundColor = System.Drawing.Color.SlateGray;
            this.YardData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YardData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.YardData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.YardData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.YardData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YardData.ColumnHeadersVisible = false;
            this.YardData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yardnameDataGridViewTextBoxColumn,
            this.yard_address});
            this.YardData.DataSource = this.yardBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.YardData.DefaultCellStyle = dataGridViewCellStyle2;
            this.YardData.Location = new System.Drawing.Point(59, 39);
            this.YardData.Name = "YardData";
            this.YardData.ReadOnly = true;
            this.YardData.RowHeadersVisible = false;
            this.YardData.Size = new System.Drawing.Size(750, 358);
            this.YardData.TabIndex = 1;
            // 
            // yardnameDataGridViewTextBoxColumn
            // 
            this.yardnameDataGridViewTextBoxColumn.DataPropertyName = "yard_name";
            this.yardnameDataGridViewTextBoxColumn.HeaderText = "yard_name";
            this.yardnameDataGridViewTextBoxColumn.Name = "yardnameDataGridViewTextBoxColumn";
            this.yardnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.yardnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // yard_address
            // 
            this.yard_address.DataPropertyName = "yard_address";
            this.yard_address.HeaderText = "yard_address";
            this.yard_address.Name = "yard_address";
            this.yard_address.ReadOnly = true;
            this.yard_address.Width = 600;
            // 
            // yardBindingSource2
            // 
            this.yardBindingSource2.DataMember = "Yard";
            this.yardBindingSource2.DataSource = this.gYardDataSetYardAddress;
            // 
            // gYardDataSetYardAddress
            // 
            this.gYardDataSetYardAddress.DataSetName = "GYardDataSetYardAddress";
            this.gYardDataSetYardAddress.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yardBindingSource
            // 
            this.yardBindingSource.DataMember = "Yard";
            this.yardBindingSource.DataSource = this.gYardDataSetYardBindingSource;
            // 
            // gYardDataSetYardBindingSource
            // 
            this.gYardDataSetYardBindingSource.DataSource = this.gYardDataSetYard;
            this.gYardDataSetYardBindingSource.Position = 0;
            // 
            // gYardDataSetYard
            // 
            this.gYardDataSetYard.DataSetName = "GYardDataSetYard";
            this.gYardDataSetYard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yardTableAdapter
            // 
            this.yardTableAdapter.ClearBeforeFill = true;
            // 
            // yardBindingSource1
            // 
            this.yardBindingSource1.DataMember = "Yard";
            this.yardBindingSource1.DataSource = this.gYardDataSetYardBindingSource;
            // 
            // yardTableAdapter1
            // 
            this.yardTableAdapter1.ClearBeforeFill = true;
            // 
            // YardAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.YardData);
            this.Controls.Add(this.OpenYardAdd);
            this.Controls.Add(this.BackToMain);
            this.Name = "YardAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр кладбищ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YardAll_FormClosing);
            this.Load += new System.EventHandler(this.YardAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YardData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetYardAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetYardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetYard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackToMain;
        private System.Windows.Forms.Button OpenYardAdd;
        private System.Windows.Forms.DataGridView YardData;
        private System.Windows.Forms.BindingSource gYardDataSetYardBindingSource;
        private GYardDataSetYard gYardDataSetYard;
        private System.Windows.Forms.BindingSource yardBindingSource;
        private GYardDataSetYardTableAdapters.YardTableAdapter yardTableAdapter;
        private System.Windows.Forms.BindingSource yardBindingSource1;
        private GYardDataSetYardAddress gYardDataSetYardAddress;
        private System.Windows.Forms.BindingSource yardBindingSource2;
        private GYardDataSetYardAddressTableAdapters.YardTableAdapter yardTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yardnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yard_address;
    }
}
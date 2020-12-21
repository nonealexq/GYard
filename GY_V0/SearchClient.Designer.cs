namespace GY_V0
{
    partial class SearchClient
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
            this.ClientSearchData = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYardDataSetClient = new GY_V0.GYardDataSetClient();
            this.clientTableAdapter = new GY_V0.GYardDataSetClientTableAdapters.ClientTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BackToMain = new System.Windows.Forms.Button();
            this.ShowInfo = new System.Windows.Forms.Button();
            this.last_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_death_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yard_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coor1_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coor2_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientSearchData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetClient)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientSearchData
            // 
            this.ClientSearchData.AllowUserToAddRows = false;
            this.ClientSearchData.AllowUserToDeleteRows = false;
            this.ClientSearchData.AutoGenerateColumns = false;
            this.ClientSearchData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientSearchData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.last_name_column,
            this.first_name_column,
            this.patronymic_column,
            this.date_birth_column,
            this.date_death_column,
            this.yard_column,
            this.coor1_column,
            this.coor2_column});
            this.ClientSearchData.DataSource = this.clientBindingSource;
            this.ClientSearchData.Location = new System.Drawing.Point(12, 27);
            this.ClientSearchData.Name = "ClientSearchData";
            this.ClientSearchData.ReadOnly = true;
            this.ClientSearchData.RowHeadersVisible = false;
            this.ClientSearchData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientSearchData.Size = new System.Drawing.Size(860, 398);
            this.ClientSearchData.TabIndex = 0;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.gYardDataSetClient;
            // 
            // gYardDataSetClient
            // 
            this.gYardDataSetClient.DataSetName = "GYardDataSetClient";
            this.gYardDataSetClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(108, 481);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(110, 15);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Имя";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SlateGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(108, 453);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(110, 15);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Фамилия";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SlateGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(108, 511);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(110, 15);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Отчество";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(241, 450);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(110, 22);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(241, 478);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(110, 22);
            this.textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(241, 506);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(110, 22);
            this.textBox9.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 50);
            this.button2.TabIndex = 14;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 50);
            this.button3.TabIndex = 15;
            this.button3.Text = "Сброс";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackToMain
            // 
            this.BackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMain.Location = new System.Drawing.Point(762, 476);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(110, 50);
            this.BackToMain.TabIndex = 16;
            this.BackToMain.Text = "Назад";
            this.BackToMain.UseVisualStyleBackColor = true;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // ShowInfo
            // 
            this.ShowInfo.Location = new System.Drawing.Point(414, 476);
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.Size = new System.Drawing.Size(110, 50);
            this.ShowInfo.TabIndex = 18;
            this.ShowInfo.Text = "Показать данные";
            this.ShowInfo.UseVisualStyleBackColor = true;
            this.ShowInfo.Click += new System.EventHandler(this.ShowInfo_Click);
            // 
            // last_name_column
            // 
            this.last_name_column.DataPropertyName = "last_name";
            this.last_name_column.HeaderText = "Фамилия";
            this.last_name_column.Name = "last_name_column";
            this.last_name_column.ReadOnly = true;
            // 
            // first_name_column
            // 
            this.first_name_column.DataPropertyName = "first_name";
            this.first_name_column.HeaderText = "Имя";
            this.first_name_column.Name = "first_name_column";
            this.first_name_column.ReadOnly = true;
            // 
            // patronymic_column
            // 
            this.patronymic_column.DataPropertyName = "patronymic";
            this.patronymic_column.HeaderText = "Отчество";
            this.patronymic_column.Name = "patronymic_column";
            this.patronymic_column.ReadOnly = true;
            // 
            // date_birth_column
            // 
            this.date_birth_column.DataPropertyName = "date_birth";
            this.date_birth_column.HeaderText = "Дата рождения";
            this.date_birth_column.Name = "date_birth_column";
            this.date_birth_column.ReadOnly = true;
            this.date_birth_column.Width = 130;
            // 
            // date_death_column
            // 
            this.date_death_column.DataPropertyName = "date_death";
            this.date_death_column.HeaderText = "Дата смерти";
            this.date_death_column.Name = "date_death_column";
            this.date_death_column.ReadOnly = true;
            // 
            // yard_column
            // 
            this.yard_column.DataPropertyName = "yard";
            this.yard_column.HeaderText = "Кладбище";
            this.yard_column.Name = "yard_column";
            this.yard_column.ReadOnly = true;
            // 
            // coor1_column
            // 
            this.coor1_column.DataPropertyName = "coor_1";
            this.coor1_column.HeaderText = "Координата 1";
            this.coor1_column.Name = "coor1_column";
            this.coor1_column.ReadOnly = true;
            this.coor1_column.Width = 130;
            // 
            // coor2_column
            // 
            this.coor2_column.DataPropertyName = "coor_2";
            this.coor2_column.HeaderText = "Координата 2";
            this.coor2_column.Name = "coor2_column";
            this.coor2_column.ReadOnly = true;
            this.coor2_column.Width = 130;
            // 
            // SearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ShowInfo);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClientSearchData);
            this.Name = "SearchClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_Client_FormClosing);
            this.Load += new System.EventHandler(this.Search_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientSearchData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientSearchData;
        private GYardDataSetClient gYardDataSetClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private GYardDataSetClientTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BackToMain;
        private System.Windows.Forms.Button ShowInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_death_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn yard_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn coor1_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn coor2_column;
    }
}
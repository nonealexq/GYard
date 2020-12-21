using System;
using System.Runtime.CompilerServices;

namespace GY_V0
{
    partial class Client
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
            this.NewFirstName = new System.Windows.Forms.TextBox();
            this.NewLastName = new System.Windows.Forms.TextBox();
            this.NewPatronymic = new System.Windows.Forms.TextBox();
            this.NewDateBirth = new System.Windows.Forms.TextBox();
            this.NewDateDeath = new System.Windows.Forms.TextBox();
            this.NewYard = new System.Windows.Forms.TextBox();
            this.NewGPS1 = new System.Windows.Forms.TextBox();
            this.NewGPS2 = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.GPS1 = new System.Windows.Forms.TextBox();
            this.GPS2 = new System.Windows.Forms.TextBox();
            this.DateBirth = new System.Windows.Forms.DateTimePicker();
            this.DateDeath = new System.Windows.Forms.DateTimePicker();
            this.SaveClient = new System.Windows.Forms.Button();
            this.BackToMain = new System.Windows.Forms.Button();
            this.gYardDataSetYard = new GY_V0.GYardDataSetYard();
            this.yardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yardTableAdapter = new GY_V0.GYardDataSetYardTableAdapters.YardTableAdapter();
            this.YardName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetYard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NewFirstName
            // 
            this.NewFirstName.BackColor = System.Drawing.Color.SlateGray;
            this.NewFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewFirstName.Location = new System.Drawing.Point(79, 133);
            this.NewFirstName.Name = "NewFirstName";
            this.NewFirstName.ReadOnly = true;
            this.NewFirstName.Size = new System.Drawing.Size(110, 15);
            this.NewFirstName.TabIndex = 0;
            this.NewFirstName.TabStop = false;
            this.NewFirstName.Text = "Имя:";
            // 
            // NewLastName
            // 
            this.NewLastName.BackColor = System.Drawing.Color.SlateGray;
            this.NewLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewLastName.Location = new System.Drawing.Point(79, 107);
            this.NewLastName.Name = "NewLastName";
            this.NewLastName.ReadOnly = true;
            this.NewLastName.Size = new System.Drawing.Size(110, 15);
            this.NewLastName.TabIndex = 1;
            this.NewLastName.TabStop = false;
            this.NewLastName.Text = "Фамилия:";
            // 
            // NewPatronymic
            // 
            this.NewPatronymic.BackColor = System.Drawing.Color.SlateGray;
            this.NewPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPatronymic.Location = new System.Drawing.Point(79, 159);
            this.NewPatronymic.Name = "NewPatronymic";
            this.NewPatronymic.ReadOnly = true;
            this.NewPatronymic.Size = new System.Drawing.Size(110, 15);
            this.NewPatronymic.TabIndex = 2;
            this.NewPatronymic.TabStop = false;
            this.NewPatronymic.Text = "Отчество:";
            // 
            // NewDateBirth
            // 
            this.NewDateBirth.BackColor = System.Drawing.Color.SlateGray;
            this.NewDateBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewDateBirth.Location = new System.Drawing.Point(79, 185);
            this.NewDateBirth.Name = "NewDateBirth";
            this.NewDateBirth.ReadOnly = true;
            this.NewDateBirth.Size = new System.Drawing.Size(110, 15);
            this.NewDateBirth.TabIndex = 3;
            this.NewDateBirth.TabStop = false;
            this.NewDateBirth.Text = "Дата рождения:";
            // 
            // NewDateDeath
            // 
            this.NewDateDeath.BackColor = System.Drawing.Color.SlateGray;
            this.NewDateDeath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewDateDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewDateDeath.Location = new System.Drawing.Point(79, 211);
            this.NewDateDeath.Name = "NewDateDeath";
            this.NewDateDeath.ReadOnly = true;
            this.NewDateDeath.Size = new System.Drawing.Size(110, 15);
            this.NewDateDeath.TabIndex = 4;
            this.NewDateDeath.TabStop = false;
            this.NewDateDeath.Text = "Дата смерти:";
            // 
            // NewYard
            // 
            this.NewYard.BackColor = System.Drawing.Color.SlateGray;
            this.NewYard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewYard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewYard.Location = new System.Drawing.Point(79, 237);
            this.NewYard.Name = "NewYard";
            this.NewYard.ReadOnly = true;
            this.NewYard.Size = new System.Drawing.Size(110, 15);
            this.NewYard.TabIndex = 5;
            this.NewYard.TabStop = false;
            this.NewYard.Text = "Кладбище:";
            // 
            // NewGPS1
            // 
            this.NewGPS1.BackColor = System.Drawing.Color.SlateGray;
            this.NewGPS1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewGPS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGPS1.Location = new System.Drawing.Point(79, 263);
            this.NewGPS1.Name = "NewGPS1";
            this.NewGPS1.ReadOnly = true;
            this.NewGPS1.Size = new System.Drawing.Size(110, 15);
            this.NewGPS1.TabIndex = 6;
            this.NewGPS1.TabStop = false;
            this.NewGPS1.Text = "Координата 1:";
            // 
            // NewGPS2
            // 
            this.NewGPS2.BackColor = System.Drawing.Color.SlateGray;
            this.NewGPS2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewGPS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGPS2.Location = new System.Drawing.Point(79, 289);
            this.NewGPS2.Name = "NewGPS2";
            this.NewGPS2.ReadOnly = true;
            this.NewGPS2.Size = new System.Drawing.Size(110, 15);
            this.NewGPS2.TabIndex = 7;
            this.NewGPS2.TabStop = false;
            this.NewGPS2.Text = "Координата 2:";
            // 
            // LastName
            // 
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(261, 107);
            this.LastName.MaxLength = 20;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(213, 22);
            this.LastName.TabIndex = 1;
            // 
            // FirstName
            // 
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(261, 133);
            this.FirstName.MaxLength = 20;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(213, 22);
            this.FirstName.TabIndex = 2;
            // 
            // Patronymic
            // 
            this.Patronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronymic.Location = new System.Drawing.Point(261, 159);
            this.Patronymic.MaxLength = 20;
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(213, 22);
            this.Patronymic.TabIndex = 3;
            // 
            // GPS1
            // 
            this.GPS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GPS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GPS1.Location = new System.Drawing.Point(261, 263);
            this.GPS1.MaxLength = 10;
            this.GPS1.Name = "GPS1";
            this.GPS1.Size = new System.Drawing.Size(213, 22);
            this.GPS1.TabIndex = 7;
            // 
            // GPS2
            // 
            this.GPS2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GPS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GPS2.Location = new System.Drawing.Point(261, 289);
            this.GPS2.MaxLength = 10;
            this.GPS2.Name = "GPS2";
            this.GPS2.Size = new System.Drawing.Size(213, 22);
            this.GPS2.TabIndex = 8;
            // 
            // DateBirth
            // 
            this.DateBirth.Checked = false;
            this.DateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBirth.Location = new System.Drawing.Point(261, 185);
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.ShowCheckBox = true;
            this.DateBirth.Size = new System.Drawing.Size(213, 22);
            this.DateBirth.TabIndex = 4;
            this.DateBirth.ValueChanged += new System.EventHandler(this.DateBirth_ValueChanged);
            // 
            // DateDeath
            // 
            this.DateDeath.Checked = false;
            this.DateDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateDeath.Location = new System.Drawing.Point(261, 208);
            this.DateDeath.Name = "DateDeath";
            this.DateDeath.ShowCheckBox = true;
            this.DateDeath.Size = new System.Drawing.Size(213, 22);
            this.DateDeath.TabIndex = 5;
            this.DateDeath.ValueChanged += new System.EventHandler(this.DateDeath_ValueChanged);
            // 
            // SaveClient
            // 
            this.SaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveClient.Location = new System.Drawing.Point(261, 442);
            this.SaveClient.Name = "SaveClient";
            this.SaveClient.Size = new System.Drawing.Size(100, 50);
            this.SaveClient.TabIndex = 10;
            this.SaveClient.Text = "Сохранить";
            this.SaveClient.UseVisualStyleBackColor = true;
            this.SaveClient.Click += new System.EventHandler(this.SaveClient_Click);
            // 
            // BackToMain
            // 
            this.BackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMain.Location = new System.Drawing.Point(80, 442);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(110, 50);
            this.BackToMain.TabIndex = 9;
            this.BackToMain.Text = "Назад";
            this.BackToMain.UseVisualStyleBackColor = true;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // gYardDataSetYard
            // 
            this.gYardDataSetYard.DataSetName = "GYardDataSetYard";
            this.gYardDataSetYard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yardBindingSource
            // 
            this.yardBindingSource.DataMember = "Yard";
            this.yardBindingSource.DataSource = this.gYardDataSetYard;
            // 
            // yardTableAdapter
            // 
            this.yardTableAdapter.ClearBeforeFill = true;
            // 
            // YardName
            // 
            this.YardName.AllowDrop = true;
            this.YardName.DataSource = this.yardBindingSource;
            this.YardName.DisplayMember = "yard_name";
            this.YardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YardName.FormattingEnabled = true;
            this.YardName.Location = new System.Drawing.Point(261, 237);
            this.YardName.Name = "YardName";
            this.YardName.Size = new System.Drawing.Size(213, 24);
            this.YardName.TabIndex = 6;
            this.YardName.ValueMember = "yard_name";
            // 
            // Client
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.YardName);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.SaveClient);
            this.Controls.Add(this.DateDeath);
            this.Controls.Add(this.DateBirth);
            this.Controls.Add(this.GPS2);
            this.Controls.Add(this.GPS1);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.NewGPS2);
            this.Controls.Add(this.NewGPS1);
            this.Controls.Add(this.NewYard);
            this.Controls.Add(this.NewDateDeath);
            this.Controls.Add(this.NewDateBirth);
            this.Controls.Add(this.NewPatronymic);
            this.Controls.Add(this.NewLastName);
            this.Controls.Add(this.NewFirstName);
            this.KeyPreview = true;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gYardDataSetYard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox NewFirstName;
        private System.Windows.Forms.TextBox NewLastName;
        private System.Windows.Forms.TextBox NewPatronymic;
        private System.Windows.Forms.TextBox NewDateBirth;
        private System.Windows.Forms.TextBox NewDateDeath;
        private System.Windows.Forms.TextBox NewYard;
        private System.Windows.Forms.TextBox NewGPS1;
        private System.Windows.Forms.TextBox NewGPS2;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.TextBox GPS1;
        private System.Windows.Forms.TextBox GPS2;
        private System.Windows.Forms.DateTimePicker DateBirth;
        private System.Windows.Forms.DateTimePicker DateDeath;
        private System.Windows.Forms.Button SaveClient;
        private System.Windows.Forms.Button BackToMain;
        private GYardDataSetYard gYardDataSetYard;
        private System.Windows.Forms.BindingSource yardBindingSource;
        private GYardDataSetYardTableAdapters.YardTableAdapter yardTableAdapter;
        private System.Windows.Forms.ComboBox YardName;
    }
}
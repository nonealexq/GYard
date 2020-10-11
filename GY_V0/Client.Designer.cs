using System;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.yard = new System.Windows.Forms.TextBox();
            this.coor_1 = new System.Windows.Forms.TextBox();
            this.coor_2 = new System.Windows.Forms.TextBox();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.date_death = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Имя";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Фамилия";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(93, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Отчество";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(62, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(93, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Дата рождения";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(62, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(93, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Дата смерти";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(62, 179);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(93, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Кладбище";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(62, 205);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(93, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Координата 1";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(62, 231);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(93, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Координата 2";
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(244, 49);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(213, 20);
            this.last_name.TabIndex = 8;
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(244, 75);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(213, 20);
            this.first_name.TabIndex = 9;
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(244, 101);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(213, 20);
            this.patronymic.TabIndex = 10;
            // 
            // yard
            // 
            this.yard.Location = new System.Drawing.Point(244, 179);
            this.yard.Name = "yard";
            this.yard.Size = new System.Drawing.Size(213, 20);
            this.yard.TabIndex = 11;
            // 
            // coor_1
            // 
            this.coor_1.Location = new System.Drawing.Point(244, 205);
            this.coor_1.Name = "coor_1";
            this.coor_1.Size = new System.Drawing.Size(213, 20);
            this.coor_1.TabIndex = 12;
            // 
            // coor_2
            // 
            this.coor_2.Location = new System.Drawing.Point(244, 231);
            this.coor_2.Name = "coor_2";
            this.coor_2.Size = new System.Drawing.Size(213, 20);
            this.coor_2.TabIndex = 13;
            // 
            // date_birth
            // 
            this.date_birth.Location = new System.Drawing.Point(244, 127);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(213, 20);
            this.date_birth.TabIndex = 14;
            // 
            // date_death
            // 
            this.date_death.Location = new System.Drawing.Point(244, 150);
            this.date_death.Name = "date_death";
            this.date_death.Size = new System.Drawing.Size(213, 20);
            this.date_death.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_death);
            this.Controls.Add(this.date_birth);
            this.Controls.Add(this.coor_2);
            this.Controls.Add(this.coor_1);
            this.Controls.Add(this.yard);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox yard;
        private System.Windows.Forms.TextBox coor_1;
        private System.Windows.Forms.TextBox coor_2;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.DateTimePicker date_death;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
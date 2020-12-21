namespace GY_V0
{
    partial class YardAdd
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
            this.BackToYardAll = new System.Windows.Forms.Button();
            this.NewYardName = new System.Windows.Forms.TextBox();
            this.NewYardAddress = new System.Windows.Forms.TextBox();
            this.yard_name = new System.Windows.Forms.TextBox();
            this.yard_address = new System.Windows.Forms.TextBox();
            this.AddNewYard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToYardAll
            // 
            this.BackToYardAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToYardAll.Location = new System.Drawing.Point(50, 471);
            this.BackToYardAll.Name = "BackToYardAll";
            this.BackToYardAll.Size = new System.Drawing.Size(110, 50);
            this.BackToYardAll.TabIndex = 3;
            this.BackToYardAll.Text = "Назад";
            this.BackToYardAll.UseVisualStyleBackColor = true;
            this.BackToYardAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewYardName
            // 
            this.NewYardName.BackColor = System.Drawing.Color.SlateGray;
            this.NewYardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewYardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewYardName.Location = new System.Drawing.Point(60, 199);
            this.NewYardName.Name = "NewYardName";
            this.NewYardName.ReadOnly = true;
            this.NewYardName.Size = new System.Drawing.Size(100, 15);
            this.NewYardName.TabIndex = 1;
            this.NewYardName.TabStop = false;
            this.NewYardName.Text = "Название:";
            // 
            // NewYardAddress
            // 
            this.NewYardAddress.BackColor = System.Drawing.Color.SlateGray;
            this.NewYardAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewYardAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewYardAddress.Location = new System.Drawing.Point(60, 240);
            this.NewYardAddress.Name = "NewYardAddress";
            this.NewYardAddress.ReadOnly = true;
            this.NewYardAddress.Size = new System.Drawing.Size(100, 15);
            this.NewYardAddress.TabIndex = 2;
            this.NewYardAddress.TabStop = false;
            this.NewYardAddress.Text = "Адрес:";
            this.NewYardAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // yard_name
            // 
            this.yard_name.AcceptsTab = true;
            this.yard_name.AllowDrop = true;
            this.yard_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yard_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yard_name.Location = new System.Drawing.Point(183, 199);
            this.yard_name.MaxLength = 50;
            this.yard_name.Name = "yard_name";
            this.yard_name.Size = new System.Drawing.Size(609, 22);
            this.yard_name.TabIndex = 1;
            // 
            // yard_address
            // 
            this.yard_address.AcceptsTab = true;
            this.yard_address.AllowDrop = true;
            this.yard_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yard_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yard_address.Location = new System.Drawing.Point(183, 242);
            this.yard_address.MaxLength = 150;
            this.yard_address.Name = "yard_address";
            this.yard_address.Size = new System.Drawing.Size(609, 22);
            this.yard_address.TabIndex = 2;
            // 
            // AddNewYard
            // 
            this.AddNewYard.BackColor = System.Drawing.Color.Gainsboro;
            this.AddNewYard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewYard.Location = new System.Drawing.Point(183, 471);
            this.AddNewYard.Name = "AddNewYard";
            this.AddNewYard.Size = new System.Drawing.Size(110, 50);
            this.AddNewYard.TabIndex = 4;
            this.AddNewYard.Text = "Добавить";
            this.AddNewYard.UseVisualStyleBackColor = false;
            this.AddNewYard.Click += new System.EventHandler(this.button2_Click);
            // 
            // YardAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.AddNewYard);
            this.Controls.Add(this.yard_address);
            this.Controls.Add(this.yard_name);
            this.Controls.Add(this.NewYardAddress);
            this.Controls.Add(this.NewYardName);
            this.Controls.Add(this.BackToYardAll);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "YardAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление кладбища";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YardAdd_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToYardAll;
        private System.Windows.Forms.TextBox NewYardName;
        private System.Windows.Forms.TextBox NewYardAddress;
        private System.Windows.Forms.TextBox yard_name;
        private System.Windows.Forms.TextBox yard_address;
        private System.Windows.Forms.Button AddNewYard;
    }
}
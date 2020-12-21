namespace GY_V0
{
    partial class ClientInfo
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
            this.BackToSearchClient = new System.Windows.Forms.Button();
            this.ClientInfoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackToSearchClient
            // 
            this.BackToSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToSearchClient.Location = new System.Drawing.Point(91, 458);
            this.BackToSearchClient.Name = "BackToSearchClient";
            this.BackToSearchClient.Size = new System.Drawing.Size(110, 50);
            this.BackToSearchClient.TabIndex = 3;
            this.BackToSearchClient.Text = "Назад";
            this.BackToSearchClient.UseVisualStyleBackColor = true;
            this.BackToSearchClient.Click += new System.EventHandler(this.BackToSearchClient_Click);
            // 
            // ClientInfoTextBox
            // 
            this.ClientInfoTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.ClientInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientInfoTextBox.Location = new System.Drawing.Point(91, 38);
            this.ClientInfoTextBox.Multiline = true;
            this.ClientInfoTextBox.Name = "ClientInfoTextBox";
            this.ClientInfoTextBox.ReadOnly = true;
            this.ClientInfoTextBox.Size = new System.Drawing.Size(720, 171);
            this.ClientInfoTextBox.TabIndex = 6;
            this.ClientInfoTextBox.TabStop = false;
            this.ClientInfoTextBox.Text = "Информация о клиенте";
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ClientInfoTextBox);
            this.Controls.Add(this.BackToSearchClient);
            this.Name = "ClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о клиенте";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientInfo_FormClosing);
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackToSearchClient;
        private System.Windows.Forms.TextBox ClientInfoTextBox;
    }
}
namespace GY_V0
{
    partial class MainScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.MainScreenHeader = new System.Windows.Forms.TextBox();
            this.OpenYardAllForm = new System.Windows.Forms.Button();
            this.OpenClientForm = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.OpenSearchClientForm = new System.Windows.Forms.Button();
            this.NameCompany = new System.Windows.Forms.TextBox();
            this.Breadcrumb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainScreenHeader
            // 
            this.MainScreenHeader.BackColor = System.Drawing.Color.White;
            this.MainScreenHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainScreenHeader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainScreenHeader.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainScreenHeader.ForeColor = System.Drawing.Color.Black;
            this.MainScreenHeader.Location = new System.Drawing.Point(0, 0);
            this.MainScreenHeader.MaxLength = 50;
            this.MainScreenHeader.Multiline = true;
            this.MainScreenHeader.Name = "MainScreenHeader";
            this.MainScreenHeader.ReadOnly = true;
            this.MainScreenHeader.ShortcutsEnabled = false;
            this.MainScreenHeader.Size = new System.Drawing.Size(884, 77);
            this.MainScreenHeader.TabIndex = 0;
            this.MainScreenHeader.TabStop = false;
            this.MainScreenHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenYardAllForm
            // 
            this.OpenYardAllForm.BackColor = System.Drawing.Color.Silver;
            this.OpenYardAllForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OpenYardAllForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenYardAllForm.Location = new System.Drawing.Point(12, 499);
            this.OpenYardAllForm.Name = "OpenYardAllForm";
            this.OpenYardAllForm.Size = new System.Drawing.Size(190, 50);
            this.OpenYardAllForm.TabIndex = 3;
            this.OpenYardAllForm.TabStop = false;
            this.OpenYardAllForm.Text = "Просмотр кладбищ";
            this.OpenYardAllForm.UseVisualStyleBackColor = false;
            this.OpenYardAllForm.Visible = false;
            this.OpenYardAllForm.Click += new System.EventHandler(this.OpenYardAllForm_Click);
            // 
            // OpenClientForm
            // 
            this.OpenClientForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.OpenClientForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenClientForm.FlatAppearance.BorderSize = 0;
            this.OpenClientForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenClientForm.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.OpenClientForm.ForeColor = System.Drawing.Color.White;
            this.OpenClientForm.Location = new System.Drawing.Point(250, 369);
            this.OpenClientForm.Name = "OpenClientForm";
            this.OpenClientForm.Size = new System.Drawing.Size(400, 150);
            this.OpenClientForm.TabIndex = 2;
            this.OpenClientForm.Text = "Добавить клиента";
            this.OpenClientForm.UseVisualStyleBackColor = false;
            this.OpenClientForm.Click += new System.EventHandler(this.OpenClientForm_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitApp.Location = new System.Drawing.Point(12, 443);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(110, 50);
            this.ExitApp.TabIndex = 4;
            this.ExitApp.TabStop = false;
            this.ExitApp.Text = "Выход";
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Visible = false;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // OpenSearchClientForm
            // 
            this.OpenSearchClientForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.OpenSearchClientForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenSearchClientForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSearchClientForm.FlatAppearance.BorderSize = 0;
            this.OpenSearchClientForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSearchClientForm.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.OpenSearchClientForm.ForeColor = System.Drawing.Color.White;
            this.OpenSearchClientForm.Location = new System.Drawing.Point(250, 139);
            this.OpenSearchClientForm.Name = "OpenSearchClientForm";
            this.OpenSearchClientForm.Size = new System.Drawing.Size(400, 150);
            this.OpenSearchClientForm.TabIndex = 1;
            this.OpenSearchClientForm.Text = "Поиск клиента";
            this.OpenSearchClientForm.UseVisualStyleBackColor = false;
            this.OpenSearchClientForm.Click += new System.EventHandler(this.OpenSearchClientForm_Click);
            // 
            // NameCompany
            // 
            this.NameCompany.BackColor = System.Drawing.Color.White;
            this.NameCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameCompany.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NameCompany.Font = new System.Drawing.Font("Roboto", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.NameCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.NameCompany.Location = new System.Drawing.Point(23, 25);
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.ReadOnly = true;
            this.NameCompany.Size = new System.Drawing.Size(226, 34);
            this.NameCompany.TabIndex = 6;
            this.NameCompany.TabStop = false;
            this.NameCompany.Text = "МАУ \"Мемориал\"";
            // 
            // Breadcrumb
            // 
            this.Breadcrumb.BackColor = System.Drawing.Color.White;
            this.Breadcrumb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Breadcrumb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Breadcrumb.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.Breadcrumb.Location = new System.Drawing.Point(23, 12);
            this.Breadcrumb.Name = "Breadcrumb";
            this.Breadcrumb.ReadOnly = true;
            this.Breadcrumb.Size = new System.Drawing.Size(99, 17);
            this.Breadcrumb.TabIndex = 7;
            this.Breadcrumb.TabStop = false;
            this.Breadcrumb.Text = "Главное меню";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Breadcrumb);
            this.Controls.Add(this.NameCompany);
            this.Controls.Add(this.OpenSearchClientForm);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.OpenClientForm);
            this.Controls.Add(this.OpenYardAllForm);
            this.Controls.Add(this.MainScreenHeader);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainScreenHeader;
        private System.Windows.Forms.Button OpenYardAllForm;
        private System.Windows.Forms.Button OpenClientForm;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Button OpenSearchClientForm;
        private System.Windows.Forms.TextBox NameCompany;
        private System.Windows.Forms.TextBox Breadcrumb;
    }
}


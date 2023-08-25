namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCeose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLk = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.btnCustomers);
            this.panelMenu.Controls.Add(this.btnNotifications);
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(247, 647);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Teal;
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Image = global::WindowsFormsApp2.Properties.Resources.free_icon_inspection_753459_1_;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomers.Location = new System.Drawing.Point(0, 384);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCustomers.Size = new System.Drawing.Size(247, 60);
            this.btnCustomers.TabIndex = 6;
            this.btnCustomers.Text = "Т.Поддержка";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.Teal;
            this.btnNotifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotifications.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotifications.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNotifications.ForeColor = System.Drawing.Color.Black;
            this.btnNotifications.Image = global::WindowsFormsApp2.Properties.Resources.free_icon_notifications_button_60753_1_;
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotifications.Location = new System.Drawing.Point(0, 324);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNotifications.Size = new System.Drawing.Size(247, 60);
            this.btnNotifications.TabIndex = 5;
            this.btnNotifications.Text = "Уведомления";
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Teal;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Image = global::WindowsFormsApp2.Properties.Resources.free_icon_analytics_5382514_4_;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.Location = new System.Drawing.Point(0, 264);
            this.btnReport.Name = "btnReport";
            this.btnReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReport.Size = new System.Drawing.Size(247, 60);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Репортинг";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(168, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Teal;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = global::WindowsFormsApp2.Properties.Resources.free_icon_settings_503849_1_;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(0, 204);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSettings.Size = new System.Drawing.Size(247, 60);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Teal;
            this.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrders.ForeColor = System.Drawing.Color.Black;
            this.btnOrders.Image = global::WindowsFormsApp2.Properties.Resources.free_icon_shopping_bag_5236486_1_;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrders.Location = new System.Drawing.Point(0, 144);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOrders.Size = new System.Drawing.Size(247, 60);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Покупки";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Teal;
            this.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProducts.ForeColor = System.Drawing.Color.Black;
            this.btnProducts.Image = global::WindowsFormsApp2.Properties.Resources.free_icon_basket_shop_5681181_2__1__1_;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducts.Location = new System.Drawing.Point(0, 84);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnProducts.Size = new System.Drawing.Size(247, 60);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Купить";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.btnCeose);
            this.panelLogo.Controls.Add(this.btnCloseChildForm);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(247, 84);
            this.panelLogo.TabIndex = 0;
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.BackColor = System.Drawing.Color.Transparent;
            this.Timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Timer.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timer.Location = new System.Drawing.Point(453, 339);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(86, 36);
            this.Timer.TabIndex = 3;
            this.Timer.Text = "Time:";
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.free_icon_shop_4563482_1_1;
            this.pictureBox2.Location = new System.Drawing.Point(32, 3);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(70, 70);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(70, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "LiteShop";
            // 
            // btnCeose
            // 
            this.btnCeose.BackColor = System.Drawing.Color.Transparent;
            this.btnCeose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCeose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCeose.FlatAppearance.BorderSize = 0;
            this.btnCeose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCeose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCeose.ForeColor = System.Drawing.Color.Black;
            this.btnCeose.Location = new System.Drawing.Point(0, 0);
            this.btnCeose.Name = "btnCeose";
            this.btnCeose.Size = new System.Drawing.Size(32, 30);
            this.btnCeose.TabIndex = 1;
            this.btnCeose.Text = "X";
            this.btnCeose.UseVisualStyleBackColor = false;
            this.btnCeose.Click += new System.EventHandler(this.btnCeose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseChildForm.Location = new System.Drawing.Point(108, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(139, 35);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "На главную";
            this.btnCloseChildForm.UseVisualStyleBackColor = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTitleBar.Controls.Add(this.btnLk);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(247, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1344, 84);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnLk
            // 
            this.btnLk.BackColor = System.Drawing.Color.Transparent;
            this.btnLk.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.free_icon_analytics_5382514;
            this.btnLk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLk.FlatAppearance.BorderSize = 0;
            this.btnLk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLk.Image = global::WindowsFormsApp2.Properties.Resources.free_icon_user_1946392_1_;
            this.btnLk.Location = new System.Drawing.Point(3, 3);
            this.btnLk.Name = "btnLk";
            this.btnLk.Size = new System.Drawing.Size(75, 78);
            this.btnLk.TabIndex = 9;
            this.btnLk.UseVisualStyleBackColor = false;
            this.btnLk.Click += new System.EventHandler(this.btnLk_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(84, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1257, 84);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDesktopPanel_MouseDown);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.Timer);
            this.panelDesktopPanel.Controls.Add(this.label4);
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Controls.Add(this.label1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(247, 84);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1344, 563);
            this.panelDesktopPanel.TabIndex = 2;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            this.panelDesktopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDesktopPanel_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(621, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 58);
            this.label4.TabIndex = 6;
            this.label4.Text = "LiteShop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.free_icon_shop_4563482;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(458, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 178);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "logo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(628, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тут могла быть ваша реклама";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 647);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1607, 686);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.FlowLayoutPanel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCeose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLk;
    }
}


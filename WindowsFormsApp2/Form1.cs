using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = true;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null) 
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.BackColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitleBar.BackColor = color;
                    panelMenu.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCustomers .BackColor = color;
                    btnNotifications.BackColor = color;
                    btnOrders.BackColor = color;
                    btnProducts.BackColor = color;
                    btnReport.BackColor = color;
                    btnProducts.BackColor = color;
                    btnSettings.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                    btnLk.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 128, 128);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false; //чтобы было не поверх
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;//делаем заполнение
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;//текст home меняется на название Form
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProduct(),sender);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrders(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReporting(), sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNotifications(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCustomers(), sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSetting(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if ( activeForm!=null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 128, 128);
            panelLogo.BackColor = Color.FromArgb(47, 79, 79);
            panelMenu.BackColor = Color.FromArgb(0, 128, 128);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelDesktopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCeose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        { 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // Интервал в миллисекундах (1 секунда)
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void Timer_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeZoneInfo moscowTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time");
            DateTime moscowTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, moscowTimeZone);

            // Отобразите текущее время по МСК на Label
            Timer.Text = $"Time:{moscowTime:HH:mm:ss}";
        }

        private void btnLk_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLk(), sender);
        }
    }
}

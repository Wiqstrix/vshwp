using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Forms
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }


        private void button22_Click(object sender, EventArgs e)
        {

        }

        public void Alert(string msg, From_Alert.enmType type)
        {
            From_Alert frm = new From_Alert();
            frm.showAlert(msg, type);
        }

        private void Succes_Click(object sender, EventArgs e)
        {
            this.Alert("Оформили!", From_Alert.enmType.Success);
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            this.Alert("Доставка около 2ух дней.", From_Alert.enmType.Info);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Alert("Ошибка: даный товар повторный", From_Alert.enmType.Warning);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Alert("Доставка около 2ух дней.", From_Alert.enmType.Info);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Alert("Оформили!", From_Alert.enmType.Success);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Alert("Доставка около 2ух дней.", From_Alert.enmType.Info);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Alert("Оформили!", From_Alert.enmType.Success);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Alert("Оболочка: CH; Доставка 7 дней.", From_Alert.enmType.Info);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.Alert("Оформили!", From_Alert.enmType.Success);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.Alert("Доставка 5 дней.", From_Alert.enmType.Info);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.Alert("Оформили!", From_Alert.enmType.Success);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.Alert("Доставка на завтра.", From_Alert.enmType.Info);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.Alert("Оформили!", From_Alert.enmType.Success);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.Alert("Доставка на завтра.", From_Alert.enmType.Info);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.Alert("Оформили!", From_Alert.enmType.Success);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.Alert("Доставка на завтра.", From_Alert.enmType.Info);
        }

    }
}

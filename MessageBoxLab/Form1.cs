using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageBoxLab
{
    public partial class Form1 : Form
    {
        string title = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var dt = DateTime.Now.ToString("HH:mm:ss");
            Text = $"Старт в {dt}";
        }

        private void btnOneB_MouseClick(object sender, MouseEventArgs e)
        {
            var text = "Одна кнопка";
            var caption = "Заголовок однокнопочного окна";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Asterisk;
            MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button2;
            MessageBoxOptions options = MessageBoxOptions.RtlReading;
            if (rbOkCancel.Checked)
            {
                buttons = MessageBoxButtons.OKCancel;
            }
            var result =
            MessageBox.Show(text, // сообщение
                caption, // заголовок
                buttons, // кнопки
                icon,   // иконка
                defaultButton, // кнопка по умолчанию
                options); // справа налево
            labelUserChoice.Text = result.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelInfo.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnTwoB_MouseHover(object sender, EventArgs e)
        {
            this.title = Text;
            Text = btnTwoB.Text;
            //Text += " " + sender.ToString();
            var tmp = (Button)sender;
            var size = tmp.Size;
            
            var location = tmp.Location;
            Text+= " " + size.Width + " " + size.Height + " "+location.Y + " "+location.X;
        }

        private void btnTwoB_MouseLeave(object sender, EventArgs e)
        {
            Text = title;
        }

        private void btnTwoB_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (rbOkCancel.Checked)
            {
                buttons |= MessageBoxButtons.OKCancel;
            }
            else
            {

            }

        }
    }
}

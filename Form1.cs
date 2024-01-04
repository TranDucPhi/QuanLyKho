using PHAN_MEM_QUAN_LY_CUA_HANG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class clientdangnhap : Form
    {
        public clientdangnhap()
        {
            InitializeComponent();
        }

        private void clientdangnhap_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if((textBox1.Text=="")||(textBox2.Text== ""))
            {
                MessageBox.Show("Nhập thông Tin", "Thông báo");
            }
            else
            if ((textBox1.Text != "tranphi") || (textBox2.Text != "123456"))
            {
                MessageBox.Show("Sai Password hoặc username", "thông báo");
            }
            else
            {
                if ((textBox1.Text == "tranphi") || (textBox2.Text == "123456"))
                {
                    MessageBox.Show("Đăng nhập thành công", "thông báo");
                    quanlycuahang frmquanlykho = new quanlycuahang();
                    frmquanlykho.ShowDialog();
                    
                }   
            }
            this.Hide();
        }
    }
}

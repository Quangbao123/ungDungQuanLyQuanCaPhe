using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyQuanCaPhe
{
    public partial class FirstForm : DevExpress.XtraEditors.XtraForm
    {
        
        public FirstForm()
        {
            InitializeComponent();
            
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            // mo form dang nhap
            LoginFormNhanVien nv = new LoginFormNhanVien();

            nv.FormClosing += (s, args) =>
            {
                // hien thi lai firstform sau khi dong
                this.Show();
            };
            nv.ShowDialog();
        }
    }
}
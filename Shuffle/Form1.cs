using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuffle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog openfile = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            openfile.Title = "Chọn File Ảnh Đại Diện Cho Hoa";
            openfile.InitialDirectory = @"E:\Pictures\cmPic";//Thư mục mặc định khi mở
            openfile.Filter = "All files (*.*)|*.*|jpg files (*.jpg)|*.jpg";// Lọc ra những file cần hiển thị
            openfile.FilterIndex = 1;//chúng ta có All files là 1,jpg là 2
            openfile.RestoreDirectory = true;
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openfile.FileName);
            }
        }
    }
}

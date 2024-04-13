using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Images |*.png ;*.jpg;*.jpeg";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                pictureBox.Image=new Bitmap(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Icon File(*.ico)|*.ico";
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                Icon.FromHandle(((Bitmap)pictureBox.Image).GetHicon()).Save(new FileStream(sfd.FileName, FileMode.Create));
                MessageBox.Show("Success Convert");
                pictureBox.Image = null;
            }
        }
    }
}

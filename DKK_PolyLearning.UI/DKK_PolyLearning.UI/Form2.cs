using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DKK_PolyLearning.DAL;
using DKK_PolyLearning.BLL;// Cần thiết cho GraphicsPath
using DKK_PolyLearning.DTO;

namespace DKK_PolyLearning.UI
{   

    public partial class Form2 : Form
    {
        private string VaiTro;

        public Form2(string vaitro)
        {
            InitializeComponent();
            VaiTro = vaitro;
        }

        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lịchHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void quảnLýLịchHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýPhòngHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void PhanQuyen()
        {
            if (VaiTro == "GiangVien")
            {
                quảnLýGiảngViênToolStripMenuItem.Visible = false;
                quảnLýLớpHọcToolStripMenuItem.Visible=false;
                quảnLýPhòngHọcToolStripMenuItem.Visible=false;
                thốngKêToolStripMenuItem.Visible=false;
            }
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

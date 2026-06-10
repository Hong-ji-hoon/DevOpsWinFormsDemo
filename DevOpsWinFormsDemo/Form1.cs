using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevOpsWinFormsDemo
{
    public partial class Form1 : Form
    {
        private readonly ProcessController _controller;

        public Form1()
        {
            InitializeComponent();

            _controller = new ProcessController();
            lblStatus.Text = "Ready";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string result = _controller.Start();
            lblStatus.Text = result;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            string result = _controller.Stop();
            lblStatus.Text = result;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string id = idtb.Text;
            string pw = pwtb.Text;
            bool isexistid = _controller.ID(id);
            bool isexistpw = _controller.PW(pw);

            if (isexistid && isexistpw) statuslb.Text = "Login";
            else
            {
                statuslb.Text = "Fail";
                idtb.Clear();
                pwtb.Clear();
            }
        }
    }
}

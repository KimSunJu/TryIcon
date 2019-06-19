using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TryIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VisibleChange(bool visible)
        {
            this.Visible = visible;
            this.ntiTray.Visible = !visible;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnTray_Click(object sender, EventArgs e)
        {
            VisibleChange(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;       //종료 이벤트 취소 
            VisibleChange(false); //앱 종료가 아닌 트레이 숨기는 것처럼 효과
        }

        private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true);
        }

        private void NtiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ntiTray.Visible = false;
            Application.ExitThread();//어플리케이션 스레드 완전 종료
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixOnTheTop
{
    public partial class Form1 : Form
    {
   

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Criado por Juan Almeida, acesse o site https://juanalmeida.ga para mais informações.", "Juan Almeida");
            // Apresenta o formulário chamado
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           if(this.TopMost == true)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    painel.Visible = true;
                    return true;
                case Keys.F2:
                    painel.Visible = false;
                    return true;
                case Keys.F3:
                    this.TopMost = true;
                    return true;
                case Keys.F4:
                    this.TopMost = false;
                    return true;
                case Keys.F6:
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    return true;
                case Keys.F7:
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    return true;
                case Keys.F9:
                    webBrowser1.ScrollBarsEnabled = false;
                    return true;
                case Keys.F8:
                    webBrowser1.ScrollBarsEnabled = true;
                    return true;
            }
            return false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;

        }


        private void Button4_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            painel.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            webBrowser1.ScrollBarsEnabled = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            webBrowser1.ScrollBarsEnabled = true;
        }
    }
}

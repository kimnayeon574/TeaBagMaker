using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class teaForm : Form
    {
        string[] teaBag = { "홍차", "녹차", "루이보스차", "국화차" };
        public teaForm()
        {
            InitializeComponent();
        }

        private void teaForm_Load(object sender, EventArgs e)
        {
            for(int i=0; i < teaBag.Length; i++)
            {
                this.cbBox.Items.Add(teaBag[i]);
            }
            if(this.cbBox.Items.Count > 0)
            {
                this.cbBox.SelectedIndex = 0;
            }
        }

        
    }
}

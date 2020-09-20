//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//
namespace SchedarioPolizia
{
    public partial class FormSchedario : Form
    {
        public FormSchedario()
        {
            InitializeComponent();
        }


        //
        private void FormSchedario_Load(object sender, EventArgs e)
        {
           
        }

        //
        private void buttonAccediPers_Click(object sender, EventArgs e)
        {
            Form Pers = new FormSezPersone();
            Pers.Show();
        }

        //
        private void button1Closeall_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        private void buttonAccediAuto_Click(object sender, EventArgs e)
        {
            Form Auto = new FormSezAuto();
            Auto.Show();
        }
    }
}

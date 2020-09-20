//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using System.Data.SqlClient;

//
namespace SchedarioPolizia
{
    public partial class FormSezAuto : Form
    {
        string Conn = "Server=localhost;User ID=office;Password=office;Database=schedario;";
        
        DataTable tabella = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();


        public FormSezAuto()
        {
            InitializeComponent();
        }

        //
        private void FormSezAuto_Load(object sender, EventArgs e)
        {
             
            toolTipHelPsezAuto.AutoPopDelay = 4000;
            toolTipHelPsezAuto.InitialDelay = 1000;
            toolTipHelPsezAuto.ReshowDelay = 500;

            /***************   CODICE TAB INSERIMENTO       ************/






            /**************  CODICE TAB RICERCA            ************/
 
            toolTipHelPsezAuto.SetToolTip(textBoxTarga,"Inserire la targa"); 
            toolTipHelPsezAuto.SetToolTip(textBoxModello,"Inserire il modello di auto");
            toolTipHelPsezAuto.SetToolTip(textBoxModel,"");
            toolTipHelPsezAuto.SetToolTip(textBoxNumeTel,"");
            toolTipHelPsezAuto.SetToolTip(textBoxCil,"");
            toolTipHelPsezAuto.SetToolTip(textBoxKw,"");
            toolTipHelPsezAuto.SetToolTip(textBoxMotore,"");
            toolTipHelPsezAuto.SetToolTip(textBoxNumPort,"");
            toolTipHelPsezAuto.SetToolTip(textBoxCVAuto,"");

        }

        private void buttonRicercaAuto_Click(object sender, EventArgs e)
        {
            if (textBoxTarga.Text ==" ")
            {
                MessageBox.Show("Il campo di ricerca è vuoto","ERRORE",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            if (radioButtonRicTarga.Checked == true)
            {
                MySqlConnection conn = new MySqlConnection(Conn);
                MySqlCommand com = new MySqlCommand();
                adapter.SelectCommand = com;
                com.Connection = conn;
                com.CommandText =
                                "SELECT * " +
                                "FROM tblauto " +
                                "WHERE Targa='" + textBoxTarga.Text + "';";
                adapter.Fill(tabella);
                textBoxModel.Text = tabella.Rows[0][4].ToString();
                textBoxNumeTel.Text = tabella.Rows[0][5].ToString();
                textBoxCil.Text = tabella.Rows[0][6].ToString();
                textBoxKw.Text = tabella.Rows[0][7].ToString();
                textBoxMotore.Text = tabella.Rows[0][8].ToString();
                textBoxNumPort.Text = tabella.Rows[0][9].ToString();
                textBoxTargaAuto.Text = tabella.Rows[0][10].ToString();
                textBoxCVAuto.Text = tabella.Rows[0][11].ToString();
                int rub = Convert.ToInt16(tabella.Rows[0][12]);

                if (rub == 1)
                {
                    textBoxRubata.Text = "SI";
                    textBoxRubata.BackColor=Color.Red;
                }
                if (rub == 0)
                {
                    textBoxRubata.Text = "NO";
                }
                textBoxDataFurto.Text = tabella.Rows[0][13].ToString();
            }
            if (radioButtonRicercModel.Checked == true)
            {
                MySqlConnection conn = new MySqlConnection(Conn);
                MySqlCommand com = new MySqlCommand();
                adapter.SelectCommand = com;
                com.Connection = conn;
                com.CommandText =
                                "SELECT * " +
                                "FROM tblauto " +
                                "WHERE Modello='" + textBoxModello.Text + "';";
                adapter.Fill(tabella);
                textBoxModel.Text=tabella.Rows[0][4].ToString();
                textBoxNumeTel.Text=tabella.Rows[0][5].ToString();
                textBoxCil.Text=tabella.Rows[0][6].ToString();
                textBoxKw.Text=tabella.Rows[0][7].ToString();
                textBoxMotore.Text=tabella.Rows[0][8].ToString();
                textBoxNumPort.Text=tabella.Rows[0][9].ToString();
                textBoxTargaAuto.Text=tabella.Rows[0][10].ToString();
                textBoxCVAuto.Text=tabella.Rows[0][11].ToString();
                int rub=Convert.ToInt16(tabella.Rows[0][12]);

                if (rub == 1)
                {
                    textBoxRubata.Text ="SI";
                    textBoxRubata.BackColor=Color.Red;
                }
                if(rub==0)
                {
                    textBoxRubata.Text ="NO";
                }
                textBoxDataFurto.Text=tabella.Rows[0][13].ToString();
                textBoxDataFurto.BackColor = Color.Red;
            }

        }

        //
        private void buttonCLosSezAuto_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        private void buttonResetRicAuto_Click(object sender, EventArgs e)
        {
            radioButtonRicTarga.Checked = false;
            radioButtonRicercModel.Checked = false;
            textBoxTarga.Text = "";
            textBoxModello.Text = "";
            textBoxModel.Text = "";
            textBoxNumeTel.Text = "";
            textBoxCil.Text = "";
            textBoxKw.Text = "";
            textBoxMotore.Text = "";
            textBoxNumPort.Text = "";
            textBoxCVAuto.Text = "";
            textBoxTargaAuto.Text = "";
            textBoxRubata.Text = "";
            textBoxDataFurto.Text = "";
            
        }

        private void buttonResetAuto_Click(object sender, EventArgs e)
        {
           
        }
 
    }
}

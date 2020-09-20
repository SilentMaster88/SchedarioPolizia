//
//
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
    public partial class FormSezPersone : Form
    {   
        // 
        string Conn = "Server=localhost;User ID=office;Password=office;Database=schedario;"; 
        DataTable tabella = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        //
         

        //
        public FormSezPersone()
        {
            InitializeComponent();
        }

        //
        private void buttonModifica_Click(object sender, EventArgs e)
        {
            textBoxNomeRic.ReadOnly = false;
            textBoxCognRic.ReadOnly = false;
            textBoxDataNascRic.ReadOnly=false;
            textBoxLuogNasc.ReadOnly = false;
            textBoxComResRic.ReadOnly=false;
            textBoxProvResRic.ReadOnly = false;
            textBoxSegnaRic.ReadOnly = false;
            textBoxReatoRic.ReadOnly = false;
            textBoxSegnalMot.ReadOnly = false;
            //


        }

        //
        private void buttonResetRic_Click(object sender, EventArgs e)
        {
             
            textBoxNome.Text = "";
            textBoxCognome.Text = "";
            textBoxNomeRic.Text=""; 
            textBoxCognRic.Text=""; 
            textBoxDataNascRic.Text=""; 
            textBoxLuogNasc.Text=""; 
            textBoxComResRic.Text=""; 
            textBoxProvResRic.Text=""; 
            textBoxSegnaRic.Text=""; 
            textBoxReatoRic.Text="";
            textBoxSegnalMot.Text = ""; 
        }

        //
        private void buttonCloseSchedarioPersone_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        private void buttonSalva_Click(object sender, EventArgs e)
        {

            textBoxNomeRic.ReadOnly = true;
            textBoxCognRic.ReadOnly = true;
            textBoxDataNascRic.ReadOnly = true;
            textBoxLuogNasc.ReadOnly = true;
            textBoxComResRic.ReadOnly = true;
            textBoxProvResRic.ReadOnly = true;
            textBoxSegnaRic.ReadOnly = true;
            textBoxReatoRic.ReadOnly = true;
            textBoxSegnalMot.ReadOnly = true;
        }

        //
        private void FormSezPersone_Load(object sender, EventArgs e)
        {
             

            toolTipHelpSchedarioPersona.AutoPopDelay = 4000;
            toolTipHelpSchedarioPersona.InitialDelay = 1000;
            toolTipHelpSchedarioPersona.ReshowDelay = 500;
            //

            /***************   CODICE TAB INSERIMENTO       ************/

            toolTipHelpSchedarioPersona.SetToolTip(textBoxNomeIns,"Inserire il nome della persona");
            toolTipHelpSchedarioPersona.SetToolTip(textBoxCognIns,"Inserire il cognome della persona");
            toolTipHelpSchedarioPersona.SetToolTip(textBoxDatanascIns,"Inserire la data di nascita della persona");
            toolTipHelpSchedarioPersona.SetToolTip(textBoxLuogonascIns,"Inserire il luogo di nascita della persona");
            toolTipHelpSchedarioPersona.SetToolTip(textBoxComuneresIns,"Inserire il comune di residenza attuale");
            toolTipHelpSchedarioPersona.SetToolTip(textBoxProvresIns,"Inserire la provincia di residenza attuale");
            toolTipHelpSchedarioPersona.SetToolTip(textBoxMotivsengIns,"Inserire il motivo della segnalazione");
            toolTipHelpSchedarioPersona.SetToolTip(comboBoxReatoIns,"Scegliere il reato commesso");
            toolTipHelpSchedarioPersona.SetToolTip(textBoxDataIns,"Inserire la data odierna");
            toolTipHelpSchedarioPersona.SetToolTip(textBoxCittaIns,"Inserire il nome della città dove si trova il comando");
            toolTipHelpSchedarioPersona.SetToolTip(textBoxProvIns,"Inserire la provincia dove si trova il comando");
            toolTipHelpSchedarioPersona.SetToolTip(textBoxRegIns,"Inserire la region dove si trova il comando");
            
            
            /*****************   CODICE TAB RICERCA         *****************/
            
            toolTipHelpSchedarioPersona.SetToolTip(textBoxNome,"Inserire il nome del sospetto");
            toolTipHelpSchedarioPersona.SetToolTip(textBoxCognome, "Inserire il cognome del sospetto");
            toolTipHelpSchedarioPersona.SetToolTip(buttonResetRic, "Permette di fare una nuova ricerca");
            toolTipHelpSchedarioPersona.SetToolTip(buttonSalva, "Salva le modifiche effetuate");
            toolTipHelpSchedarioPersona.SetToolTip(buttonResearch, "Permette di ricercare i dati relativi a una persona");
            toolTipHelpSchedarioPersona.SetToolTip(buttonDeleteRicerc, "Permette di cancellare una persona dall'archivio");
            toolTipHelpSchedarioPersona.SetToolTip(buttonModifica, "Permette di modificare dei dati");
            toolTipHelpSchedarioPersona.SetToolTip(buttonCloseSchedarioPersone, "Chiude la form corrente");

            //
            textBoxMotivsengIns.Enabled = false;
            comboBoxReatoIns.Enabled = false;

            //
            MySqlConnection conn = new MySqlConnection(Conn);
            MySqlCommand com = new MySqlCommand();
            adapter.SelectCommand = com;
            com.Connection = conn;
            com.CommandText =
                             "SELECT * "+
                             "FROM tblreato;";
            adapter.Fill(tabella);
            comboBoxReatoIns.DataSource = tabella;
            comboBoxReatoIns.DisplayMember = "Tipo";
        }

        //
        private void buttonResearch_Click(object sender, EventArgs e)
        {
             
                tabella = new DataTable();
                MySqlConnection conn = new MySqlConnection(Conn);
                MySqlCommand com = new MySqlCommand();
                adapter.SelectCommand = com;
                com.Connection = conn;
                com.CommandText =
                                 "SELECT * " +
                                 "FROM tblsospetto " +
                                 "WHERE Nome='" + textBoxNome.Text + "';";
                adapter.Fill(tabella);
                textBoxNomeRic.Text = tabella.Rows[0][1].ToString();
                textBoxCognRic.Text = tabella.Rows[0][2].ToString();
                textBoxDataNascRic.Text = tabella.Rows[0][3].ToString();
                textBoxLuogNasc.Text = tabella.Rows[0][4].ToString();
                textBoxComResRic.Text = tabella.Rows[0][5].ToString();
                textBoxProvResRic.Text = tabella.Rows[0][6].ToString();
                int segn =Convert.ToInt16(tabella.Rows[0][7]);

                if (segn==1)
                {
                    textBoxSegnaRic.Text = "SI";
                }
                if (segn == 0)
                {
                    textBoxSegnaRic.Text = "NO";
                }
                textBoxSegnalMot.Text = tabella.Rows[0][8].ToString();
                 
                     
            
        }


        /*************************  INIZIO CODICE TAB INSERIMENTO        ***********************/ 

        //
        private void checkBoxSegnalatoIns_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSegnalatoIns.Checked == true)
            {
                textBoxMotivsengIns.Enabled = true;
            }
            else
            {
                textBoxMotivsengIns.Enabled = false;
            }
        }

        //
        private void checkBoxReatoIns_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxReatoIns.Checked==true)
            {
                comboBoxReatoIns.Enabled = true;
            }
            else
            {
                comboBoxReatoIns.Enabled = false;
            }
        }

        //
        private void buttonResetIns_Click(object sender, EventArgs e)
        {
            textBoxNomeIns.Text = "";
            textBoxCognIns.Text = "";
            textBoxDatanascIns.Text = "";
            textBoxLuogonascIns.Text = "";
            textBoxComuneresIns.Text = "";
            textBoxProvresIns.Text = "";
            textBoxMotivsengIns.Text = "";
            comboBoxReatoIns.Text = "";
            textBoxDataIns.Text = "";
            textBoxCittaIns.Text = "";
            textBoxProvIns.Text = "";
            textBoxRegIns.Text = "";
            checkBoxReatoIns.Checked = false;
            checkBoxSegnalatoIns.Checked = false;
        }

        //
        private void buttonChiudiIns_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Funzione salva del tab di inserimento:
        private void buttonSalvaIns_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            MySqlCommand com = new MySqlCommand();
            adapter.SelectCommand = com;
            com.Connection = conn;

            com.CommandText =
                             "INSERT INTO bdo.tblsospetto(Nome,Cognome,DataNascita,LuogoNascita,ComuneRes,ProvRes,Segnalato,MotivoSegnalazione) "+
                             "VALUES ("+textBoxNomeIns.Text+",'"+textBoxCognIns.Text+"','"+textBoxDatanascIns.Text+"','"+ textBoxLuogonascIns.Text+"'"+
                             "        '"+textBoxComuneresIns.Text+"','"+textBoxProvresIns.Text+"','"+checkBoxSegnalatoIns.Checked+"','"+textBoxSegnalMot.Text+"');";
              
             

        }
 
    }
}

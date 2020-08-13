using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park2
{
    public partial class MainForm : Form
    {
        internal static MainForm mainForm;
        internal static Aracins aracins;
        int index;
        int column;
        string sqllist = "SELECT PA.\"Arac_ID\", PA.\"Arac_giris_suresi\", AB.\"Plaka\" FROM public.\"Parktaki_araclar\" PA, public.\"Arac_Bilgileri\" AB WHERE AB.\"Arac_ID\" = PA.\"Arac_ID\" ORDER BY \"Arac_ID\"";
        DB db = new DB();
        public MainForm()
        {
            InitializeComponent();
            mainForm = this;
            datalist(db.sqlq(sqllist));
        }
        
        public void datalist(DataSet data)
        {
            dataGridView1.DataSource = data.Tables[0];
        }

        private void aracins_button_Click(object sender, EventArgs e)
        {
            Aracins aracins = new Aracins();
            aracins.Show();
        }
        public void refresh()
        {
            datalist(db.sqlq(sqllist));
            text_plaka.Text = "";
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "RowIndex", e.RowIndex);
            MessageBox.Show(messageBoxCS.ToString(), "CellDoubleClick Event");*/
            
            index = e.RowIndex;
            column = e.ColumnIndex;
            Odeme odeme = new Odeme(index, column);
            odeme.Show();
            /*
            AracUpdate aracUpdate = new AracUpdate(index, column);
            aracUpdate.Show();
            */
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void text_plaka_TextChanged(object sender, EventArgs e)
        {
            datalist(db.sqlq(
                "SELECT PA.\"Arac_ID\", PA.\"Arac_giris_suresi\", AB.\"Plaka\" " +
                "FROM public.\"Parktaki_araclar\" PA, public.\"Arac_Bilgileri\" AB " +
                "WHERE AB.\"Arac_ID\" = PA.\"Arac_ID\" " +
                "AND ab.\"Plaka\" LIKE \'" +text_plaka.Text+
                "%\'"+
                "ORDER BY \"Arac_ID\""
                ));
        }
    }
}

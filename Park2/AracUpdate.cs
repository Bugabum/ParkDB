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
    public partial class AracUpdate : Form
    {
        DB db = new DB();
        int index, column,id;
        public AracUpdate(int index,int column)
        {
            InitializeComponent();
            this.index = index;
            this.column = column;
            /*
            id = db.getidfromindex(index);
            string sql;
            switch (column)
            {
                case 0:
                    update_label.Text = "id";
                    update_text.Text = db.getvalue(id, "id");
                    break;
                case 1:
                    update_label.Text = "Plaka";
                    update_text.Text = db.getvalue(id, "plaka");
                    break;
                case 2:
                    update_label.Text = "Not";
                    update_text.Text = db.getvalue(id, "\"not\"");
                    break;
                case 3:
                    update_label.Text = "Üyelik idsi";
                    update_text.Text = db.getvalue(id, "kullaniciid");
                    break;
                case 4:
                    update_label.Text = "Giriş Zamanı";
                    update_text.Text = db.getvalue(id, "giriszamani");
                    break;
                case 5:
                    update_label.Text = "Çıkış Zamanı";
                    update_text.Text = db.getvalue(id, "cikiszamani");
                    break;
                default:
                    break;
            }
            */
        }

        private void update_button_Click(object sender, EventArgs e)
        {

        }
    }
}

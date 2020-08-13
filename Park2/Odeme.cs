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
    public partial class Odeme : Form
    {
        DB db = new DB();
        int index, column, id;
        string marka, model, renk, plaka, giris, ucret;
        int markaid, modelid, renkid, zaman;

        int otoparkid = 0;
        public Odeme(int index, int column)
        {
            InitializeComponent();
            this.index = index;
            this.column = column;
            id = db.getidfromindex("Parktaki_araclar", "Arac_ID", index);

            if (id == -1)
            {
                db.sqltest("Bilinmeyen Hata");
            }
            modelid= Int32.Parse(db.getvaluefromid("Arac_Bilgileri", "Arac_ID", id, "Model_ID"));
            renkid= Int32.Parse(db.getvaluefromid("Arac_Bilgileri", "Arac_ID", id, "Renk_ID"));
            markaid = Int32.Parse(db.getvaluefromid("Araba_modeli", "Model_id", id, "Marka_ID"));

            plaka = db.getvaluefromid("Arac_Bilgileri", "Arac_ID", id, "Plaka");
            model = db.getvaluefromid("Araba_modeli", "Model_id", id, "Model_adi");
            marka = db.getvaluefromid("Araba_markasi", "Marka_ID", id, "Marka_Adi");
            renk = db.getvaluefromid("Araba_Rengi", "RENK_ID", id, "Renk_ADI");
            giris = db.getvaluefromid("Parktaki_araclar", "Arac_ID", id, "Arac_giris_suresi");

            text_marka.Text = marka;
            text_model.Text = model;
            text_plaka.Text = plaka;
            text_renk.Text = renk;
            text_giris.Text = giris;

            
            zaman= db.exsqli("SELECT zamanHesapla("+id+")");
            ucret = db.exsqls("SELECT ucretHesapla("+zaman+","+otoparkid+")");
            text_ucret.Text = ucret+" TL";
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            if(plaka!=text_plaka.Text)
            db.sqltest(db.sqlupdate("Arac_Bilgileri", "Plaka", "Arac_ID", id, text_plaka.Text).ToString());
            if (renk != text_renk.Text)
            {
                int renk_id;
                renk_id = db.getidfromvalue("Araba_Rengi", "RENK_ID", "Renk_ADI", text_renk.Text.ToString().ToLower());
                if (renk_id == -1)
                {
                    renk_id = (db.lastid("Araba_Rengi", "RENK_ID") + 1);
                    db.sqlq("INSERT INTO public.\"Araba_Rengi\"(\"RENK_ID\", \"Renk_ADI\") VALUES(" + renk_id + ", '" + text_renk.Text.ToString().ToLower() + "')");
                }
                db.sqlupdate("Arac_Bilgileri","Renk_ID","Arac_ID",id,renk_id.ToString());
            }
            if (model != text_model.Text)
            {
                int model_id, marka_id;
                model_id = db.getidfromvalue("Araba_modeli", "Model_id", "Model_adi", text_model.Text.ToString().ToLower());
                if (model_id == -1)
                {
                    marka_id = db.getidfromvalue("Araba_markasi", "Marka_ID", "Marka_Adi", text_marka.Text.ToString().ToLower());
                    if (marka_id == -1)
                    {
                        marka_id = (db.lastid("Araba_markasi", "Marka_ID") + 1);
                        db.sqlq("INSERT INTO public.\"Araba_markasi\"(\"Marka_ID\", \"Marka_Adi\") VALUES(" + marka_id + ", '" + text_marka.Text.ToString().ToLower() + "')");
                    }
                    model_id = (db.lastid("Araba_modeli", "Model_id") + 1);
                    db.sqlq("INSERT INTO public.\"Araba_modeli\"(\"Model_id\", \"Model_adi\", \"Marka_ID\") VALUES(" + model_id + ", '" + text_model.Text.ToString().ToLower() + "', " + marka_id + ")");
                }
                db.sqlupdate("Arac_Bilgileri", "Model_ID", "Arac_ID", id, model_id.ToString());
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            db.sqlq("INSERT INTO public.\"Odemeler\"(" +
                "\"Odeme_ID\", \"Ucret\", \"Odeme_Zamani\", \"Plan_ID\", \"Arac_ID\")" +
                "VALUES (" +
                (db.lastid("Odemeler", "Odeme_ID") + 1) + ", " +
                ucret + ", " +
                "current_timestamp, " +
                "planidbul(" + otoparkid + "), " +
                id + ")");
            db.sqlq("DELETE FROM public.\"Parktaki_araclar\"" +
                "WHERE \"Arac_ID\" = " + id);
        }
    }
}

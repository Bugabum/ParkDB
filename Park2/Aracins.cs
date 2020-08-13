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
    public partial class Aracins : Form
    {
        DB db = new DB();
        public Aracins()
        {
            InitializeComponent();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            int plakacontrol = -1; //Aracın bilgilerinin olup olmadığı kontrol edilcek
            plakacontrol = db.getidfromvalue("Arac_Bilgileri", "Arac_ID", "Plaka", text_plaka.Text.ToString());
            if (plakacontrol != -1)
            {
                db.sqltest("INSERT INTO public.\"Parktaki_araclar\"(\"Arac_ID\", \"Arac_giris_suresi\") VALUES (" + plakacontrol + ", current_timestamp)");
                db.sqlq("INSERT INTO public.\"Parktaki_araclar\"(\"Arac_ID\", \"Arac_giris_suresi\") VALUES (" + plakacontrol + ", current_timestamp)");
            }
            else
            {

            
            int controlid=-1;
            int renk_id, tip_id, model_id, marka_id,arac_id,kullanici_id;
            renk_id = db.getidfromvalue("Araba_Rengi", "RENK_ID", "Renk_ADI", text_renk.Text.ToString().ToLower());
            if (renk_id== -1) {
                renk_id=(db.lastid("Araba_Rengi", "RENK_ID") + 1);
                db.sqlq("INSERT INTO public.\"Araba_Rengi\"(\"RENK_ID\", \"Renk_ADI\") VALUES(" + renk_id + ", '"+text_renk.Text.ToString().ToLower()+"')");
            }
            tip_id = db.getidfromvalue("Araba_tipi", "Tip_id", "Tip_adi", text_tip.Text.ToString().ToLower());
            if (tip_id == -1)
            {
                tip_id = (db.lastid("Araba_tipi", "Tip_id") + 1);
                db.sqlq("INSERT INTO public.\"Araba_tipi\"(\"Tip_id\", \"Tip_adi\") VALUES(" + tip_id + ", '" + text_tip.Text.ToString().ToLower() + "')");
            }
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
            arac_id = db.lastid("Arac_Bilgileri", "Arac_ID")+1;
            if (text_kullanici.Text.ToString().Length == 0)
            {
                db.sqlq("INSERT INTO public.\"Arac_Bilgileri\"(\"Arac_ID\", \"Plaka\", \"Model_ID\", \"Renk_ID\", \"TYPE_ID\") VALUES (" + arac_id + ", '" + text_plaka.Text.ToString() + "', " + model_id + ", " + renk_id + ", " + tip_id + ")");
            }
            else
            {
                kullanici_id = db.getidfromvalue("Kullanici", "Kullanici_id", "Kullanici_id", text_kullanici.Text.ToString());
                if (kullanici_id == -1)
                {
                    db.sqltest("Kullanıcı bulunamadı!");
                }
                else
                    controlid = db.getidfromvalue("Arac_Bilgileri", "Arac_ID", "Plaka", text_plaka.Text);
                db.sqltest(controlid.ToString());
                if (db.checkforid("Parktaki_araclar", "Arac_ID", controlid) || controlid == -1)
                {
                    db.sqltest("Parkta olan bir aracı eklemeye çalışıyorsunuz!");
                }
                db.sqlq("INSERT INTO public.\"Arac_Bilgileri\"(\"Arac_ID\", \"Plaka\", \"Model_ID\", \"Renk_ID\", \"TYPE_ID\",\"Arac_sahibi_ID\") VALUES (" + arac_id + ", '" + text_plaka.Text.ToString() + "', " + model_id + ", " + renk_id + ", " + tip_id + ", " + text_kullanici.Text.ToString() + ")");
            }
            controlid = db.getidfromvalue("Arac_Bilgileri", "Arac_ID", "Plaka", text_plaka.Text);
            if (db.checkforid("Parktaki_araclar","Arac_ID",controlid))
            {
                db.sqltest("Parkta olan bir aracı eklemeye çalışıyorsunuz!");
            }
            else if (controlid== -1)
            {
                db.sqlq("INSERT INTO public.\"Parktaki_araclar\"(\"Arac_ID\", \"Arac_giris_suresi\") VALUES (" + arac_id + ", current_timestamp)");
            }
            }
            MainForm.mainForm.refresh();
            Close();
        }

        private void Aracins_Load(object sender, EventArgs e)
        {
            
        }
    }
}

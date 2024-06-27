using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Collections;
using System.Runtime.Remoting.Contexts;
using System.Drawing.Text;

namespace FZ_NM_PROJEKAT_SOFTING
{
    public partial class Form1 : Form
    {

        //PRIPREMA ZA BAZU
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-Q1LFQNB\\SQLEXPRESS;" +
                                               "Initial Catalog=FZ_NM_PROJEKAT_V2;" +
                                               "Integrated Security=True");
        SqlCommand cmd;
        DataTable dataTablet;
        SqlDataAdapter adapter;
        DataSet dataSet;
        //PRIPREMA ZA PRACENJE TABELA
        public string tabela;
        List<int> selectedIds = new List<int>();

        public void GetTable(string query, string name)
        {
            conn.Open();
            cmd = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(cmd);
            dataSet = new DataSet();
            adapter.Fill(dataSet, name);
            dataTablet = dataSet.Tables[name];
            conn.Close();
        }


        public void Visibility(bool a = true, bool b = true, bool c = true, bool d = true, bool e = true)
        {
            Izbrisi.Visible = a;
            Naruci.Visible = b;
            label1.Visible = c;
            textBox1.Visible = d;
            Dodaj_Radnika.Visible = e;
        }
        public void ClearTable()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
        }

        public Form1()
        {
            InitializeComponent();
            label3.Text = " "; // IZNAD TABELE ISPISE IME TABELE KASNIJE

            //POPUNI RESTORAN INFORMACIJU
            GetTable("SELECT restoran_id FROM Restorani", "RestoranTable");

            List<KeyValuePair<int, string>> restoranList = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dataTablet.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(" Restoran " + (i + 1));

                restoranList.Add(new KeyValuePair<int, string>(i+1, "Restoran"+(i+1)));
            }
            RadnikRestoran.DataSource = restoranList;
            RadnikRestoran.DisplayMember = "Value";
            RadnikRestoran.ValueMember = "Key";

            //POPUNI GRAD INFORMACIJU
            GetTable("SELECT ptt, ime_grada FROM Grad", "GradTable");
            List<KeyValuePair<int, string>> gradList = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dataTablet.Rows.Count; i++)
            {
                int ptt = Convert.ToInt32(dataTablet.Rows[i]["ptt"]);
                string imeGrada = dataTablet.Rows[i]["ime_grada"].ToString();
                gradList.Add(new KeyValuePair<int, string>(ptt, imeGrada));
            }
            RadnikLokacija.DataSource = gradList;
            RadnikLokacija.DisplayMember = "Value";
            RadnikLokacija.ValueMember = "Key";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Rezervacije_Click(object sender, EventArgs e)
        {
            //MENJA VIDLJIVOST DUGMADI
            Visibility(b: false, c: false, d: false, e: false);

           
            tabela = "Rezervacije";
            label3.Text = tabela + ": ";

            //IZBRISI PROSLU TABELU
            ClearTable();

            //KREIRAR KOLONE
            listView1.Columns.Add("id", 30);
            listView1.Columns.Add("ime", 150, HorizontalAlignment.Right);
            listView1.Columns.Add("Prezime", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("datum", 100, HorizontalAlignment.Right);
            listView1.Columns.Add("vreme", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("br_stolica", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Restoran_id", 100, HorizontalAlignment.Center);
            listView1.View = View.Details;

            //SELEKCIJA TABELE U BAZI
            GetTable(SelectList(), "RezervacijeTable");
            //LISTANJE KROZ BAZU I POPUNJAVANJE TABELE
            int i;
            for (i = 0; i < dataTablet.Rows.Count; i++)
            {
                listView1.Items.Add(dataTablet.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[3].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[5].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[6].ToString());
            }

        }

        public void Magacin_Click(object sender, EventArgs e)
        {
            //MENJA VIDLJIVOST DUGMADI
            Visibility(a: false, e: false);

            tabela = "Magacin";
            label3.Text = tabela + ": ";
            //IZBRISI PROSLU TABELU
            ClearTable();

            //KREIRAR KOLONE
            listView1.Columns.Add("id", 30);
            listView1.Columns.Add("sastojak", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("kolicina", 100, HorizontalAlignment.Right);
            listView1.Columns.Add(" ", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("restoran_id", 100, HorizontalAlignment.Center);
            listView1.View = View.Details;

            //SELEKCIJA TABELE U BAZI
            GetTable(SelectList(), "MagacinTable");
            //LISTANJE KROZ BAZU I POPUNJAVANJE TABELE
            int i;
            for (i = 0; i < dataTablet.Rows.Count; i++)
            {
                listView1.Items.Add(dataTablet.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[3].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[4].ToString());

            }

        }

        public void Zaposleni_Click(object sender, EventArgs e)
        {
            Visibility(b: false, c: false, d:false);

            tabela = "Radnici";
            label3.Text = tabela + ": ";
            //IZBRISI PROSLU TABELU
            ClearTable();

            //KREIRAR KOLONE
            listView1.Columns.Add("id", 30);
            listView1.Columns.Add("ime", 150, HorizontalAlignment.Right);
            listView1.Columns.Add("Prezime", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("profesija", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("plata", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("restoran id", 100, HorizontalAlignment.Center);
            listView1.View = View.Details;

            //SELEKCIJA TABELE U BAZI
            GetTable(SelectList(), "RadniciTable");
            //LISTANJE KROZ BAZU I POPUNJAVANJE TABELE
            int i;
            for (i = 0; i < dataTablet.Rows.Count; i++)
            {
                listView1.Items.Add(dataTablet.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[3].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(dataTablet.Rows[i].ItemArray[5].ToString());
            }
        }

        public string SelectList()
        {
            //IZBRISI PROSLU TABELU
            listView1.Items.Clear();

            //POPUNI NOVU TABELU
            string msg = "";
            switch (tabela)
            {

                case "Rezervacije":
                    msg = "SELECT rezervacija_id,ime,prezime,datum,vreme,br_stolica,restoran_id FROM Rezervacije";
                    break;
                case "Magacin":
                    msg = "SELECT sastojak_id,ime_sastojka, kolicina,merna_jedinica,restoran_id FROM Magacin";
                    break;
                case "Radnici":
                    msg = "SELECT radnik_id, ime, prezime, profesija, plata, restoran_id FROM Radnici";
                    break;
                default:
                    msg = "SELECT rezervacija_id,ime,prezime,datum,vreme,br_stolica,restoran_id FROM Rezervacije";
                    break;
            }
            //FILTERUJ PO RESTORANIMA
            if (selectedIds.Count > 0)
            {
                msg += " WHERE restoran_id IN (" + string.Join(", ", selectedIds) + ")";
            }
            return msg;
        }

                private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // NAPRAVI LISTU SVIH SLEKTOVANIH RESTORAN ID
            var checkedItems = checkedListBox1.CheckedItems;
            selectedIds = new List<int>();
            foreach (string item in checkedItems)
            {
                if (int.TryParse(item.Substring(10), out int id))
                {
                    selectedIds.Add(id);
                }

            }

            switch (tabela)
            {
                case "Rezervacije":
                    Rezervacije_Click(sender, e);
                    break;
                case "Magacin":
                    Magacin_Click(sender, e);
                    break;
                case "Radnici":
                    Zaposleni_Click(sender, e);
                    break;
                default:
                    Rezervacije_Click(sender, e);
                    break;
            }

        }
        private void Izbrisi_Click(object sender, EventArgs e)
        {
            void DeleteItem(string query, int id)
            {
                //BRISANJE IZ BAZE
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            // DALI JE IZABRANA OPCIJA
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Opcija nije izabrana");
            }
            else if (listView1.SelectedItems.Count > 0)
            {
                int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                // IZBRISI IZ LISTE:
                listView1.Items.Remove(listView1.SelectedItems[0]);

                   
                // IZ KOJE TABELE BRISEMO
                switch (tabela)
                {

                    case "Rezervacije":
                        // TABELA REZERVACIJE JE POVEZANA SA TABELOM NARUCENO
                        DeleteItem("DELETE FROM Naruceno WHERE rezervacija_id = @id", id);
                        //  BRISANJE IZ TABELE
                        DeleteItem("DELETE FROM Rezervacije WHERE rezervacija_id = @id", id);
                        break;

                    case "Magacin":
                        //  BRISANJE IZ TABELE
                        DeleteItem("DELETE FROM Magacin WHERE sastojak_id = @id", id);
                        break;
                    case "Radnici":
                        //  delete related records from table
                        DeleteItem("DELETE FROM Radnici WHERE radnik_id = @id", id);
                        break;
                }
            }
        }
           
        private void Naruci_Click(object sender, EventArgs e)
        {
            // AKO SASTOJAK NIJE SELEKTOVAN
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Opcija nije izabrana");
            }
            // AKO CENA NIJE DOBRO UNETA
            else if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int increaseAmount))
            {
                MessageBox.Show("Unesite validan broj");
            }
            //UPDATUJE SE BAZA
            else if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                    conn.Open();
                    string query = "UPDATE Magacin SET kolicina = kolicina + @IncreaseAmount WHERE sastojak_id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@IncreaseAmount", increaseAmount);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    Magacin_Click(sender, e);
                }
            }
        }

        //OTVARA FORMU ZA POPUNAVANJE
        private void Dodaj_Radnika_Click(object sender, EventArgs e)
        {
            RadnikForm.Visible = true;
        }
        //ZATVARA FORMU
        public void Otkazi_Click(object sender, EventArgs e)
        {
            RadnikForm.Visible = false;
            //OCISTI SVU UNETU INFORMACIJU
            RadnikIme.Text = string.Empty;
            RadnikPrezime.Text = string.Empty;
            RadnikPlata.Text = string.Empty;
        }

        
        private void Potvrdi_Click(object sender, EventArgs e)
        {
            // UZIMANJE INFORMACIJE IZ FORME
            string ime = RadnikIme.Text;
            string prezime = RadnikPrezime.Text;
            string profesija = RadnikProfesija.Text;
            int plata = 0;
            if (int.TryParse(RadnikPlata.Text, out plata))
            {
                if (plata <= 0)
                {
                    MessageBox.Show("Nevažeći unos za „Plata“. Unesite važeću celobrojnu vrednost.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            int restoran = -1;
            if (RadnikRestoran.SelectedIndex != -1 && RadnikRestoran.SelectedValue != null)
            {
                restoran = (int)RadnikRestoran.SelectedValue;
            }
            int lokacija = -1;
            if (RadnikLokacija.SelectedIndex != -1 && RadnikLokacija.SelectedValue != null)
            {
                lokacija = (int)RadnikLokacija.SelectedValue;
            }
            // DALI JE SVA INFORMACIJA POPUNJENA
            if (string.IsNullOrWhiteSpace(ime) || string.IsNullOrWhiteSpace(prezime) ||
                string.IsNullOrWhiteSpace(profesija) || restoran == -1 || lokacija == -1 || plata <= 0)
            {
                MessageBox.Show("Popunite sva polja.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //INSERTOVANJE U BAZU
                conn.Open();
                string query = "INSERT INTO Radnici (ime,prezime,profesija, plata, restoran_id,location)" +
                                "VALUES(@ime,@prezime,@profesija,@plata,@restoran_id,@location)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ime", ime);
                cmd.Parameters.AddWithValue("@prezime", prezime);
                cmd.Parameters.AddWithValue("@profesija", profesija);
                cmd.Parameters.AddWithValue("@plata", plata);
                cmd.Parameters.AddWithValue("@restoran_id", restoran);
                cmd.Parameters.AddWithValue("@location", lokacija);
                cmd.ExecuteNonQuery();

                conn.Close();
                Zaposleni_Click(sender, e);
                Otkazi_Click(sender, e);
            }
        }
    }
}

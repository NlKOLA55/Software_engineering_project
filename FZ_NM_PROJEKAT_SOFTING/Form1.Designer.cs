namespace FZ_NM_PROJEKAT_SOFTING
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Rezervacije = new System.Windows.Forms.Button();
            this.Magacin = new System.Windows.Forms.Button();
            this.Zaposleni = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.Naruci = new System.Windows.Forms.Button();
            this.Izbrisi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Dodaj_Radnika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RadnikForm = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Potvrdi = new System.Windows.Forms.Button();
            this.Otkazi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RadnikRestoran = new System.Windows.Forms.ComboBox();
            this.RadnikLokacija = new System.Windows.Forms.ComboBox();
            this.RadnikProfesija = new System.Windows.Forms.ComboBox();
            this.RadnikPlata = new System.Windows.Forms.TextBox();
            this.RadnikPrezime = new System.Windows.Forms.TextBox();
            this.RadnikIme = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RadnikForm.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rezervacije
            // 
            this.Rezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rezervacije.Location = new System.Drawing.Point(3, 3);
            this.Rezervacije.Name = "Rezervacije";
            this.Rezervacije.Size = new System.Drawing.Size(124, 50);
            this.Rezervacije.TabIndex = 4;
            this.Rezervacije.Text = "Rezervacije";
            this.Rezervacije.UseVisualStyleBackColor = true;
            this.Rezervacije.Click += new System.EventHandler(this.Rezervacije_Click);
            // 
            // Magacin
            // 
            this.Magacin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Magacin.Location = new System.Drawing.Point(3, 59);
            this.Magacin.Name = "Magacin";
            this.Magacin.Size = new System.Drawing.Size(124, 50);
            this.Magacin.TabIndex = 5;
            this.Magacin.Text = "Magacin";
            this.Magacin.UseVisualStyleBackColor = true;
            this.Magacin.Click += new System.EventHandler(this.Magacin_Click);
            // 
            // Zaposleni
            // 
            this.Zaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zaposleni.Location = new System.Drawing.Point(3, 115);
            this.Zaposleni.Name = "Zaposleni";
            this.Zaposleni.Size = new System.Drawing.Size(124, 50);
            this.Zaposleni.TabIndex = 6;
            this.Zaposleni.Text = "Zaposleni";
            this.Zaposleni.UseVisualStyleBackColor = true;
            this.Zaposleni.Click += new System.EventHandler(this.Zaposleni_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.Rezervacije);
            this.flowLayoutPanel1.Controls.Add(this.Magacin);
            this.flowLayoutPanel1.Controls.Add(this.Zaposleni);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 11);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 380);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "TABELE:";
            // 
            // Naruci
            // 
            this.Naruci.BackColor = System.Drawing.SystemColors.Window;
            this.Naruci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naruci.Location = new System.Drawing.Point(214, 28);
            this.Naruci.Name = "Naruci";
            this.Naruci.Size = new System.Drawing.Size(124, 50);
            this.Naruci.TabIndex = 12;
            this.Naruci.Text = "Naruci";
            this.Naruci.UseVisualStyleBackColor = false;
            this.Naruci.Visible = false;
            this.Naruci.Click += new System.EventHandler(this.Naruci_Click);
            // 
            // Izbrisi
            // 
            this.Izbrisi.BackColor = System.Drawing.SystemColors.Window;
            this.Izbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izbrisi.Location = new System.Drawing.Point(27, 28);
            this.Izbrisi.Name = "Izbrisi";
            this.Izbrisi.Size = new System.Drawing.Size(124, 50);
            this.Izbrisi.TabIndex = 13;
            this.Izbrisi.Text = "Izbrisi";
            this.Izbrisi.UseVisualStyleBackColor = false;
            this.Izbrisi.Visible = false;
            this.Izbrisi.Click += new System.EventHandler(this.Izbrisi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(415, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // Dodaj_Radnika
            // 
            this.Dodaj_Radnika.BackColor = System.Drawing.SystemColors.Window;
            this.Dodaj_Radnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dodaj_Radnika.Location = new System.Drawing.Point(571, 28);
            this.Dodaj_Radnika.Name = "Dodaj_Radnika";
            this.Dodaj_Radnika.Size = new System.Drawing.Size(124, 50);
            this.Dodaj_Radnika.TabIndex = 15;
            this.Dodaj_Radnika.Text = "Dodaj Radnika";
            this.Dodaj_Radnika.UseVisualStyleBackColor = false;
            this.Dodaj_Radnika.Visible = false;
            this.Dodaj_Radnika.Click += new System.EventHandler(this.Dodaj_Radnika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "kolicina:";
            this.label1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-3, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(729, 411);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(723, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "selektovana tabela:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-8, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 411);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-8, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 61);
            this.panel2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(888, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Restorani: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.RadnikForm);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Location = new System.Drawing.Point(153, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 422);
            this.panel3.TabIndex = 22;
            // 
            // RadnikForm
            // 
            this.RadnikForm.Controls.Add(this.label11);
            this.RadnikForm.Controls.Add(this.Potvrdi);
            this.RadnikForm.Controls.Add(this.Otkazi);
            this.RadnikForm.Controls.Add(this.label10);
            this.RadnikForm.Controls.Add(this.label9);
            this.RadnikForm.Controls.Add(this.label8);
            this.RadnikForm.Controls.Add(this.label7);
            this.RadnikForm.Controls.Add(this.label6);
            this.RadnikForm.Controls.Add(this.label5);
            this.RadnikForm.Controls.Add(this.RadnikRestoran);
            this.RadnikForm.Controls.Add(this.RadnikLokacija);
            this.RadnikForm.Controls.Add(this.RadnikProfesija);
            this.RadnikForm.Controls.Add(this.RadnikPlata);
            this.RadnikForm.Controls.Add(this.RadnikPrezime);
            this.RadnikForm.Controls.Add(this.RadnikIme);
            this.RadnikForm.Location = new System.Drawing.Point(204, 25);
            this.RadnikForm.Name = "RadnikForm";
            this.RadnikForm.Size = new System.Drawing.Size(366, 331);
            this.RadnikForm.TabIndex = 18;
            this.RadnikForm.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(338, 31);
            this.label11.TabIndex = 16;
            this.label11.Text = "Unesi Informaciju o Radiku";
            // 
            // Potvrdi
            // 
            this.Potvrdi.BackColor = System.Drawing.SystemColors.Window;
            this.Potvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Potvrdi.Location = new System.Drawing.Point(208, 268);
            this.Potvrdi.Name = "Potvrdi";
            this.Potvrdi.Size = new System.Drawing.Size(124, 40);
            this.Potvrdi.TabIndex = 15;
            this.Potvrdi.Text = "Potvrdi";
            this.Potvrdi.UseVisualStyleBackColor = false;
            this.Potvrdi.Click += new System.EventHandler(this.Potvrdi_Click);
            // 
            // Otkazi
            // 
            this.Otkazi.BackColor = System.Drawing.SystemColors.Window;
            this.Otkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Otkazi.Location = new System.Drawing.Point(37, 268);
            this.Otkazi.Name = "Otkazi";
            this.Otkazi.Size = new System.Drawing.Size(124, 40);
            this.Otkazi.TabIndex = 14;
            this.Otkazi.Text = "Otkazi";
            this.Otkazi.UseVisualStyleBackColor = false;
            this.Otkazi.Click += new System.EventHandler(this.Otkazi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(207, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Lokacija:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(207, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Plata:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Prezime:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Restoran:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Profesija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ime:";
            // 
            // RadnikRestoran
            // 
            this.RadnikRestoran.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RadnikRestoran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RadnikRestoran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadnikRestoran.FormattingEnabled = true;
            this.RadnikRestoran.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.RadnikRestoran.Location = new System.Drawing.Point(37, 210);
            this.RadnikRestoran.Name = "RadnikRestoran";
            this.RadnikRestoran.Size = new System.Drawing.Size(124, 28);
            this.RadnikRestoran.TabIndex = 7;
            // 
            // RadnikLokacija
            // 
            this.RadnikLokacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RadnikLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadnikLokacija.FormattingEnabled = true;
            this.RadnikLokacija.Location = new System.Drawing.Point(211, 210);
            this.RadnikLokacija.Name = "RadnikLokacija";
            this.RadnikLokacija.Size = new System.Drawing.Size(124, 28);
            this.RadnikLokacija.TabIndex = 6;
            // 
            // RadnikProfesija
            // 
            this.RadnikProfesija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RadnikProfesija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadnikProfesija.FormattingEnabled = true;
            this.RadnikProfesija.Items.AddRange(new object[] {
            "Kuvar",
            "Konobar",
            "Cistac"});
            this.RadnikProfesija.Location = new System.Drawing.Point(37, 144);
            this.RadnikProfesija.Name = "RadnikProfesija";
            this.RadnikProfesija.Size = new System.Drawing.Size(124, 28);
            this.RadnikProfesija.TabIndex = 5;
            // 
            // RadnikPlata
            // 
            this.RadnikPlata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadnikPlata.Location = new System.Drawing.Point(211, 144);
            this.RadnikPlata.Name = "RadnikPlata";
            this.RadnikPlata.Size = new System.Drawing.Size(124, 26);
            this.RadnikPlata.TabIndex = 4;
            // 
            // RadnikPrezime
            // 
            this.RadnikPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadnikPrezime.Location = new System.Drawing.Point(211, 70);
            this.RadnikPrezime.Name = "RadnikPrezime";
            this.RadnikPrezime.Size = new System.Drawing.Size(124, 26);
            this.RadnikPrezime.TabIndex = 1;
            // 
            // RadnikIme
            // 
            this.RadnikIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadnikIme.Location = new System.Drawing.Point(37, 70);
            this.RadnikIme.Name = "RadnikIme";
            this.RadnikIme.Size = new System.Drawing.Size(124, 26);
            this.RadnikIme.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Izbrisi);
            this.panel4.Controls.Add(this.Naruci);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.Dodaj_Radnika);
            this.panel4.Location = new System.Drawing.Point(158, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(726, 121);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(-5, 463);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1034, 119);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Controls.Add(this.flowLayoutPanel2);
            this.panel6.Location = new System.Drawing.Point(879, 60);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 403);
            this.panel6.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Controls.Add(this.checkedListBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 11);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(130, 380);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(127, 379);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 578);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.RadnikForm.ResumeLayout(false);
            this.RadnikForm.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Rezervacije;
        private System.Windows.Forms.Button Magacin;
        private System.Windows.Forms.Button Zaposleni;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Naruci;
        private System.Windows.Forms.Button Izbrisi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Dodaj_Radnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel RadnikForm;
        private System.Windows.Forms.ComboBox RadnikRestoran;
        private System.Windows.Forms.ComboBox RadnikLokacija;
        private System.Windows.Forms.ComboBox RadnikProfesija;
        private System.Windows.Forms.TextBox RadnikPlata;
        private System.Windows.Forms.TextBox RadnikPrezime;
        private System.Windows.Forms.TextBox RadnikIme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Potvrdi;
        private System.Windows.Forms.Button Otkazi;
        private System.Windows.Forms.Label label11;
    }
}


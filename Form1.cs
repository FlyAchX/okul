using Microsoft.EntityFrameworkCore;

namespace WinForms_EF
{
    public partial class Form1 : Form
    {
        VTContext veriler = new VTContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ogrenci yeni_ogr = new ogrenci();
            yeni_ogr.OkulNo = Int32.Parse(textBox1.Text);
            yeni_ogr.Ad = textBox2.Text;
            yeni_ogr.Soyad = textBox3.Text;
            veriler.ogrenciler.Add(yeni_ogr);
            veriler.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriler.ogrenciler.Load();
            dataGridView1.DataSource = veriler.ogrenciler.Local.ToBindingList();
        }
    }
}
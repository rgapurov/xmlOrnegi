using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xmlOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // xml dosyamın oluşacak yolunu proje yolu olarak belirttim
            string xmlpath = Application.StartupPath + "\\Customer.xml";
            //Yazıcı nesnemi ve formatımı oluşturdum
            XmlTextWriter customer = new XmlTextWriter(xmlpath, UTF8Encoding.UTF8);
            //Format düzenleme satırımı ekledım
            customer.Formatting = Formatting.Indented;
            //ve işlemimi başlatıyorum
            customer.WriteStartDocument();
            customer.WriteStartElement("Müşteriler");
            customer.WriteStartElement("Müşteri");
            //Id Tanımlamak için kullandım
            customer.WriteStartAttribute("ID", "1");
            //Sıra geldi Textboxlardan verileri almaya!!
            customer.WriteElementString("isim", txtAd.Text);
            customer.WriteElementString("soyisim", txtSoyad.Text);
            //tag kapama işlemimi yapıyorum
            customer.WriteEndElement();
            customer.WriteEndElement();
            //Kapıyorum
            customer.Close();
            MessageBox.Show("İŞLEMİNİZ TAMAMLANMIŞTIR");
            Application.Exit();
        }
    }
}

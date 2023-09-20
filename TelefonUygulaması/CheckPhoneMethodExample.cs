using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonUygulaması
{
    public partial class CheckPhoneMethodExample : Form
    {
        public CheckPhoneMethodExample()
        {
            InitializeComponent();
        }

        private void btnCheckPhone_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            string phoneLast = CheckPhone(phoneNumber);
            if (phoneLast.Contains("Hata"))
            {
                MessageBox.Show(phoneLast);
            }
            else
            {
                // kullanıcıya sms gönderme işlemi
                MessageBox.Show($"{phoneLast} telefona mesaj gönderilmiştir");
            }
        }


        public string CheckPhone(string phone)
        {
            try
            {
                if (phone == "")
                {
                    return "Hata mesajı  => lütfen telefon alanını doldurunuz";
                }

                phone = phone.Replace(" ", "");
                phone = phone.Replace("+", "");            //1. durumdan 2. duruma çevirir.

                string firstcharacter = phone.Substring(0, 1);
                if (firstcharacter == "9")
                {
                    phone = phone.Substring(1, phone.Length - 1);
                }
                else if (firstcharacter != "0")
                {
                    phone = "0" + phone;
                }
                if (phone.Length == 11)
                {
                    Convert.ToDouble(phone);
                    return phone;
                }
                return "Hata mesajı => lütfen girdiğiniz telefon formatını kontrol ediniz.";
            }
            catch(FormatException)
            {
                return "Hata mesajı => lütfen uygun format ile telefon numarası giriniz.";
            }
            catch (Exception)
            {
                return "Hata mesajı => Bilinmeyen hata lütfen telefon numaranızı tekrar giriniz.";
            }
            

        }









        //05350554833
        //
        //0535 055 48 33
        //
        //+90535 055 48 33
        //
        //5350554833
        //
        //asddasdasa
    }
}

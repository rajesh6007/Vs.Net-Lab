using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {

            string provience = comboBox1.SelectedItem.ToString();
            comboBox2.Items.Clear();

            switch (provience)
            {
                case "Koshi":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new string[] { "Bhojpur", "Dhankuta", "Ilam", "Jhapa", "Khotang", "Morang", "Okhaldhunga", "Panchthar", "Sankhuwasabha", "Solukhumbu", "Sunsari", "Taplejung", "Terhathum", "Udayapur" });
                    break;

                case "Madesh":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new string[] { "Bara", "Dhanusha", "Mahottari", "Parsa", "Rautahat", "Saptari", "Sarlahi", "Siraha" });
                    break;

                case "Bagmati":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new string[] { "Bhaktapur", "Chitwan", "Dhading", "Dolakha", "Kathmandu", "Kavrepalanchok", "Lalitpur", "Makwanpur", "Nuwakot", "Ramechhap", "Rasuwa", "Sindhuli", "Sindhupalchok" });
                    break;

                case "Gandaki":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new string[] { "Baglung", "Gorkha", "Kaski", "Lamjung", "Manang", "Mustang", "Myagdi", "Nawalpur", "Parbat", "Syangja", "Tanahun" });
                    break;

                case "Lumbini":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new string[] { "Arghakhanchi", "Banke", "Bardiya", "Dang", "Eastern Rukum", "Gulmi", "Kapilvastu", "Parasi", "Palpa", "Pyuthan", "Rolpa", "Rupandehi" });
                    break;

                case "Karnali":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new string[] { "Dailekh", "Dolpa", "Humla", "Jajarkot", "Jumla", "Kalikot", "Mugu", "Salyan", "Surkhet", "Western Rukum" });
                    break;

                case "Sudurpashchim":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new string[] { "Achham", "Baitadi", "Bajhang", "Bajura", "Dadeldhura", "Darchula", "Doti", "Kailali", "Kanchanpur" });
                    break;

                default:
                    comboBox2.Items.Clear();
                    break;
            }



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press if it's a digit
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == "") && !(comboBox1.Text == "") && !(comboBox2.Text == ""))
            {
                MessageBox.Show(textBox1.Text + "\n" + comboBox1.Text + "\n" + comboBox2.Text);
            }

            else
            {
                MessageBox.Show("Please fill the forms");
            }
        }
    }
}

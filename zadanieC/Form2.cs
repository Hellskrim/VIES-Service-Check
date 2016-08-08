using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using ZadanieC.VatChecker;
using System.Web.Services.Protocols;
namespace ZadanieC
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
            Initialize();
        }



        private void Initialize()
        {
            textBox2.MaxLength = 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Application();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            this.Close();
            frm.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
                label3.Visible = true;
            else
            {
                label3.Visible = false;
                try
                {
                    if (comboBox1.SelectedItem != null && textBox2.Text.Length >= 10)
                    {
                        VIESCheckService isCheckService = VIESCheckServFact.getService(ServiceType.SOAP);
                        VatValid isValid = isCheckService.getDetailVat(comboBox1.SelectedItem.ToString().Split('-')[0], textBox2.Text);
                        
                        MessageBox.Show("Valid: " + isValid.gsValid + "\nName: " + isValid.gsName + "\nAddress: " + isValid.gsAddress, "Check");
                    }

                    else
                        MessageBox.Show("Sth goes wrong... try again", "Check");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured: " + ex.ToString(), "title");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VIESCheckService isCheckService = VIESCheckServFact.getService(ServiceType.SOAP);
                VatValid isValid = isCheckService.getDetailVat(comboBox1.SelectedItem.ToString().Split('-')[0], textBox2.Text);

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "XML Files (*.xml)|*.xml";
                save.Title = "Zapisz jako..";

                if (save.ShowDialog() == DialogResult.OK && isValid.gsValid)
                {
                    XMLWriter.saveData(isValid, save.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is nothing to save", "Save Error");
            }
        }
    }
}

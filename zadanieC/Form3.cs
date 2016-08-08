using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZadanieC.VatChecker;
using System.Web.Services.Protocols;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace ZadanieC
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            textBox4.Text = "6342709934";
            comboBox2.SelectedIndex = 22;
            textBox2.MaxLength = 10;
            textBox4.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Application();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            this.Close();
            frm.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox4.Text == "")
                label3.Visible = true;
            else
            {
                label3.Visible = false;
                try
                {
                    if (comboBox1.SelectedItem != null && textBox2.Text.Length >= 10 &&
                        comboBox2.SelectedItem != null && textBox4.Text.Length >= 10 &&
                        comboBox1.SelectedItem.Equals(comboBox2.SelectedItem))
                    {
                        VIESCheckService isCheckServiceApprox = VIESCheckServFact.getService(ServiceType.SOAP);
                        VatValidApprox isValidApprox = isCheckServiceApprox.getDetailVatApprox(comboBox1.SelectedItem.ToString().Split('-')[0], textBox2.Text, comboBox2.SelectedItem.ToString().Split('-')[0], textBox4.Text);
                        
                        treeView1.Nodes.Clear();
                        TreeNode rootResultsNode;
                        rootResultsNode = treeView1.Nodes.Add("Show Results");
                        rootResultsNode.Nodes.Add("Valid: " + isValidApprox.gsValid);
                        if(isValidApprox.gsValid)
                        {
                            treeView1.Nodes[0].FirstNode.ForeColor = Color.Green;
                            rootResultsNode.Nodes.Add("Company name: " + isValidApprox.gsTraderName);
                            rootResultsNode.Nodes.Add("Company address: " + isValidApprox.gsTraderAddress);
                            rootResultsNode.Nodes.Add("Request Identifier: " + isValidApprox.gsRequestIdentifier);
                        }
                        else
                        {
                            rootResultsNode.FirstNode.ForeColor = Color.Red;
                        }
                    }
                    else
                        MessageBox.Show("Sth goes wrong... try again", "Check");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error occured: " + ex.ToString(), "Error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                VIESCheckService isCheckServiceApprox = VIESCheckServFact.getService(ServiceType.SOAP);
                VatValidApprox isValidApprox = isCheckServiceApprox.getDetailVatApprox(comboBox1.SelectedItem.ToString().Split('-')[0], textBox2.Text, comboBox2.SelectedItem.ToString().Split('-')[0], textBox4.Text);
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "XML Files (*.xml)|*.xml";
                save.Title = "Zapisz jako..";
                if (save.ShowDialog() == DialogResult.OK && isValidApprox.gsValid)
                {
                    XMLWriter.saveData(isValidApprox, save.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is nothing to save", "Save Error");
            }

        }
    }
}

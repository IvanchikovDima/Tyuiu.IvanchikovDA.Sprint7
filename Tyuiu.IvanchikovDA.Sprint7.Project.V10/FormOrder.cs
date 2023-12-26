using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.IvanchikovDA.Sprint7.Project.V10.Lib;

namespace Tyuiu.IvanchikovDA.Sprint7.Project.V10
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            
        }        
        private void buttonSave_IDA_Click(object sender, EventArgs e)
        {
            StringBuilder selectedItems = new StringBuilder();

            
            for (int i = 0; i < checkedListBox_IDA.Items.Count; i++)
            {
                
                if (checkedListBox_IDA.GetItemChecked(i))
                {
                    
                    selectedItems.Append(checkedListBox_IDA.Items[i].ToString());

                    if (i < checkedListBox_IDA.Items.Count - 1)
                        selectedItems.Append(", ");
                }
            }
            string selectedItemsString = selectedItems.ToString();

            string path = $@"{Directory.GetCurrentDirectory()}\заказы.csv";

                using (StreamWriter streamWriter = new StreamWriter(path, true, Encoding.Default))
                {
                    string surname = textBoxSurname_IDA.Text;
                    string name = textBoxName_IDA.Text;
                    string otchestvo = textBoxOtchestvo_IDA.Text;
                    string phoneNumber = textBoxTelephone_IDA.Text;
                    string adress = textBoxAdress_IDA.Text;
                    string nomerScheta = textBoxNomerScheta_IDA.Text;
                    string price = textBoxPrice_IDA.Text;
                    string date = dateTimePicker_IDA.Text;
                    
                    string data = $"{surname};{name};{otchestvo};{phoneNumber};{adress};{nomerScheta};{selectedItems};{price};{date}";
                    streamWriter.WriteLine(data);
                    streamWriter.Close();
                }
            MessageBox.Show("Ваш заказ принят, мы позвоним вам, когда он будет готов", "Спасибо за заказ!", MessageBoxButtons.OK);
              
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            dateTimePicker_IDA.MinDate = DateTime.Today;
            dateTimePicker_IDA.MaxDate = DateTime.Today.AddDays(7);
        }

        private void buttonPrice_VAA_Click(object sender, EventArgs e)
        {
            PriceItems pi = new PriceItems();

            double totalSum = 0;

            for (int i = 0; i < checkedListBox_IDA.CheckedItems.Count; i++)
            {
                string item = checkedListBox_IDA.CheckedItems[i].ToString();
                double price = pi.GetPrice(item);

                totalSum += price;
            }

            textBoxPrice_IDA.Text = totalSum.ToString();
        }

        
    }
}

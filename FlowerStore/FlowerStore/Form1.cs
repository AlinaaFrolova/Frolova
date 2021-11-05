using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowerDBDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.flowerDBDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowerDBDataSet.Цветок". При необходимости она может быть перемещена или удалена.
            this.цветокTableAdapter.Fill(this.flowerDBDataSet.Цветок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowerDBDataSet.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter.Fill(this.flowerDBDataSet.Тип);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowerDBDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.flowerDBDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowerDBDataSet.Цветок". При необходимости она может быть перемещена или удалена.
            this.цветокTableAdapter.Fill(this.flowerDBDataSet.Цветок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowerDBDataSet.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter.Fill(this.flowerDBDataSet.Тип);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.типBindingSource.EndEdit();
            this.типTableAdapter.Update(this.flowerDBDataSet.Тип);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.цветокBindingSource.EndEdit();
            this.цветокTableAdapter.Update(this.flowerDBDataSet.Цветок);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.заказBindingSource.EndEdit();
            this.заказTableAdapter.Update(this.flowerDBDataSet.Заказ);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Сountry : Form
    {
        public Сountry()
        {
            InitializeComponent();
        }

        private void країнаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.країнаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.каталог_взуттяDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_взуттяDataSet.Країна". При необходимости она может быть перемещена или удалена.
            this.країнаTableAdapter.Fill(this.каталог_взуттяDataSet.Країна);

        }
    }
}

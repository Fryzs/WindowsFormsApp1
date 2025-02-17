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
    public partial class Shoe_catalog : Form
    {
        public Shoe_catalog()
        {
            InitializeComponent();
        }

        private void каталог_взуттяBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_взуттяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.каталог_взуттяDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_взуттяDataSet.Каталог_взуття". При необходимости она может быть перемещена или удалена.
            this.каталог_взуттяTableAdapter.Fill(this.каталог_взуттяDataSet.Каталог_взуття);

        }
    }
}

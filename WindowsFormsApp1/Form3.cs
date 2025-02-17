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
    public partial class Upper_material : Form
    {
        public Upper_material()
        {
            InitializeComponent();
        }

        private void матеріал_верхаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.матеріал_верхаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.каталог_взуттяDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_взуттяDataSet.Матеріал_верха". При необходимости она может быть перемещена или удалена.
            this.матеріал_верхаTableAdapter.Fill(this.каталог_взуттяDataSet.Матеріал_верха);

        }

        private void матеріал_верхаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

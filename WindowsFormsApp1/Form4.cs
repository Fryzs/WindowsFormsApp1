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
    public partial class Sole_material : Form
    {
        public Sole_material()
        {
            InitializeComponent();
        }

        private void матеріал_підошвиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.матеріал_підошвиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.каталог_взуттяDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_взуттяDataSet.Матеріал_підошви". При необходимости она может быть перемещена или удалена.
            this.матеріал_підошвиTableAdapter.Fill(this.каталог_взуттяDataSet.Матеріал_підошви);

        }
    }
}

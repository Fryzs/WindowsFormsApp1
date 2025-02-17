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
    public partial class Target_audience : Form
    {
        public Target_audience()
        {
            InitializeComponent();
        }

        private void цільова_аудиторіяBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.цільова_аудиторіяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.каталог_взуттяDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_взуттяDataSet.Цільова_аудиторія". При необходимости она может быть перемещена или удалена.
            this.цільова_аудиторіяTableAdapter.Fill(this.каталог_взуттяDataSet.Цільова_аудиторія);

        }
    }
}

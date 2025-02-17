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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Сountry сountry = new Сountry();
            сountry.ShowDialog();
        }

        private void Upper_materialButton_Click(object sender, EventArgs e)
        {
            Upper_material upper_Material = new Upper_material();   
            upper_Material.ShowDialog();
        }

        private void Sole_materialButton_Click(object sender, EventArgs e)
        {
            Sole_material sole_Material = new Sole_material();
            sole_Material.ShowDialog();
        }

        private void Target_audienceButton_Click(object sender, EventArgs e)
        {
            Target_audience target_Audience = new Target_audience();    
            target_Audience.ShowDialog();
        }

        private void Shoe_catalogButton_Click(object sender, EventArgs e)
        {
            Shoe_catalog shoe_Catalog  = new Shoe_catalog();
            shoe_Catalog.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

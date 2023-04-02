using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adapter_ri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirtRoad dirtRoad = new DirtRoad();
            dirtRoad.Show();
            TransformerAdapter Asphaltadapter = new TransformerAdapter();
            Asphaltadapter.DirtSpeed();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            AsphaltRoad asphalt = new AsphaltRoad();
            asphalt.Show();
            TransformerAdapter Dirtadapter = new TransformerAdapter();
            Dirtadapter.AsphaltSpeed();

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMR_Contact_List_Generator
{
    public partial class Form1 : Form
    {
        Data dataController;
        public Form1()
        {
            InitializeComponent();
        }    

        private void Form1_Load(object sender, EventArgs e)
        {
            dataController = new Data(this.txt_Console);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String radioModel = select_RadioModel.Text;
            dataController.Download(radioModel, new string[] { });
        }
    }
}

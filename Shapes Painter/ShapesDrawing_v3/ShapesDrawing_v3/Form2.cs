using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesDrawing_v3
{
    public partial class Form2 : Form
    {
        private List<String> InfoList;

        public Form2()
        {
            InitializeComponent();
            InfoList = new List<String>();
            loadInfo(InfoList);
        }

        private void DrawMode_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void InfoMode_Click(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void loadInfo(List<String> list)
        {
            foreach (var item in list)
            {
                ListInfoShapes.Items.Add(item);
            }
        }

        public void setInfoList(List<String> infoList)
        {
            this.InfoList = new List<string> (infoList);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ListInfoShapes.Items.Clear();
            loadInfo(InfoList);
        }
    }
}

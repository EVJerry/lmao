using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijkstra_Vietnam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Province> provinces = new List<Province>();
        DirectedWeightedGraph g = new DirectedWeightedGraph();
        private Graphics graph; 
        private void Form1_Load(object sender, EventArgs e)
        {
            Province quan1 = new Province("Quận 1", "A", 550, 235);
            Province quan3 = new Province("Quận 3", "B", 510, 232);
            Province quan4 = new Province("Quận 4", "C", 536, 295);
            Province quan5 = new Province("Quận 5", "D", 493, 296);
            Province quan6 = new Province("Quận 6", "E", 350, 350);
            Province quan8 = new Province("Quận 8", "F", 420, 350);
            Province quan10 = new Province("Quận 10", "G", 450, 265);
            Province quan11 = new Province("Quận 11", "H", 390, 270);
            Province quantanbinh = new Province("Quận Tân Bình", "I", 400, 180);
            Province quanbinhthanh = new Province("Quận Bình Thạnh", "K", 560, 160);
            Province quanphunhuan = new Province("Quận Phú Nhuận", "L", 500, 180);
            Province quangovap = new Province("Quận Gò Vấp", "M", 490, 60);
            Province quantanphu = new Province("Quận Tân Phú", "N", 350, 230);
            provinces.Add(quan1);
            provinces.Add(quan3);
            provinces.Add(quan4);
            provinces.Add(quan5);
            provinces.Add(quan6);
            provinces.Add(quan8);
            provinces.Add(quan10);
            provinces.Add(quan11);
            provinces.Add(quantanbinh);
            provinces.Add(quanbinhthanh);
            provinces.Add(quanphunhuan);
            provinces.Add(quangovap);
            provinces.Add(quantanphu);
            Graphics graph = pnMap.CreateGraphics();
            for (int i = 0; i < provinces.Count; i++)
            {
                lvListProvinces.Items.Add(provinces[i].getPointName());
                lvListProvinces.Items[i].SubItems.Add(provinces[i].getName());
                g.listPoint.Add(provinces[i].getPoint());
                g.InsertVertex(provinces[i].getName());
            }
            g.InsertEdge("Quận 1", "Quận 3", 2);
            g.InsertEdge("Quận 3", "Quận 10", 4);
            g.InsertEdge("Quận 10", "Quận 5", 5);
            g.InsertEdge("Quận 5", "Quận 6", 3);
            g.InsertEdge("Quận Tân Phú", "Quận Tân Bình", 6);
            g.InsertEdge("Quận Tân Bình", "Quận Gò Vấp", 8);
            g.InsertEdge("Quận Phú Nhuận", "Quận Bình Thạnh", 4);
            g.InsertEdge("Quận Gò Vấp", "Quận Phú Nhuận", 7);
            g.InsertEdge("Quận 8", "Quận 6", 6);
            g.InsertEdge("Quận 6", "Quận Tân Phú", 7);
            g.InsertEdge("Quận 10", "Quận 10", 3);
            g.InsertEdge("Quận 11", "Quận 6", 4);
            g.InsertEdge("Quận Bình Thạnh", "Quận 1", 8);
            g.InsertEdge("Quận 6", "Quận 11", 4);
            g.InsertEdge("Quận 10", "Quận 11", 3);
            g.InsertEdge("Quận 4", "Quận 1", 3);
            g.InsertEdge("Quận 5", "Quận 4", 4);
            g.InsertEdge("Quận 8", "Quận 4", 7);
            g.InsertEdge("Quận Gò Vấp", "Quận Bình Thạnh",6);
            g.InsertEdge("Quận Tân Bình", "Quận Phú Nhuận",4);
            g.InsertEdge("Quận 3", "Quận Phú Nhuận", 3);
            g.InsertEdge("Quận Tân Bình", "Quận 10", 4);
            g.InsertEdge("Quận 11", "Quận Tân Phú", 6);
            g.InsertEdge("Quận 11", "Quận 5", 4);
            g.InsertEdge("Quận 1", "Quận 5", 6);
            cbSource.Items.Add("Quận 1");
            cbSource.Items.Add("Quận 3");
            cbSource.Items.Add("Quận 4");
            cbSource.Items.Add("Quận 5");
            cbSource.Items.Add("Quận 6");
            cbSource.Items.Add("Quận 8");
            cbSource.Items.Add("Quận 10");
            cbSource.Items.Add("Quận 11");
            cbSource.Items.Add("Quận Tân Bình");
            cbSource.Items.Add("Quận Bình Thạnh");
            cbSource.Items.Add("Quận Phú Nhuận");
            cbSource.Items.Add("Quận Gò Vấp");
            cbSource.Items.Add("Quận Tân Phú");
            cbDestination.Items.Add("Quận 1");
            cbDestination.Items.Add("Quận 3");
            cbDestination.Items.Add("Quận 4");
            cbDestination.Items.Add("Quận 5");
            cbDestination.Items.Add("Quận 6");
            cbDestination.Items.Add("Quận 8");
            cbDestination.Items.Add("Quận 10");
            cbDestination.Items.Add("Quận 11");
            cbDestination.Items.Add("Quận Tân Bình");
            cbDestination.Items.Add("Quận Bình Thạnh");
            cbDestination.Items.Add("Quận Phú Nhuận");
            cbDestination.Items.Add("Quận Gò Vấp");
            cbDestination.Items.Add("Quận Tân Phú");
        }
        //Vẽ bản đồ ra Panel
        private void pnMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics graph = pnMap.CreateGraphics();
            for (int i = 0; i < provinces.Count; i++)
            {
                SolidBrush brush = new SolidBrush(Color.Purple);
                Brush pointName = new SolidBrush(Color.White);
                graph.FillEllipse(brush, provinces[i].getPoint().X - 5, provinces[i].getPoint().Y - 5, 20, 20);
                graph.DrawString(provinces[i].getPointName(), new Font("Arial", 10), pointName, provinces[i].getPoint().X , provinces[i].getPoint().Y );
            }
            DrawLine();
        }

        private void DrawLine()
        {
            DrawLine("Quận 1", "Quận 3");
            DrawLine("Quận 3", "Quận 10");
            DrawLine("Quận 10", "Quận 5");
            DrawLine("Quận 5", "Quận 6");
            DrawLine("Quận Tân Phú", "Quận Tân Bình");
            DrawLine("Quận Tân Bình", "Quận Gò Vấp");
            DrawLine("Quận Phú Nhuận", "Quận Bình Thạnh");
            DrawLine("Quận Phú Nhuận", "Quận Gò Vấp");
            DrawLine("Quận 8", "Quận 6");
            DrawLine("Quận 6", "Quận Tân Phú");
            DrawLine("Quận 10", "Quận 10");
            DrawLine("Quận 11", "Quận 6");
            DrawLine("Quận Bình Thạnh", "Quận 1");
            DrawLine("Quận 6", "Quận 11");
            DrawLine("Quận 10", "Quận 11");
            DrawLine("Quận 4", "Quận 1");
            DrawLine("Quận 5", "Quận 4");
            DrawLine("Quận 8", "Quận 4");
            DrawLine("Quận Gò Vấp", "Quận Bình Thạnh");
            DrawLine("Quận Tân Bình", "Quận Phú Nhuận");
            DrawLine("Quận 3", "Quận Phú Nhuận");
            DrawLine("Quận Tân Bình", "Quận 10");
            DrawLine("Quận 11", "Quận Tân Phú");
            DrawLine("Quận 11", "Quận 5");
            DrawLine("Quận 1", "Quận 5");
        }
        private void DrawLine(string a, string b)
        {
            Graphics graph = pnMap.CreateGraphics();
            int x = g.GetIndex(a);
            int y = g.GetIndex(b);
            Pen p = new Pen(Color.Black, 2);
            Point point1 = new Point(g.listPoint[x].X , g.listPoint[x].Y );
            Point point2 = new Point(g.listPoint[y].X , g.listPoint[y].Y );
            graph.DrawLine(p, point1, point2);
            graph.DrawString($"{g.adj[x, y]}", new Font("Fira Code", 10), Brushes.Black, new Point((point1.X + point2.X) / 2 - 8, (point1.Y + point2.Y) / 2 + 8));
        }

        private void cbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSource.SelectedIndex != -1 && cbDestination.SelectedIndex != -1)
            {
                pnMap.Controls.Clear();
                pnMap.Refresh();
                DrawLine();
                g.pathIndex.Clear();
                tbCost.Clear();
                tbPath.Clear();
                g.FindPaths(cbSource.SelectedItem.ToString(), cbDestination.SelectedIndex.ToString(), tbCost, tbPath);
                for (int i = 0; i < g.pathIndex.Count - 1; i++)
                {
                    DrawPathLine(i);
                }
            }
        }

        private void cbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSource.SelectedIndex != -1 && cbDestination.SelectedIndex != -1)
            {
                pnMap.Controls.Clear();
                pnMap.Refresh();
                DrawLine();
                g.pathIndex.Clear();
                tbCost.Clear();
                tbPath.Clear();
                g.FindPaths(cbSource.SelectedItem.ToString(), cbDestination.SelectedIndex.ToString(), tbCost, tbPath);
                for (int i = 0; i < g.pathIndex.Count - 1; i++)
                {
                    DrawPathLine(i);
                }
            }
        }
        //Vẽ lại đường đi ngắn nhất
        private void DrawPathLine(int i)
        {
            Graphics graph = pnMap.CreateGraphics();
            Pen p = new Pen(Color.Aqua, 2);
            Point point1 = new Point(g.pathIndex[i].X , g.pathIndex[i].Y );
            Point point2 = new Point(g.pathIndex[i + 1].X , g.pathIndex[i + 1].Y );
            graph.DrawLine(p, point1, point2);
        }

        private void lvListProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flpListProvince_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

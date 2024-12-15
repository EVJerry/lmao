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
            Province quan1 = new Province("Quận 1", "A", 500, 400);
            Province quantanbinh = new Province("Quận Tân Bình", "B", 350, 250);
            Province quan3 = new Province("Quận 3", "C", 470, 360);
            Province quan4 = new Province("Quận 4", "D", 540, 460);
            Province quan5 = new Province("Quận 5", "E", 450, 480);
            Province quan6 = new Province("Quận 6", "F", 350, 500);
            Province quan8 = new Province("Quận 8", "H", 420, 580);
            Province quanphunhuan = new Province("Quận Phú Nhuận", "I", 400, 300);
            Province quan10 = new Province("Quận 10", "K", 430, 430);
            Province quan11 = new Province("Quận 11", "M", 390, 470);
            Province quan12 = new Province("Quận 12", "N", 280, 160);
            Province quangovap = new Province("Quận Gò Vấp", "O", 320, 200);
            Province quantanphu = new Province("Quận Tân Phú", "P", 350, 350);
            provinces.Add(quan1);
            provinces.Add(quantanbinh);
            provinces.Add(quan3);
            provinces.Add(quan4);
            provinces.Add(quan5);
            provinces.Add(quan6);
            provinces.Add(quanphunhuan);
            provinces.Add(quan8);
            provinces.Add(quangovap);
            provinces.Add(quan10);
            provinces.Add(quantanphu);
            provinces.Add(quan11);
            provinces.Add(quan12);
            Graphics graph = pnMap.CreateGraphics();
            for (int i = 0; i < provinces.Count; i++)
            {
                lvListProvinces.Items.Add(provinces[i].getPointName());
                lvListProvinces.Items[i].SubItems.Add(provinces[i].getName());
                g.listPoint.Add(provinces[i].getPoint());
                g.InsertVertex(provinces[i].getName());
            }
            g.InsertEdge("Quận 1", "Quận 3", 141);
            g.InsertEdge("Quận 3", "Quận 10", 101);
            g.InsertEdge("Quận 10", "Quận 5", 206);
            g.InsertEdge("Quận 5", "Quận 6", 249);
            g.InsertEdge("Quận Tân Phú", "Quận Tân Bình", 125);
            g.InsertEdge("Quận 12", "Quận Tân Bình", 145);
            g.InsertEdge("Quận Tân Bình", "Quận Gò Vấp", 209);
            g.InsertEdge("Quận Gò Vấp", "Quận 12", 95);
            g.InsertEdge("Quận Tân Bình", "Quận 12", 220);
            g.InsertEdge("Quận 8", "Quận 6", 160);
            g.InsertEdge("Quận 8", "Quận Tân Phú", 284);
            g.InsertEdge("Quận 10", "Quận 12", 191);
            g.InsertEdge("Quận 11", "Quận 12", 98);
            g.InsertEdge("Quận 12", "Quận 5", 226);
            g.InsertEdge("Quận 6", "Quận 1", 490);
            cbSource.Items.Add("Quận 1");
            cbSource.Items.Add("Quận 3");
            cbSource.Items.Add("Quận 4");
            cbSource.Items.Add("Quận 5");
            cbSource.Items.Add("Quận 6");
            cbSource.Items.Add("Quận 8");
            cbSource.Items.Add("Quận 10");
            cbSource.Items.Add("Quận 11");
            cbSource.Items.Add("Quận 12");
            cbSource.Items.Add("Quận Tân Bình");
            cbSource.Items.Add("Quận Tân Phú");
            cbSource.Items.Add("Quận Gò Vấp");
            cbDestination.Items.Add("Quận 1");
            cbDestination.Items.Add("Quận 3");
            cbDestination.Items.Add("Quận 4");
            cbDestination.Items.Add("Quận 5");
            cbDestination.Items.Add("Quận 6");
            cbDestination.Items.Add("Quận 8");
            cbDestination.Items.Add("Quận 10");
            cbDestination.Items.Add("Quận 11");
            cbDestination.Items.Add("Quận 12");
            cbDestination.Items.Add("Quận Tân Bình");
            cbDestination.Items.Add("Quận Tân Phú");
            cbDestination.Items.Add("Quận Gò Vấp");
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
            DrawLine("Quận 12", "Quận Tân Bình");
            DrawLine("Quận Tân Bình", "Quận Gò Vấp");
            DrawLine("Quận Gò Vấp", "Quận 12");
            DrawLine("Quận Tân Bình", "Quận 12");
            DrawLine("Quận 8", "Quận 6");
            DrawLine("Quận 8", "Quận Tân Phú");
            DrawLine("Quận 10", "Quận 12");
            DrawLine("Quận 11", "Quận 12");
            DrawLine("Quận 12", "Quận 5");
            DrawLine("Quận 6", "Quận 1");
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
    }
}

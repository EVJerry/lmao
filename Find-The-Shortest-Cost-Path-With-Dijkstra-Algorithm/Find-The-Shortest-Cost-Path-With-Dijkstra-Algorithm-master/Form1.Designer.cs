namespace Dijkstra_Vietnam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbInfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flpListProvince = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lvListProvinces = new System.Windows.Forms.ListView();
            this.clPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMap = new System.Windows.Forms.Panel();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msMenuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuStrip
            // 
            this.msMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.msMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.msMenuStrip.Name = "msMenuStrip";
            this.msMenuStrip.Size = new System.Drawing.Size(1787, 28);
            this.msMenuStrip.TabIndex = 0;
            this.msMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(95, 30);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(1419, 48);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "Dijkstra tìm đường đi ngắn nhất giữa các quận trong khu đô thị hiện hữu TP.HCM";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(563, 191);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(417, 55);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm bắt đầu";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 55);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điểm đến";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // flpListProvince
            // 
            this.flpListProvince.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpListProvince.Location = new System.Drawing.Point(25, 230);
            this.flpListProvince.Margin = new System.Windows.Forms.Padding(4);
            this.flpListProvince.Name = "flpListProvince";
            this.flpListProvince.Size = new System.Drawing.Size(790, 384);
            this.flpListProvince.TabIndex = 5;
            this.flpListProvince.Paint += new System.Windows.Forms.PaintEventHandler(this.flpListProvince_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "KHU ĐÔ THỊ HIỆN HỮU Ở TP.HCM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvListProvinces
            // 
            this.lvListProvinces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clPoint,
            this.clName});
            this.lvListProvinces.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvListProvinces.GridLines = true;
            this.lvListProvinces.HideSelection = false;
            this.lvListProvinces.Location = new System.Drawing.Point(103, 393);
            this.lvListProvinces.Margin = new System.Windows.Forms.Padding(4);
            this.lvListProvinces.Name = "lvListProvinces";
            this.lvListProvinces.Size = new System.Drawing.Size(718, 526);
            this.lvListProvinces.TabIndex = 3;
            this.lvListProvinces.UseCompatibleStateImageBehavior = false;
            this.lvListProvinces.View = System.Windows.Forms.View.Details;
            this.lvListProvinces.SelectedIndexChanged += new System.EventHandler(this.lvListProvinces_SelectedIndexChanged);
            // 
            // clPoint
            // 
            this.clPoint.Text = "Point";
            this.clPoint.Width = 235;
            // 
            // clName
            // 
            this.clName.Text = "Name";
            this.clName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clName.Width = 400;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.pnMap);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(887, 82);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(994, 837);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1032, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Map";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMap
            // 
            this.pnMap.BackgroundImage = global::Dijkstra_Vietnam.Properties.Resources.z3933211686906_622f0714c00aab2a85def064acac3922;
            this.pnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMap.Location = new System.Drawing.Point(4, 51);
            this.pnMap.Margin = new System.Windows.Forms.Padding(4);
            this.pnMap.Name = "pnMap";
            this.pnMap.Size = new System.Drawing.Size(1000, 618);
            this.pnMap.TabIndex = 3;
            this.pnMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMap_Paint);
            // 
            // cbSource
            // 
            this.cbSource.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(591, 7);
            this.cbSource.Margin = new System.Windows.Forms.Padding(4);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(246, 40);
            this.cbSource.TabIndex = 1;
            this.cbSource.SelectedIndexChanged += new System.EventHandler(this.cbSource_SelectedIndexChanged);
            // 
            // cbDestination
            // 
            this.cbDestination.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(591, 59);
            this.cbDestination.Margin = new System.Windows.Forms.Padding(4);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(246, 40);
            this.cbDestination.TabIndex = 7;
            this.cbDestination.SelectedIndexChanged += new System.EventHandler(this.cbDestination_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cbSource);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.cbDestination);
            this.panel2.Location = new System.Drawing.Point(16, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 110);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tbPath);
            this.panel3.Controls.Add(this.tbCost);
            this.panel3.Controls.Add(this.flpListProvince);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(18, 191);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(861, 154);
            this.panel3.TabIndex = 9;
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPath.Location = new System.Drawing.Point(223, 64);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(630, 81);
            this.tbPath.TabIndex = 8;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.Location = new System.Drawing.Point(223, 5);
            this.tbCost.Margin = new System.Windows.Forms.Padding(4);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(630, 44);
            this.tbCost.TabIndex = 7;
            this.tbCost.TextChanged += new System.EventHandler(this.tbCost_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 55);
            this.label8.TabIndex = 6;
            this.label8.Text = "Path";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 55);
            this.label7.TabIndex = 5;
            this.label7.Text = "Khoảng cách Km";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 942);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvListProvinces);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.msMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMenuStrip.ResumeLayout(false);
            this.msMenuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpListProvince;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnMap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.ListView lvListProvinces;
        public System.Windows.Forms.ColumnHeader clPoint;
        public System.Windows.Forms.ColumnHeader clName;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form p;
        private void Calculator(object sender, EventArgs e)
        {
            Kib.Controls.Clear();
            Form2 simple = new Form2();
            simple.TopLevel = false;
            Kib.Controls.Add(simple);
            simple.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeView3.Nodes[0].ExpandAll();
            p = new Form2();

            p.TopLevel = false;
            this.Kib.Controls.Add(p);
            p.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 simple = new Form2();
            simple.TopLevel = false;
            simple.Show();
            this.Hide();
        }

        private void treeView3_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView3.SelectedNode;
            switch (node.Text)
            {
                case "Calculator":
                    p.Dispose();
                    p = new Form2();
                    p.TopLevel = false;
                    this.Kib.Controls.Add(p);
                    p.Dock = DockStyle.Fill;
                    p.Show();

                    break;


                case "Student_REG":
                    p.Dispose();
                    p = new Form3();
                    p.TopLevel = false;
                    this.Kib.Controls.Add(p);
                    p.Dock = DockStyle.Fill;
                    p.Show();

                    break;
            }
        }
    }
}
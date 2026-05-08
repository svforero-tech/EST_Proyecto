using EST_Proyecto.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace EST_Proyecto.Forms
{
    public partial class Form2 : Form
    {

        private void SetDoubleBuffered(Panel panel)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty |
            BindingFlags.Instance |
            BindingFlags.NonPublic,
            null, panel, new object[] { true });
        }
     
       


        private Dictionary<NodeTree<int>, Point> positions = new();
        private void AssignPositions(NodeTree<int> node, ref int counter, int sideMargin, int
        spacing, int topMargin, int level)
        {
            if (node == null) return;
            AssignPositions(node.Left, ref counter, sideMargin, spacing, topMargin, level + 1);
            int x = sideMargin + counter * spacing;
            int y = topMargin + level * LEVEL_HEIGHT;
            positions[node] = new Point(x, y);
            counter++;
            AssignPositions(node.Right, ref counter, sideMargin, spacing, topMargin, level + 1);
        }
        public Form2()
        {
            InitializeComponent();
            SetDoubleBuffered(panelTree);

            tree = new BinaryTree<int>();

            panelTree.Paint += panelTree_Paint;

            panelTree.MouseClick += panelTree_MouseClick;
        }
    }
}

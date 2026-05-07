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
        // Llamarlo en el constructor, tras InitializeComponent()
        SetDoubleBuffered(panelTree);

        public Form2()
        {
            InitializeComponent();
        }
    }
}

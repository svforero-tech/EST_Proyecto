namespace EST_Proyecto.Forms
{
    partial class Form3
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
            panelGraph = new Panel();
            txtDestination = new TextBox();
            SuspendLayout();
            // 
            // panelGraph
            // 
            panelGraph.BorderStyle = BorderStyle.FixedSingle;
            panelGraph.Location = new Point(159, 118);
            panelGraph.Name = "panelGraph";
            panelGraph.Size = new Size(1164, 662);
            panelGraph.TabIndex = 0;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(830, 40);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(100, 27);
            txtDestination.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 785);
            Controls.Add(txtDestination);
            Controls.Add(panelGraph);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGraph;
        private TextBox txtDestination;
    }
}
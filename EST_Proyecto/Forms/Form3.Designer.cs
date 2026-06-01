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
            btnShowPath = new Button();
            txtDestination = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // panelGraph
            // 
            panelGraph.BorderStyle = BorderStyle.FixedSingle;
            panelGraph.Location = new Point(301, 109);
            panelGraph.Name = "panelGraph";
            panelGraph.Size = new Size(1012, 664);
            panelGraph.TabIndex = 0;
            // 
            // btnShowPath
            // 
            btnShowPath.Location = new Point(978, 24);
            btnShowPath.Name = "btnShowPath";
            btnShowPath.Size = new Size(133, 59);
            btnShowPath.TabIndex = 0;
            btnShowPath.Text = "Mostrar camino más corto";
            btnShowPath.UseVisualStyleBackColor = true;
            btnShowPath.Click += btnShowPath_Click;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(830, 40);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(100, 27);
            txtDestination.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(490, 43);
            label1.Name = "label1";
            label1.Size = new Size(317, 20);
            label1.TabIndex = 2;
            label1.Text = "Seleccione un nodo y luego ingrese un destino";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 785);
            Controls.Add(label1);
            Controls.Add(btnShowPath);
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
        private Button btnShowPath;
        private Label label1;
    }
}
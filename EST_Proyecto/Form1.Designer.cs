namespace EST_Proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciar = new Button();
            btnClear = new Button();
            txtMain = new Label();
            txtStackA = new Label();
            txtStackB = new Label();
            txtStackC = new Label();
            StackA = new ListBox();
            StackB = new ListBox();
            StackC = new ListBox();
            btnSelectA = new Button();
            btnSelectB = new Button();
            btnSelectC = new Button();
            txtAgregar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MinMov = new Label();
            Mov = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(176, 368);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click_1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(276, 368);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Reiniciar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtMain
            // 
            txtMain.AutoSize = true;
            txtMain.Location = new Point(375, 344);
            txtMain.Name = "txtMain";
            txtMain.Size = new Size(0, 20);
            txtMain.TabIndex = 3;
            // 
            // txtStackA
            // 
            txtStackA.AutoSize = true;
            txtStackA.ForeColor = SystemColors.ButtonHighlight;
            txtStackA.Location = new Point(26, 29);
            txtStackA.Name = "txtStackA";
            txtStackA.Size = new Size(98, 20);
            txtStackA.TabIndex = 4;
            txtStackA.Text = "Seleccionado";
            // 
            // txtStackB
            // 
            txtStackB.AutoSize = true;
            txtStackB.ForeColor = SystemColors.ButtonHighlight;
            txtStackB.Location = new Point(308, 29);
            txtStackB.Name = "txtStackB";
            txtStackB.Size = new Size(98, 20);
            txtStackB.TabIndex = 5;
            txtStackB.Text = "Seleccionado";
            // 
            // txtStackC
            // 
            txtStackC.AutoSize = true;
            txtStackC.ForeColor = SystemColors.ButtonHighlight;
            txtStackC.Location = new Point(593, 29);
            txtStackC.Name = "txtStackC";
            txtStackC.Size = new Size(98, 20);
            txtStackC.TabIndex = 6;
            txtStackC.Text = "Seleccionado";
            // 
            // StackA
            // 
            StackA.FormattingEnabled = true;
            StackA.Location = new Point(26, 92);
            StackA.Name = "StackA";
            StackA.Size = new Size(150, 104);
            StackA.TabIndex = 7;
            StackA.SelectedIndexChanged += StackA_SelectedIndexChanged;
            // 
            // StackB
            // 
            StackB.FormattingEnabled = true;
            StackB.Location = new Point(294, 92);
            StackB.Name = "StackB";
            StackB.Size = new Size(150, 104);
            StackB.TabIndex = 8;
            // 
            // StackC
            // 
            StackC.FormattingEnabled = true;
            StackC.Location = new Point(593, 92);
            StackC.Name = "StackC";
            StackC.Size = new Size(150, 104);
            StackC.TabIndex = 9;
            // 
            // btnSelectA
            // 
            btnSelectA.Location = new Point(30, 202);
            btnSelectA.Name = "btnSelectA";
            btnSelectA.Size = new Size(94, 29);
            btnSelectA.TabIndex = 10;
            btnSelectA.Text = "Seleccionar";
            btnSelectA.UseVisualStyleBackColor = true;
            btnSelectA.Click += btnSelectA_Click_1;
            // 
            // btnSelectB
            // 
            btnSelectB.Location = new Point(308, 202);
            btnSelectB.Name = "btnSelectB";
            btnSelectB.Size = new Size(94, 29);
            btnSelectB.TabIndex = 11;
            btnSelectB.Text = "Seleccionar";
            btnSelectB.UseVisualStyleBackColor = true;
            btnSelectB.Click += btnSelectB_Click_1;
            // 
            // btnSelectC
            // 
            btnSelectC.Location = new Point(616, 202);
            btnSelectC.Name = "btnSelectC";
            btnSelectC.Size = new Size(94, 29);
            btnSelectC.TabIndex = 12;
            btnSelectC.Text = "Seleccionar";
            btnSelectC.UseVisualStyleBackColor = true;
            btnSelectC.Click += btnSelectC_Click_1;
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(26, 369);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(125, 27);
            txtAgregar.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(30, 62);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 15;
            label1.Text = "Torre A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(308, 62);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 16;
            label2.Text = "Torre B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(605, 62);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 17;
            label3.Text = "Torre C";
            // 
            // MinMov
            // 
            MinMov.AutoSize = true;
            MinMov.ForeColor = SystemColors.ButtonHighlight;
            MinMov.Location = new Point(26, 301);
            MinMov.Name = "MinMov";
            MinMov.Size = new Size(73, 20);
            MinMov.TabIndex = 18;
            MinMov.Text = "Minimos: ";
            // 
            // Mov
            // 
            Mov.AutoSize = true;
            Mov.ForeColor = SystemColors.ButtonHighlight;
            Mov.Location = new Point(30, 332);
            Mov.Name = "Mov";
            Mov.Size = new Size(102, 20);
            Mov.TabIndex = 19;
            Mov.Text = "Movimientos: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(Mov);
            Controls.Add(MinMov);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAgregar);
            Controls.Add(btnSelectC);
            Controls.Add(btnSelectB);
            Controls.Add(btnSelectA);
            Controls.Add(StackC);
            Controls.Add(StackB);
            Controls.Add(StackA);
            Controls.Add(txtStackC);
            Controls.Add(txtStackB);
            Controls.Add(txtStackA);
            Controls.Add(txtMain);
            Controls.Add(btnClear);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnClear;
        private Label txtMain;
        private Label txtStackA;
        private Label txtStackB;
        private Label txtStackC;
        private ListBox StackA;
        private ListBox StackB;
        private ListBox StackC;
        private Button btnSelectA;
        private Button btnSelectB;
        private Button btnSelectC;
        private TextBox txtAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label MinMov;
        private Label Mov;
    }
}

namespace EST_Proyecto.Forms
{
    partial class Form2
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
            panelTree = new Panel();
            txtValue = new TextBox();
            btnInsert = new Button();
            btnRemove = new Button();
            btnContains = new Button();
            lblResult = new Label();
            btnPreOrder = new Button();
            btnInOrder = new Button();
            btnLevelOrder = new Button();
            txtTraversal = new TextBox();
            btnHeight = new Button();
            btnCount = new Button();
            btnMin = new Button();
            btnMax = new Button();
            btnClear = new Button();
            lblHeight = new Label();
            lblCount = new Label();
            lblMin = new Label();
            lblMax = new Label();
            rbBST = new RadioButton();
            rbAVL = new RadioButton();
            SuspendLayout();
            // 
            // panelTree
            // 
            panelTree.BorderStyle = BorderStyle.FixedSingle;
            panelTree.Location = new Point(400, 30);
            panelTree.Name = "panelTree";
            panelTree.Size = new Size(850, 600);
            panelTree.TabIndex = 0;
            panelTree.Paint += panelTree_Paint;
            panelTree.MouseClick += panelTree_MouseClick;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(20, 30);
            txtValue.MaximumSize = new Size(150, 0);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(125, 27);
            txtValue.TabIndex = 1;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Plum;
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(20, 70);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Plum;
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(120, 70);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Eliminar";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnContains
            // 
            btnContains.BackColor = Color.Plum;
            btnContains.ForeColor = Color.White;
            btnContains.Location = new Point(220, 70);
            btnContains.Name = "btnContains";
            btnContains.Size = new Size(94, 29);
            btnContains.TabIndex = 5;
            btnContains.Text = "Buscar";
            btnContains.UseVisualStyleBackColor = false;
            btnContains.Click += btnContains_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(20, 110);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(75, 20);
            lblResult.TabIndex = 6;
            lblResult.Text = "Resultado";
            // 
            // btnPreOrder
            // 
            btnPreOrder.BackColor = Color.Plum;
            btnPreOrder.ForeColor = Color.White;
            btnPreOrder.Location = new Point(20, 160);
            btnPreOrder.Name = "btnPreOrder";
            btnPreOrder.Size = new Size(94, 29);
            btnPreOrder.TabIndex = 7;
            btnPreOrder.Text = "PreOrder";
            btnPreOrder.UseVisualStyleBackColor = false;
            btnPreOrder.Click += btnPreOrder_Click;
            // 
            // btnInOrder
            // 
            btnInOrder.BackColor = Color.Plum;
            btnInOrder.ForeColor = Color.White;
            btnInOrder.Location = new Point(120, 160);
            btnInOrder.Name = "btnInOrder";
            btnInOrder.Size = new Size(94, 29);
            btnInOrder.TabIndex = 8;
            btnInOrder.Text = "InOrder";
            btnInOrder.UseVisualStyleBackColor = false;
            btnInOrder.Click += btnInOrder_Click;
            // 
            // btnLevelOrder
            // 
            btnLevelOrder.BackColor = Color.Plum;
            btnLevelOrder.ForeColor = Color.White;
            btnLevelOrder.Location = new Point(20, 210);
            btnLevelOrder.Name = "btnLevelOrder";
            btnLevelOrder.Size = new Size(94, 29);
            btnLevelOrder.TabIndex = 9;
            btnLevelOrder.Text = "LevelOrder";
            btnLevelOrder.UseVisualStyleBackColor = false;
            btnLevelOrder.Click += btnLevelOrder_Click;
            // 
            // txtTraversal
            // 
            txtTraversal.Location = new Point(20, 250);
            txtTraversal.Multiline = true;
            txtTraversal.Name = "txtTraversal";
            txtTraversal.Size = new Size(300, 80);
            txtTraversal.TabIndex = 10;
            // 
            // btnHeight
            // 
            btnHeight.BackColor = Color.Plum;
            btnHeight.ForeColor = Color.White;
            btnHeight.Location = new Point(20, 360);
            btnHeight.Name = "btnHeight";
            btnHeight.Size = new Size(94, 29);
            btnHeight.TabIndex = 11;
            btnHeight.Text = "Altura";
            btnHeight.UseVisualStyleBackColor = false;
            btnHeight.Click += btnHeight_Click;
            // 
            // btnCount
            // 
            btnCount.BackColor = Color.Plum;
            btnCount.ForeColor = Color.White;
            btnCount.Location = new Point(120, 360);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(94, 29);
            btnCount.TabIndex = 12;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = false;
            btnCount.Click += btnCount_Click;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Plum;
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(220, 360);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(94, 29);
            btnMin.TabIndex = 13;
            btnMin.Text = "Min";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.BackColor = Color.Plum;
            btnMax.ForeColor = Color.White;
            btnMax.Location = new Point(20, 410);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(94, 29);
            btnMax.TabIndex = 14;
            btnMax.Text = "Max";
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Plum;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(120, 410);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 15;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(20, 460);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(49, 20);
            lblHeight.TabIndex = 16;
            lblHeight.Text = "Altura";
            lblHeight.Click += lblHeight_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(20, 490);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(48, 20);
            lblCount.TabIndex = 17;
            lblCount.Text = "Count";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(20, 520);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(34, 20);
            lblMin.TabIndex = 18;
            lblMin.Text = "Min";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(20, 550);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(37, 20);
            lblMax.TabIndex = 19;
            lblMax.Text = "Max";
            // 
            // rbBST
            // 
            rbBST.AutoSize = true;
            rbBST.Checked = true;
            rbBST.Location = new Point(20, 600);
            rbBST.Name = "rbBST";
            rbBST.Size = new Size(55, 24);
            rbBST.TabIndex = 20;
            rbBST.TabStop = true;
            rbBST.Text = "BST";
            rbBST.UseVisualStyleBackColor = true;
            rbBST.CheckedChanged += rbBST_CheckedChanged;
            // 
            // rbAVL
            // 
            rbAVL.AutoSize = true;
            rbAVL.Location = new Point(120, 600);
            rbAVL.Name = "rbAVL";
            rbAVL.Size = new Size(55, 24);
            rbAVL.TabIndex = 21;
            rbAVL.TabStop = true;
            rbAVL.Text = "AVL";
            rbAVL.UseVisualStyleBackColor = true;
            rbAVL.CheckedChanged += rbAVL_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1282, 653);
            Controls.Add(rbAVL);
            Controls.Add(rbBST);
            Controls.Add(lblMax);
            Controls.Add(lblMin);
            Controls.Add(lblCount);
            Controls.Add(lblHeight);
            Controls.Add(btnClear);
            Controls.Add(btnMax);
            Controls.Add(btnMin);
            Controls.Add(btnCount);
            Controls.Add(btnHeight);
            Controls.Add(txtTraversal);
            Controls.Add(btnLevelOrder);
            Controls.Add(btnInOrder);
            Controls.Add(btnPreOrder);
            Controls.Add(lblResult);
            Controls.Add(btnContains);
            Controls.Add(btnRemove);
            Controls.Add(btnInsert);
            Controls.Add(txtValue);
            Controls.Add(panelTree);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Árboles BST y AVL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTree;
        private TextBox txtValue;
        private Button btnInsert;
        private Button btnRemove;
        private Button btnContains;
        private Label lblResult;
        private Button btnPreOrder;
        private Button btnInOrder;
        private Button btnLevelOrder;
        private TextBox txtTraversal;
        private Button btnHeight;
        private Button btnCount;
        private Button btnMin;
        private Button btnMax;
        private Button btnClear;
        private Label lblHeight;
        private Label lblCount;
        private Label lblMin;
        private Label lblMax;
        private RadioButton rbBST;
        private RadioButton rbAVL;
    }
}
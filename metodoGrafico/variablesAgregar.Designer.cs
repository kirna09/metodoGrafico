namespace metodoGrafico
{
    partial class variablesAgregar
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
            txtVx = new TextBox();
            txtVy = new TextBox();
            cmbSM = new ComboBox();
            btnAceptar = new Button();
            cmbMIM = new ComboBox();
            txtTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblEc = new Label();
            ltboxVar = new ListBox();
            SuspendLayout();
            // 
            // txtVx
            // 
            txtVx.Location = new Point(73, 63);
            txtVx.Name = "txtVx";
            txtVx.Size = new Size(150, 31);
            txtVx.TabIndex = 0;
            // 
            // txtVy
            // 
            txtVy.Location = new Point(82, 129);
            txtVy.Name = "txtVy";
            txtVy.Size = new Size(150, 31);
            txtVy.TabIndex = 1;
            // 
            // cmbSM
            // 
            cmbSM.FormattingEnabled = true;
            cmbSM.Items.AddRange(new object[] { "+", "-" });
            cmbSM.Location = new Point(308, 61);
            cmbSM.Name = "cmbSM";
            cmbSM.Size = new Size(182, 33);
            cmbSM.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(608, 255);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbMIM
            // 
            cmbMIM.FormattingEnabled = true;
            cmbMIM.Items.AddRange(new object[] { "≤", "≥" });
            cmbMIM.Location = new Point(308, 129);
            cmbMIM.Name = "cmbMIM";
            cmbMIM.Size = new Size(182, 33);
            cmbMIM.TabIndex = 4;
            cmbMIM.SelectedIndexChanged += cmbMIM_SelectedIndexChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(545, 129);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(150, 31);
            txtTotal.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 19);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 6;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 19);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 7;
            label2.Text = "+/-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 95);
            label3.Name = "label3";
            label3.Size = new Size(21, 25);
            label3.TabIndex = 8;
            label3.Text = "y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 95);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 9;
            label4.Text = "<=/>=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(608, 95);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 10;
            label5.Text = "total";
            // 
            // lblEc
            // 
            lblEc.AutoSize = true;
            lblEc.Location = new Point(564, 19);
            lblEc.Name = "lblEc";
            lblEc.Size = new Size(22, 25);
            lblEc.TabIndex = 11;
            lblEc.Text = "0";
            // 
            // ltboxVar
            // 
            ltboxVar.FormattingEnabled = true;
            ltboxVar.ItemHeight = 25;
            ltboxVar.Location = new Point(73, 190);
            ltboxVar.Name = "ltboxVar";
            ltboxVar.Size = new Size(180, 129);
            ltboxVar.TabIndex = 12;
            ltboxVar.SelectedIndexChanged += ltboxVar_SelectedIndexChanged;
            // 
            // variablesAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ltboxVar);
            Controls.Add(lblEc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(cmbMIM);
            Controls.Add(btnAceptar);
            Controls.Add(cmbSM);
            Controls.Add(txtVy);
            Controls.Add(txtVx);
            Name = "variablesAgregar";
            Text = "t";
            Load += variablesAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox2;
        private ComboBox cmbSM;
        private Button btnAceptar;
        private ComboBox cmbMIM;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblEc;
        private ListBox ltboxVar;
        private TextBox txtVx;
        private TextBox txtVy;
        private TextBox txtTotal;
    }
}
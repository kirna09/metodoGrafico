namespace metodoGrafico
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
            components = new System.ComponentModel.Container();
            txt1 = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(337, 188);
            txt1.Name = "txt1";
            txt1.Size = new Size(150, 31);
            txt1.TabIndex = 0;
            txt1.TextAlign = HorizontalAlignment.Right;
            txt1.TextChanged += textBox1_TextChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 118);
            label1.Name = "label1";
            label1.Size = new Size(453, 25);
            label1.TabIndex = 1;
            label1.Text = "ingrese la cantidad de de ecuaciones que desea agregar";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(539, 182);
            button1.Name = "button1";
            button1.Size = new Size(63, 42);
            button1.TabIndex = 2;
            button1.Text = "ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 449);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txt1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private NotifyIcon notifyIcon1;
        private Label label1;
        private Button button1;
    }
}
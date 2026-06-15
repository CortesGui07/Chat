namespace Chat
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
            numQtd = new NumericUpDown();
            label1 = new Label();
            btIniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            SuspendLayout();
            // 
            // numQtd
            // 
            numQtd.Font = new Font("Segoe UI", 20F);
            numQtd.Location = new Point(388, 18);
            numQtd.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQtd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(85, 43);
            numQtd.TabIndex = 0;
            numQtd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(370, 37);
            label1.TabIndex = 1;
            label1.Text = "Quantidade de interlocutores:";
            // 
            // btIniciar
            // 
            btIniciar.Font = new Font("Segoe UI", 20F);
            btIniciar.Location = new Point(165, 84);
            btIniciar.Name = "btIniciar";
            btIniciar.Size = new Size(156, 51);
            btIniciar.TabIndex = 2;
            btIniciar.Text = "&Iniciar";
            btIniciar.UseVisualStyleBackColor = true;
            btIniciar.Click += btIniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 156);
            Controls.Add(btIniciar);
            Controls.Add(label1);
            Controls.Add(numQtd);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat";
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numQtd;
        private Label label1;
        private Button btIniciar;
    }
}

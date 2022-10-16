namespace Calculator
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
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSob = new System.Windows.Forms.Label();
            this.lbSoa = new System.Windows.Forms.Label();
            this.lbkq = new System.Windows.Forms.Label();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoa
            // 
            this.txtSoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoa.Location = new System.Drawing.Point(252, 118);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(388, 37);
            this.txtSoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(287, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tính toán";
            // 
            // lbSob
            // 
            this.lbSob.AutoSize = true;
            this.lbSob.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSob.Location = new System.Drawing.Point(73, 187);
            this.lbSob.Name = "lbSob";
            this.lbSob.Size = new System.Drawing.Size(78, 41);
            this.lbSob.TabIndex = 2;
            this.lbSob.Text = "Số b";
            // 
            // lbSoa
            // 
            this.lbSoa.AutoSize = true;
            this.lbSoa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSoa.Location = new System.Drawing.Point(73, 112);
            this.lbSoa.Name = "lbSoa";
            this.lbSoa.Size = new System.Drawing.Size(75, 41);
            this.lbSoa.TabIndex = 3;
            this.lbSoa.Text = "Số a";
            // 
            // lbkq
            // 
            this.lbkq.AutoSize = true;
            this.lbkq.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbkq.Location = new System.Drawing.Point(73, 271);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(119, 41);
            this.lbkq.TabIndex = 4;
            this.lbkq.Text = "Kết quả";
            // 
            // txtSob
            // 
            this.txtSob.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSob.Location = new System.Drawing.Point(252, 193);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(388, 37);
            this.txtSob.TabIndex = 5;
            // 
            // txtkq
            // 
            this.txtkq.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtkq.Location = new System.Drawing.Point(252, 277);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(388, 37);
            this.txtkq.TabIndex = 6;
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(339, 357);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(151, 60);
            this.btCong.TabIndex = 7;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.lbSoa);
            this.Controls.Add(this.lbSob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSoa;
        private Label label1;
        private Label lbSob;
        private Label lbSoa;
        private Label lbkq;
        private TextBox txtSob;
        private TextBox txtkq;
        private Button btCong;
    }
}
namespace Shamir
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.eATextBox = new System.Windows.Forms.TextBox();
            this.eBTextBox = new System.Windows.Forms.TextBox();
            this.c1TextBox = new System.Windows.Forms.TextBox();
            this.c2TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.c2TextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.c1TextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.eBTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.eATextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "p =";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "m =";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "e<a> = ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "d<a> =";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "C1 =";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "C2 =";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTextBox
            // 
            this.pTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTextBox.Location = new System.Drawing.Point(65, 3);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(423, 22);
            this.pTextBox.TabIndex = 6;
            // 
            // mTextBox
            // 
            this.mTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTextBox.Location = new System.Drawing.Point(65, 31);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(423, 22);
            this.mTextBox.TabIndex = 7;
            // 
            // eATextBox
            // 
            this.eATextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eATextBox.Location = new System.Drawing.Point(65, 59);
            this.eATextBox.Name = "eATextBox";
            this.eATextBox.Size = new System.Drawing.Size(423, 22);
            this.eATextBox.TabIndex = 8;
            // 
            // eBTextBox
            // 
            this.eBTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eBTextBox.Location = new System.Drawing.Point(65, 87);
            this.eBTextBox.Name = "eBTextBox";
            this.eBTextBox.Size = new System.Drawing.Size(423, 22);
            this.eBTextBox.TabIndex = 9;
            // 
            // c1TextBox
            // 
            this.c1TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TextBox.Location = new System.Drawing.Point(65, 115);
            this.c1TextBox.Name = "c1TextBox";
            this.c1TextBox.Size = new System.Drawing.Size(423, 22);
            this.c1TextBox.TabIndex = 10;
            // 
            // c2TextBox
            // 
            this.c2TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c2TextBox.Location = new System.Drawing.Point(65, 143);
            this.c2TextBox.Name = "c2TextBox";
            this.c2TextBox.Size = new System.Drawing.Size(423, 22);
            this.c2TextBox.TabIndex = 11;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(491, 409);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox c2TextBox;
        private System.Windows.Forms.TextBox c1TextBox;
        private System.Windows.Forms.TextBox eBTextBox;
        private System.Windows.Forms.TextBox eATextBox;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.TextBox pTextBox;
    }
}

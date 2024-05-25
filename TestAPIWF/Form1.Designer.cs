namespace TestAPIWF
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
            this.tbt_weight = new System.Windows.Forms.TextBox();
            this.tbt_height = new System.Windows.Forms.TextBox();
            this.btn_Cal = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbt_weight
            // 
            this.tbt_weight.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_weight.Location = new System.Drawing.Point(180, 59);
            this.tbt_weight.Name = "tbt_weight";
            this.tbt_weight.Size = new System.Drawing.Size(484, 38);
            this.tbt_weight.TabIndex = 0;
            // 
            // tbt_height
            // 
            this.tbt_height.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_height.Location = new System.Drawing.Point(180, 129);
            this.tbt_height.Name = "tbt_height";
            this.tbt_height.Size = new System.Drawing.Size(484, 38);
            this.tbt_height.TabIndex = 1;
            // 
            // btn_Cal
            // 
            this.btn_Cal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cal.Location = new System.Drawing.Point(180, 194);
            this.btn_Cal.Name = "btn_Cal";
            this.btn_Cal.Size = new System.Drawing.Size(207, 43);
            this.btn_Cal.TabIndex = 2;
            this.btn_Cal.Text = "Tính BMI";
            this.btn_Cal.UseVisualStyleBackColor = true;
            this.btn_Cal.Click += new System.EventHandler(this.btn_Cal_Click);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_result.Location = new System.Drawing.Point(184, 272);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(92, 31);
            this.lb_result.TabIndex = 3;
            this.lb_result.Text = "Kết quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cân nặng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chiều cao";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_Cal);
            this.Controls.Add(this.tbt_height);
            this.Controls.Add(this.tbt_weight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbt_weight;
        private TextBox tbt_height;
        private Button btn_Cal;
        private Label lb_result;
        private Label label2;
        private Label label3;
    }
}
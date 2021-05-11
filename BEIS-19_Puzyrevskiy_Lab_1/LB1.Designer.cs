
namespace BEIS_19_Puzyrevskiy_Lab_1
{
    partial class LB1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.Res = new System.Windows.Forms.Label();
            this.Read1 = new System.Windows.Forms.TextBox();
            this.Read2 = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.Oper = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num1.Location = new System.Drawing.Point(20, 20);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(133, 22);
            this.Num1.TabIndex = 0;
            this.Num1.Text = "Первое число";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num2.Location = new System.Drawing.Point(20, 60);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(130, 22);
            this.Num2.TabIndex = 1;
            this.Num2.Text = "Второе число";
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Res.Location = new System.Drawing.Point(20, 100);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(97, 22);
            this.Res.TabIndex = 2;
            this.Res.Text = "Результат";
            // 
            // Read1
            // 
            this.Read1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Read1.Location = new System.Drawing.Point(170, 17);
            this.Read1.Name = "Read1";
            this.Read1.Size = new System.Drawing.Size(150, 29);
            this.Read1.TabIndex = 3;
            // 
            // Read2
            // 
            this.Read2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Read2.Location = new System.Drawing.Point(170, 57);
            this.Read2.Name = "Read2";
            this.Read2.Size = new System.Drawing.Size(150, 29);
            this.Read2.TabIndex = 4;
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(170, 97);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(150, 29);
            this.Output.TabIndex = 10;
            // 
            // Oper
            // 
            this.Oper.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oper.Location = new System.Drawing.Point(170, 140);
            this.Oper.Name = "Oper";
            this.Oper.Size = new System.Drawing.Size(150, 22);
            this.Oper.TabIndex = 5;
            this.Oper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sum
            // 
            this.Sum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sum.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum.Location = new System.Drawing.Point(330, 17);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(120, 29);
            this.Sum.TabIndex = 6;
            this.Sum.Text = "Сложение";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Sub
            // 
            this.Sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sub.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sub.Location = new System.Drawing.Point(330, 57);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(120, 29);
            this.Sub.TabIndex = 7;
            this.Sub.Text = "Вычитание";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mul.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mul.Location = new System.Drawing.Point(330, 97);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(120, 29);
            this.Mul.TabIndex = 8;
            this.Mul.Text = "Умножение";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Div
            // 
            this.Div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Div.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Div.Location = new System.Drawing.Point(330, 137);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(120, 29);
            this.Div.TabIndex = 9;
            this.Div.Text = "Деление";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // LB1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 181);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Oper);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Read2);
            this.Controls.Add(this.Read1);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "LB1";
            this.Text = "Арифметические операции";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.TextBox Read1;
        private System.Windows.Forms.TextBox Read2;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label Oper;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Div;
    }
}


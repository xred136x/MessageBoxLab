namespace MessageBoxLab
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnOneB = new System.Windows.Forms.Button();
            this.btnTwoB = new System.Windows.Forms.Button();
            this.btnThreeB = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelUserChoice = new System.Windows.Forms.Label();
            this.rbOkCancel = new System.Windows.Forms.RadioButton();
            this.rbRetryCancel = new System.Windows.Forms.RadioButton();
            this.label2button = new System.Windows.Forms.Label();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOneB
            // 
            this.btnOneB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOneB.Location = new System.Drawing.Point(25, 23);
            this.btnOneB.Name = "btnOneB";
            this.btnOneB.Size = new System.Drawing.Size(148, 65);
            this.btnOneB.TabIndex = 0;
            this.btnOneB.Text = "1 кнопка";
            this.btnOneB.UseVisualStyleBackColor = true;
            this.btnOneB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOneB_MouseClick);
            // 
            // btnTwoB
            // 
            this.btnTwoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTwoB.Location = new System.Drawing.Point(230, 23);
            this.btnTwoB.Name = "btnTwoB";
            this.btnTwoB.Size = new System.Drawing.Size(148, 65);
            this.btnTwoB.TabIndex = 0;
            this.btnTwoB.Text = "2 кнопки";
            this.btnTwoB.UseVisualStyleBackColor = true;
            this.btnTwoB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTwoB_MouseClick);
            this.btnTwoB.MouseLeave += new System.EventHandler(this.btnTwoB_MouseLeave);
            this.btnTwoB.MouseHover += new System.EventHandler(this.btnTwoB_MouseHover);
            // 
            // btnThreeB
            // 
            this.btnThreeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnThreeB.Location = new System.Drawing.Point(442, 23);
            this.btnThreeB.Name = "btnThreeB";
            this.btnThreeB.Size = new System.Drawing.Size(148, 65);
            this.btnThreeB.TabIndex = 0;
            this.btnThreeB.Text = "3 кнопки";
            this.btnThreeB.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(19, 261);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(86, 31);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelUserChoice
            // 
            this.labelUserChoice.AutoSize = true;
            this.labelUserChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserChoice.Location = new System.Drawing.Point(19, 309);
            this.labelUserChoice.Name = "labelUserChoice";
            this.labelUserChoice.Size = new System.Drawing.Size(86, 31);
            this.labelUserChoice.TabIndex = 1;
            this.labelUserChoice.Text = "label1";
            // 
            // rbOkCancel
            // 
            this.rbOkCancel.AutoSize = true;
            this.rbOkCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbOkCancel.Location = new System.Drawing.Point(230, 141);
            this.rbOkCancel.Name = "rbOkCancel";
            this.rbOkCancel.Size = new System.Drawing.Size(130, 28);
            this.rbOkCancel.TabIndex = 2;
            this.rbOkCancel.TabStop = true;
            this.rbOkCancel.Text = "OK - Cancel";
            this.rbOkCancel.UseVisualStyleBackColor = true;
            // 
            // rbRetryCancel
            // 
            this.rbRetryCancel.AutoSize = true;
            this.rbRetryCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRetryCancel.Location = new System.Drawing.Point(230, 164);
            this.rbRetryCancel.Name = "rbRetryCancel";
            this.rbRetryCancel.Size = new System.Drawing.Size(146, 28);
            this.rbRetryCancel.TabIndex = 2;
            this.rbRetryCancel.TabStop = true;
            this.rbRetryCancel.Text = "Retry - Cancel";
            this.rbRetryCancel.UseVisualStyleBackColor = true;
            // 
            // label2button
            // 
            this.label2button.AutoSize = true;
            this.label2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2button.Location = new System.Drawing.Point(230, 107);
            this.label2button.Name = "label2button";
            this.label2button.Size = new System.Drawing.Size(75, 24);
            this.label2button.TabIndex = 3;
            this.label2button.Text = "Кнопки";
            // 
            // rbYesNo
            // 
            this.rbYesNo.AutoSize = true;
            this.rbYesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbYesNo.Location = new System.Drawing.Point(230, 189);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(101, 28);
            this.rbYesNo.TabIndex = 2;
            this.rbYesNo.TabStop = true;
            this.rbYesNo.Text = "Yes - No";
            this.rbYesNo.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(442, 141);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 473);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2button);
            this.Controls.Add(this.rbYesNo);
            this.Controls.Add(this.rbRetryCancel);
            this.Controls.Add(this.rbOkCancel);
            this.Controls.Add(this.labelUserChoice);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnThreeB);
            this.Controls.Add(this.btnTwoB);
            this.Controls.Add(this.btnOneB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOneB;
        private System.Windows.Forms.Button btnTwoB;
        private System.Windows.Forms.Button btnThreeB;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelUserChoice;
        private System.Windows.Forms.RadioButton rbOkCancel;
        private System.Windows.Forms.RadioButton rbRetryCancel;
        private System.Windows.Forms.Label label2button;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


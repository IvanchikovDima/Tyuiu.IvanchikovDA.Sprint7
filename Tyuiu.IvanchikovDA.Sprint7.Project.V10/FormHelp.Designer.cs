
namespace Tyuiu.IvanchikovDA.Sprint7.Project.V10
{
    partial class FormHelp
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
            this.tabControlHelp_IDA = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxHelp1_IDA = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxHelp2_IDA = new System.Windows.Forms.TextBox();
            this.tabControlHelp_IDA.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHelp_IDA
            // 
            this.tabControlHelp_IDA.Controls.Add(this.tabPage1);
            this.tabControlHelp_IDA.Controls.Add(this.tabPage2);
            this.tabControlHelp_IDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHelp_IDA.Location = new System.Drawing.Point(0, 0);
            this.tabControlHelp_IDA.Name = "tabControlHelp_IDA";
            this.tabControlHelp_IDA.SelectedIndex = 0;
            this.tabControlHelp_IDA.Size = new System.Drawing.Size(491, 184);
            this.tabControlHelp_IDA.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxHelp1_IDA);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 155);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Посмотреть график";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxHelp1_IDA
            // 
            this.textBoxHelp1_IDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHelp1_IDA.Location = new System.Drawing.Point(3, 3);
            this.textBoxHelp1_IDA.Multiline = true;
            this.textBoxHelp1_IDA.Name = "textBoxHelp1_IDA";
            this.textBoxHelp1_IDA.Size = new System.Drawing.Size(477, 149);
            this.textBoxHelp1_IDA.TabIndex = 0;
            this.textBoxHelp1_IDA.Text = "Чтобы узнать интересующую вас статистику заказов домашних продуктов нашей сети, н" +
    "ажмите на кнопки всправа на главной панели";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxHelp2_IDA);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 155);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сделать заказ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxHelp2_IDA
            // 
            this.textBoxHelp2_IDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHelp2_IDA.Location = new System.Drawing.Point(3, 3);
            this.textBoxHelp2_IDA.Multiline = true;
            this.textBoxHelp2_IDA.Name = "textBoxHelp2_IDA";
            this.textBoxHelp2_IDA.Size = new System.Drawing.Size(477, 149);
            this.textBoxHelp2_IDA.TabIndex = 0;
            this.textBoxHelp2_IDA.Text = "Для того, чтобы сделать заказ заполните необходимые поля, выберите дату исполнени" +
    "я, необходимые продукты и нажмите кнопку сделать заказ";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 184);
            this.Controls.Add(this.tabControlHelp_IDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПОМОЩНИК";
            this.tabControlHelp_IDA.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHelp_IDA;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxHelp1_IDA;
        private System.Windows.Forms.TextBox textBoxHelp2_IDA;
    }
}

namespace Tyuiu.IvanchikovDA.Sprint7.Project.V10
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_IDA = new System.Windows.Forms.Label();
            this.pictureBoxDima_IDA = new System.Windows.Forms.PictureBox();
            this.buttonOK_IDA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDima_IDA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_IDA
            // 
            this.labelInfo_IDA.AutoSize = true;
            this.labelInfo_IDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_IDA.Location = new System.Drawing.Point(212, 24);
            this.labelInfo_IDA.Name = "labelInfo_IDA";
            this.labelInfo_IDA.Size = new System.Drawing.Size(460, 180);
            this.labelInfo_IDA.TabIndex = 0;
            this.labelInfo_IDA.Text = resources.GetString("labelInfo_IDA.Text");
            // 
            // pictureBoxDima_IDA
            // 
            this.pictureBoxDima_IDA.Location = new System.Drawing.Point(12, 24);
            this.pictureBoxDima_IDA.Name = "pictureBoxDima_IDA";
            this.pictureBoxDima_IDA.Size = new System.Drawing.Size(179, 213);
            this.pictureBoxDima_IDA.TabIndex = 1;
            this.pictureBoxDima_IDA.TabStop = false;
            // 
            // buttonOK_IDA
            // 
            this.buttonOK_IDA.Location = new System.Drawing.Point(404, 214);
            this.buttonOK_IDA.Name = "buttonOK_IDA";
            this.buttonOK_IDA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_IDA.TabIndex = 2;
            this.buttonOK_IDA.Text = "OK";
            this.buttonOK_IDA.UseVisualStyleBackColor = true;
            this.buttonOK_IDA.Click += new System.EventHandler(this.buttonOK_IDA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 264);
            this.Controls.Add(this.buttonOK_IDA);
            this.Controls.Add(this.pictureBoxDima_IDA);
            this.Controls.Add(this.labelInfo_IDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИНФОРМАЦИЯ О РАЗРАБОТЧИКЕ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDima_IDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_IDA;
        private System.Windows.Forms.PictureBox pictureBoxDima_IDA;
        private System.Windows.Forms.Button buttonOK_IDA;
    }
}
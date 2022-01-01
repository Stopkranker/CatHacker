
namespace CatHackerShell
{
    partial class CTShell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTShell));
            this.CTShellGIF = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CTShellGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // CTShellGIF
            // 
            this.CTShellGIF.Image = ((System.Drawing.Image)(resources.GetObject("CTShellGIF.Image")));
            this.CTShellGIF.Location = new System.Drawing.Point(163, 12);
            this.CTShellGIF.Name = "CTShellGIF";
            this.CTShellGIF.Size = new System.Drawing.Size(375, 363);
            this.CTShellGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CTShellGIF.TabIndex = 0;
            this.CTShellGIF.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(139, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "CatHacker is successfully defeated your PC....\r\n\r\nGood Luck with restore your PC!" +
    "!!";
            // 
            // CTShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(693, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CTShellGIF);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CTShell";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CTShell_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.CTShellGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CTShellGIF;
        private System.Windows.Forms.Label label1;
    }
}


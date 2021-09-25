
namespace Tarea_sobre_reporte
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstReportInfo = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReportId = new System.Windows.Forms.TextBox();
            this.txtReportCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtReportDate = new System.Windows.Forms.TextBox();
            this.txtReportDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstReportInfo
            // 
            this.lstReportInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstReportInfo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lstReportInfo.FormattingEnabled = true;
            this.lstReportInfo.Location = new System.Drawing.Point(93, 280);
            this.lstReportInfo.Name = "lstReportInfo";
            this.lstReportInfo.Size = new System.Drawing.Size(952, 238);
            this.lstReportInfo.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn.Location = new System.Drawing.Point(12, 353);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 39);
            this.btn.TabIndex = 1;
            this.btn.Text = "Agregar";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código de reporte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de reporte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripción de reporte";
            // 
            // txtReportId
            // 
            this.txtReportId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtReportId.Location = new System.Drawing.Point(258, 49);
            this.txtReportId.Name = "txtReportId";
            this.txtReportId.Size = new System.Drawing.Size(238, 20);
            this.txtReportId.TabIndex = 7;
            // 
            // txtReportCode
            // 
            this.txtReportCode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtReportCode.Location = new System.Drawing.Point(258, 96);
            this.txtReportCode.Name = "txtReportCode";
            this.txtReportCode.Size = new System.Drawing.Size(238, 20);
            this.txtReportCode.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtName.Location = new System.Drawing.Point(258, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtReportDate
            // 
            this.txtReportDate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtReportDate.Location = new System.Drawing.Point(258, 175);
            this.txtReportDate.Name = "txtReportDate";
            this.txtReportDate.Size = new System.Drawing.Size(238, 20);
            this.txtReportDate.TabIndex = 10;
            // 
            // txtReportDescription
            // 
            this.txtReportDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtReportDescription.Location = new System.Drawing.Point(258, 209);
            this.txtReportDescription.Name = "txtReportDescription";
            this.txtReportDescription.Size = new System.Drawing.Size(238, 20);
            this.txtReportDescription.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 530);
            this.Controls.Add(this.txtReportDescription);
            this.Controls.Add(this.txtReportDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtReportCode);
            this.Controls.Add(this.txtReportId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lstReportInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReportInfo;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReportId;
        private System.Windows.Forms.TextBox txtReportCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtReportDate;
        private System.Windows.Forms.TextBox txtReportDescription;
    }
}


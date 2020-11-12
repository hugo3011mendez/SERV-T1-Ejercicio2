namespace Ejercicio2
{
    partial class Form
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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.lblPID = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(98, 38);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(690, 400);
            this.txtInfo.TabIndex = 0;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(199, 12);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(195, 20);
            this.txtPID.TabIndex = 1;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPID.Location = new System.Drawing.Point(94, 9);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(99, 24);
            this.lblPID.TabIndex = 2;
            this.lblPID.Text = "Enter PID :";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnView.Location = new System.Drawing.Point(3, 38);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(89, 47);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View Processes";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnInfo.Location = new System.Drawing.Point(3, 116);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(89, 47);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Process Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnClose.Location = new System.Drawing.Point(3, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 47);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close Process";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKill
            // 
            this.btnKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnKill.Location = new System.Drawing.Point(3, 295);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(89, 47);
            this.btnKill.TabIndex = 6;
            this.btnKill.Text = "Kill Process";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRun.Location = new System.Drawing.Point(3, 380);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(89, 47);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run App";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.txtInfo);
            this.Name = "Form";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button btnRun;
    }
}


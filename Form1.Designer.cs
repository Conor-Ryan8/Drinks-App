
namespace DrinksApp
{
    partial class FrmDrinks
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
            this.lblMain = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.grpExtras = new System.Windows.Forms.GroupBox();
            this.btnMilk = new System.Windows.Forms.Button();
            this.btnSugar = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpType.SuspendLayout();
            this.grpExtras.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.SystemColors.Control;
            this.lblMain.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMain.Location = new System.Drawing.Point(208, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(210, 36);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Drinks App v1";
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.txtType);
            this.grpType.Controls.Add(this.lblType);
            this.grpType.Controls.Add(this.btnCoffee);
            this.grpType.Controls.Add(this.btnTea);
            this.grpType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpType.Location = new System.Drawing.Point(23, 69);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(287, 154);
            this.grpType.TabIndex = 1;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(107, 99);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(157, 26);
            this.txtType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(24, 102);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(77, 18);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Selection:";
            // 
            // btnCoffee
            // 
            this.btnCoffee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffee.Location = new System.Drawing.Point(155, 35);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(109, 38);
            this.btnCoffee.TabIndex = 1;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnTea
            // 
            this.btnTea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTea.Location = new System.Drawing.Point(21, 35);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(112, 38);
            this.btnTea.TabIndex = 0;
            this.btnTea.Text = "Tea";
            this.btnTea.UseVisualStyleBackColor = true;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // grpExtras
            // 
            this.grpExtras.Controls.Add(this.btnMilk);
            this.grpExtras.Controls.Add(this.btnSugar);
            this.grpExtras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExtras.Location = new System.Drawing.Point(23, 229);
            this.grpExtras.Name = "grpExtras";
            this.grpExtras.Size = new System.Drawing.Size(287, 103);
            this.grpExtras.TabIndex = 2;
            this.grpExtras.TabStop = false;
            this.grpExtras.Text = "Extras:";
            // 
            // btnMilk
            // 
            this.btnMilk.Location = new System.Drawing.Point(155, 36);
            this.btnMilk.Name = "btnMilk";
            this.btnMilk.Size = new System.Drawing.Size(112, 38);
            this.btnMilk.TabIndex = 1;
            this.btnMilk.Text = "Milk";
            this.btnMilk.UseVisualStyleBackColor = true;
            this.btnMilk.Click += new System.EventHandler(this.btnMilk_Click);
            // 
            // btnSugar
            // 
            this.btnSugar.Location = new System.Drawing.Point(21, 36);
            this.btnSugar.Name = "btnSugar";
            this.btnSugar.Size = new System.Drawing.Size(112, 38);
            this.btnSugar.TabIndex = 0;
            this.btnSugar.Text = "Sugar";
            this.btnSugar.UseVisualStyleBackColor = true;
            this.btnSugar.Click += new System.EventHandler(this.btnSugar_Click);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.txtSummary);
            this.grpSummary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSummary.Location = new System.Drawing.Point(349, 69);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(280, 263);
            this.grpSummary.TabIndex = 3;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(25, 35);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.Size = new System.Drawing.Size(229, 175);
            this.txtSummary.TabIndex = 0;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(80, 354);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(169, 40);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Complete Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(399, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 415);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpExtras);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblMain);
            this.Name = "FrmDrinks";
            this.Text = "Drinks App v1";
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpExtras.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.GroupBox grpExtras;
        private System.Windows.Forms.Button btnMilk;
        private System.Windows.Forms.Button btnSugar;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Button btnClear;
    }
}


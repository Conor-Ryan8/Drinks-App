
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
            this.btnChocolate = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpType.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.SystemColors.Control;
            this.lblMain.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMain.Location = new System.Drawing.Point(164, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(210, 36);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Drinks App v2";
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.btnChocolate);
            this.grpType.Controls.Add(this.btnCoffee);
            this.grpType.Controls.Add(this.btnTea);
            this.grpType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpType.Location = new System.Drawing.Point(23, 69);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(174, 217);
            this.grpType.TabIndex = 1;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type:";
            // 
            // btnChocolate
            // 
            this.btnChocolate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChocolate.Location = new System.Drawing.Point(21, 95);
            this.btnChocolate.Name = "btnChocolate";
            this.btnChocolate.Size = new System.Drawing.Size(126, 38);
            this.btnChocolate.TabIndex = 2;
            this.btnChocolate.Text = "Hot Chocolate";
            this.btnChocolate.UseVisualStyleBackColor = true;
            this.btnChocolate.Click += new System.EventHandler(this.btnChocolate_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffee.Location = new System.Drawing.Point(21, 156);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(126, 38);
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
            this.btnTea.Size = new System.Drawing.Size(126, 38);
            this.btnTea.TabIndex = 0;
            this.btnTea.Text = "Tea";
            this.btnTea.UseVisualStyleBackColor = true;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.btnFinish);
            this.grpOrder.Controls.Add(this.txtOrder);
            this.grpOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrder.Location = new System.Drawing.Point(246, 69);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(271, 317);
            this.grpOrder.TabIndex = 3;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order:";
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(46, 245);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(169, 40);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Finish Order";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(20, 42);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(229, 175);
            this.txtOrder.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(23, 546);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add to Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(46, 93);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(169, 40);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New Order";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.btnMedium);
            this.grpSize.Controls.Add(this.btnLarge);
            this.grpSize.Controls.Add(this.btnSmall);
            this.grpSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(23, 304);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(174, 217);
            this.grpSize.TabIndex = 3;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size:";
            // 
            // btnMedium
            // 
            this.btnMedium.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(21, 95);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(126, 38);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLarge.Location = new System.Drawing.Point(21, 156);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(126, 38);
            this.btnLarge.TabIndex = 1;
            this.btnLarge.Text = "Large";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmall.Location = new System.Drawing.Point(21, 35);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(126, 38);
            this.btnSmall.TabIndex = 0;
            this.btnSmall.Text = "Small";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.txtTotal);
            this.grpTotal.Controls.Add(this.btnNew);
            this.grpTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotal.Location = new System.Drawing.Point(246, 413);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(261, 156);
            this.grpTotal.TabIndex = 6;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(46, 36);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(169, 29);
            this.txtTotal.TabIndex = 0;
            // 
            // FrmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 613);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblMain);
            this.Name = "FrmDrinks";
            this.Text = "Drinks App v2";
            this.grpType.ResumeLayout(false);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnChocolate;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}


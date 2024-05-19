
namespace Glasses_Shop_Project
{
    partial class Purchase
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
            this.txtPurchaseId = new System.Windows.Forms.TextBox();
            this.txtAmountPerUnit = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtDistributorId = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_purchase = new System.Windows.Forms.Label();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.lbl_distributor_id = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPurchaseId
            // 
            this.txtPurchaseId.Location = new System.Drawing.Point(125, 147);
            this.txtPurchaseId.Name = "txtPurchaseId";
            this.txtPurchaseId.Size = new System.Drawing.Size(100, 20);
            this.txtPurchaseId.TabIndex = 0;
            // 
            // txtAmountPerUnit
            // 
            this.txtAmountPerUnit.Location = new System.Drawing.Point(338, 256);
            this.txtAmountPerUnit.Name = "txtAmountPerUnit";
            this.txtAmountPerUnit.Size = new System.Drawing.Size(100, 20);
            this.txtAmountPerUnit.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(553, 256);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(125, 256);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(338, 147);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 20);
            this.txtProductId.TabIndex = 4;
            // 
            // txtDistributorId
            // 
            this.txtDistributorId.Location = new System.Drawing.Point(553, 147);
            this.txtDistributorId.Name = "txtDistributorId";
            this.txtDistributorId.Size = new System.Drawing.Size(100, 20);
            this.txtDistributorId.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(276, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lbl_purchase
            // 
            this.lbl_purchase.AutoSize = true;
            this.lbl_purchase.Location = new System.Drawing.Point(52, 150);
            this.lbl_purchase.Name = "lbl_purchase";
            this.lbl_purchase.Size = new System.Drawing.Size(67, 13);
            this.lbl_purchase.TabIndex = 7;
            this.lbl_purchase.Text = "Purchase Id:";
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.AutoSize = true;
            this.lbl_product_id.Location = new System.Drawing.Point(273, 150);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.Size = new System.Drawing.Size(59, 13);
            this.lbl_product_id.TabIndex = 8;
            this.lbl_product_id.Text = "Product Id:";
            // 
            // lbl_distributor_id
            // 
            this.lbl_distributor_id.AutoSize = true;
            this.lbl_distributor_id.Location = new System.Drawing.Point(478, 150);
            this.lbl_distributor_id.Name = "lbl_distributor_id";
            this.lbl_distributor_id.Size = new System.Drawing.Size(69, 13);
            this.lbl_distributor_id.TabIndex = 9;
            this.lbl_distributor_id.Text = "Distributor Id:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(70, 259);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(49, 13);
            this.lbl_quantity.TabIndex = 10;
            this.lbl_quantity.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Amount Per Unit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(257, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(350, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(441, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(350, 355);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 16;
            this.btnRetrieve.Text = "Retrieve Product";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(550, 355);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "Message:";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_distributor_id);
            this.Controls.Add(this.lbl_product_id);
            this.Controls.Add(this.lbl_purchase);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtDistributorId);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtAmountPerUnit);
            this.Controls.Add(this.txtPurchaseId);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPurchaseId;
        private System.Windows.Forms.TextBox txtAmountPerUnit;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtDistributorId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_purchase;
        private System.Windows.Forms.Label lbl_product_id;
        private System.Windows.Forms.Label lbl_distributor_id;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lblMessage;
    }
}
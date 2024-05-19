
namespace Glasses_Shop_Project
{
    partial class Distributor
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
            this.txt_distributor_id = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_distributor_phone_no = new System.Windows.Forms.TextBox();
            this.lbl_disitributor_id = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_distributor_id
            // 
            this.txt_distributor_id.Location = new System.Drawing.Point(155, 99);
            this.txt_distributor_id.Name = "txt_distributor_id";
            this.txt_distributor_id.Size = new System.Drawing.Size(140, 20);
            this.txt_distributor_id.TabIndex = 0;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(155, 238);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(382, 20);
            this.txt_description.TabIndex = 1;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(155, 191);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(312, 20);
            this.txt_address.TabIndex = 2;
            // 
            // txt_distributor_phone_no
            // 
            this.txt_distributor_phone_no.Location = new System.Drawing.Point(155, 146);
            this.txt_distributor_phone_no.Name = "txt_distributor_phone_no";
            this.txt_distributor_phone_no.Size = new System.Drawing.Size(180, 20);
            this.txt_distributor_phone_no.TabIndex = 3;
            // 
            // lbl_disitributor_id
            // 
            this.lbl_disitributor_id.AutoSize = true;
            this.lbl_disitributor_id.Location = new System.Drawing.Point(80, 102);
            this.lbl_disitributor_id.Name = "lbl_disitributor_id";
            this.lbl_disitributor_id.Size = new System.Drawing.Size(69, 13);
            this.lbl_disitributor_id.TabIndex = 4;
            this.lbl_disitributor_id.Text = "Distributor Id:";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(86, 241);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(63, 13);
            this.lbl_description.TabIndex = 5;
            this.lbl_description.Text = "Description:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(101, 194);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(48, 13);
            this.lbl_address.TabIndex = 6;
            this.lbl_address.Text = "Address:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(108, 149);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_phone.TabIndex = 7;
            this.lbl_phone.Text = "Phone:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(560, 236);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(205, 306);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(341, 306);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.Location = new System.Drawing.Point(479, 306);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_retrieve.TabIndex = 11;
            this.btn_retrieve.Text = "Retrieve";
            this.btn_retrieve.UseVisualStyleBackColor = true;
            this.btn_retrieve.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(338, 363);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(53, 13);
            this.lbl_message.TabIndex = 12;
            this.lbl_message.Text = "Message:";
            // 
            // Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_retrieve);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_disitributor_id);
            this.Controls.Add(this.txt_distributor_phone_no);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_distributor_id);
            this.Name = "Distributor";
            this.Text = "Distributor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_distributor_id;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_distributor_phone_no;
        private System.Windows.Forms.Label lbl_disitributor_id;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_retrieve;
        private System.Windows.Forms.Label lbl_message;
    }
}
﻿
namespace Ticari_Otomasyon
{
    partial class Frm_Personnels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Personnels));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Grdcntrl_Personnel = new DevExpress.XtraGrid.GridControl();
            this.cmbbx_Country = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbbx_City = new DevExpress.XtraEditors.ComboBoxEdit();
            this.msktxb_IdentityNumber = new System.Windows.Forms.MaskedTextBox();
            this.msktxb_Phone = new System.Windows.Forms.MaskedTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtedit_Address = new DevExpress.XtraEditors.TextEdit();
            this.txtedit_Task = new DevExpress.XtraEditors.TextEdit();
            this.grpcntrl_Customers = new DevExpress.XtraEditors.GroupControl();
            this.btn_Clean = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_Details = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Saleprice = new DevExpress.XtraEditors.LabelControl();
            this.txt_Mail = new DevExpress.XtraEditors.TextEdit();
            this.lbl_PurchasePrice = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Stok = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Model = new DevExpress.XtraEditors.LabelControl();
            this.txt_LastName = new DevExpress.XtraEditors.TextEdit();
            this.lbl_SupplierCompany = new DevExpress.XtraEditors.LabelControl();
            this.txt_FirstName = new DevExpress.XtraEditors.TextEdit();
            this.lbl_ProductName = new DevExpress.XtraEditors.LabelControl();
            this.txt_Id = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Id = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grdcntrl_Personnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_Country.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_City.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtedit_Address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtedit_Task.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcntrl_Customers)).BeginInit();
            this.grpcntrl_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.LightCoral;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.Grdcntrl_Personnel;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // Grdcntrl_Personnel
            // 
            this.Grdcntrl_Personnel.Location = new System.Drawing.Point(-9, 0);
            this.Grdcntrl_Personnel.MainView = this.gridView1;
            this.Grdcntrl_Personnel.Name = "Grdcntrl_Personnel";
            this.Grdcntrl_Personnel.Size = new System.Drawing.Size(1075, 560);
            this.Grdcntrl_Personnel.TabIndex = 4;
            this.Grdcntrl_Personnel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cmbbx_Country
            // 
            this.cmbbx_Country.Location = new System.Drawing.Point(169, 256);
            this.cmbbx_Country.Name = "cmbbx_Country";
            this.cmbbx_Country.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbx_Country.Properties.Appearance.Options.UseFont = true;
            this.cmbbx_Country.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbbx_Country.Size = new System.Drawing.Size(268, 24);
            this.cmbbx_Country.TabIndex = 7;
            // 
            // cmbbx_City
            // 
            this.cmbbx_City.Location = new System.Drawing.Point(169, 226);
            this.cmbbx_City.Name = "cmbbx_City";
            this.cmbbx_City.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbx_City.Properties.Appearance.Options.UseFont = true;
            this.cmbbx_City.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbbx_City.Size = new System.Drawing.Size(268, 24);
            this.cmbbx_City.TabIndex = 6;
            this.cmbbx_City.SelectedIndexChanged += new System.EventHandler(this.cmbbx_City_SelectedIndexChanged);
            // 
            // msktxb_IdentityNumber
            // 
            this.msktxb_IdentityNumber.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxb_IdentityNumber.Location = new System.Drawing.Point(169, 165);
            this.msktxb_IdentityNumber.Mask = "00000000000";
            this.msktxb_IdentityNumber.Name = "msktxb_IdentityNumber";
            this.msktxb_IdentityNumber.Size = new System.Drawing.Size(268, 25);
            this.msktxb_IdentityNumber.TabIndex = 4;
            this.msktxb_IdentityNumber.ValidatingType = typeof(int);
            // 
            // msktxb_Phone
            // 
            this.msktxb_Phone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxb_Phone.Location = new System.Drawing.Point(169, 134);
            this.msktxb_Phone.Mask = "(999) 000-0000";
            this.msktxb_Phone.Name = "msktxb_Phone";
            this.msktxb_Phone.Size = new System.Drawing.Size(268, 25);
            this.msktxb_Phone.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(120, 314);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 22);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Task:";
            this.labelControl2.UseMnemonic = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(95, 286);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 22);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Address:";
            // 
            // txtedit_Address
            // 
            this.txtedit_Address.Location = new System.Drawing.Point(169, 286);
            this.txtedit_Address.Name = "txtedit_Address";
            this.txtedit_Address.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtedit_Address.Properties.Appearance.Options.UseFont = true;
            this.txtedit_Address.Size = new System.Drawing.Size(268, 24);
            this.txtedit_Address.TabIndex = 8;
            // 
            // txtedit_Task
            // 
            this.txtedit_Task.Location = new System.Drawing.Point(169, 316);
            this.txtedit_Task.Name = "txtedit_Task";
            this.txtedit_Task.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtedit_Task.Properties.Appearance.Options.UseFont = true;
            this.txtedit_Task.Size = new System.Drawing.Size(268, 24);
            this.txtedit_Task.TabIndex = 9;
            // 
            // grpcntrl_Customers
            // 
            this.grpcntrl_Customers.Controls.Add(this.btn_Clean);
            this.grpcntrl_Customers.Controls.Add(this.cmbbx_Country);
            this.grpcntrl_Customers.Controls.Add(this.cmbbx_City);
            this.grpcntrl_Customers.Controls.Add(this.msktxb_IdentityNumber);
            this.grpcntrl_Customers.Controls.Add(this.msktxb_Phone);
            this.grpcntrl_Customers.Controls.Add(this.labelControl2);
            this.grpcntrl_Customers.Controls.Add(this.labelControl1);
            this.grpcntrl_Customers.Controls.Add(this.txtedit_Address);
            this.grpcntrl_Customers.Controls.Add(this.txtedit_Task);
            this.grpcntrl_Customers.Controls.Add(this.btn_Update);
            this.grpcntrl_Customers.Controls.Add(this.btn_Delete);
            this.grpcntrl_Customers.Controls.Add(this.btn_Save);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Details);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Saleprice);
            this.grpcntrl_Customers.Controls.Add(this.txt_Mail);
            this.grpcntrl_Customers.Controls.Add(this.lbl_PurchasePrice);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Stok);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Model);
            this.grpcntrl_Customers.Controls.Add(this.txt_LastName);
            this.grpcntrl_Customers.Controls.Add(this.lbl_SupplierCompany);
            this.grpcntrl_Customers.Controls.Add(this.txt_FirstName);
            this.grpcntrl_Customers.Controls.Add(this.lbl_ProductName);
            this.grpcntrl_Customers.Controls.Add(this.txt_Id);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Id);
            this.grpcntrl_Customers.Location = new System.Drawing.Point(1072, 0);
            this.grpcntrl_Customers.Name = "grpcntrl_Customers";
            this.grpcntrl_Customers.Size = new System.Drawing.Size(456, 560);
            this.grpcntrl_Customers.TabIndex = 5;
            this.grpcntrl_Customers.Text = " ";
            // 
            // btn_Clean
            // 
            this.btn_Clean.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Clean.Appearance.Options.UseFont = true;
            this.btn_Clean.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Clean.ImageOptions.SvgImage")));
            this.btn_Clean.Location = new System.Drawing.Point(5, 442);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(198, 44);
            this.btn_Clean.TabIndex = 12;
            this.btn_Clean.Text = "Clean";
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Update.ImageOptions.SvgImage")));
            this.btn_Update.Location = new System.Drawing.Point(239, 442);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(198, 44);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Update";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Delete.ImageOptions.SvgImage")));
            this.btn_Delete.Location = new System.Drawing.Point(239, 379);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(198, 44);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Save.ImageOptions.SvgImage")));
            this.btn_Save.Location = new System.Drawing.Point(5, 379);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(198, 44);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Details
            // 
            this.lbl_Details.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.Appearance.Options.UseFont = true;
            this.lbl_Details.Location = new System.Drawing.Point(103, 258);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(64, 22);
            this.lbl_Details.TabIndex = 16;
            this.lbl_Details.Text = "County:";
            // 
            // lbl_Saleprice
            // 
            this.lbl_Saleprice.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saleprice.Appearance.Options.UseFont = true;
            this.lbl_Saleprice.Location = new System.Drawing.Point(128, 230);
            this.lbl_Saleprice.Name = "lbl_Saleprice";
            this.lbl_Saleprice.Size = new System.Drawing.Size(39, 22);
            this.lbl_Saleprice.TabIndex = 14;
            this.lbl_Saleprice.Text = "City:";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(169, 196);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Mail.Properties.Appearance.Options.UseFont = true;
            this.txt_Mail.Size = new System.Drawing.Size(268, 24);
            this.txt_Mail.TabIndex = 5;
            // 
            // lbl_PurchasePrice
            // 
            this.lbl_PurchasePrice.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchasePrice.Appearance.Options.UseFont = true;
            this.lbl_PurchasePrice.Location = new System.Drawing.Point(124, 198);
            this.lbl_PurchasePrice.Name = "lbl_PurchasePrice";
            this.lbl_PurchasePrice.Size = new System.Drawing.Size(43, 22);
            this.lbl_PurchasePrice.TabIndex = 12;
            this.lbl_PurchasePrice.Text = "Mail:";
            // 
            // lbl_Stok
            // 
            this.lbl_Stok.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stok.Appearance.Options.UseFont = true;
            this.lbl_Stok.Location = new System.Drawing.Point(34, 169);
            this.lbl_Stok.Name = "lbl_Stok";
            this.lbl_Stok.Size = new System.Drawing.Size(133, 22);
            this.lbl_Stok.TabIndex = 11;
            this.lbl_Stok.Text = "IdentityNumber:";
            // 
            // lbl_Model
            // 
            this.lbl_Model.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Appearance.Options.UseFont = true;
            this.lbl_Model.Location = new System.Drawing.Point(110, 141);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(56, 22);
            this.lbl_Model.TabIndex = 7;
            this.lbl_Model.Text = "Phone:";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(169, 104);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_LastName.Properties.Appearance.Options.UseFont = true;
            this.txt_LastName.Size = new System.Drawing.Size(268, 24);
            this.txt_LastName.TabIndex = 2;
            // 
            // lbl_SupplierCompany
            // 
            this.lbl_SupplierCompany.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplierCompany.Appearance.Options.UseFont = true;
            this.lbl_SupplierCompany.Location = new System.Drawing.Point(77, 106);
            this.lbl_SupplierCompany.Name = "lbl_SupplierCompany";
            this.lbl_SupplierCompany.Size = new System.Drawing.Size(89, 22);
            this.lbl_SupplierCompany.TabIndex = 5;
            this.lbl_SupplierCompany.Text = "LastName:";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(169, 74);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_FirstName.Properties.Appearance.Options.UseFont = true;
            this.txt_FirstName.Size = new System.Drawing.Size(268, 24);
            this.txt_FirstName.TabIndex = 1;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProductName.Appearance.Options.UseFont = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(75, 78);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(92, 22);
            this.lbl_ProductName.TabIndex = 3;
            this.lbl_ProductName.Text = "FirstName:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(169, 44);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Id.Properties.Appearance.Options.UseFont = true;
            this.txt_Id.Size = new System.Drawing.Size(268, 24);
            this.txt_Id.TabIndex = 14;
            // 
            // lbl_Id
            // 
            this.lbl_Id.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Id.Appearance.Options.UseFont = true;
            this.lbl_Id.Location = new System.Drawing.Point(131, 46);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(36, 22);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "ID:  ";
            // 
            // Frm_Personnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 561);
            this.Controls.Add(this.grpcntrl_Customers);
            this.Controls.Add(this.Grdcntrl_Personnel);
            this.Name = "Frm_Personnels";
            this.Text = "EMPLOYEES";
            this.Load += new System.EventHandler(this.Frm_Personnels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grdcntrl_Personnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_Country.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_City.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtedit_Address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtedit_Task.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcntrl_Customers)).EndInit();
            this.grpcntrl_Customers.ResumeLayout(false);
            this.grpcntrl_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl Grdcntrl_Personnel;
        private DevExpress.XtraEditors.ComboBoxEdit cmbbx_Country;
        private DevExpress.XtraEditors.ComboBoxEdit cmbbx_City;
        private System.Windows.Forms.MaskedTextBox msktxb_IdentityNumber;
        private System.Windows.Forms.MaskedTextBox msktxb_Phone;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtedit_Address;
        private DevExpress.XtraEditors.TextEdit txtedit_Task;
        private DevExpress.XtraEditors.GroupControl grpcntrl_Customers;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.LabelControl lbl_Details;
        private DevExpress.XtraEditors.LabelControl lbl_Saleprice;
        private DevExpress.XtraEditors.TextEdit txt_Mail;
        private DevExpress.XtraEditors.LabelControl lbl_PurchasePrice;
        private DevExpress.XtraEditors.LabelControl lbl_Stok;
        private DevExpress.XtraEditors.LabelControl lbl_Model;
        private DevExpress.XtraEditors.TextEdit txt_LastName;
        private DevExpress.XtraEditors.LabelControl lbl_SupplierCompany;
        private DevExpress.XtraEditors.TextEdit txt_FirstName;
        private DevExpress.XtraEditors.LabelControl lbl_ProductName;
        private DevExpress.XtraEditors.TextEdit txt_Id;
        private DevExpress.XtraEditors.LabelControl lbl_Id;
        private DevExpress.XtraEditors.SimpleButton btn_Clean;
    }
}
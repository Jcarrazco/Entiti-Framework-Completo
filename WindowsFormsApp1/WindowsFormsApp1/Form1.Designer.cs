namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Lst_Datos = new System.Windows.Forms.ListBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Txb_Id = new System.Windows.Forms.TextBox();
            this.Txb_CompanyName = new System.Windows.Forms.TextBox();
            this.Txb_ContactName = new System.Windows.Forms.TextBox();
            this.Txb_ContactTitle = new System.Windows.Forms.TextBox();
            this.Txb_Addres = new System.Windows.Forms.TextBox();
            this.Txb_city = new System.Windows.Forms.TextBox();
            this.Txb_Region = new System.Windows.Forms.TextBox();
            this.Txb_Pc = new System.Windows.Forms.TextBox();
            this.Txb_Country = new System.Windows.Forms.TextBox();
            this.Txb_Phone = new System.Windows.Forms.TextBox();
            this.Txb_Fax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_addr = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_reg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_all = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lst_Datos
            // 
            this.Lst_Datos.FormattingEnabled = true;
            this.Lst_Datos.Location = new System.Drawing.Point(12, 38);
            this.Lst_Datos.Name = "Lst_Datos";
            this.Lst_Datos.Size = new System.Drawing.Size(300, 264);
            this.Lst_Datos.TabIndex = 0;
            this.Lst_Datos.SelectedIndexChanged += new System.EventHandler(this.Lst_Datos_SelectedIndexChanged);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(658, 12);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 1;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_edit
            // 
            this.Btn_edit.Location = new System.Drawing.Point(658, 60);
            this.Btn_edit.Name = "Btn_edit";
            this.Btn_edit.Size = new System.Drawing.Size(75, 23);
            this.Btn_edit.TabIndex = 2;
            this.Btn_edit.Text = "Editar";
            this.Btn_edit.UseVisualStyleBackColor = true;
            this.Btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(658, 113);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Txb_Id
            // 
            this.Txb_Id.Location = new System.Drawing.Point(339, 12);
            this.Txb_Id.Name = "Txb_Id";
            this.Txb_Id.Size = new System.Drawing.Size(100, 20);
            this.Txb_Id.TabIndex = 4;
            // 
            // Txb_CompanyName
            // 
            this.Txb_CompanyName.Location = new System.Drawing.Point(339, 38);
            this.Txb_CompanyName.Name = "Txb_CompanyName";
            this.Txb_CompanyName.Size = new System.Drawing.Size(100, 20);
            this.Txb_CompanyName.TabIndex = 5;
            // 
            // Txb_ContactName
            // 
            this.Txb_ContactName.Location = new System.Drawing.Point(339, 64);
            this.Txb_ContactName.Name = "Txb_ContactName";
            this.Txb_ContactName.Size = new System.Drawing.Size(100, 20);
            this.Txb_ContactName.TabIndex = 6;
            // 
            // Txb_ContactTitle
            // 
            this.Txb_ContactTitle.Location = new System.Drawing.Point(339, 90);
            this.Txb_ContactTitle.Name = "Txb_ContactTitle";
            this.Txb_ContactTitle.Size = new System.Drawing.Size(100, 20);
            this.Txb_ContactTitle.TabIndex = 7;
            // 
            // Txb_Addres
            // 
            this.Txb_Addres.Location = new System.Drawing.Point(339, 116);
            this.Txb_Addres.Name = "Txb_Addres";
            this.Txb_Addres.Size = new System.Drawing.Size(100, 20);
            this.Txb_Addres.TabIndex = 8;
            // 
            // Txb_city
            // 
            this.Txb_city.Location = new System.Drawing.Point(339, 142);
            this.Txb_city.Name = "Txb_city";
            this.Txb_city.Size = new System.Drawing.Size(100, 20);
            this.Txb_city.TabIndex = 9;
            // 
            // Txb_Region
            // 
            this.Txb_Region.Location = new System.Drawing.Point(339, 168);
            this.Txb_Region.Name = "Txb_Region";
            this.Txb_Region.Size = new System.Drawing.Size(100, 20);
            this.Txb_Region.TabIndex = 10;
            // 
            // Txb_Pc
            // 
            this.Txb_Pc.Location = new System.Drawing.Point(339, 194);
            this.Txb_Pc.Name = "Txb_Pc";
            this.Txb_Pc.Size = new System.Drawing.Size(100, 20);
            this.Txb_Pc.TabIndex = 11;
            // 
            // Txb_Country
            // 
            this.Txb_Country.Location = new System.Drawing.Point(339, 220);
            this.Txb_Country.Name = "Txb_Country";
            this.Txb_Country.Size = new System.Drawing.Size(100, 20);
            this.Txb_Country.TabIndex = 12;
            // 
            // Txb_Phone
            // 
            this.Txb_Phone.Location = new System.Drawing.Point(339, 246);
            this.Txb_Phone.Name = "Txb_Phone";
            this.Txb_Phone.Size = new System.Drawing.Size(100, 20);
            this.Txb_Phone.TabIndex = 13;
            // 
            // Txb_Fax
            // 
            this.Txb_Fax.Location = new System.Drawing.Point(339, 272);
            this.Txb_Fax.Name = "Txb_Fax";
            this.Txb_Fax.Size = new System.Drawing.Size(100, 20);
            this.Txb_Fax.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Contact Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "CompanyName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "CustomerID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contact Title";
            // 
            // lbl_addr
            // 
            this.lbl_addr.AutoSize = true;
            this.lbl_addr.Location = new System.Drawing.Point(445, 123);
            this.lbl_addr.Name = "lbl_addr";
            this.lbl_addr.Size = new System.Drawing.Size(40, 13);
            this.lbl_addr.TabIndex = 21;
            this.lbl_addr.Text = "Addres";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(445, 149);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(24, 13);
            this.lbl_City.TabIndex = 22;
            this.lbl_City.Text = "City";
            // 
            // lbl_reg
            // 
            this.lbl_reg.AutoSize = true;
            this.lbl_reg.Location = new System.Drawing.Point(445, 175);
            this.lbl_reg.Name = "lbl_reg";
            this.lbl_reg.Size = new System.Drawing.Size(41, 13);
            this.lbl_reg.TabIndex = 23;
            this.lbl_reg.Text = "Region";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Postal Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fax";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(94, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 18);
            this.label12.TabIndex = 28;
            this.label12.Text = "List of Customers";
            // 
            // Btn_all
            // 
            this.Btn_all.Location = new System.Drawing.Point(658, 279);
            this.Btn_all.Name = "Btn_all";
            this.Btn_all.Size = new System.Drawing.Size(75, 23);
            this.Btn_all.TabIndex = 29;
            this.Btn_all.Text = "Todos";
            this.Btn_all.UseVisualStyleBackColor = true;
            this.Btn_all.Click += new System.EventHandler(this.Btn_all_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.Location = new System.Drawing.Point(658, 250);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_clear.TabIndex = 30;
            this.Btn_clear.Text = "Limpiar";
            this.Btn_clear.UseVisualStyleBackColor = true;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Location = new System.Drawing.Point(658, 168);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Crear.TabIndex = 31;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = true;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 320);
            this.Controls.Add(this.Btn_Crear);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.Btn_all);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_reg);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_addr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_Fax);
            this.Controls.Add(this.Txb_Phone);
            this.Controls.Add(this.Txb_Country);
            this.Controls.Add(this.Txb_Pc);
            this.Controls.Add(this.Txb_Region);
            this.Controls.Add(this.Txb_city);
            this.Controls.Add(this.Txb_Addres);
            this.Controls.Add(this.Txb_ContactTitle);
            this.Controls.Add(this.Txb_ContactName);
            this.Controls.Add(this.Txb_CompanyName);
            this.Controls.Add(this.Txb_Id);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_edit);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lst_Datos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lst_Datos;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox Txb_Id;
        private System.Windows.Forms.TextBox Txb_CompanyName;
        private System.Windows.Forms.TextBox Txb_ContactName;
        private System.Windows.Forms.TextBox Txb_ContactTitle;
        private System.Windows.Forms.TextBox Txb_Addres;
        private System.Windows.Forms.TextBox Txb_city;
        private System.Windows.Forms.TextBox Txb_Region;
        private System.Windows.Forms.TextBox Txb_Pc;
        private System.Windows.Forms.TextBox Txb_Country;
        private System.Windows.Forms.TextBox Txb_Phone;
        private System.Windows.Forms.TextBox Txb_Fax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_addr;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_reg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_all;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Button Btn_Crear;
    }
}


﻿namespace DatabasePJ
{
    partial class Func
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
            this.welcome = new System.Windows.Forms.Label();
            this.auzInfo = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.accountManage = new System.Windows.Forms.Button();
            this.categoryManage = new System.Windows.Forms.Button();
            this.productManage = new System.Windows.Forms.Button();
            this.itemManage = new System.Windows.Forms.Button();
            this.sellingsManage = new System.Windows.Forms.Button();
            this.reviewManage = new System.Windows.Forms.Button();
            this.sellerManage = new System.Windows.Forms.Button();
            this.suppsManage = new System.Windows.Forms.Button();
            this.sqlMode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(81, 38);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(155, 39);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Welcome, ";
            // 
            // auzInfo
            // 
            this.auzInfo.AutoSize = true;
            this.auzInfo.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auzInfo.Location = new System.Drawing.Point(81, 95);
            this.auzInfo.Name = "auzInfo";
            this.auzInfo.Size = new System.Drawing.Size(176, 39);
            this.auzInfo.TabIndex = 2;
            this.auzInfo.Text = "Your role is: ";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.role.Location = new System.Drawing.Point(249, 95);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(67, 39);
            this.role.TabIndex = 3;
            this.role.Text = "role";
            // 
            // accountManage
            // 
            this.accountManage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountManage.Location = new System.Drawing.Point(380, 165);
            this.accountManage.Name = "accountManage";
            this.accountManage.Size = new System.Drawing.Size(122, 40);
            this.accountManage.TabIndex = 4;
            this.accountManage.Text = "Account";
            this.accountManage.UseVisualStyleBackColor = true;
            this.accountManage.Click += new System.EventHandler(this.accountManage_Click);
            // 
            // categoryManage
            // 
            this.categoryManage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryManage.Location = new System.Drawing.Point(519, 165);
            this.categoryManage.Name = "categoryManage";
            this.categoryManage.Size = new System.Drawing.Size(122, 40);
            this.categoryManage.TabIndex = 5;
            this.categoryManage.Text = "Category";
            this.categoryManage.UseVisualStyleBackColor = true;
            this.categoryManage.Click += new System.EventHandler(this.categoryManage_Click);
            // 
            // productManage
            // 
            this.productManage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productManage.Location = new System.Drawing.Point(519, 209);
            this.productManage.Name = "productManage";
            this.productManage.Size = new System.Drawing.Size(122, 40);
            this.productManage.TabIndex = 7;
            this.productManage.Text = "Product";
            this.productManage.UseVisualStyleBackColor = true;
            this.productManage.Click += new System.EventHandler(this.productManage_Click);
            // 
            // itemManage
            // 
            this.itemManage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemManage.Location = new System.Drawing.Point(380, 209);
            this.itemManage.Name = "itemManage";
            this.itemManage.Size = new System.Drawing.Size(122, 40);
            this.itemManage.TabIndex = 6;
            this.itemManage.Text = "Item";
            this.itemManage.UseVisualStyleBackColor = true;
            this.itemManage.Click += new System.EventHandler(this.itemManage_Click);
            // 
            // sellingsManage
            // 
            this.sellingsManage.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingsManage.Location = new System.Drawing.Point(380, 300);
            this.sellingsManage.Name = "sellingsManage";
            this.sellingsManage.Size = new System.Drawing.Size(122, 58);
            this.sellingsManage.TabIndex = 10;
            this.sellingsManage.Text = "Selling History";
            this.sellingsManage.UseVisualStyleBackColor = true;
            this.sellingsManage.Click += new System.EventHandler(this.sellingsManage_Click);
            // 
            // reviewManage
            // 
            this.reviewManage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewManage.Location = new System.Drawing.Point(519, 255);
            this.reviewManage.Name = "reviewManage";
            this.reviewManage.Size = new System.Drawing.Size(122, 40);
            this.reviewManage.TabIndex = 9;
            this.reviewManage.Text = "Review";
            this.reviewManage.UseVisualStyleBackColor = true;
            this.reviewManage.Click += new System.EventHandler(this.reviewManage_Click);
            // 
            // sellerManage
            // 
            this.sellerManage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerManage.Location = new System.Drawing.Point(380, 255);
            this.sellerManage.Name = "sellerManage";
            this.sellerManage.Size = new System.Drawing.Size(122, 40);
            this.sellerManage.TabIndex = 8;
            this.sellerManage.Text = "Seller";
            this.sellerManage.UseVisualStyleBackColor = true;
            this.sellerManage.Click += new System.EventHandler(this.sellerManage_Click);
            // 
            // suppsManage
            // 
            this.suppsManage.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppsManage.Location = new System.Drawing.Point(519, 300);
            this.suppsManage.Name = "suppsManage";
            this.suppsManage.Size = new System.Drawing.Size(122, 58);
            this.suppsManage.TabIndex = 11;
            this.suppsManage.Text = "Supplement History";
            this.suppsManage.UseVisualStyleBackColor = true;
            this.suppsManage.Click += new System.EventHandler(this.suppsManage_Click);
            // 
            // sqlMode
            // 
            this.sqlMode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlMode.Location = new System.Drawing.Point(380, 374);
            this.sqlMode.Name = "sqlMode";
            this.sqlMode.Size = new System.Drawing.Size(262, 40);
            this.sqlMode.TabIndex = 12;
            this.sqlMode.Text = "SQL Mode (Advanced)";
            this.sqlMode.UseVisualStyleBackColor = true;
            this.sqlMode.Click += new System.EventHandler(this.sqlMode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DatabasePJ.Properties.Resources.head;
            this.pictureBox1.Location = new System.Drawing.Point(80, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 460);
            this.Controls.Add(this.sqlMode);
            this.Controls.Add(this.suppsManage);
            this.Controls.Add(this.sellingsManage);
            this.Controls.Add(this.reviewManage);
            this.Controls.Add(this.sellerManage);
            this.Controls.Add(this.productManage);
            this.Controls.Add(this.itemManage);
            this.Controls.Add(this.categoryManage);
            this.Controls.Add(this.accountManage);
            this.Controls.Add(this.role);
            this.Controls.Add(this.auzInfo);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Func";
            this.Text = "Stocl Management System";
            this.Load += new System.EventHandler(this.Func_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label auzInfo;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Button accountManage;
        private System.Windows.Forms.Button categoryManage;
        private System.Windows.Forms.Button productManage;
        private System.Windows.Forms.Button itemManage;
        private System.Windows.Forms.Button sellingsManage;
        private System.Windows.Forms.Button reviewManage;
        private System.Windows.Forms.Button sellerManage;
        private System.Windows.Forms.Button suppsManage;
        private System.Windows.Forms.Button sqlMode;
    }
}
namespace Proj_DijkstraShortestPath
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
            this.gb_map = new System.Windows.Forms.GroupBox();
            this.kota_E = new System.Windows.Forms.Button();
            this.kota_D = new System.Windows.Forms.Button();
            this.kota_C = new System.Windows.Forms.Button();
            this.kota_B = new System.Windows.Forms.Button();
            this.kota_A = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape10 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.kotaTujuan = new System.Windows.Forms.Label();
            this.jarakTempuh = new System.Windows.Forms.Label();
            this.kotaAsal = new System.Windows.Forms.Label();
            this.FcR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cari = new System.Windows.Forms.Button();
            this.gb_map.SuspendLayout();
            this.gb_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_map
            // 
            this.gb_map.Controls.Add(this.label7);
            this.gb_map.Controls.Add(this.label6);
            this.gb_map.Controls.Add(this.label5);
            this.gb_map.Controls.Add(this.label4);
            this.gb_map.Controls.Add(this.label3);
            this.gb_map.Controls.Add(this.label2);
            this.gb_map.Controls.Add(this.label1);
            this.gb_map.Controls.Add(this.kota_E);
            this.gb_map.Controls.Add(this.kota_D);
            this.gb_map.Controls.Add(this.kota_C);
            this.gb_map.Controls.Add(this.kota_B);
            this.gb_map.Controls.Add(this.kota_A);
            this.gb_map.Controls.Add(this.shapeContainer1);
            this.gb_map.Location = new System.Drawing.Point(29, 22);
            this.gb_map.Name = "gb_map";
            this.gb_map.Size = new System.Drawing.Size(586, 237);
            this.gb_map.TabIndex = 0;
            this.gb_map.TabStop = false;
            this.gb_map.Text = "Area Map";
            // 
            // kota_E
            // 
            this.kota_E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kota_E.Location = new System.Drawing.Point(245, 155);
            this.kota_E.Name = "kota_E";
            this.kota_E.Size = new System.Drawing.Size(75, 23);
            this.kota_E.TabIndex = 4;
            this.kota_E.Text = "Kota E";
            this.kota_E.UseVisualStyleBackColor = true;
            this.kota_E.Click += new System.EventHandler(this.kota_E_Click);
            // 
            // kota_D
            // 
            this.kota_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kota_D.Location = new System.Drawing.Point(139, 100);
            this.kota_D.Name = "kota_D";
            this.kota_D.Size = new System.Drawing.Size(75, 23);
            this.kota_D.TabIndex = 3;
            this.kota_D.Text = "Kota D";
            this.kota_D.UseVisualStyleBackColor = true;
            this.kota_D.Click += new System.EventHandler(this.kota_D_Click);
            // 
            // kota_C
            // 
            this.kota_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kota_C.Location = new System.Drawing.Point(245, 37);
            this.kota_C.Name = "kota_C";
            this.kota_C.Size = new System.Drawing.Size(75, 23);
            this.kota_C.TabIndex = 2;
            this.kota_C.Text = "Kota C";
            this.kota_C.UseVisualStyleBackColor = true;
            this.kota_C.Click += new System.EventHandler(this.kota_C_Click);
            // 
            // kota_B
            // 
            this.kota_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kota_B.Location = new System.Drawing.Point(27, 155);
            this.kota_B.Name = "kota_B";
            this.kota_B.Size = new System.Drawing.Size(75, 23);
            this.kota_B.TabIndex = 1;
            this.kota_B.Text = "Kota B";
            this.kota_B.UseVisualStyleBackColor = true;
            this.kota_B.Click += new System.EventHandler(this.kota_B_Click);
            // 
            // kota_A
            // 
            this.kota_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kota_A.Location = new System.Drawing.Point(27, 37);
            this.kota_A.Name = "kota_A";
            this.kota_A.Size = new System.Drawing.Size(75, 23);
            this.kota_A.TabIndex = 0;
            this.kota_A.Text = "Kota A";
            this.kota_A.UseVisualStyleBackColor = true;
            this.kota_A.Click += new System.EventHandler(this.kota_A_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape10,
            this.lineShape8,
            this.lineShape6,
            this.lineShape5,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(580, 218);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape10
            // 
            this.lineShape10.Name = "lineShape10";
            this.lineShape10.X1 = 98;
            this.lineShape10.X2 = 242;
            this.lineShape10.Y1 = 160;
            this.lineShape10.Y2 = 160;
            // 
            // lineShape8
            // 
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 317;
            this.lineShape8.X2 = 316;
            this.lineShape8.Y1 = 44;
            this.lineShape8.Y2 = 138;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 25;
            this.lineShape6.X2 = 23;
            this.lineShape6.Y1 = 43;
            this.lineShape6.Y2 = 139;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 209;
            this.lineShape5.X2 = 242;
            this.lineShape5.Y1 = 84;
            this.lineShape5.Y2 = 43;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 210;
            this.lineShape3.X2 = 243;
            this.lineShape3.Y1 = 106;
            this.lineShape3.Y2 = 141;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 97;
            this.lineShape2.X2 = 136;
            this.lineShape2.Y1 = 139;
            this.lineShape2.Y2 = 106;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 98;
            this.lineShape1.X2 = 136;
            this.lineShape1.Y1 = 42;
            this.lineShape1.Y2 = 84;
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.kotaTujuan);
            this.gb_status.Controls.Add(this.jarakTempuh);
            this.gb_status.Controls.Add(this.kotaAsal);
            this.gb_status.Location = new System.Drawing.Point(32, 269);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(242, 90);
            this.gb_status.TabIndex = 1;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status";
            // 
            // kotaTujuan
            // 
            this.kotaTujuan.AutoSize = true;
            this.kotaTujuan.Location = new System.Drawing.Point(6, 62);
            this.kotaTujuan.Name = "kotaTujuan";
            this.kotaTujuan.Size = new System.Drawing.Size(74, 13);
            this.kotaTujuan.TabIndex = 3;
            this.kotaTujuan.Text = "Kota Tujuan : ";
            // 
            // jarakTempuh
            // 
            this.jarakTempuh.AutoSize = true;
            this.jarakTempuh.Location = new System.Drawing.Point(6, 39);
            this.jarakTempuh.Name = "jarakTempuh";
            this.jarakTempuh.Size = new System.Drawing.Size(84, 13);
            this.jarakTempuh.TabIndex = 2;
            this.jarakTempuh.Text = "Jarak Tempuh : ";
            // 
            // kotaAsal
            // 
            this.kotaAsal.AutoSize = true;
            this.kotaAsal.Location = new System.Drawing.Point(6, 16);
            this.kotaAsal.Name = "kotaAsal";
            this.kotaAsal.Size = new System.Drawing.Size(61, 13);
            this.kotaAsal.TabIndex = 0;
            this.kotaAsal.Text = "Kota Asal : ";
            // 
            // FcR
            // 
            this.FcR.Location = new System.Drawing.Point(555, 331);
            this.FcR.Name = "FcR";
            this.FcR.Size = new System.Drawing.Size(75, 23);
            this.FcR.TabIndex = 2;
            this.FcR.Text = "reset";
            this.FcR.UseVisualStyleBackColor = true;
            this.FcR.Click += new System.EventHandler(this.FcR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "5";
            // 
            // btn_cari
            // 
            this.btn_cari.Location = new System.Drawing.Point(555, 303);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(75, 23);
            this.btn_cari.TabIndex = 3;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 362);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.FcR);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.gb_map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_map.ResumeLayout(false);
            this.gb_map.PerformLayout();
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_map;
        private System.Windows.Forms.Button kota_E;
        private System.Windows.Forms.Button kota_D;
        private System.Windows.Forms.Button kota_C;
        private System.Windows.Forms.Button kota_B;
        private System.Windows.Forms.Button kota_A;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape10;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.Label kotaTujuan;
        private System.Windows.Forms.Label jarakTempuh;
        private System.Windows.Forms.Label kotaAsal;
        private System.Windows.Forms.Button FcR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cari;
    }
}


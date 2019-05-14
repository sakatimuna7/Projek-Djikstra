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
            this.kota_A = new System.Windows.Forms.Button();
            this.kota_B = new System.Windows.Forms.Button();
            this.kota_C = new System.Windows.Forms.Button();
            this.kota_D = new System.Windows.Forms.Button();
            this.kota_E = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape10 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape11 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape12 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape13 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.kotaAsal = new System.Windows.Forms.Label();
            this.jarakTempuh = new System.Windows.Forms.Label();
            this.kotaTujuan = new System.Windows.Forms.Label();
            this.FcR = new System.Windows.Forms.Button();
            this.gb_map.SuspendLayout();
            this.gb_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_map
            // 
            this.gb_map.Controls.Add(this.button9);
            this.gb_map.Controls.Add(this.button8);
            this.gb_map.Controls.Add(this.button7);
            this.gb_map.Controls.Add(this.button6);
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
            // kota_C
            // 
            this.kota_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kota_C.Location = new System.Drawing.Point(245, 37);
            this.kota_C.Name = "kota_C";
            this.kota_C.Size = new System.Drawing.Size(75, 23);
            this.kota_C.TabIndex = 2;
            this.kota_C.Text = "Kota C";
            this.kota_C.UseVisualStyleBackColor = true;
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
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(360, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(488, 194);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(379, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(488, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape13,
            this.lineShape12,
            this.lineShape11,
            this.lineShape10,
            this.lineShape9,
            this.lineShape8,
            this.lineShape7,
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(580, 218);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 98;
            this.lineShape1.X2 = 136;
            this.lineShape1.Y1 = 42;
            this.lineShape1.Y2 = 84;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 97;
            this.lineShape2.X2 = 136;
            this.lineShape2.Y1 = 139;
            this.lineShape2.Y2 = 106;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 210;
            this.lineShape3.X2 = 243;
            this.lineShape3.Y1 = 106;
            this.lineShape3.Y2 = 141;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 99;
            this.lineShape4.X2 = 356;
            this.lineShape4.Y1 = 22;
            this.lineShape4.Y2 = 73;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 209;
            this.lineShape5.X2 = 242;
            this.lineShape5.Y1 = 84;
            this.lineShape5.Y2 = 43;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 25;
            this.lineShape6.X2 = 23;
            this.lineShape6.Y1 = 43;
            this.lineShape6.Y2 = 139;
            // 
            // lineShape7
            // 
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 315;
            this.lineShape7.X2 = 357;
            this.lineShape7.Y1 = 43;
            this.lineShape7.Y2 = 73;
            // 
            // lineShape8
            // 
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 317;
            this.lineShape8.X2 = 316;
            this.lineShape8.Y1 = 44;
            this.lineShape8.Y2 = 138;
            // 
            // lineShape9
            // 
            this.lineShape9.Name = "lineShape9";
            this.lineShape9.X1 = 317;
            this.lineShape9.X2 = 357;
            this.lineShape9.Y1 = 137;
            this.lineShape9.Y2 = 97;
            // 
            // lineShape10
            // 
            this.lineShape10.Name = "lineShape10";
            this.lineShape10.X1 = 98;
            this.lineShape10.X2 = 242;
            this.lineShape10.Y1 = 160;
            this.lineShape10.Y2 = 160;
            // 
            // lineShape11
            // 
            this.lineShape11.Name = "lineShape11";
            this.lineShape11.X1 = 316;
            this.lineShape11.X2 = 378;
            this.lineShape11.Y1 = 44;
            this.lineShape11.Y2 = 143;
            // 
            // lineShape12
            // 
            this.lineShape12.Name = "lineShape12";
            this.lineShape12.X1 = 316;
            this.lineShape12.X2 = 486;
            this.lineShape12.Y1 = 139;
            this.lineShape12.Y2 = 25;
            // 
            // lineShape13
            // 
            this.lineShape13.Name = "lineShape13";
            this.lineShape13.X1 = 316;
            this.lineShape13.X2 = 485;
            this.lineShape13.Y1 = 42;
            this.lineShape13.Y2 = 178;
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
            // kotaAsal
            // 
            this.kotaAsal.AutoSize = true;
            this.kotaAsal.Location = new System.Drawing.Point(6, 16);
            this.kotaAsal.Name = "kotaAsal";
            this.kotaAsal.Size = new System.Drawing.Size(61, 13);
            this.kotaAsal.TabIndex = 0;
            this.kotaAsal.Text = "Kota Asal : ";
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
            // kotaTujuan
            // 
            this.kotaTujuan.AutoSize = true;
            this.kotaTujuan.Location = new System.Drawing.Point(6, 62);
            this.kotaTujuan.Name = "kotaTujuan";
            this.kotaTujuan.Size = new System.Drawing.Size(74, 13);
            this.kotaTujuan.TabIndex = 3;
            this.kotaTujuan.Text = "Kota Tujuan : ";
            // 
            // FcR
            // 
            this.FcR.Location = new System.Drawing.Point(555, 331);
            this.FcR.Name = "FcR";
            this.FcR.Size = new System.Drawing.Size(75, 23);
            this.FcR.TabIndex = 2;
            this.FcR.Text = "Force Reset";
            this.FcR.UseVisualStyleBackColor = true;
            this.FcR.Click += new System.EventHandler(this.FcR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 362);
            this.Controls.Add(this.FcR);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.gb_map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_map.ResumeLayout(false);
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_map;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button kota_E;
        private System.Windows.Forms.Button kota_D;
        private System.Windows.Forms.Button kota_C;
        private System.Windows.Forms.Button kota_B;
        private System.Windows.Forms.Button kota_A;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape13;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape12;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape11;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape10;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.Label kotaTujuan;
        private System.Windows.Forms.Label jarakTempuh;
        private System.Windows.Forms.Label kotaAsal;
        private System.Windows.Forms.Button FcR;
    }
}


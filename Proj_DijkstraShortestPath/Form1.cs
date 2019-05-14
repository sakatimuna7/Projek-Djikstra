using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_DijkstraShortestPath
{
    public partial class Form1 : Form
    {
        string cek = "F"; //cek awal
        string F = "F";
        string D = "D";
        bool btnl = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kotaAsal.Text = "Kota Asal : ";
            jarakTempuh.Text = "Jarak Tempuh : ";
            kotaTujuan.Text = "Kota Tujuan : ";
        }

        private void kota_A_Click(object sender, EventArgs e)
        {

            if (cek == "F")
            {
                if (kotaAsal.Text == "Kota Asal : ")
                {
                    kotaAsal.Text += kota_A.Text;
                    cek = "D";
                    F = kota_A.Text;
                }
            }
            else if (cek == "D")
            {
                if (kotaTujuan.Text == "Kota Tujuan : ")
                {
                    D = kota_A.Text;
                    if (F == D && btnl == true)
                    {
                        kotaAsal.Text = "Kota Asal : ";
                        kotaTujuan.Text = "Kota Tujuan : ";
                        cek = "F";
                        btnl = false;
                    }
                    else
                    {
                        kotaTujuan.Text += kota_A.Text;
                        cek = "F";
                        btnl = true;
                    }
                }
            }
        }

        private void reset()
        {
            kotaAsal.Text = "Kota Asal : ";
            jarakTempuh.Text = "Jarak Tempuh : ";
            kotaTujuan.Text = "Kota Tujuan : ";
            cek = "F";
            F = "F";
            D = "D";
        }

        private void kota_B_Click(object sender, EventArgs e)
        {
            if (cek == "F")
            {
                if (kotaAsal.Text == "Kota Asal : ")
                {
                    kotaAsal.Text += kota_B.Text;
                    cek = "D";
                    F = kota_B.Text;
                }
            }
            else if (cek == "D")
            {
                if (kotaTujuan.Text == "Kota Tujuan : ")
                {
                    D = kota_B.Text;
                    if (F == D && btnl == true)
                    {
                        kotaAsal.Text = "Kota Asal : ";
                        kotaTujuan.Text = "Kota Tujuan : ";
                        cek = "F";
                        btnl = false;
                    }
                    else
                    {
                        kotaTujuan.Text += kota_B.Text;
                        cek = "F";
                        btnl = true;
                    }
                }
            }

        }

        private void FcR_Click(object sender, EventArgs e)
        {
            reset();
        }

    }
}

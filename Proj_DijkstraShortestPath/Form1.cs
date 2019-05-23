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
        int hasil;
        bool btnl = false;
        int[,] road = {
        {0,5,0,3,0,0},{5,0,0,4,8,0},{0,0,0,2,7,0},{3,4,2,0,5,0},{0,8,0,7,5,0}
        };
        int[] step;


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

        private void _cek(string kota)
        {
            if (cek == "F")
            {
                if (kotaAsal.Text == "Kota Asal : ")
                {
                    kotaAsal.Text += kota;
                    cek = "D";
                    F = kota;
                }
            }
            else if (cek == "D")
            {
                if (kotaTujuan.Text == "Kota Tujuan : ")
                {
                    D = kota;
                    if (F == D && btnl == true)
                    {
                        kotaAsal.Text = "Kota Asal : ";
                        kotaTujuan.Text = "Kota Tujuan : ";
                        cek = "F";
                        btnl = false;
                        
                    }
                    else
                    {
                        kotaTujuan.Text += kota;
                        cek = "F";
                        btnl = true;
                    }
                }
            }
        }
        void _Djikstra(string awal, string tujuan)
        {
            int a = int.Parse(_inisial(awal));
            int d = int.Parse(_inisial(tujuan));
            step = new int[d];
            int current = 0;
            for (int i = a; i <= 4; i++)
            {

                for (int j = 0; j <= 4; j++)
                {
                    if (road[i, j] < road[i, j + 1] && road[i, j] != 0 && road[i, j + 1] < road[i, j] && j > step[current])
                    {
                        step[current] = j;
                        current++;
                        i = j;
                        break;
                    }
                }
            }
            jumlah(step);
        }

        void jumlah(int[] jml)
        {
            foreach (var g in jml)
            {
                hasil += g;
            }

            jarakTempuh.Text += " " + hasil;
        }
        string _inisial(string data)
        {
            if (data == kota_A.Text) data = "0";
            if (data == kota_B.Text) data = "1";
            if (data == kota_C.Text) data = "2";
            if (data == kota_D.Text) data = "3";
            if (data == kota_E.Text) data = "4";

            return data;
        }
        private void reset()
        {
            kotaAsal.Text = "Kota Asal : ";
            jarakTempuh.Text = "Jarak Tempuh : ";
            kotaTujuan.Text = "Kota Tujuan : ";
            cek = "F";
            F = "F";
            D = "D";
            hasil = 0;
        }
        //================== void btn =============================
        private void kota_A_Click(object sender, EventArgs e)
        {
            _cek(kota_A.Text);

        }
        private void kota_B_Click(object sender, EventArgs e)
        {
            _cek(kota_B.Text);
        }

        private void FcR_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void kota_D_Click(object sender, EventArgs e)
        {
            _cek(kota_D.Text);
        }

        private void kota_E_Click(object sender, EventArgs e)
        {
            _cek(kota_E.Text);
        }

        private void kota_C_Click(object sender, EventArgs e)
        {
            _cek(kota_C.Text);
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            _Djikstra(F, D);
        }

    }
}

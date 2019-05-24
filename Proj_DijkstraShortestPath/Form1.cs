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
        int[,] road = {
        {0,5,0,3,0},
        {5,0,0,4,8},
        {0,0,0,2,4},
        {3,4,2,0,5},
        {0,8,4,5,0}
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kotaAsal.Text = "Kota Asal : ";
            jarakTempuh.Text = "Jarak Tempuh : ";
            kotaTujuan.Text = "Kota Tujuan : ";
            tempuh.Text = "Kota Yang Di Tempuh : ";
        }

        //function dijiksra alogaritm, mencari total jarak terpendek
        public static List<int> DijkstraAlgorithm(int[,] graph, int sourceNode, int destinationNode)
        {
            var n = graph.GetLength(0);

            var distance = new int[n];
            for (int i = 0; i < n; i++)
            {
                distance[i] = int.MaxValue;
            }

            distance[sourceNode] = 0;

            var used = new bool[n];
            var previous = new int?[n];

            while (true)
            {
                var minDistance = int.MaxValue;
                var minNode = 0;
                for (int i = 0; i < n; i++)
                {
                    if (!used[i] && minDistance > distance[i])
                    {
                        minDistance = distance[i];
                        minNode = i;
                    }
                }

                if (minDistance == int.MaxValue)
                {
                    break;
                }

                used[minNode] = true;

                for (int i = 0; i < n; i++)
                {
                    if (graph[minNode, i] > 0)
                    {
                        var shortestToMinNode = distance[minNode];
                        var distanceToNextNode = graph[minNode, i];

                        var totalDistance = shortestToMinNode + distanceToNextNode;

                        if (totalDistance < distance[i])
                        {
                            distance[i] = totalDistance;
                            previous[i] = minNode;
                        }
                    }
                }
            }

            if (distance[destinationNode] == int.MaxValue)
            {
                return null;
            }

            var path = new LinkedList<int>();
            int? currentNode = destinationNode;
            while (currentNode != null)
            {
                path.AddFirst(currentNode.Value);
                currentNode = previous[currentNode.Value];
            }

            return path.ToList();
        }

        // menghitung total jarak dan menyimpan jarak - jalan - tujuan
        public void PrintPath(int[,] graph, int sourceNode, int destinationNode)
        {
            var path = DijkstraAlgorithm(graph, sourceNode, destinationNode);

                int pathLength = 0;
                for (int i = 0; i < path.Count - 1; i++)
                {
                    pathLength += graph[path[i], path[i + 1]];
                }

                var formattedPath = string.Join("", path);
                _printscreen(pathLength, formattedPath);
        }

        //menampilkan hasil di printpath ke dalam form 
        private void _printscreen(int total, string path)
        {
            jarakTempuh.Text += "  "+total;

            foreach (var p in path)
            {
                string temp = p.ToString();
                temp = _reverse(temp);
                tempuh.Text += " -> " + temp;
            }

        }
        //mencek kota tujuan / kota asal
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

        // merubah nama kota menjadi angka index array
        string _inisial(string data)
        {
            if (data == kota_A.Text) data = "0";
            if (data == kota_B.Text) data = "1";
            if (data == kota_C.Text) data = "2";
            if (data == kota_D.Text) data = "3";
            if (data == kota_E.Text) data = "4";
            return data;
        }
        //merubah index array menjadi nama kota
        string _reverse(string data)
        {
            if (data == "0") data = kota_A.Text;
            if (data == "1") data = kota_B.Text;
            if (data == "2") data = kota_C.Text;
            if (data == "3") data = kota_D.Text;
            if (data == "4") data = kota_E.Text;
            return data;
        }
        //mereset
        private void reset()
        {
            kotaAsal.Text = "Kota Asal : ";
            jarakTempuh.Text = "Jarak Tempuh : ";
            kotaTujuan.Text = "Kota Tujuan : ";
            tempuh.Text = "Kota Yang Di Tempuh : ";
            cek = "F";
            F = "F";
            D = "D";
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
            int awal = int.Parse(_inisial(F));
            int tujuan = int.Parse(_inisial(D));
            PrintPath(road, awal, tujuan);
        }

        private void abaoutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abaotme a = new Abaotme();
            a.Show();
        }

    }
}

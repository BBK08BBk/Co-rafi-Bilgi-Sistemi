using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoğrafiBilgiSistemiProjesi1
{
    public partial class Form1 : Form
    {
        List<Arac> aracs;
        SqlConnection connection = new SqlConnection(@"Data Source=BBK\SQLEXPRESS;Initial Catalog=BBK;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            InitialezeMap();
            aracListesiniOlustur();
        }

        private void aracListesiniOlustur()
        {
            aracs = new List<Arac>();
            //VeriTabnından ADoNet ile veri çekilmesi

            try
            {
                connection.Open();
                string sqlcumle = "Select * from Araclar";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcumle,connection);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgwaraclar.DataSource = dt;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    aracs.Add(new Arac(dt.Rows[i][0].ToString(),
                                        dt.Rows[i][1].ToString(),
                                        dt.Rows[i][2].ToString(),
                                        dt.Rows[i][3].ToString(),
                                        new PointLatLng(Convert.ToDouble(dt.Rows[i][4].ToString()),
                                                        (Convert.ToDouble(dt.Rows[i][5].ToString())



                        ))));
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Veritabanı bağlanmasında sıkıntı var" + ex.Message);
            }
            finally
            {
                if (connection != null) {
                    connection.Close();
                }
                
            }
            araclarıgoster();
        }

        GMapOverlay gMapOverlay;

        private void InitialezeMap()
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new GMap.NET.PointLatLng(0, 0);
            map.Zoom = 4;
            map.MinZoom = 3;
            map.MaxZoom = 30;
            gMapOverlay = new GMapOverlay();
            map.Overlays.Add(gMapOverlay);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointLatLng pointLatLng = new PointLatLng(Convert.ToDouble(tbxenlem.Text),Convert.ToDouble(tbxBoylam.Text));
            GMarkerGoogle gMarker = new GMarkerGoogle(pointLatLng, GMarkerGoogleType.blue_dot);
            //GMapOverlay gMapOverlay = new GMapOverlay();
            gMarker.ToolTipText = "Lokasyon 1";
            //map.Overlays.Add(gMapOverlay);
            gMapOverlay.Markers.Add(gMarker);
            gMarker.Tag = 101;


            
            //Bir overlay yani katman oluşturmamız lazım harita üzerinde görüntülenecek tüm componentleri bu katmana ekliyeceğiz
            //ilk olarak da yeni oluşturduğumuz katmanı harita nesnemize eklemliyiz 
            //Markerı önce eklersiniz yanlış yere koyacaktır

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            map.Dispose();
            Application.Exit();
        }

        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            //int markerId = (int)item.Tag;
            //Console.WriteLine("Id: "+markerId+" olan markera tıklandı.");
            string secilenAracinPlakasi = (string)item.Tag;
            foreach (Arac arac in aracs)
            {
                if (secilenAracinPlakasi.Equals(arac.Plaka))
                {
                    tbx13.Text = secilenAracinPlakasi;
                    tbxtype.Text = arac.Type;
                    tbxto.Text = arac.To;
                    tbxfrom.Text = arac.From;
                    break;
                    
                }


            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PointLatLng pointLatLng2 = new PointLatLng(Convert.ToDouble(tbx2enlem.Text), Convert.ToDouble(tbx2boylam.Text));
            GMarkerGoogle gMarker2 = new GMarkerGoogle(pointLatLng2,GMarkerGoogleType.red_dot);
            map.Overlays.Add(gMapOverlay);
            gMarker2.Tag = 102;
            gMapOverlay.Markers.Add(gMarker2);
        }
        private void araclarıgoster()
        {
            foreach (Arac arac in aracs)
            {
                GMarkerGoogle gMarker2 = new GMarkerGoogle(arac.Konum, GMarkerGoogleType.orange_dot);
                gMarker2.Tag = arac.Plaka;
                gMarker2.ToolTipText = arac.ToString();
                gMapOverlay.Markers.Add(gMarker2);
                Console.WriteLine(arac.ToString());
            }
        }

        private void btnAracYerlestir_Click(object sender, EventArgs e)
        {
            araclarıgoster();
        }

    }
}

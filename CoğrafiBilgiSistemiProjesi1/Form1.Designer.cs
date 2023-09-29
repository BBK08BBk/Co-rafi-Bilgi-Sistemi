namespace CoğrafiBilgiSistemiProjesi1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxenlem = new System.Windows.Forms.TextBox();
            this.lblenlem = new System.Windows.Forms.Label();
            this.lblboylam = new System.Windows.Forms.Label();
            this.tbxBoylam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx2boylam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx2enlem = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAracYerlestir = new System.Windows.Forms.Button();
            this.tbxtype = new System.Windows.Forms.TextBox();
            this.tbxto = new System.Windows.Forms.TextBox();
            this.tbx13 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxfrom = new System.Windows.Forms.TextBox();
            this.dgwaraclar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwaraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(291, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(501, 510);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.map_OnMarkerClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Haritada Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxenlem
            // 
            this.tbxenlem.Location = new System.Drawing.Point(44, 56);
            this.tbxenlem.Name = "tbxenlem";
            this.tbxenlem.Size = new System.Drawing.Size(67, 20);
            this.tbxenlem.TabIndex = 2;
            // 
            // lblenlem
            // 
            this.lblenlem.AutoSize = true;
            this.lblenlem.Location = new System.Drawing.Point(3, 59);
            this.lblenlem.Name = "lblenlem";
            this.lblenlem.Size = new System.Drawing.Size(36, 13);
            this.lblenlem.TabIndex = 3;
            this.lblenlem.Text = "Enlem";
            // 
            // lblboylam
            // 
            this.lblboylam.AutoSize = true;
            this.lblboylam.Location = new System.Drawing.Point(134, 62);
            this.lblboylam.Name = "lblboylam";
            this.lblboylam.Size = new System.Drawing.Size(41, 13);
            this.lblboylam.TabIndex = 5;
            this.lblboylam.Text = "Boylam";
            // 
            // tbxBoylam
            // 
            this.tbxBoylam.Location = new System.Drawing.Point(175, 59);
            this.tbxBoylam.Name = "tbxBoylam";
            this.tbxBoylam.Size = new System.Drawing.Size(70, 20);
            this.tbxBoylam.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "!!Ondalık Kısmı Virgül İle Ayırınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "!!Ondalık Kısmı Virgül İle Ayırınız";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Boylam";
            // 
            // tbx2boylam
            // 
            this.tbx2boylam.Location = new System.Drawing.Point(175, 203);
            this.tbx2boylam.Name = "tbx2boylam";
            this.tbx2boylam.Size = new System.Drawing.Size(70, 20);
            this.tbx2boylam.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enlem";
            // 
            // tbx2enlem
            // 
            this.tbx2enlem.Location = new System.Drawing.Point(44, 200);
            this.tbx2enlem.Name = "tbx2enlem";
            this.tbx2enlem.Size = new System.Drawing.Size(67, 20);
            this.tbx2enlem.TabIndex = 8;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(85, 262);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 34);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "Haritada Göster";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Marker2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Marker1";
            // 
            // btnAracYerlestir
            // 
            this.btnAracYerlestir.Location = new System.Drawing.Point(44, 315);
            this.btnAracYerlestir.Name = "btnAracYerlestir";
            this.btnAracYerlestir.Size = new System.Drawing.Size(148, 39);
            this.btnAracYerlestir.TabIndex = 15;
            this.btnAracYerlestir.Text = "Araçları Yerleştir ";
            this.btnAracYerlestir.UseVisualStyleBackColor = true;
            this.btnAracYerlestir.Click += new System.EventHandler(this.btnAracYerlestir_Click);
            // 
            // tbxtype
            // 
            this.tbxtype.Location = new System.Drawing.Point(175, 502);
            this.tbxtype.Name = "tbxtype";
            this.tbxtype.Size = new System.Drawing.Size(70, 20);
            this.tbxtype.TabIndex = 17;
            // 
            // tbxto
            // 
            this.tbxto.Location = new System.Drawing.Point(175, 476);
            this.tbxto.Name = "tbxto";
            this.tbxto.Size = new System.Drawing.Size(70, 20);
            this.tbxto.TabIndex = 18;
            // 
            // tbx13
            // 
            this.tbx13.Location = new System.Drawing.Point(44, 502);
            this.tbx13.Name = "tbx13";
            this.tbx13.Size = new System.Drawing.Size(70, 20);
            this.tbx13.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Plaka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "To";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 468);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "From";
            // 
            // tbxfrom
            // 
            this.tbxfrom.Location = new System.Drawing.Point(44, 464);
            this.tbxfrom.Name = "tbxfrom";
            this.tbxfrom.Size = new System.Drawing.Size(70, 20);
            this.tbxfrom.TabIndex = 24;
            // 
            // dgwaraclar
            // 
            this.dgwaraclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwaraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwaraclar.Location = new System.Drawing.Point(835, 12);
            this.dgwaraclar.Name = "dgwaraclar";
            this.dgwaraclar.Size = new System.Drawing.Size(511, 503);
            this.dgwaraclar.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 580);
            this.Controls.Add(this.dgwaraclar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxfrom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx13);
            this.Controls.Add(this.tbxto);
            this.Controls.Add(this.tbxtype);
            this.Controls.Add(this.btnAracYerlestir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx2boylam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx2enlem);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblboylam);
            this.Controls.Add(this.tbxBoylam);
            this.Controls.Add(this.lblenlem);
            this.Controls.Add(this.tbxenlem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgwaraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxenlem;
        private System.Windows.Forms.Label lblenlem;
        private System.Windows.Forms.Label lblboylam;
        private System.Windows.Forms.TextBox tbxBoylam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx2boylam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx2enlem;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAracYerlestir;
        private System.Windows.Forms.TextBox tbxtype;
        private System.Windows.Forms.TextBox tbxto;
        private System.Windows.Forms.TextBox tbx13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxfrom;
        private System.Windows.Forms.DataGridView dgwaraclar;
    }
}


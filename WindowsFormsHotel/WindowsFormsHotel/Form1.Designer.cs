namespace WindowsFormsHotel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxHotels = new System.Windows.Forms.ListBox();
            this.lblHotels = new System.Windows.Forms.Label();
            this.lblHotelRooms = new System.Windows.Forms.Label();
            this.listBoxHotelRooms = new System.Windows.Forms.ListBox();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.lblClients = new System.Windows.Forms.Label();
            this.btnAddHotel = new System.Windows.Forms.Button();
            this.btnRemoveHotel = new System.Windows.Forms.Button();
            this.btnAddHotelRoom = new System.Windows.Forms.Button();
            this.btnRemoveHotelRoom = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnTotalClients = new System.Windows.Forms.Button();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveClient);
            this.groupBox1.Controls.Add(this.btnAddClient);
            this.groupBox1.Controls.Add(this.btnRemoveHotelRoom);
            this.groupBox1.Controls.Add(this.btnAddHotelRoom);
            this.groupBox1.Controls.Add(this.btnRemoveHotel);
            this.groupBox1.Controls.Add(this.btnAddHotel);
            this.groupBox1.Controls.Add(this.lblClients);
            this.groupBox1.Controls.Add(this.listBoxClients);
            this.groupBox1.Controls.Add(this.listBoxHotelRooms);
            this.groupBox1.Controls.Add(this.lblHotelRooms);
            this.groupBox1.Controls.Add(this.lblHotels);
            this.groupBox1.Controls.Add(this.listBoxHotels);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object List:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTotalPrice);
            this.groupBox2.Controls.Add(this.btnTotalClients);
            this.groupBox2.Controls.Add(this.btnSaveData);
            this.groupBox2.Controls.Add(this.dataGV);
            this.groupBox2.Location = new System.Drawing.Point(12, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1017, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atributte Table:";
            // 
            // listBoxHotels
            // 
            this.listBoxHotels.FormattingEnabled = true;
            this.listBoxHotels.Location = new System.Drawing.Point(7, 35);
            this.listBoxHotels.Name = "listBoxHotels";
            this.listBoxHotels.Size = new System.Drawing.Size(310, 277);
            this.listBoxHotels.TabIndex = 0;
            this.listBoxHotels.Click += new System.EventHandler(this.ListBoxHotels_Click);
            // 
            // lblHotels
            // 
            this.lblHotels.AutoSize = true;
            this.lblHotels.Location = new System.Drawing.Point(7, 20);
            this.lblHotels.Name = "lblHotels";
            this.lblHotels.Size = new System.Drawing.Size(40, 13);
            this.lblHotels.TabIndex = 1;
            this.lblHotels.Text = "Hotels:";
            // 
            // lblHotelRooms
            // 
            this.lblHotelRooms.AutoSize = true;
            this.lblHotelRooms.Location = new System.Drawing.Point(320, 20);
            this.lblHotelRooms.Name = "lblHotelRooms";
            this.lblHotelRooms.Size = new System.Drawing.Size(71, 13);
            this.lblHotelRooms.TabIndex = 2;
            this.lblHotelRooms.Text = "Hotel Rooms:";
            // 
            // listBoxHotelRooms
            // 
            this.listBoxHotelRooms.FormattingEnabled = true;
            this.listBoxHotelRooms.Location = new System.Drawing.Point(323, 35);
            this.listBoxHotelRooms.Name = "listBoxHotelRooms";
            this.listBoxHotelRooms.Size = new System.Drawing.Size(353, 277);
            this.listBoxHotelRooms.TabIndex = 3;
            this.listBoxHotelRooms.Click += new System.EventHandler(this.ListBoxHotelRooms_Click);
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.Location = new System.Drawing.Point(682, 35);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(328, 56);
            this.listBoxClients.TabIndex = 4;
            this.listBoxClients.Click += new System.EventHandler(this.ListBoxClients_Click);
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Location = new System.Drawing.Point(682, 20);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(41, 13);
            this.lblClients.TabIndex = 5;
            this.lblClients.Text = "Clients:";
            // 
            // btnAddHotel
            // 
            this.btnAddHotel.Location = new System.Drawing.Point(105, 319);
            this.btnAddHotel.Name = "btnAddHotel";
            this.btnAddHotel.Size = new System.Drawing.Size(75, 23);
            this.btnAddHotel.TabIndex = 6;
            this.btnAddHotel.Text = "Add";
            this.btnAddHotel.UseVisualStyleBackColor = true;
            this.btnAddHotel.Click += new System.EventHandler(this.BtnAddHotel_Click);
            // 
            // btnRemoveHotel
            // 
            this.btnRemoveHotel.Location = new System.Drawing.Point(105, 349);
            this.btnRemoveHotel.Name = "btnRemoveHotel";
            this.btnRemoveHotel.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveHotel.TabIndex = 7;
            this.btnRemoveHotel.Text = "Remove";
            this.btnRemoveHotel.UseVisualStyleBackColor = true;
            this.btnRemoveHotel.Click += new System.EventHandler(this.BtnRemoveHotel_Click);
            // 
            // btnAddHotelRoom
            // 
            this.btnAddHotelRoom.Location = new System.Drawing.Point(447, 319);
            this.btnAddHotelRoom.Name = "btnAddHotelRoom";
            this.btnAddHotelRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddHotelRoom.TabIndex = 8;
            this.btnAddHotelRoom.Text = "Add";
            this.btnAddHotelRoom.UseVisualStyleBackColor = true;
            this.btnAddHotelRoom.Click += new System.EventHandler(this.BtnAddHotelRoom_Click);
            // 
            // btnRemoveHotelRoom
            // 
            this.btnRemoveHotelRoom.Location = new System.Drawing.Point(447, 349);
            this.btnRemoveHotelRoom.Name = "btnRemoveHotelRoom";
            this.btnRemoveHotelRoom.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveHotelRoom.TabIndex = 9;
            this.btnRemoveHotelRoom.Text = "Remove";
            this.btnRemoveHotelRoom.UseVisualStyleBackColor = true;
            this.btnRemoveHotelRoom.Click += new System.EventHandler(this.BtnRemoveHotelRoom_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(800, 319);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 10;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(800, 349);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveClient.TabIndex = 11;
            this.btnRemoveClient.Text = "Remove";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.BtnRemoveClient_Click);
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(7, 20);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(1004, 102);
            this.dataGV.TabIndex = 0;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(243, 158);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveData.TabIndex = 1;
            this.btnSaveData.Text = "Save";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // btnTotalClients
            // 
            this.btnTotalClients.Location = new System.Drawing.Point(448, 158);
            this.btnTotalClients.Name = "btnTotalClients";
            this.btnTotalClients.Size = new System.Drawing.Size(75, 23);
            this.btnTotalClients.TabIndex = 2;
            this.btnTotalClients.Text = "TotalClients";
            this.btnTotalClients.UseVisualStyleBackColor = true;
            this.btnTotalClients.Click += new System.EventHandler(this.BtnTotalClients_Click);
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Location = new System.Drawing.Point(601, 158);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(75, 23);
            this.btnTotalPrice.TabIndex = 3;
            this.btnTotalPrice.Text = "TotalPrice";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.BtnTotalPrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnRemoveHotelRoom;
        private System.Windows.Forms.Button btnAddHotelRoom;
        private System.Windows.Forms.Button btnRemoveHotel;
        private System.Windows.Forms.Button btnAddHotel;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.ListBox listBoxHotelRooms;
        private System.Windows.Forms.Label lblHotelRooms;
        private System.Windows.Forms.Label lblHotels;
        private System.Windows.Forms.ListBox listBoxHotels;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTotalPrice;
        private System.Windows.Forms.Button btnTotalClients;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.DataGridView dataGV;
    }
}


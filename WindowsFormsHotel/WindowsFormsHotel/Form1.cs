using InformationExpertCreatorPatterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsHotel
{
    public partial class Form1 : Form
    {
        private List<Hotel> hotels;
        private string uri;
        public Form1()
        {
            InitializeComponent();
            hotels = new List<Hotel>();
            uri = "Hotels.xml";
        }

        private void GenerListBoxHotels()
        {
            listBoxHotels.Items.Clear();

            foreach(Hotel hotel in hotels)
            {
                listBoxHotels.Items.Add(hotel.Name);
            }
        }

        private void GenerDataGridHotel()
        {
            dataGV.Columns.Clear();
            dataGV.Columns.Add("HotelName", "Name");

            int hotelIndex = listBoxHotels.SelectedIndex;
            if(hotelIndex < 0)
            {
                return;
            }

            string[] hotelData = new string[]
            {
                hotels[hotelIndex].Name
            };

            dataGV.Rows.Add(hotelData);
        }
        
        private void GenerListBoxHotelRooms()
        {
            listBoxHotelRooms.Items.Clear();
            int hotelIndex = listBoxHotels.SelectedIndex;
            if(hotelIndex < 0)
            {
                return;
            }

            foreach(HotelRoom room in hotels[hotelIndex].Rooms)
            {
                listBoxHotelRooms.Items.Add(room.Number);
            }
        }

        private void GenerHotelRoomsDataGrid()
        {
            dataGV.Columns.Clear();
            dataGV.Columns.Add("HotelRoomNumber", "Number");
            dataGV.Columns.Add("HotelRoomType", "RoomType");
            dataGV.Columns.Add("HotelRoomPrice", "Price");

            int hotelIndex = listBoxHotels.SelectedIndex;
            int roomIndex = listBoxHotelRooms.SelectedIndex;

            if(hotelIndex < 0 || roomIndex < 0)
            {
                return;
            }

            string[] roomData = new string[]
            {
                hotels[hotelIndex].Rooms[roomIndex].Number,
                hotels[hotelIndex].Rooms[roomIndex].RoomType.ToString(),
                hotels[hotelIndex].Rooms[roomIndex].Price.ToString()
            };

            dataGV.Rows.Add(roomData);
        }

        private void GenerListBoxClients()
        {
            listBoxClients.Items.Clear();

            int hotelIndex = listBoxHotels.SelectedIndex;
            int roomIndex = listBoxHotelRooms.SelectedIndex;
            if(hotelIndex < 0 || roomIndex < 0)
            {
                return;
            }
            if(hotels[hotelIndex].Rooms[roomIndex].Client != null)
            {
                listBoxClients.Items.Add(hotels[hotelIndex].Rooms[roomIndex].Client.LastName);
            }            
        }

        private void GenerClientDataGrid()
        {
            dataGV.Columns.Clear();
            dataGV.Columns.Add("ClientFirstName", "FirstName");
            dataGV.Columns.Add("ClientLastName", "LastName");
            dataGV.Columns.Add("ClientAge", "Age");
            dataGV.Columns.Add("LivingDays", "Days");

            int hotelIndex = listBoxHotels.SelectedIndex;
            int roomIndex = listBoxHotelRooms.SelectedIndex;
            int clientIndex = listBoxClients.SelectedIndex;
            if(hotelIndex < 0 || roomIndex < 0 || clientIndex < 0)
            {
                return;
            }

            string[] clientData = new string[]
            {
                hotels[hotelIndex].Rooms[roomIndex].Client.FirstName,
                hotels[hotelIndex].Rooms[roomIndex].Client.LastName,
                hotels[hotelIndex].Rooms[roomIndex].Client.Age.ToString(),
                hotels[hotelIndex].Rooms[roomIndex].Days.ToString()
            };

            dataGV.Rows.Add(clientData);
        }

        private string[] GetDataFromGrid()
        {
            int columnCount = dataGV.ColumnCount;
            string[] dataArray = new string[columnCount];

            for(int i = 0; i< columnCount; i++)
            {
                dataArray[i] = dataGV.Rows[0].Cells[i].Value.ToString();
            }
            return dataArray;
        }

        private void DeserializeObjects()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Hotel>));
                XmlReader xmlReader = XmlReader.Create(uri);
                hotels = xmlSerializer.Deserialize(xmlReader) as List<Hotel>;
                xmlReader.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Hotels (Artsiom Shabolda Pir-161)";
            btnAddHotel.Enabled = false;
            btnRemoveHotel.Enabled = false;
            btnAddHotelRoom.Enabled = false;
            btnRemoveHotelRoom.Enabled = false;
            btnAddClient.Enabled = false;
            btnRemoveClient.Enabled = false;
            DeserializeObjects();
            GenerListBoxHotels();
        }

        private void ListBoxHotels_Click(object sender, EventArgs e)
        {
            GenerDataGridHotel();
            GenerListBoxHotels();            
            btnAddHotel.Enabled = true;
            btnRemoveHotel.Enabled = true;
            btnAddHotelRoom.Enabled = false;
            btnRemoveHotelRoom.Enabled = false;
            btnAddClient.Enabled = false;
            btnRemoveClient.Enabled = false;
        }
        private void ListBoxHotelRooms_Click(object sender, EventArgs e)
        {
            GenerHotelRoomsDataGrid();
            GenerListBoxHotelRooms();
            btnAddHotelRoom.Enabled = true;
            btnRemoveHotelRoom.Enabled = true;
            btnAddClient.Enabled = false;
            btnRemoveClient.Enabled = false;
        }
        private void ListBoxClients_Click(object sender, EventArgs e)
        {
            GenerClientDataGrid();
            GenerListBoxClients();
            btnAddClient.Enabled = true;
            btnRemoveClient.Enabled = true;
        }

        private void BtnAddHotel_Click(object sender, EventArgs e)
        {
            string[] hotelData = GetDataFromGrid();

            hotels.Add(new Hotel(hotelData[0]));
            listBoxHotelRooms.Items.Clear();
            listBoxHotels.Items.Clear();
            GenerListBoxHotels();
        }       
        private void BtnRemoveHotel_Click(object sender, EventArgs e)
        {
            int hotelIndex = listBoxHotels.SelectedIndex;
            if(hotelIndex < 0)
            {
                return;
            }

            hotels.RemoveAt(hotelIndex);
            listBoxHotelRooms.Items.Clear();
            listBoxHotels.Items.Clear();
            GenerListBoxHotels();
        }

        private void BtnAddHotelRoom_Click(object sender, EventArgs e)
        {
            int hotelIndex = listBoxHotels.SelectedIndex;
            if(hotelIndex < 0)
            {
                return;
            }

            string[] roomData = GetDataFromGrid();

            string[] types = Enum.GetNames(typeof(HotelRoomType));

            HotelRoomType roomType = HotelRoomType.Single;
            foreach(var type in types)
            {
                if(roomData[1] == type)
                {
                    Enum.TryParse(roomData[1], out roomType);
                    break;
                }
            }

            hotels[hotelIndex].AddHotelRoom(roomData[0], roomType, Convert.ToDouble(roomData[2]));
        }
        private void BtnRemoveHotelRoom_Click(object sender, EventArgs e)
        {
            int hotelIndex = listBoxHotels.SelectedIndex;
            int roomIndex = listBoxHotelRooms.SelectedIndex;
            if(hotelIndex < 0 || roomIndex < 0)
            {
                return;
            }

            hotels[hotelIndex].RemoveHotelRoom(roomIndex);
            listBoxClients.Items.Clear();
            GenerListBoxHotelRooms();
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                int hotelIndex = listBoxHotels.SelectedIndex;
                int roomIndex = listBoxHotelRooms.SelectedIndex;
                if(hotelIndex < 0 || roomIndex < 0)
                {
                    return;
                }

                string[] clientData = GetDataFromGrid();

                hotels[hotelIndex].Rooms[roomIndex].AddClient(
                    clientData[0], clientData[1], 
                    Convert.ToInt32(clientData[2]), Convert.ToInt32(clientData[3]));
                GenerListBoxClients();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Client is living here!");
            }
        }

        private void BtnRemoveClient_Click(object sender, EventArgs e)
        {
            int hotelIndex = listBoxHotels.SelectedIndex;
            int roomIndex = listBoxHotelRooms.SelectedIndex;
            int clientIndex = listBoxClients.SelectedIndex;
            if(hotelIndex < 0 || roomIndex < 0 || clientIndex < 0)
            {
                return;
            }

            hotels[hotelIndex].Rooms[roomIndex].RemoveClient();
            GenerListBoxClients();
        }

        private void BtnSaveData_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Hotel>));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter xmlWriter = XmlWriter.Create(uri, settings);
            xmlSerializer.Serialize(xmlWriter, hotels);
            xmlWriter.Close();
        }

        private void BtnTotalClients_Click(object sender, EventArgs e)
        {
            int hotelIndex = listBoxHotels.SelectedIndex;
            if(hotelIndex < 0)
            {
                return;
            }

            MessageBox.Show(string.Format("Total clients of hotel {0}: {1}",
                                          hotels[hotelIndex].Name, hotels[hotelIndex].GetTotalClients()), 
                                          "Result");
        }

        private void BtnTotalPrice_Click(object sender, EventArgs e)
        {
            int hotelIndex = listBoxHotels.SelectedIndex;
            if(hotelIndex < 0)
            {
                return;
            }

            MessageBox.Show(string.Format("Total price of hotel {0}: {1}",
                                          hotels[hotelIndex].Name, hotels[hotelIndex].GetTotalPrice()),
                                          "Result");
        }
    }
}

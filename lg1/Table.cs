using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lg1
{
    public partial class Table : Form
    {
        private OleDbConnection connect;
        private int typeTable;
        //имя таблицы
        private string nameTable= "";

        //запрос на поиск
        private string sqlSearch = "";
        //запрос на замену цены продукта
        private string sqlRePriceWhere = "";
        private string sqlRePriceUpdate = "";
        public Table(int typeTable)
        {
            this.typeTable = typeTable;
            InitializeComponent();
            connect = new OleDbConnection(System.Configuration.ConfigurationManager.
            ConnectionStrings["lg1.Properties.Settings.DBConnectionString"].ConnectionString);
            connect.Open();
        }

        private void Table_Load(object sender, EventArgs e)
        {

            updateDB();

        }
        //Обновление бд, установка запросов в зависимости от бд
        private void updateDB()
        {

            switch (typeTable)
            {
                case 1:
                    this.ssd_накопительTableAdapter.Fill(this.кУРСАЧ1DataSet._ssd_накопитель);
                    dataGridView1.DataSource = ssdнакопительBindingSource;
                    sqlSearch = "SELECT наименование, характеристики, цена FROM [ssd-накопитель] WHERE наименование Like ";
                    sqlRePriceWhere = "UPDATE [ssd-накопитель] SET [ssd-накопитель].цена = ";
                    sqlRePriceUpdate = "WHERE [ssd-накопитель].наименование LIKE ";
                    nameTable = "[ssd-накопитель]";



                    break;
                case 2:
                    this.жесткие_дискиTableAdapter.Fill(this.кУРСАЧ1DataSet.жесткие_диски);
                    dataGridView1.DataSource = жесткиеДискиBindingSource;
                    sqlSearch = "SELECT[жесткие диски].наименование, [жесткие диски].характеристики, [жесткие диски].цена FROM [жесткие диски] WHERE[жесткие диски].наименование Like ";
                    sqlRePriceWhere = "UPDATE [жесткие диски] SET[жесткие диски].цена = ";
                    sqlRePriceUpdate = "WHERE [жесткие диски].наименование LIKE ";
                    nameTable = "[жесткие диски]";
                    break;
                case 3:
                    this.блоки_питанияTableAdapter.Fill(this.кУРСАЧ1DataSet.блоки_питания);
                    dataGridView1.DataSource = блокиПитанияBindingSource;
                    sqlSearch = "SELECT[блоки питания].наименование, [блоки питания].характеристики, [блоки питания].цена FROM[блоки питания] WHERE [блоки питания].наименование  Like ";
                    sqlRePriceWhere = "UPDATE [блоки питания] SET[блоки питания].цена = ";


                    sqlRePriceUpdate = "WHERE [блоки питания].наименование) LIKE ";
                    nameTable = "[блоки питания]";
                    break;
                case 4:
                    this.видеокартыTableAdapter.Fill(this.кУРСАЧ1DataSet.видеокарты);
                    dataGridView1.DataSource = видеокартыBindingSource;
                    sqlSearch = "SELECT видеокарты.наименование, видеокарты.характеристики, видеокарты.цена FROM видеокарты WHERE видеокарты.наименование Like ";
                    sqlRePriceWhere = "UPDATE видеокарты SET видеокарты.цена = ";
                    sqlRePriceUpdate = "WHERE видеокарты.наименование LIKE ";


                    nameTable = "видеокарты";
                    break;
                case 5:
                    this.звуковые_картыTableAdapter.Fill(this.кУРСАЧ1DataSet.звуковые_карты);
                    dataGridView1.DataSource = звуковыеКартыBindingSource;
                    sqlSearch = "SELECT[звуковые карты].наименование, [звуковые карты].характеристики, [звуковые карты].цена FROM[звуковые карты] WHERE [звуковые карты].наименовани Like ";
                    sqlRePriceWhere = "UPDATE [звуковые карты] SET[звуковые карты].цена = ";
                    sqlRePriceUpdate = "WHERE[звуковые карты].наименование LIKE ";


                    nameTable = "[звуковые карты]";
                    break;
                case 6:
                    this.материнские_платыTableAdapter.Fill(this.кУРСАЧ1DataSet.материнские_платы);
                    dataGridView1.DataSource = материнскиеПлатыBindingSource;
                    sqlSearch = "SELECT[материнские платы].наименование, [материнские платы].характеристики, [материнские платы].цена FROM[материнские платы] WHERE [материнские платы].наименование Like ";
                    sqlRePriceWhere = "UPDATE [материнские платы] SET[материнские платы].цена = ";
                    sqlRePriceUpdate = "WHERE [материнские платы].наименование LIKE ";


                    nameTable = "[материнские платы]";
                    break;
                case 7:
                    this.оперативная_памятьTableAdapter.Fill(this.кУРСАЧ1DataSet.оперативная_память);
                    dataGridView1.DataSource = оперативнаяПамятьBindingSource;
                    sqlSearch = "SELECT[оперативная память].наименование, [оперативная память].характеристики, [оперативная память].цена FROM[оперативная память] WHERE [оперативная память].наименование Like ";
                    sqlRePriceWhere = "UPDATE[оперативная память] SET[оперативная память].цена = ";
                    sqlRePriceUpdate = "WHERE [оперативная память].наименование) LIKE ";

                    nameTable = "[оперативная память]";

                    break;
                case 8:
                    this.процессоорыTableAdapter.Fill(this.кУРСАЧ1DataSet.процессооры);
                    dataGridView1.DataSource = процессоорыBindingSource;
                    sqlSearch = "SELECT процессооры.наименование, процессооры.характеристики, процессооры.цена FROM процессооры WHERE процессооры.наименование Like ";
                    sqlRePriceWhere = "UPDATE процессооры SET процессооры.цена = ";
                    sqlRePriceUpdate = "WHERE процессооры.наименование LIKE ";

                    nameTable = "процессооры";
                    break;
                case 9:
                    this.кулерыTableAdapter.Fill(this.кУРСАЧ1DataSet.кулеры);
                    dataGridView1.DataSource = кулерыBindingSource;
                    sqlSearch = "SELECT кулеры.наименование, кулеры.характеристики, кулеры.цена FROM кулеры WHERE кулеры.наименование Like ";
                    sqlRePriceWhere = "UPDATE кулеры SET кулеры.цена = ";

                    sqlRePriceUpdate = "WHERE кулеры.наименование LIKE ";
                    nameTable = "кулеры";

                    break;
                case 10:
                    this.система_водяного_охлажденияTableAdapter.Fill(this.кУРСАЧ1DataSet.Система_водяного_охлаждения);
                    dataGridView1.DataSource = системаВодяногоОхлажденияBindingSource;
                    sqlSearch = "SELECT[Система водяного охлаждения].наименование, [Система водяного охлаждения].характеристики, [Система водяного охлаждения].цена FROM[Система водяного охлаждения] " +
                        "WHERE [Система водяного охлаждения].наименование Like ";
                    sqlRePriceWhere = "UPDATE[Система водяного охлаждения] SET [Система водяного охлаждения].цена = ";
                    sqlRePriceUpdate = "WHERE [Система водяного охлаждения].наименование LIKE ";

                    nameTable = "[Система водяного охлаждения]";
                    break;
                case 11:
                    this.готовые_сборки_ПКTableAdapter.Fill(this.кУРСАЧ1DataSet.Готовые_сборки_ПК);
                    dataGridView1.DataSource = готовыеСборкиПКBindingSource;
                    groupBox1.Hide();
                    groupBox2.Hide();
                    nameTable = "[Готовые сборки пк]";
                     
                    break;
                case 12:
                    this.игровыеTableAdapter.Fill(this.кУРСАЧ1DataSet.игровые);
                    dataGridView1.DataSource = игровыеBindingSource;
                    sqlSearch = "SELECT игровые.наименование, игровые.наполнение, игровые.цена FROM игровые WHERE игровые.наименование  Like ";
                    sqlRePriceWhere = "UPDATE игровые SET игровые.цена = ";
                    sqlRePriceUpdate = "WHERE игровые.наименование LIKE ";

                    nameTable = "игровые.наименование";
                    break;
                case 13:
                    this.средниеTableAdapter.Fill(this.кУРСАЧ1DataSet.средние);
                    dataGridView1.DataSource = средниеBindingSource;
                    sqlSearch = "SELECT средние.наименование, средние.наполнение, средние.цена FROM средние WHERE средние.наименование Like ";
                    sqlRePriceWhere = "UPDATE средние SET средние.цена =  ";
                    sqlRePriceUpdate = "WHERE средние.наименование LIKE ";
                    nameTable = "средние";
                    break;
                case 14:
                    this.офисныеTableAdapter.Fill(this.кУРСАЧ1DataSet.офисные);
                    dataGridView1.DataSource = офисныеBindingSource;
                    sqlSearch = "SELECT офисные.наименование, офисные.наполнение, офисные.цена FROM офисные WHERE офисные.наименование Like ";
                    sqlRePriceWhere = "UPDATE офисные SET офисные.цена = ";
                    sqlRePriceUpdate = "WHERE офисные.наименование LIKE ";
                    nameTable = "офисные";

                    break;
            }
            MessageBox.Show("База загружена");

        }

        private void Table_FormClosed(object sender, FormClosedEventArgs e)
        {

            connect.Close();
          
        }


 
       
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable search = new DataTable();
            string name = textBox1.Text.ToString();
            string sqlCommand = sqlSearch + "'%"+name+"%'";
            
            OleDbCommand command = new OleDbCommand(sqlCommand,connect);

  

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            search.Clear();
            adapter.Fill(search);
            dataGridView1.DataSource = search;
        }

 

        private void button3_Click(object sender, EventArgs e)
        {
            this.updateDB();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.ToString();
            int price = Convert.ToInt32(textBox3.Text);
            string sqlCommand = sqlRePriceWhere + " " + price + " "+ sqlRePriceUpdate+"'%" + name + "%'";
            OleDbCommand command = new OleDbCommand(sqlCommand, connect);
            int i = command.ExecuteNonQuery();
            MessageBox.Show("Обновлено строк: "+ i.ToString());
            updateDB();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteForm f1 = new DeleteForm();
            f1.Owner = this;
            f1.ShowDialog();
        }
        public void DeletRow(string id)
        {

            string sqlCommand = "DELETE FROM " + nameTable + "WHERE id = "+id;
            OleDbCommand command = new OleDbCommand(sqlCommand, connect);
            int i = command.ExecuteNonQuery();
            MessageBox.Show("Обновлено строк: " + i.ToString());
            updateDB();
        }
        public void AddRow(string id, string name, string coar, string price)
        {

            string sqlCommand = "INSERT INTO " + nameTable + "VALUES( " + id + ", '" +name +" '" + ", '" +coar +" '," + price.ToString() + " )";
            OleDbCommand command = new OleDbCommand(sqlCommand, connect);
            int i = command.ExecuteNonQuery();
            MessageBox.Show("Обновлено строк: " + i.ToString());
            updateDB();
        }
        private void button6_Click(object sender, EventArgs e)
        {
  
            AddRow f1 = new AddRow();
            f1.Owner = this;
            f1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            EditForm f1 = new EditForm(
                dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString(),
               dataGridView1[1, dataGridView1.SelectedRows[0].Index].Value.ToString(),
                dataGridView1[2, dataGridView1.SelectedRows[0].Index].Value.ToString(),
                dataGridView1[3, dataGridView1.SelectedRows[0].Index].Value.ToString());
            f1.Owner = this;
            f1.ShowDialog();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        // Код кнопки "Заголовок"
        private void buttonTab1_Click(object sender, EventArgs e)
        {
            openViewTable(
                WorkOfDatabaseController.tabOrderInfo, // Техническое имя таблицы "Заголовок"
                WorkOfDatabaseController.tabOrderInfoName // Имя таблицы "Заголовок"
            );
        }

        // Код кнопки "Позиции"
        private void buttonTab2_Click(object sender, EventArgs e)
        {
            openViewTable(
                WorkOfDatabaseController.tabPositionInfo, // Техническое имя таблицы "Позиции"
                WorkOfDatabaseController.tabPositionInfoName // Имя таблицы "Позиции"
            );
        }

        // Функция вызова окна отображения данных и работы с ними по выбранной таблицы 
        private void openViewTable(string TableNameDb, string TableName)
        {
            // Создаем объект отображения формы с передачей параметров
            TableViewer view = new TableViewer(
                TableName,      // Имя таблицы
                TableNameDb     // Техническое имя таблицы
            );

            view.Owner = this;  // Указываем владельца созданной формы текущую формы
            view.Show();        // Отображаем форму
        }
    }
}


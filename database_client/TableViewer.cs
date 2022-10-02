using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Client
{
    public partial class TableViewer : Form
    {
        string TableNameDb; // Технической имя таблицы
        DataTable ViewDataTable; // Переменная таблицы для хранения данных

        public TableViewer(string _TableName, string _TableNameDb)
        {
            InitializeComponent();

            this.Text = "Просмотр таблицы: " + _TableName; // Устанавливаем наименование формы в зависимости от таблицы
            TableNameDb = _TableNameDb; // Записываем в глобальную переменную техническое имя таблицы
            FillDataTable(); // Вызываем функцию настройки экранной таблицы и заполнения данными
            // Настраиваем поля отвечающие за поиск
            SetRadioButtons();
        }

        // Функция настройки экранной таблицы и заполнения данными
        public void FillDataTable(string Where = "")
        {
            // Делаем запрос к базе данных для получения таблицы с данными
            ViewDataTable = WorkOfDatabaseController.GetTable(TableNameDb, "*", Where);
            // Устанавливаем источник данных экранной таблицы
            dataGridView1.DataSource = ViewDataTable;
            // Настраиваем поля экранной таблицы
            SetTableColumnName();
            // Обновляем экранную таблицу
            dataGridView1.Update();
        }

        // Функция настройки полей экранной таблицы
        public void SetTableColumnName()
        {
            // Кейс в зависмости от технического имени таблицы
            // Для каждого технического имени столбца выставляем более понятное наименование при отображении экранной таблицы
            // Для ключевых полей выставляем параметр ReadOnly - только для чтения
            switch (TableNameDb)
            {
                case WorkOfDatabaseController.tabOrderInfo:
                    dataGridView1.Columns["number_order"].HeaderText = "Номер заказа ";
                    dataGridView1.Columns["number_order"].ReadOnly = true;

                    dataGridView1.Columns["fabricator"].HeaderText = "Цех-производитель";
                    dataGridView1.Columns["start_date"].HeaderText = "Дата начала";
                    dataGridView1.Columns["end_date"].HeaderText = "Дача окончания";
                    dataGridView1.Columns["status"].HeaderText = "Статус";
                    break;
                case WorkOfDatabaseController.tabPositionInfo:
                    dataGridView1.Columns["numder_position"].HeaderText = "Номер позиции заказа";
                    dataGridView1.Columns["numder_position"].ReadOnly = true;

                    dataGridView1.Columns["order_info_id"].HeaderText = "Номер заказа";
                    dataGridView1.Columns["steel_grade"].HeaderText = "Марка стали";
                    dataGridView1.Columns["diameter"].HeaderText = "Диаметр";
                    dataGridView1.Columns["wall"].HeaderText = "Стенка";
                    dataGridView1.Columns["volume"].HeaderText = "Объем позиции заказа";
                    dataGridView1.Columns["unit"].HeaderText = "Единица измерения";
                    dataGridView1.Columns["status"].HeaderText = "Статус";
                    break;
            }
        }

        public void SetRadioButtons()
        {
            switch (TableNameDb)
            {
                case WorkOfDatabaseController.tabOrderInfo:
                    this.radioButton1.Checked = true;
                    this.radioButton2.Enabled = false;
                    this.radioButton3.Enabled = false;
                    this.radioButton4.Enabled = false;
                    break;
                case WorkOfDatabaseController.tabPositionInfo:
                    this.radioButton1.Enabled = false;
                    this.radioButton2.Checked = true;
                    this.radioButton3.Enabled = true;
                    this.radioButton4.Enabled = true;
                    break;
            }
        }

            // Событие изменения ячейки экранной таблицы (dataGridView1)
        private void UpdateCell(object sender, DataGridViewCellEventArgs e)
        {
            // Блок try .. catch для обработки ошибок в выполнении запроса
            try
            {
                // Если столбец изменения больше чем 0
                // и строка изменения больше или равна 0 
                // и цвет строки не равен "Светло-зеленый", т.е. это не созданнная строка
                if (e.ColumnIndex > 0 && e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.GreenYellow)
                {
                    // Вызов функции для отправки запроса по изменению строки в базе данных
                    WorkOfDatabaseController.UpdateValueTable(
                        TableNameDb,                                // Техническое имя таблицы
                        dataGridView1.Columns[1].Name,              // Техническое имя ключевого столбца
                        dataGridView1.Columns[e.ColumnIndex].Name,  // Техническое имя изменяемого столбца
                        dataGridView1[1, e.RowIndex],               // Значение ячейки ключевого столбца
                        dataGridView1[e.ColumnIndex, e.RowIndex]    // Значение ячейки изменяемого столбца
                    );
                }
            }
            catch (MySqlException ex) // Если возникла ошибка при выполнении запроса, выводим на экран
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        // Код кнопки "Удалить выбранные строки"
        private void DeleteRows(object sender, EventArgs e)
        {
            // Цикл по строка экранной таблицы
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // Если чекбокс первого столбца у строки в активном положении
                if ((bool)dataGridView1[0, i].EditedFormattedValue == true)
                {
                    // Блок try .. catch для обработки ошибок в выполнении запроса
                    try
                    {
                        // Вызов функции для отправки запроса по удалению строки из базы данных
                        WorkOfDatabaseController.DeleteRow(
                            TableNameDb,                    // Техническое имя таблицы
                            dataGridView1.Columns[1].Name,  // Техническое имя ключевого столбца
                            dataGridView1[1, i]             // Значение ячейки ключевого столбца
                        );
                        // Удаляем запись из экранной таблицы
                        ViewDataTable.Rows.RemoveAt(i);
                        // Уменьшаем счетчик на один, так как при удалении строк стало меньше
                        i--;                                
                    }
                    catch (MySqlException ex) // Если возникла ошибка при выполнении запроса, выводим на экран
                    {
                        MessageBox.Show(ex.Message, "Ошибка!");
                    }
                }
            }
        }

        // Код кнопки "Добавить строку"
        private void AddRows(object sender, EventArgs e)
        {
            // Добавляем пустую строку в таблицу с данными
            ViewDataTable.Rows.Add();
            // Обновляем экранную таблицу
            dataGridView1.Update();
            // Выставляем цвет строки "Светло-зеленый"
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.GreenYellow;
            // Цикл по ячейкам строки
            foreach (DataGridViewCell cell in dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells)
            {
                // Если для неё стоял режим только для чтения
                if (cell.ReadOnly == true)
                {
                    // Разрешаем изменение ключевого поля, т.к. это создание строки и ключ можно определить самому
                    cell.ReadOnly = false;
                }
            }
        }

        // Код кнопки "Сохранить новые строки"
        private void saveNewRowsButton_Click(object sender, EventArgs e)
        {
            // Булева переменная для контроля ошибок
            bool isError = false;
            // Цикл по строкам экранной таблицы
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string fields = ""; // Переменная для формирования строки технических имен столбцов для вставки данных
                string values = ""; // Переменная для формирования строки значений ячеек строки для вставки данных
                // Если цвет строки "Светло-зеленый", обрабатываем
                if (row.DefaultCellStyle.BackColor == Color.GreenYellow)
                {
                    // Цикл по ячейкам строки
                    for (int i = 1; i < row.Cells.Count; i++)
                    {
                        // Если это последний по счёте столбец/значение запятую в конце добавлять не нужно
                        if (i == row.Cells.Count - 1)
                        {
                            // Склеиваем технические имена столбцов таблицы
                            fields += dataGridView1.Columns[row.Cells[i].ColumnIndex].Name;
                            // Склеиваем значения ячеек строки
                            values += '\'' + row.Cells[i].Value.ToString() + '\'';
                        }
                        else
                        {
                            // Склеиваем технические имена столбцов таблицы и добавляем в конце запятую
                            fields += dataGridView1.Columns[row.Cells[i].ColumnIndex].Name + ",";
                            // Склеиваем значения ячеек строки и добавляем в конце запятую
                            values += '\'' + row.Cells[i].Value.ToString() + '\'' + ",";
                        }
                    }
                    // Блок try .. catch для обработки ошибок в выполнении запроса
                    try
                    {
                        // Вызов функции для отправки запроса по добавлению строки в базу данных
                        WorkOfDatabaseController.InsertRow(
                            TableNameDb,    // Техническое имя таблицы
                            fields,         // Строка технических имен столбцов для вставки данных
                            values          // Строка значений ячеек строки для вставки данных
                        );
                    }
                    catch (MySqlException ex) // Если возникла ошибка при выполнении запроса, выводим на экран
                    {
                        isError = true; // Переменная ошибки становится true
                        MessageBox.Show(ex.Message, "Ошибка!");
                    }
                }
            } // Если ошибок нет, перерисовываем экранную таблицу
            if (!isError)
            {
                FillDataTable();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string Where = "";
            if ( this.textBox1.Text != "") {
                if (radioButton1.Checked) {
                    Where = string.Format("WHERE fabricator LIKE '%{0}%'", this.textBox1.Text);
                } 
                else if (radioButton2.Checked)
                {
                    Where = string.Format("WHERE steel_grade LIKE '%{0}%'", this.textBox1.Text);
                } 
                else if (radioButton3.Checked)
                {
                    Where = string.Format("WHERE diameter LIKE '%{0}%'", this.textBox1.Text);
                } 
                else if (radioButton4.Checked)
                {
                    Where = string.Format("WHERE wall LIKE '%{0}%'", this.textBox1.Text);
                }
            }
            // Блок try .. catch для обработки ошибок в выполнении запроса
            try
            {
                FillDataTable(Where);
            }
            catch (MySqlException ex) // Если возникла ошибка при выполнении запроса, выводим на экран
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }
    }
}

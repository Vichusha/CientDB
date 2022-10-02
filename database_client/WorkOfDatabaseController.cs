using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;

// Класс по работе с запросами к базе данных

namespace Client
{
    static class WorkOfDatabaseController
    {
        // Некоторые константы технических имен таблиц и просто имен таблиц для отображения
        public const string tabOrderInfo = "order_info";
        public const string tabOrderInfoName = "Заголовок";
        
        public const string tabPositionInfo = "position_info";
        public const string tabPositionInfoName = "Позиции";

        // Строка подключения к базе данных
        const string ConnInfo = "server=localhost;user=root;database=mydb;password=root;";
        // Объект для подключения к базе данных
        static MySqlConnection MySQLConnection;

        // Функция открытия соединения к базе данных
        static private void createOpenConnect()
        {
            MySQLConnection = new MySqlConnection(ConnInfo);
            MySQLConnection.Open();
        }

        // Функция закрытия соединения
        static private void closeConnect()
        {
            MySQLConnection.Close();
        }

        // Функция получения данных таблицы (параметр Where - необязательный)
        static public DataTable GetTable(string TableName, string Fields, string Where = "")
        {
            // Открываем соединение к базе данных
            createOpenConnect(); 
            // Создаем таблицу для записи результата запроса
            DataTable buf = new DataTable();
            MySqlDataAdapter MySQLDataAdapter = new MySqlDataAdapter("SELECT " + Fields + " FROM " + TableName + " " + Where, MySQLConnection);
            MySQLDataAdapter.Fill(buf);
            // Закрываем соединение
            closeConnect();
            // Возвращаем таблицу с результатом запроса
            return buf;
        }

        static public void UpdateValueTable(string TableName, string KeyField, string ChangeField, DataGridViewCell KeyValue, DataGridViewCell ChangeValue)
        {
            // Открываем соединение к базе данных
            createOpenConnect();
            // Формируем запрос к базе данных
            string sql = string.Format("UPDATE " + TableName + " SET " + ChangeField + " = @value WHERE " + KeyField + " =@id");
            MySqlCommand MySQLCommand = new MySqlCommand(sql, MySQLConnection);
            // Заполняем значения переменнных
            MySQLCommand.Parameters.AddWithValue("@value", ChangeValue.Value);
            MySQLCommand.Parameters.AddWithValue("@id", KeyValue.Value);
            // Выполняем запрос изменения данных
            MySQLCommand.ExecuteNonQuery();
            // Закрываем соединение
            closeConnect();
        }

        static public void DeleteRow(string TableName, string KeyField, DataGridViewCell KeyValue)
        {
            // Открываем соединение к базе данных
            createOpenConnect();
            // Формируем запрос к базе данных
            string sql = string.Format("DELETE FROM " + TableName + " WHERE " + KeyField + " =@id");
            MySqlCommand MySQLCommand = new MySqlCommand(sql, MySQLConnection);
            MySQLCommand.Parameters.AddWithValue("@id", KeyValue.Value);
            // Выполняем запрос удаления данных
            MySQLCommand.ExecuteNonQuery();
            // Закрываем соединение
            closeConnect();
        }

        static public void InsertRow(string TableName, string InsertFieldsOfQuery, string InsertValuesOfQuery)
        {
            // Открываем соединение к базе данных
            createOpenConnect();
            // Формируем запрос к базе данных
            string sql = "INSERT INTO " + TableName + '(' + InsertFieldsOfQuery + ") VALUES (" + InsertValuesOfQuery + ')';
            MySqlCommand MySQLCommand = new MySqlCommand(sql, MySQLConnection);
            // Выполняем запрос вставки данных
            MySQLCommand.ExecuteNonQuery();
            // Закрываем соединение
            closeConnect();
        }
    }
}

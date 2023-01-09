using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WorkersDB.Models;

namespace WorkersDB
{
    public partial class Form1 : Form
    {

        public List<Worker> workers { get; set; } // список работников

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb;";
        private OleDbConnection _myConnection;

        public Form1()
        {
            InitializeComponent();

            // Соединение с БД
            try
            {
                _myConnection = new OleDbConnection(connectString);
                _myConnection.Open();

                workers = GetWorkers();

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка соединения с БД");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ViewAllWorkers(); // Выводи список всех сотрудников
        }

        /// <summary>
        /// Получение списка всех работников
        /// </summary>
        private List<Worker> GetWorkers()
        {
            var listWorkers = new List<Worker>();

            string query = "SELECT w_id, w_name, w_family, w_position, w_birthday, w_salary FROM Workers ORDER BY w_id";

            OleDbCommand command = new OleDbCommand(query, _myConnection);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Worker worker = new Worker((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                    (int)reader[4], (int)reader[5]);
                listWorkers.Add(worker);
            }

            reader.Close();

            return listWorkers;
        }

        /// <summary>
        /// Вывод всех работинков в форму
        /// </summary>
        private void ViewAllWorkers()
        {
            foreach (Worker worker in workers)
            {
                dataGridViewWorkers.Rows.Add(worker.id, worker.name, worker.family, worker.position, worker.birthday, worker.salary);
            }
        }

        /// <summary>
        /// Обновить данные на начальные из файла (кнопка)
        /// </summary>
        private void updateAllWorkersBtn_Click(object sender, EventArgs e)
        {

            UpdateViewInDataGrid();
        }

        /// <summary>
        /// Обновление данных в Гриде
        /// </summary>
        private void UpdateViewInDataGrid()
        {
            dataGridViewWorkers.Rows.Clear();

            workers.Clear();
            workers = GetWorkers();
            ViewAllWorkers();
        }

        private void dataGridViewWorkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            int rows = dataGridViewWorkers.Rows.Count - 1;

            // Сохраняем значение всех строк в БД
            for (int i = 0; i < rows; i++)
            {
                bool error = false;

                // ID
                int id = (int)dataGridViewWorkers[0, i].Value;

                // Имя
                string name = "";
                var validateName = CheckStringWorker(1, i, "name", id, 2);
                if (!error)
                {
                    error = validateName.Item1;
                    if (!error)
                    {
                        name = validateName.Item2;
                    }
                }

                // Фамилия
                string family = "";
                var validateFamily = CheckStringWorker(2, i, "family", id, 2);
                if (!error)
                {
                    error = validateFamily.Item1;
                    if (!error)
                    {
                        family = validateFamily.Item2;
                    }
                }

                // Должность
                string position = "";
                var validatePosition = CheckStringWorker(3, i, "position", id, 3);
                if (!error)
                {
                    error = validatePosition.Item1;
                    if (!error)
                    {
                        position = validatePosition.Item2;
                    }
                }

                // День рождения
                if (!Int32.TryParse(dataGridViewWorkers[4, i].Value.ToString(), out int birthday))
                {
                    error = true;
                    MessageBox.Show($"Error birthday in rows {id}");
                }
                else
                {
                    // если год некорректный в плане числа
                    if (CheckBirthdayWorker(birthday))
                    {
                        error = true;
                        MessageBox.Show($"Error birthday in rows {id}");
                    }
                }

                // Зарплата
                if (!Int32.TryParse(dataGridViewWorkers[5, i].Value.ToString(), out int salary))
                {
                    MessageBox.Show($"Error salary in rows {id}");
                    error = true;
                }

                // если нет ошибок, то изменяет значение в БД
                if (!error)
                {
                    Worker redactWorker = new Worker(id, name, family, position, birthday, salary);

                    try
                    {
                        UpdateRows(redactWorker);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Errror UPDATE {id}");
                    }
                }

            }

        }

        /// <summary>
        /// Обновляет значение работинка в БД
        /// </summary>
        private void UpdateRows(Worker worker)
        {
            if (worker != null)
            {
                string query = $"UPDATE Workers SET w_name = '{worker.name}', " +
                    $"w_family = '{worker.family}', " +
                    $"w_position = '{worker.position}'," +
                    $"w_birthday = {worker.birthday}," +
                    $"w_salary = {worker.salary} WHERE w_id = {worker.id}";

                OleDbCommand command = new OleDbCommand(query, _myConnection);

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Проверяет корректность года рождения работинка
        /// Возвращает true в случае ошибкит года рождения
        /// </summary>
        private bool CheckBirthdayWorker(int birthday)
        {
            int veryOld = 1910;
            if (birthday < veryOld) return true;

            return false;
        }

        private (bool, string) CheckStringWorker(int columnIndex, int rowIndex, string nameStr, int idWorker, int minLenght)
        {

            bool error = false;
            string str = "";

            try
            {
                if (dataGridViewWorkers[columnIndex, rowIndex].Value != null)
                {
                    str = dataGridViewWorkers[columnIndex, rowIndex].Value.ToString();
                    str = str?.Replace(" ", "");
                    if (str == null || str.Length < minLenght)
                    {
                        error = true;
                        MessageBox.Show($"Error {nameStr} in rows {idWorker}");
                    }
                }
                else
                {
                    error = true;
                    MessageBox.Show($"Error {nameStr} in rows {idWorker}");
                }

            }
            catch (Exception)
            {
                error = true;
                MessageBox.Show($"Error {nameStr} in rows {idWorker}");
            }

            return (error, str);
        }

        /// <summary>
        /// Кнопка добавление нового сотрудника
        /// </summary>
        private void newWorkerBtn_Click(object sender, EventArgs e)
        {

            bool error = false;

            string name = nameNewWorkerTextBox.Text;
            string family = familyNewWorkerTextBox.Text;
            string position = positionNewWorkerTextBox.Text;

            // Год рождения
            if (!Int32.TryParse(birthdayNewWorkerTextBox.Text, out int birthday))
            {
                error = true;
            }

            // ЗП
            if (!Int32.TryParse(salaryNewWorkerTextBox.Text, out int salary))
            {
                error = true;
            }

            name = name?.Replace(" ", "");
            family = family?.Replace(" ", "");
            position = position?.Replace(" ", "");

            if (name == null || name.Length < 2)
            {
                error = true;
            }

            if (family == null || family.Length < 2)
            {
                error = true;
            }

            if (position == null || position.Length < 3)
            {
                error = true;
            }

            // если нет ошибок, то добавляем сотрудника
            if (!error)
            {
                string query = $"INSERT INTO Workers (w_name, w_family, w_position, w_birthday, w_salary) VALUES ('{name}'," +
                    $"'{family}'," +
                    $"'{position}', {birthday}, {salary})";

                // Добавляем сотрудника в БД
                try
                {
                    OleDbCommand command = new OleDbCommand(query, _myConnection);
                    command.ExecuteNonQuery();

                    ClearNewWorkerTextBoxs();
                    UpdateViewInDataGrid();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error add new Worker!");
                }
            }
            else
            {
                MessageBox.Show("Error add new Worker!");
            }

        }

        /// <summary>
        /// Очистка полей после добавления сотрудника
        /// </summary>
        private void ClearNewWorkerTextBoxs()
        {
            nameNewWorkerTextBox.Text = "";
            familyNewWorkerTextBox.Text = "";
            positionNewWorkerTextBox.Text = "";
            birthdayNewWorkerTextBox.Text = "";
            salaryNewWorkerTextBox.Text = "";
        }

        private void deleteWorkerbtn_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(deleteIndexTextBox.Text, out int id))
            {
                string query = $"DELETE FROM Workers WHERE w_id = {id}";

                try
                {
                    OleDbCommand command = new OleDbCommand(query, _myConnection);
                    command.ExecuteNonQuery();

                    UpdateViewInDataGrid();
                    deleteIndexTextBox.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Error delete worker");
                }
            }
            else
            {
                MessageBox.Show("Error delete worker");
            }
        }
    }
}

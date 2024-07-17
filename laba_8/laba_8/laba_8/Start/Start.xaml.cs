using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Data.SqlClient;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System;
using System.Reflection;

namespace laba_8
{
    public partial class Start : Page
    {
        private List<Class> myClass = new List<Class>();
        private List<RadioButton> radioButtons;
        private bool isUpdate = false;
        private List<string> command;

        static Start()
        {
        }

        public Start()
        {
            InitializeComponent();

            radioButtons = new List<RadioButton>();
            radioButtons.Add(year1);
            radioButtons.Add(year2);
            radioButtons.Add(year3);
            radioButtons.Add(year4);

            command = FileWork.GetConnectionString();
        }

        private void PressChar(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int h))
            {
                e.Handled = true;
            }
        }

        private async void SizeControl(object sender, RoutedEventArgs e)
        {
            TextBox text = (sender as TextBox) ?? new TextBox();

            if (text.Text.Length >= 4)
            {
                text.Background = Brushes.Red;

                await Task.Delay(100);

                text.Text = text.Text.Substring(0, 3);
                text.CaretIndex = 3;
                text.Background = Brushes.White;
            }
        }

        private void AddElement(object sender, RoutedEventArgs e)
        {
            string name = ClassNameBox.Text.Replace(" ", "");
            try
            {
                if (name == string.Empty)
                {
                    throw new Exception("Error name");
                }

                if (!FSem.IsChecked == true && !SSem.IsChecked == true)
                {
                    throw new Exception("Error Semestr");
                }

                int sem = 0;
                if (FSem.IsChecked == true)
                    sem += 1;
                if (SSem.IsChecked == true)
                    sem += 2;

                int yearRes = 0;

                for (int i = 0; i < radioButtons.Count; i++)
                {
                    if (radioButtons[i].IsChecked == true)
                    {
                        yearRes = i + 1;
                    }
                }

                int checkRes = TestType.SelectedIndex + 1;

                int id = 0;

                using (SqlConnection connection = new SqlConnection(command[0]))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        string sqlQuery = command[2];
                        string getID = "Select max(id) From Class";

                        using (SqlCommand command = new SqlCommand(getID, connection, transaction))
                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                id = read.GetInt32(0) + 1;
                            }
                        }

                        using (SqlCommand command = new SqlCommand(sqlQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            command.Parameters.AddWithValue("@Name", ClassNameBox.Text);
                            command.Parameters.AddWithValue("@Semestr", sem);
                            command.Parameters.AddWithValue("@Years", yearRes);
                            command.Parameters.AddWithValue("@CountOfLabs", Convert.ToInt32(CountLab.Text));
                            command.Parameters.AddWithValue("@CountOfLects", Convert.ToInt32(CountLect.Text));
                            command.Parameters.AddWithValue("@ControlType", checkRes);

                            if (command.ExecuteNonQuery() > 0)
                            {
                                ClearForm(false);
                            }
                        }
                        if (ImagePathBox.Text != string.Empty)
                        {
                            string query = "insert Images(id, img) values(@Id, @Img)";

                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Id", id);
                                command.Parameters.AddWithValue("@Img", ImagePathBox.Text);

                                if (command.ExecuteNonQuery() > 0)
                                {
                                    ClearForm();
                                }
                            }
                        }

                        if (MessageBox.Show("Add element", "hello", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                            transaction.Commit();
                        else
                            transaction.Rollback();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Произошла ошибка: " + ex.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm(bool delImage = true)
        {
            ClassNameBox.Clear();
            FSem.IsChecked = SSem.IsChecked = false;
            CountLab.Clear();
            CountLect.Clear();

            if (delImage)
                ImagePathBox.Clear();
        }
        //locate
        private void LocateElement(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(command[0]))
                {
                    connection.Open();

                    string query1 = "select * from Class where id = " + idBox.Text;
                    string query2 = "select * from Images where id = " + idBox.Text;

                    using (SqlCommand command = new SqlCommand(query1, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ClassNameBox.Text = (string)reader["name"];

                            int sem = (int)reader["semestr"];
                            int years = (int)reader["years"];
                            int control_type = (int)reader["control_type"];

                            CountLab.Text = Convert.ToString((int)reader["count_of_labs"]);
                            CountLect.Text = Convert.ToString((int)reader["count_of_lects"]);

                            if (sem > 1)
                            {
                                SSem.IsChecked = true;
                                sem -= 2;
                            }
                            if (sem == 1)
                            {
                                FSem.IsChecked = true;
                            }

                            radioButtons[years - 1].IsChecked = true;
                            TestType.SelectedIndex = control_type - 1;
                        }
                    }

                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string imgPath = (string)reader["img"];
                                ImagePathBox.Text = imgPath;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //update
        private void UpdateElement(object sender, RoutedEventArgs e)
        {
            if (!ChangeButton(sender, e))
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(command[0]))
                {
                    connection.Open();

                    string query = command[3];

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Convert.ToInt32(idBox.Text));
                        command.Parameters.AddWithValue("@Name", ClassNameBox.Text);

                        int sem = 0;
                        if (FSem.IsChecked == true)
                            sem += 1;
                        if (SSem.IsChecked == true)
                            sem += 2;

                        command.Parameters.AddWithValue("@Semestr", Convert.ToInt32(sem));

                        int years = 0;
                        for (int i = 0; i < radioButtons.Count; i++)
                        {
                            if (radioButtons[i].IsChecked == true)
                            {
                                years = i + 1;
                            }
                        }

                        command.Parameters.AddWithValue("@Years", Convert.ToInt32(years));
                        command.Parameters.AddWithValue("@CountOfLabs", Convert.ToInt32(CountLab.Text));
                        command.Parameters.AddWithValue("@CountOfLects", Convert.ToInt32(CountLect.Text));
                        command.Parameters.AddWithValue("@ControlType", TestType.SelectedIndex + 1);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            ClearForm();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ChangeButton(object sender, RoutedEventArgs e)
        {
            if (!isUpdate)
                LocateElement(sender, e);

            if (ClassNameBox.Text == string.Empty)
                return false;

            isUpdate = !isUpdate;
            AddBut.IsEnabled = !isUpdate;
            LocateBut.IsEnabled = !isUpdate;

            if (isUpdate)
            {
                UpdateBut.Content = "Save";
                DeleteBut.Content = "Cancel";

                return false;
            }

            UpdateBut.Content = "Update";
            DeleteBut.Content = "Delete";

            return true;
        }

        private void DeleteElement(object sender, RoutedEventArgs e)
        {
            if (isUpdate)
            {
                isUpdate = !isUpdate;
                AddBut.IsEnabled = !isUpdate;
                LocateBut.IsEnabled = !isUpdate;

                UpdateBut.Content = "Update";
                DeleteBut.Content = "Delete";

                ClearForm();

                return;
            }

            try
            {
                LocateElement(sender, e);

                using (SqlConnection connection = new SqlConnection(command[0]))
                {
                    connection.Open();

                    //string query = command[4];
                    string query = "DELETE FROM Class WHERE id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Convert.ToInt32(idBox.Text));

                        if (MessageBox.Show("You sure", "hello", MessageBoxButton.YesNo) == MessageBoxResult.No)
                            return;

                        if (command.ExecuteNonQuery() > 0)
                        {
                            ClearForm();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortUp(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AllInfo(GetClasses().OrderBy(f => f.CountOfLabs).ToList()));
        }
        private void SortDown(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AllInfo(GetClasses().OrderByDescending(f => f.CountOfLabs).ToList()));
        }
        private void ShowAll(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AllInfo(GetClasses()));
        }

        private List<Class> GetClasses()
        {
            List<Class> classes = new List<Class>();

            using (SqlConnection connect = new SqlConnection(command[0]))
            {
                connect.Open();

                string query = command[1];

                using (SqlCommand command = new SqlCommand(query, connect))
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        classes.Add(new Class(read.GetInt32(0), read.GetString(1), read.GetInt32(2), read.GetInt32(3), read.GetInt32(4), read.GetInt32(5), read.GetInt32(6)));
                    }
                }
            }

            return classes;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }
    }
}

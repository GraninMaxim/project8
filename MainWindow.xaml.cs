using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Student firstStudent;
        Student secondStudent;

        private void First_Student_Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string firstName = inputFirstName.Text;
                string firstLastname = inputFirstLastname.Text;
                int firstAge = Convert.ToInt32(inputFirstAge.Text);
                int firstID = Convert.ToInt32(inputFirstID.Text);
                firstStudent = new Student(firstName, firstLastname, firstAge, firstID);
                MessageBox.Show(firstStudent.Print(), "Cтудент №1", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Second_Student_Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string secondName = inputSecondName.Text;
                string secondLastname = inputSecondLastname.Text;
                int secondAge = Convert.ToInt32(inputSecondAge.Text);
                int secondID = Convert.ToInt32(inputSecondID.Text);
                secondStudent = new Student(secondName, secondLastname, secondAge, secondID);
                MessageBox.Show(secondStudent.Print(), "Cтудент №2", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //1 способ
        private void Compare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int result = firstStudent.CompareTo(secondStudent);
                if (result == 0) MessageBox.Show("Фамилии одинаковые");
                else if (result > 0) MessageBox.Show("Первая фамилия больше второй.");
                else if (result < 0) MessageBox.Show("Вторая фамилия больше первой.");
            }
            catch(NullReferenceException ex) 
            {
                MessageBox.Show("Объект не был создан");     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            inputFirstName.Clear();
            inputFirstLastname.Clear();
            inputFirstAge.Clear();
            inputFirstID.Clear();
            inputSecondName.Clear();
            inputSecondLastname.Clear();
            inputSecondAge.Clear();
            inputSecondID.Clear();
        }

        private void About_Program_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать интерфейсы – человек и печать (для формирования информации об объекте). " +
                "Создать класс – студент. Класс должен включать конструкторы функцию для формирования строки " +
                "информации о студенте. Сравнение производить по фамилии.");
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

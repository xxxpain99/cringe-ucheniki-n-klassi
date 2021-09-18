using System;
using System.Collections.Generic;
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

namespace WpfApp10.Pages
{
    /// <summary>
    /// Логика взаимодействия для klassi.xaml
    /// </summary>
    public partial class klassi : Page
    {
        public klassi()
        {
            InitializeComponent();
            LoadGroupList();
        }

        private void LoadGroupList()
        {
            db.base10Entities connection = new db.base10Entities();
            var groupList = connection.Класс.ToList();

            foreach (var group in groupList)
            {
                ComboBoxGroup.Items.Add(group.Номер);
            }


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxGroup.SelectedIndex == -1)
            {

            }
            int g = (int)ComboBoxGroup.SelectedItem;
        }
    }
}

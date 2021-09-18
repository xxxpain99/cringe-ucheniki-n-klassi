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
    /// Логика взаимодействия для ucheniki.xaml
    /// </summary>
    public partial class ucheniki : Page
    {
        public ucheniki()
        {
            InitializeComponent();
       
        }
        private void LoadGroupList()
        {
        


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int groupNumber = int.Parse(TextBoxGroup.Text);

            //sozdat podklyuchenie k BD
            db.base10Entities connection = new db.base10Entities();
            db.Класс isExists = connection.Класс.Where(g => g.Номер == groupNumber).FirstOrDefault();
            if (isExists != null)
            {
                MessageBox.Show("Класс c таким номером уже существует");
                return;
            }
            db.Класс group = new db.Класс();
            group.Номер = groupNumber;
            connection.Класс.Add(group);


            int result = connection.SaveChanges();
            if (result == 1)
            {
                TextBoxGroup.Text = "";
                MessageBox.Show("Класс успешно создан");
            }
        }
    }
    
}

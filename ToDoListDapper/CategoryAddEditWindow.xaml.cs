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
using System.Windows.Shapes;

namespace ToDoListDapper
{
    /// <summary>
    /// Interaction logic for CategoryAddEditWindow.xaml
    /// </summary>
    public partial class CategoryAddEditWindow : Window
    {

        MainWindow mw;
        public CategoryAddEditWindow(MainWindow w)
        {
            InitializeComponent();
            mw = w;


            if (Model.StatusRow.Title == "EditCategory")
            {
                DataContext = mw.CategoriesListView.SelectedItem;

                Binding binding = new Binding("Id");
                binding.Mode = BindingMode.OneWay;
                id.SetBinding(TextBox.TextProperty, binding);

                Binding binding1 = new Binding("Name");
                binding1.Mode = BindingMode.OneWay;
                Name.SetBinding(TextBox.TextProperty, binding1);
            }

        }

        private void ok(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "" || Name.Text == null)
            {
                MessageBox.Show("Enter name");
            }
            else if (Model.StatusRow.Title == "AddCategory")
            {
                mw.categoriescontext.Create(new Category { Name= Name.Text});
                mw.CategoriesListView.ItemsSource = mw.categoriescontext.GetAll();
                this.Close();
            }
            else if (Model.StatusRow.Title == "EditCategory")
            {
                Category c = mw.CategoriesListView.SelectedItem as Category;

                Category cat = mw.categoriescontext.GetById((mw.CategoriesListView.SelectedItem as Category).Id);

                cat.Name = Name.Text;
                c.Name = Name.Text;
                mw.categoriescontext.Update(c);
                mw.CategoriesListView.ItemsSource = mw.categoriescontext.GetAll();
                this.Close();
            }
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

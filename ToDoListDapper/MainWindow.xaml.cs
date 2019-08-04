using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
using ToDoListDapper.Model;

namespace ToDoListDapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CategoryRepository categoriescontext;
        public BusinnesRepository businnescontext;
        //  public CategoryRepository Categoriescontext { get { return categoriescontext; } set { } }

        CategoryAddEditWindow categoryaddeditwindow;
        BusinessAddEditWindow businessAddEditWindow;

        public MainWindow()
        {
            InitializeComponent();

            this.ResizeMode = ResizeMode.NoResize;

            CreateDb();
            categoriescontext = new CategoryRepository();
            businnescontext = new BusinnesRepository();



            Categories.ItemsSource = categoriescontext.GetAll();
            Categories.DisplayMemberPath = "Name";

            GridView myGridView = new GridView();

            myGridView.AllowsColumnReorder = true;
            myGridView.Columns.Add(new GridViewColumn() { Header = "Id", Width = 50, DisplayMemberBinding = new Binding("Id") });
            myGridView.Columns.Add(new GridViewColumn() { Header = "Name", Width = 200, DisplayMemberBinding = new Binding("Name") });
            CategoriesListView.View = myGridView;

            CategoriesListView.ItemsSource = categoriescontext.GetAll();

            //GridView myGridView2 = new GridView();
            //myGridView2.AllowsColumnReorder = true;
            //myGridView2.Columns.Add(new GridViewColumn() { Header = "Id", Width = 30, DisplayMemberBinding = new Binding("Id") });
            //myGridView2.Columns.Add(new GridViewColumn() { Header = "Name", Width = 100, DisplayMemberBinding = new Binding("Name") });
            //myGridView2.Columns.Add(new GridViewColumn() { Header = "Text", Width = 90, DisplayMemberBinding = new Binding("Text") });
            //myGridView2.Columns.Add(new GridViewColumn() { Header = "StartDate", Width = 60, DisplayMemberBinding = new Binding("StartDate") });
            //myGridView2.Columns.Add(new GridViewColumn() { Header = "Deadline", Width = 60, DisplayMemberBinding = new Binding("Deadline") });
            //myGridView2.Columns.Add(new GridViewColumn() { Header = "State", Width = 60, DisplayMemberBinding = new Binding("State") });
            //myGridView2.Columns.Add(new GridViewColumn() { Header = "id_Category", Width = 70, DisplayMemberBinding = new Binding("id_Category") });
            //BusinessListView.View = myGridView2;
            GridViewWithStyle.Columns.Add(new GridViewColumn() { Header = "Id", Width = 30, DisplayMemberBinding = new Binding("Id") });
            GridViewWithStyle.Columns.Add(new GridViewColumn() { Header = "Name", Width = 100, DisplayMemberBinding = new Binding("Name") });
            GridViewWithStyle.Columns.Add(new GridViewColumn() { Header = "Text", Width = 90, DisplayMemberBinding = new Binding("Text") });
            GridViewWithStyle.Columns.Add(new GridViewColumn() { Header = "StartDate", Width = 60, DisplayMemberBinding = new Binding("StartDate") });
            GridViewWithStyle.Columns.Add(new GridViewColumn() { Header = "Deadline", Width = 60, DisplayMemberBinding = new Binding("Deadline") });
            GridViewWithStyle.Columns.Add(new GridViewColumn() { Header = "State", Width = 60, DisplayMemberBinding = new Binding("State") });
            GridViewWithStyle.Columns.Add(new GridViewColumn() { Header = "id_Category", Width = 80, DisplayMemberBinding = new Binding("id_Category") });

            BusinessListView.ItemsSource = businnescontext.GetAll();


            //GridView myGridView1 = new GridView();
            //myGridView1.AllowsColumnReorder = true;
            //myGridView1.Columns.Add(new GridViewColumn() { Header = "Id", Width = 50, DisplayMemberBinding = new Binding("Id") });
            //myGridView1.Columns.Add(new GridViewColumn() { Header = "Name", Width = 30, DisplayMemberBinding = new Binding("Name") });
            //myGridView1.Columns.Add(new GridViewColumn() { Header = "Text", Width = 30, DisplayMemberBinding = new Binding("Text") });
            //myGridView1.Columns.Add(new GridViewColumn() { Header = "StartDate", Width = 60, DisplayMemberBinding = new Binding("StartDate") });
            //myGridView1.Columns.Add(new GridViewColumn() { Header = "Deadline", Width = 60, DisplayMemberBinding = new Binding("Deadline") });
            //myGridView1.Columns.Add(new GridViewColumn() { Header = "State", Width = 60, DisplayMemberBinding = new Binding("State") });
            //myGridView1.Columns.Add(new GridViewColumn() { Header = "id_Category", Width = 70, DisplayMemberBinding = new Binding("id_Category") });
            // CalenderCategoriesListView.View = myGridView1;
            //  GridViewWithStyleCalender.AllowsColumnReorder = true;
            GridViewWithStyleCalender.Columns.Add(new GridViewColumn() { Header = "Id", Width = 50, DisplayMemberBinding = new Binding("Id") });
            GridViewWithStyleCalender.Columns.Add(new GridViewColumn() { Header = "Name", Width = 30, DisplayMemberBinding = new Binding("Name") });
            GridViewWithStyleCalender.Columns.Add(new GridViewColumn() { Header = "Text", Width = 30, DisplayMemberBinding = new Binding("Text") });
            GridViewWithStyleCalender.Columns.Add(new GridViewColumn() { Header = "StartDate", Width = 60, DisplayMemberBinding = new Binding("StartDate") });
            GridViewWithStyleCalender.Columns.Add(new GridViewColumn() { Header = "Deadline", Width = 60, DisplayMemberBinding = new Binding("Deadline") });
            GridViewWithStyleCalender.Columns.Add(new GridViewColumn() { Header = "State", Width = 60, DisplayMemberBinding = new Binding("State") });
            GridViewWithStyleCalender.Columns.Add(new GridViewColumn() { Header = "id_Category", Width = 70, DisplayMemberBinding = new Binding("id_Category") });



            //  categoriescontext.MultiTableQueryOneToMany();
            // categoriescontext.MultiTableQueryOneToMany();
        }

        private void CreateDb()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-JCVHM8G\\SQLEXPRESS01;Integrated Security=True";



            string sql = " IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'BusinessDb')   BEGIN   CREATE DATABASE BusinessDb   END";
            //string sql2 = " USE BusinessDb "+
            //           "Create TABLE Category  ( Id INT IDENTITY PRIMARY KEY,   Name nvarchar(100) NOT NULL Unique );"+
            //           "USE BusinessDb CREATE TABLE Business (Id INT IDENTITY PRIMARY KEY, Name NVARCHAR(30) NOT NULL Unique, " +
            //           "[Text] NVARCHAR(200) NOT NULL,StartDate DATETIME NOT NULL, Deadline DATETIME NOT NULL,  [State] NVARCHAR(20) NOT NULL, "+
            //           "id_Category int  NOT NULL FOREIGN KEY REFERENCES Category(id)); ";



            connection.Execute(sql);
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["TodoList"].ConnectionString;
            sql = "  IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BusinessDb].[dbo].[Category]') AND type in (N'U')) " +
                 "BEGIN USE BusinessDb Create TABLE Category ( Id INT IDENTITY PRIMARY KEY, Name nvarchar(100) NOT NULL Unique ); END;" +


                 " IF NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BusinessDb].[dbo].[Business]') AND type in (N'U')) " +
                 "BEGIN  USE BusinessDb CREATE TABLE Business (Id INT IDENTITY PRIMARY KEY, Name NVARCHAR(30) NOT NULL Unique,  [Text] NVARCHAR(200) NOT NULL, " +
                 "StartDate DATETIME NOT NULL , Deadline DATETIME NOT NULL, [State] NVARCHAR(20) NOT NULL, " +
                 "id_Category int NOT NULL FOREIGN KEY REFERENCES Category(id)); END";
            connection.Execute(sql);

        }


        private void GoToCategories(object sender, RoutedEventArgs e)
        {
            tabControl1.SelectedItem = CategoryTab;
        }

        private void GoToBusinnes(object sender, RoutedEventArgs e)
        {
            tabControl1.SelectedItem = BusinessTab;
        }



        private void AddCategory(object sender, RoutedEventArgs e)
        {
            StatusRow.Title = "AddCategory";
            categoryaddeditwindow = new CategoryAddEditWindow(this);
            categoryaddeditwindow.DataContext = null;
            CategoriesListView.SelectedItem = null;
            categoryaddeditwindow.ShowDialog();
        }

        private void DeleteCategory(object sender, RoutedEventArgs e)
        {


            if (CategoriesListView.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose the item");
                return;
            }
            var res = MessageBox.Show("Are you sure you want to delete this item?", "", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel);
            if (res == MessageBoxResult.OK) //and db.StatusRow = "Books"
            {

                Category rc = CategoriesListView.SelectedItem as Category;

                //  Student p1 = db.Students.Find(id);
                if (rc != null)
                {
                    categoriescontext.Delete(rc);
                }
                //SaveChanges();
                CategoriesListView.ItemsSource = categoriescontext.GetAll();
            }
        }


        private void EditCategory(object sender, MouseButtonEventArgs e)
        {
            Category rc = CategoriesListView.SelectedItem as Category;


            if (rc != null)
            {
                StatusRow.Title = "EditCategory";
                categoryaddeditwindow = new CategoryAddEditWindow(this);
                categoryaddeditwindow.ShowDialog();
            }

        }

        private void CategoriestabItem1_Clicked(object sender, MouseButtonEventArgs e)
        {
            Categories.SelectedItem = null;
            Categories.ItemsSource = categoriescontext.GetAll();
        }

        private void AddBusiness(object sender, RoutedEventArgs e)
        {
            StatusRow.Title = "AddBuisness";
            businessAddEditWindow = new BusinessAddEditWindow(this);
            businessAddEditWindow.DataContext = null;
            BusinessListView.SelectedItem = null;
            businessAddEditWindow.ShowDialog();


        }

        private void NullBusiness(object sender, RoutedEventArgs e)
        {
            BusinessListView.ItemsSource = null;
            Categories.SelectedItem = null;
        }

        private void AllBusiness(object sender, RoutedEventArgs e)
        {
            Categories.SelectedItem = null;
            BusinessListView.ItemsSource = businnescontext.GetAll();
        }

        private void DeleteBusiness(object sender, RoutedEventArgs e)
        {

            if (BusinessListView.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose the item");
                return;
            }
            var res = MessageBox.Show("Are you sure you want to delete this item?", "", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel);
            if (res == MessageBoxResult.OK) //and db.StatusRow = "Books"
            {

                Business rc = BusinessListView.SelectedItem as Business;

                //  Student p1 = db.Students.Find(id);
                if (rc != null)
                {
                    businnescontext.Delete(rc);
                }
                //SaveChanges();
                BusinessListView.ItemsSource = businnescontext.GetAll();
            }
        }


        private void editBusiness(object sender, MouseButtonEventArgs e)
        {
            Business rc = BusinessListView.SelectedItem as Business;


            if (rc != null)
            {
                StatusRow.Title = "EditBuisness";
                businessAddEditWindow = new BusinessAddEditWindow(this);
                businessAddEditWindow.ShowDialog();
            }

        }

        private void chan(object sender, SelectionChangedEventArgs e)
        {

            Category f = Categories.SelectedItem as Category;
            if (f != null)
            {

                var good =
                   (from b in businnescontext.GetAll()
                    where b.id_Category == f.Id
                    select b).ToList();


                if (good != null)
                {
                    BusinessListView.ItemsSource = good;
                }

                else
                {
                    BusinessListView.ItemsSource = null;
                }
            }
        }

        private void Selecteddatechanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? res = calendar.SelectedDate;
            CalenderCategoriesListView.ItemsSource = businnescontext.GetAllBusinessByDeadline((DateTime)res);

        }



        private void TabVisible(object sender, RoutedEventArgs e)
        {
            if (BusinessTab.Visibility == Visibility.Hidden || BusinessTab.Visibility == Visibility.Collapsed )
            {
                BusinessTab.Visibility = Visibility.Visible;
                CategoryTab.Visibility = Visibility.Visible;
                CalenderTab.Visibility = Visibility.Visible;
                // tabVisible.Visibility = Visibility.Hidden;
            }
            else {
                BusinessTab.Visibility = Visibility.Collapsed;
                CategoryTab.Visibility = Visibility.Collapsed;
                CalenderTab.Visibility = Visibility.Collapsed;
            }
        }

    }
}


/*Создать веб приложение, которое позволяет хранить список дел и управлять им.
Требования к приложению:
О каждой задаче в списке дел необходимо хранить ее описание, приоритет, срок выполнения, состояние (выполнено или нет). Задачи можно группировать по категориям, а также добавлять метки.
Приложение должно предоставлять возможность вывода списка дел, его фильтрацию по меткам и/или категориям. Список дел должен выводится с учетом приоритета и состояния. 
Так же необходима возможность добавления, редактирования и удаления задачи и категории. 
*/

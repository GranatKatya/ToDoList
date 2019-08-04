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
using ToDoListDapper.Model;

namespace ToDoListDapper
{
    /// <summary>
    /// Interaction logic for BusinessAddEditWindow.xaml
    /// </summary>
    public partial class BusinessAddEditWindow : Window
    {
        MainWindow mw;
        public BusinessAddEditWindow(MainWindow w)
        {
            InitializeComponent();
            mw = w;

            id_Category.ItemsSource = mw.categoriescontext.GetAll();
            id_Category.DisplayMemberPath = "Name";


            List<string> statelist = new List<string>() { "Active", "Done", "Expired" };
            StatecMB.ItemsSource = statelist;


            if (StatusRow.Title == "EditBuisness")
            {
                DataContext = mw.BusinessListView.SelectedItem;

                

                Binding binding = new Binding("Id");
                binding.Mode = BindingMode.OneWay;
                id.SetBinding(TextBox.TextProperty, binding);

                Binding binding1 = new Binding("Name");
                binding1.Mode = BindingMode.OneWay;
                Name.SetBinding(TextBox.TextProperty, binding1);


                Binding binding4 = new Binding("Text");
                binding4.Mode = BindingMode.OneWay;
                Text.SetBinding(TextBox.TextProperty, binding4);

                Binding binding2 = new Binding("StartDate");
                binding2.Mode = BindingMode.OneWay;
                DateStart.SetBinding(TextBox.TextProperty, binding2);

                Binding binding3 = new Binding("Deadline");
                binding3.Mode = BindingMode.OneWay;
                Deadline.SetBinding(TextBox.TextProperty, binding3);

                Binding binding5 = new Binding("State");
                binding5.Mode = BindingMode.OneWay;
                StatecMB.SetBinding(ComboBox.TextProperty, binding5);


                Binding binding6 = new Binding("selectedindex");
                binding6.Mode = BindingMode.OneWay;
                id_Category.SetBinding(ComboBox.TextProperty, binding6);

                var d = id_Category.Items;
                Category c = d[0] as Category;

                Business book = (Business)mw.BusinessListView.SelectedItem;
               // id_Category.SelectedIndex = book.selectedindex-1;
                for (int i = 0; i < id_Category.Items.Count; i++)
                {
                    if (((Category)d[i]).Id == book.id_Category) {
                        id_Category.SelectedIndex = i; }
                }

            }

        }

        private void ok(object sender, RoutedEventArgs e)
        {
            if ((Name.Text == "" || Name.Text == null) || (Text.Text == "" || Text.Text == null))
            {
                MessageBox.Show("Enter name or Text");
            }
            else if (DateStart.Text == "" || DateStart.Text == null || (Deadline.Text == "" || Deadline.Text == null) || (StatecMB.SelectedItem == null))//(State.Text == "" || State.Text == null))
            {
                MessageBox.Show("Enter DateStart or State or Deadline");
            } else if (id_Category.SelectedItem.ToString()=="" || id_Category.SelectedItem == null)
            {
                MessageBox.Show("please choose category");
            }
            else if (Model.StatusRow.Title == "AddBuisness")
            {
                Business b = new Business()
                {
                    Name = Name.Text,
                    Text = Text.Text,
                    StartDate = DateTime.Parse(DateStart.Text),
                    Deadline = DateTime.Parse(Deadline.Text),
                    State = StatecMB.SelectedValue.ToString(),
                    //State = State.Text,
                    id_Category = ((Category)id_Category.SelectedItem).Id//,
                  //  selectedindex = id_Category.SelectedIndex + 1
                };
                mw.businnescontext.Create(b);//});
                mw.BusinessListView.ItemsSource = mw.businnescontext.GetAll();



             //   Category catt = mw.categoriescontext.GetById(b.id_Category);
              //  catt.Business.Add(mw.businnescontext.GetByName(b.Name));



                this.Close();
            }
            else if (Model.StatusRow.Title == "EditBuisness")
            {
                Business c = mw.BusinessListView.SelectedItem as Business;

               // Business cat = mw.businnescontext.GetById((mw.BusinessListView.SelectedItem as Business).Id);

                c.Name = Name.Text;
                c.Text = Text.Text;
                c.StartDate = DateTime.Parse(DateStart.Text);
                c.Deadline = DateTime.Parse(Deadline.Text);
                c.State = StatecMB.SelectedValue.ToString();
              //  c.State = State.Text;
                c.id_Category = ((Category)id_Category.SelectedItem).Id;

                //  id_Category.SelectedIndex = (int)c.Id_Category - 1;

                int indexTheme = id_Category.SelectedIndex + 1;
               // c.selectedindex = indexTheme;

                //c.Category = ((Category)id_Category.SelectedItem).Name;
                // id_Category.SelectedIndex = c.id_Category;

                mw.businnescontext.Update(c);
                mw.BusinessListView.ItemsSource = mw.businnescontext.GetAll();
                this.Close();
            }

        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

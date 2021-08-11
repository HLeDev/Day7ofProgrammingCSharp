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
using System.Collections;
using System.Collections.ObjectModel;
using BookRepository;


namespace W6D2A1
{
    /// <summary>
    /// Interaction logic for Library.xaml
    /// </summary>
    public partial class Library : Window
    {
        BookRepositories librarylist; //creating variable for referencing
        public Library()
        {
            InitializeComponent();
            librarylist = new BookRepositories(); //making variable public to use
            MyLibrary.ItemsSource = librarylist.booklist; //getting datagrid = to list from class

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CreateBook create = new CreateBook(librarylist); //calling Createbook from createbook.xaml.cs and linking it to this cs
            create.ShowDialog(); //this will show the "CreateBook Window"
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            ShowData(); //calling method to display information
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var bookdel = (Book)MyLibrary.SelectedItem; //have to make new variable to call class
            librarylist.Delete(bookdel);  //delete using crud
            ShowData(); //refreshing datagrid

        }
        private void ShowData()
        {
            MyLibrary.ItemsSource = null; //setting datagrid to null
            MyLibrary.ItemsSource = librarylist.booklist; //calling what was added into booklist
        }

    }
}

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
using BookRepository;

namespace W6D2A1
{
    /// <summary>
    /// Interaction logic for CreateBook.xaml
    /// </summary>
    public partial class CreateBook : Window
    {
        BookRepositories newData; //creating variable for referencing
        public CreateBook(object obj) //creating an object to call in library
        {
            InitializeComponent();
            newData = obj as BookRepositories; //setting object as reference to call list
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text) && !string.IsNullOrWhiteSpace(txtTitle.Text) && !string.IsNullOrWhiteSpace(txtAuthor.Text)
             && !string.IsNullOrEmpty(txtYear.Text) && !string.IsNullOrEmpty(txtYear.Text))
             //Checking to make sure all boxes are filled out
            {
                Book book = new Book(Convert.ToInt32(txtID.Text), txtTitle.Text, txtAuthor.Text, Convert.ToInt32(txtYear.Text), Convert.ToDouble(txtPrice.Text));
                //creating new book through referencing

                newData.Create(book); //adding newly added book information into newData which in turns putting it on a list

                MessageBox.Show("A new book has been added to the library");
            }
            RefreshList();
        }
        private void RefreshList()
        {
            txtID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtPrice.Clear();
        }

    }
}

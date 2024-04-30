using System.Windows;

namespace testbinding
{
    public partial class EditFruitWindow : Window
    {
        private Store editedFruit;

        public EditFruitWindow(Store fruit)
        {
            InitializeComponent();
            editedFruit = fruit;
            editTextBox.Text = fruit.Name;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
            editedFruit.Name = editTextBox.Text;
            ((MainWindow)Owner).UpdateDataContext();
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {           
            Close();
        }
    }
}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Reflection.Emit;

namespace testbinding
{
    
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     private Store? editingFruit;
     public List<Store> stores {  get; set; }
     public List<Basket> baskets { get; set; }= new List<Basket>();


        public MainWindow()
        {
            InitializeComponent();

            stores = new List<Store>()
            {
                new Store() { Name = "Blackberry" },
                new Store() { Name = "Apple" },
                new Store() { Name = "Pinapple" },
                new Store() { Name = "Pomegranade" },
                new Store() { Name = "Cucumber" },
                new Store() { Name = "Tomato" },
                new Store() { Name = "Pear" },
                new Store() { Name = "Corn" }

            };

           


                DataContext = stores; 
        }


        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = SearchTextbox.Text.ToLower();
            var filteredData = stores.Where(store => store.Name.ToLower().Contains(searchTerm)).ToList();
             searchinglistbox.ItemsSource = filteredData;
        }

        private void Basket_button_Click(object sender, RoutedEventArgs e)
        {
            string basketContest = "Basket Contents ";
            foreach (var item in baskets)
            {

                basketContest += $"\n{item.Fruit}:{item.Count}";

            }
            MessageBox.Show(basketContest);
        }

        private void Apple_button_Click(object sender, RoutedEventArgs e)
        {
            Store newFruit = new Store { Name = "Apple" };

            Basket? existingBasketItem = baskets.FirstOrDefault(item => item.Fruit == newFruit.Name);
            if (existingBasketItem != null)
            {
                existingBasketItem.Count++;
            }
            else
            {
                Basket basketItem = new Basket { Fruit = newFruit.Name, Count = 1 };
                baskets.Add(basketItem);
            }

            DataContext = null;
            DataContext = stores;

        }

        private void Pomegranade_button_Click(object sender, RoutedEventArgs e)
        {
            Store newFruit = new Store { Name = "Pomegranade" };

            Basket? existingBasketItem = baskets.FirstOrDefault(item => item.Fruit == newFruit.Name);
            if (existingBasketItem != null)
            {
                existingBasketItem.Count++;
            }
            else
            {
                Basket basketItem = new Basket { Fruit = newFruit.Name, Count = 1 };
                baskets.Add(basketItem);
            }

            DataContext = null;
            DataContext = stores;

        }

        private void Cucumber_button_Click(object sender, RoutedEventArgs e)
        {
            Store newFruit = new Store { Name = "Cucumber" };

            Basket? existingBasketItem = baskets.FirstOrDefault(item => item.Fruit == newFruit.Name);
            if (existingBasketItem != null)
            {
                existingBasketItem.Count++;
            }
            else
            {
                Basket basketItem = new Basket { Fruit = newFruit.Name, Count = 1 };
                baskets.Add(basketItem);
            }

            DataContext = null;
            DataContext = stores;


        }

        private void Tomato_button_Click(object sender, RoutedEventArgs e)
        {

           
            Store newFruit = new Store { Name = "Tomato" };

            
            Basket? existingBasketItem = baskets.FirstOrDefault(item => item.Fruit == newFruit.Name);
            if (existingBasketItem != null)
            {
                
                existingBasketItem.Count++;
            }
            else
            {
                
                Basket basketItem = new Basket { Fruit = newFruit.Name, Count = 1 };
                baskets.Add(basketItem);
            }

            
            DataContext = null;
            DataContext = stores;

        }

        private void Corn_button_Click(object sender, RoutedEventArgs e)
        {
            
            Store newFruit = new Store { Name = "Corn" };

         
            Basket? existingBasketItem = baskets.FirstOrDefault(item => item.Fruit == newFruit.Name);
            if (existingBasketItem != null)
            {
           
                existingBasketItem.Count++;
            }
            else
            {
        
                Basket basketItem = new Basket { Fruit = newFruit.Name, Count = 1 };
                baskets.Add(basketItem);
            }

            DataContext = null;
            DataContext = stores;

        }

        private void Pear_button_Click(object sender, RoutedEventArgs e)
        {

    
            Store newFruit = new Store { Name = "Pear" };

        
            Basket? existingBasketItem = baskets.FirstOrDefault(item => item.Fruit == newFruit.Name);
            if (existingBasketItem != null)
            {
                
                existingBasketItem.Count++;
            }
            else
            {
     
                Basket basketItem = new Basket { Fruit = newFruit.Name, Count = 1 };
                baskets.Add(basketItem);
            }


            DataContext = null;
            DataContext = stores;

        }

        private void Pinapple_button_Click(object sender, RoutedEventArgs e)
        {
          
            Store newFruit = new Store { Name = "Pinapple" };

           
            Basket? existingBasketItem = baskets.FirstOrDefault(item => item.Fruit == newFruit.Name);
            if (existingBasketItem != null)
            {
              
                existingBasketItem.Count++;
            }
            else
            {
             
                Basket basketItem = new Basket { Fruit = newFruit.Name, Count = 1 };
                baskets.Add(basketItem);
            }

        
            DataContext = null;
            DataContext = stores;

        }



        private void Blackberry_button_Click(object sender, RoutedEventArgs e)
        {        
            Store newFruit = new Store { Name = "Blackberry" };            
            Basket? existingBasketItem = baskets.FirstOrDefault(item => item.Fruit == newFruit.Name);
            if (existingBasketItem != null)
            {               
                existingBasketItem.Count++;
            }
            else
            {             
                Basket basketItem = new Basket { Fruit = newFruit.Name, Count = 1 };
                baskets.Add(basketItem);
            }        
            DataContext = null;
            DataContext = stores;


        }



        private void Editing_Click(object sender, RoutedEventArgs e)
        {
            if (searchinglistbox.SelectedItem != null) 
            {
               
                editingFruit = searchinglistbox.SelectedItem as Store;
                
                Button_Click();
            }
            else
            {
                MessageBox.Show("Please select a fruit to edit."); 
            }
        }



        private void Button_Click()
        {
            EditFruitWindow infowindow = new EditFruitWindow(editingFruit);
            infowindow.Owner= this;
            infowindow.ShowDialog();
            UpdateDataContext();

        }

        public void UpdateDataContext()
        {
            DataContext = null;
            DataContext = stores;
        }
    }
}
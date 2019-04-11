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

namespace CountriesList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int currentIndex = 0;

        List<Country> countries = new List<Country>();

        List<Country> deletedContries = new List<Country>();

        SortedDictionary<string, string> countriesPairs = new SortedDictionary<string, string>()
        {
            { "Australia", "Sidney" },
            { "Austria", "Vienna" },
            { "Belgium", "Brussels" },
            { "Bulgaria", "Sofia"},
            { "Canada", "Otava"},
            { "England", "London"},
            { "France", "Paris" },
            { "Germany", "Berlin" },
            {"Greece", "Athens" },
            {"Hungary", "Budapest" },
            {"Italy", "Rome" },
            {"Romania", "Bucharest" },
            {"Spain", "Madrid" },
            {"Ukraine", "Kiev" },
            {"Zimbabwe", "Xapape"}
        };
        List<String> flagPaths = new List<string>()
        {
            "Images/australia.png",
            "Images/austria.png",
            "Images/belgium.png",
            "Images/bulgaria.png",
            "Images/canada.png",
            "Images/england.png",
            "Images/france.png",
            "Images/germany.png",
            "Images/greece.png",
            "Images/hungary.png",
            "Images/italy.png",
            "Images/romania.png",
            "Images/spain.png",
            "Images/ukraine.png",
            "Images/zimbabwe.png"

        };

        public MainWindow()
        {
            InitializeComponent();
            foreach (var item in countriesPairs)
            {
                countries.Add(new Country(item.Key, item.Value));
            }
            for (int i = 0; i < flagPaths.Count; i++)
            {
                countries[i].Flag = flagPaths[i];
            }
            PopulateData(currentIndex);
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                PopulateData(currentIndex);
            }
            else
            {
                MessageBox.Show("End of list!");
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex < countries.Count - 1)
            {
                currentIndex++;
                PopulateData(currentIndex);
            }
            else
            {
                MessageBox.Show("End of list!");
            }
        }

        public void PopulateData(int currentIndex)
        {
            this.Country.Content = countries[currentIndex].CountryName;
            this.Capital.Content = countries[currentIndex].Capital;
            this.Flag.Source = new BitmapImage(new Uri(countries[currentIndex].Flag, UriKind.Relative));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (countries.Count == 1)
            {
                deletedContries.Add(countries[currentIndex]);
                countries.Remove(countries[currentIndex]);
                this.Country.Content = "---------";
                this.Capital.Content = "---------";
                this.Flag.Source = null;
                Delete.IsEnabled = false;
                MessageBox.Show("List is empty");
                return;
            }
            else
            {
                if (currentIndex == countries.Count - 1)
                {
                    if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        deletedContries.Add(countries[currentIndex]);
                        countries.Remove(countries[currentIndex]);
                        currentIndex--;
                        PopulateData(currentIndex);
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        deletedContries.Add(countries[currentIndex]);
                        countries.Remove(countries[currentIndex]);
                        PopulateData(currentIndex);
                    }
                }
            }
            Undo.IsEnabled = true;
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {

            Country lastCountry = deletedContries.Last();
            countries.Add(lastCountry);
            deletedContries.Remove(lastCountry);
            countries = countries.OrderBy(x => x.CountryName).ToList();
            PopulateData(currentIndex);
            if(deletedContries.Count == 0)
            {
                Undo.IsEnabled = false;
            }
            if(countries.Count > 0)
            {
                Delete.IsEnabled = true;
            }
        }
    }
}



using BeeDone.Models;
using Microsoft.UI.Xaml;
using System.Collections.Generic;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeeDone
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window

    {

        List<Tache> Taches = new List<Tache>();

        public MainWindow()
        {
            InitializeComponent();

            Taches.Add(new Tache("Faire l'épicerie"));
            Taches.Add(new Tache("Réviser WinUI"));

            lvTaches.ItemsSource = Taches;

        }

        private void btnAjoutTache_Click(object sender, RoutedEventArgs e)
        {
            Tache nouvelleTache = new Tache(txtNouvelleTache.Text);

            Taches.Add(nouvelleTache);
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    string nom = txtNom.Text;
        //    txtMessage.Text = $"Bonjour {nom}";
        //}
    }
}

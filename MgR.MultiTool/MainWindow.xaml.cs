
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MgR.MultiTool
{
    public partial class MainWindow : Window
    {
        private static readonly Brush CardBackground =
            new SolidColorBrush(Color.FromRgb(34, 39, 51));

        private static readonly Brush MutedText =
            new SolidColorBrush(Color.FromRgb(174, 182, 197));

        public MainWindow()
        {
            InitializeComponent();
            ShowHome();
        }

        private void ShowPage(
            string title,
            string description,
            UIElement content)
        {
            PageTitle.Text = title;
            PageDescription.Text = description;
            MainContent.Content = content;
        }

        private StackPanel CreatePageContent()
        {
            return new StackPanel
            {
                Orientation = Orientation.Vertical
            };
        }

        private Border CreateCard(
            string title,
            string description,
            string status = "À venir")
        {
            var panel = new StackPanel();

            panel.Children.Add(new TextBlock
            {
                Text = title,
                FontSize = 17,
                FontWeight = FontWeights.SemiBold,
                Foreground = Brushes.White,
                TextWrapping = TextWrapping.Wrap
            });

            panel.Children.Add(new TextBlock
            {
                Text = description,
                FontSize = 13,
                Foreground = MutedText,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(0, 8, 0, 12)
            });

            panel.Children.Add(new TextBlock
            {
                Text = status,
                FontSize = 12,
                Foreground = new SolidColorBrush(
                    Color.FromRgb(174, 161, 255))
            });

            return new Border
            {
                Background = CardBackground,
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(18),
                Margin = new Thickness(0, 0, 0, 12),
                Child = panel
            };
        }

        private void ShowHome()
        {
            var content = CreatePageContent();

            content.Children.Add(CreateCard(
                "Windows",
                "Gère les paramètres, les applications et les fichiers.",
                "6 catégories prévues"));

            content.Children.Add(CreateCard(
                "Programmes utilitaires",
                "Convertis des fichiers et utilise des outils spécialisés.",
                "3 outils prévus"));

            content.Children.Add(CreateCard(
                "Historique des opérations",
                "Retrouve les actions effectuées par MgR multi-tool.",
                "En préparation"));

            content.Children.Add(CreateCard(
                "État du projet",
                "L'interface principale est en cours de construction.",
                "Beta 0.1.0"));

            ShowPage(
                "Bienvenue sur MgR multi-tool",
                "Tes outils Windows et utilitaires réunis dans une seule application.",
                content);
        }

        private void ShowPlaceholder(
            string title,
            string description,
            string details)
        {
            var content = CreatePageContent();

            content.Children.Add(CreateCard(
                title,
                details,
                "Fonctionnalité non implémentée"));

            ShowPage(title, description, content);
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            ShowHome();
        }

        private void Applications_Click(object sender, RoutedEventArgs e)
        {
            ShowPlaceholder(
                "Applications Windows",
                "Gestion des applications installées.",
                "À terme : inventaire, informations sur les applications et désinstallation contrôlée.");
        }

        private void Privacy_Click(object sender, RoutedEventArgs e)
        {
            ShowPlaceholder(
                "Confidentialité",
                "Paramètres de confidentialité et de télémétrie.",
                "À terme : consulter les paramètres disponibles et expliquer leurs conséquences avant toute modification.");
        }

        private void Security_Click(object sender, RoutedEventArgs e)
        {
            ShowPlaceholder(
                "Sécurité Windows",
                "Consultation des paramètres de sécurité.",
                "Les fonctionnalités futures devront préserver les protections de Windows.");
        }

        private void Optimization_Click(object sender, RoutedEventArgs e)
        {
            ShowPlaceholder(
                "Personnalisation et optimisation",
                "Paramètres et possibilités d'optimisation.",
                "Les modifications seront documentées et contrôlées.");
        }

        private void Files_Click(object sender, RoutedEventArgs e)
        {
            ShowPlaceholder(
                "Recherche de fichiers",
                "Analyse des fichiers et dossiers.",
                "À terme : recherche de fichiers vides, arborescence et sélection avant suppression.");
        }

        private void Permissions_Click(object sender, RoutedEventArgs e)
        {
            ShowPlaceholder(
                "Permissions",
                "Consultation et gestion des autorisations.",
                "À terme : afficher les permissions NTFS et prévoir les changements récursifs.");
        }

        private void Converters_Click(object sender, RoutedEventArgs e)
        {
            ShowPlaceholder(
                "Convertisseurs",
                "Conversion des images, sons et vidéos.",
                "À terme : sélectionner des fichiers, choisir un format et suivre la progression.");
        }

        private void Binary_Click(object sender, RoutedEventArgs e)
        {
            ShowPlaceholder(
                "Ressources binaires",
                "Analyse des ressources intégrées aux exécutables.",
                "À terme : explorer les ressources prises en charge dans des fichiers EXE et DLL.");
        }

        private void OnePack_Click(object sender, RoutedEventArgs e)
        {
            ShowPlaceholder(
                "OnePack",
                "Préparation d'installations groupées.",
                "À terme : sélectionner des applications et vérifier les installateurs avant leur lancement.");
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            ShowPlaceholder(
                "Historique",
                "Consulte les opérations effectuées.",
                "Le journal des opérations sera ajouté dans une prochaine étape.");
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            ShowPlaceholder(
                "Paramètres",
                "Configure MgR multi-tool.",
                "À terme : préférences de thème, options de fonctionnement et gestion du journal.");
        }
    }
}

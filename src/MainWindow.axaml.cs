namespace DetectUI {
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Avalonia;
    using Avalonia.Controls;
    using Avalonia.Interactivity;
    using Avalonia.Markup.Xaml;

    public class MainWindow : Window {
        public MainWindow() {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            //this.image = this.Get<Image>("CodeImage");
            //this.openFileButton = this.Get<Button>("OpenFileButton");
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

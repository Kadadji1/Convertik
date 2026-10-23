using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using static FileWheel.App.UI.Controls;
using static FileWheel.Core.Loc;

namespace FileWheel.App.UI;

internal sealed class FeedbackWindow : Window
{
    internal FeedbackWindow()
    {
        Theme.Refresh();
        Title = T("FileWheel — feedback", "FileWheel — обратная связь");
        Width = 520;
        SizeToContent = SizeToContent.Height;
        ResizeMode = ResizeMode.NoResize;
        WindowStartupLocation = WindowStartupLocation.CenterScreen;
        Icon = new BitmapImage(new Uri("pack://application:,,,/Assets/FileWheel.ico"));
        Background = Theme.Page;
        Foreground = Theme.Text;
        FontFamily = Theme.UiFont;

        var root = new StackPanel { Margin = new Thickness(28) };
        root.Children.Add(Text(T("Send useful diagnostics", "Подготовить данные для сообщения"), 25, FontWeights.SemiBold));
        var intro = Text(T("No files or personal data are included. Review the text before sharing it.",
                           "Файлы и личные данные не включаются. Проверьте текст перед отправкой."), 14, brush: Theme.Muted);
        intro.Margin = new Thickness(0, 12, 0, 22);
        root.Children.Add(intro);
        var details = new TextBox
        {
            Text = Diagnostics(), IsReadOnly = true, AcceptsReturn = true, TextWrapping = TextWrapping.Wrap,
            MinHeight = 90, Padding = new Thickness(10), Background = Theme.Card,
            Foreground = Theme.Text, BorderBrush = Theme.PanelBorder,
        };
        root.Children.Add(details);
        var copy = Button(T("Copy diagnostics", "Скопировать данные"), () =>
        {
            Clipboard.SetText(details.Text);
            MessageBox.Show(this, T("Diagnostics copied. Paste them into your message.", "Данные скопированы. Вставьте их в сообщение."),
                "FileWheel", MessageBoxButton.OK, MessageBoxImage.Information);
        }, primary: true);
        copy.Margin = new Thickness(0, 16, 0, 0);
        root.Children.Add(copy);
        Content = root;
    }

    private static string Diagnostics()
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "unknown";
        var architecture = Environment.Is64BitProcess ? "x64" : "x86";
        return $"FileWheel {version}{Environment.NewLine}{Environment.OSVersion}{Environment.NewLine}{architecture}";
    }

    public static void ShowSingle() => new FeedbackWindow().ShowDialog();
}

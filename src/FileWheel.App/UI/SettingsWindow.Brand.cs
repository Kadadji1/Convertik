using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using static FileWheel.App.UI.Controls;
using static FileWheel.Core.Loc;

namespace FileWheel.App.UI;

internal sealed partial class SettingsWindow
{
    private void AboutPage(Panel root)
    {
        var header = new DockPanel { Margin = new Thickness(0, 0, 0, 18) };
        header.Children.Add(new Image
        {
            Source = new BitmapImage(new Uri("pack://application:,,,/Assets/FileWheel.png")),
            Width = 72, Height = 72, Margin = new Thickness(0, 0, 20, 0)
        });
        var heading = new StackPanel { VerticalAlignment = VerticalAlignment.Center };
        heading.Children.Add(Text("Convertik", 30, FontWeights.SemiBold));
        heading.Children.Add(Text(T("A local toolkit for everyday files.", "Локальные инструменты для повседневной работы с файлами."), 14, brush: Theme.Muted));
        header.Children.Add(heading);
        root.Children.Add(header);

        root.Children.Add(Card(T("Made for your files", "Для ваших файлов"),
            T("Convert, edit and organize files from a compact wheel in Windows. Processing happens on this computer.",
              "Конвертируйте, редактируйте и упорядочивайте файлы через компактное меню Windows. Обработка выполняется на этом компьютере."), null, glyph: ""));
        root.Children.Add(SectionHeader(T("Credits", "Авторы исходного кода")));
        root.Children.Add(Card(T("Based on MIT-licensed software", "На основе ПО под лицензией MIT"),
            T("Original copyright notices and third-party license terms are kept in the distribution.",
              "Уведомления об исходных авторах и условия лицензий сторонних компонентов сохранены в дистрибутиве."), null, glyph: ""));
        root.Children.Add(SectionHeader(T("Updates", "Обновления")));
        root.Children.Add(Card("Convertik", T("Updates are not configured yet.", "Автообновления пока не настроены."), null, glyph: ""));
    }
}

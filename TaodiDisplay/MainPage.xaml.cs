using Core;

using Microsoft.UI.Xaml.Controls;

using TaodiZhifa;

namespace TaodiDisplay;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        var ocarina = new OcarinaAC();
        var tempos = ocarina.yinjie.GetNextTempo(12);
        tempos.Insert(0, ocarina.yinjie);
        foreach (var tempo in tempos)
        {
            TaodiIcon taodiIcon = new(tempo.beishu + 12);
            stackpanel.Children.Add(taodiIcon);
        }
    }
}

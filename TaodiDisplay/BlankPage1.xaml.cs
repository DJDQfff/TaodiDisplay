using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

using Core;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

using TaodiZhifa;

using Windows.Foundation;
using Windows.Foundation.Collections;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TaodiDisplay;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class BlankPage1 : Page
{
    public BlankPage1()
    {
        this.InitializeComponent();

        int row = 1;
        int col = 1;
        foreach (var ocarinatype in Enum.GetValues(typeof(ZiRanYinJip)))
        {
            var t = (ZiRanYinJip)ocarinatype;
            var ocarina = new OcarinaAC(t);
            var tempos = ocarina.yinjie.GetNextTempo(12);
            tempos.Insert(0, ocarina.yinjie);
            TextBlock textBlock =
                new()
                {
                    Text = t.ToString(),
                    VerticalAlignment = VerticalAlignment.Center,
                    FontSize = 24
                };
            grid.Children.Add(textBlock);
            Grid.SetRow(textBlock, row);
            Grid.SetColumn(textBlock, 0);
            foreach (var tempo in tempos)
            {
                TaodiIcon taodiIcon = new(tempo.beishu + 12);
                grid.Children.Add(taodiIcon);
                Grid.SetRow(taodiIcon, row);
                Grid.SetColumn(taodiIcon, col++);
            }
            col = 1;
            row++;
        }
    }
}

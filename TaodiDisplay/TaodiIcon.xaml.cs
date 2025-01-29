using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;

using Windows.Foundation;
using Windows.Foundation.Collections;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace TaodiDisplay;

public sealed partial class TaodiIcon : UserControl
{
    private int index;
    public int Index
    {
        get => index;
        private set
        {
            index = value;
            var uri = "ms-appx:Assets/taodi/taodi" + value + ".svg";
            SvgImageSource svg = new(new Uri(uri));
            image.Source = svg;
        }
    }

    public TaodiIcon ([Range(0 , 21)] int version)
        : this()
    {
        Index = version;
    }

    public TaodiIcon ()
    {
        this.InitializeComponent();
    }
}

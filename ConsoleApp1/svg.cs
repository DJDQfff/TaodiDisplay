// 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/svg"
)]
[System.Xml.Serialization.XmlRootAttribute(
    Namespace = "http://www.w3.org/2000/svg",
    IsNullable = false
)]
public partial class svg
{
    private namedview namedviewField;

    private svgDefs defsField;

    private svgG gField;

    private string widthField;

    private string heightField;

    private string viewBoxField;

    private decimal versionField;

    private string idField;

    private string version1Field;

    private string docnameField;

    private string exportfilenameField;

    private byte exportxdpiField;

    private byte exportydpiField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(
        Namespace = "http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd"
    )]
    public namedview namedview
    {
        get { return this.namedviewField; }
        set { this.namedviewField = value; }
    }

    /// <remarks/>
    public svgDefs defs
    {
        get { return this.defsField; }
        set { this.defsField = value; }
    }

    /// <remarks/>
    public svgG g
    {
        get { return this.gField; }
        set { this.gField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string width
    {
        get { return this.widthField; }
        set { this.widthField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string height
    {
        get { return this.heightField; }
        set { this.heightField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string viewBox
    {
        get { return this.viewBoxField; }
        set { this.viewBoxField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal version
    {
        get { return this.versionField; }
        set { this.versionField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get { return this.idField; }
        set { this.idField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        "version",
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public string version1
    {
        get { return this.version1Field; }
        set { this.version1Field = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd"
    )]
    public string docname
    {
        get { return this.docnameField; }
        set { this.docnameField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        "export-filename",
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public string exportfilename
    {
        get { return this.exportfilenameField; }
        set { this.exportfilenameField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        "export-xdpi",
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public byte exportxdpi
    {
        get { return this.exportxdpiField; }
        set { this.exportxdpiField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        "export-ydpi",
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public byte exportydpi
    {
        get { return this.exportydpiField; }
        set { this.exportydpiField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd"
)]
[System.Xml.Serialization.XmlRootAttribute(
    Namespace = "http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd",
    IsNullable = false
)]
public partial class namedview
{
    private string idField;

    private string pagecolorField;

    private string bordercolorField;

    private decimal borderopacityField;

    private byte showpageshadowField;

    private decimal pageopacityField;

    private byte pagecheckerboardField;

    private string deskcolorField;

    private string documentunitsField;

    private decimal zoomField;

    private decimal cxField;

    private decimal cyField;

    private ushort windowwidthField;

    private ushort windowheightField;

    private byte windowxField;

    private sbyte windowyField;

    private byte windowmaximizedField;

    private string currentlayerField;

    private bool showgridField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get { return this.idField; }
        set { this.idField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string pagecolor
    {
        get { return this.pagecolorField; }
        set { this.pagecolorField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string bordercolor
    {
        get { return this.bordercolorField; }
        set { this.bordercolorField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal borderopacity
    {
        get { return this.borderopacityField; }
        set { this.borderopacityField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public byte showpageshadow
    {
        get { return this.showpageshadowField; }
        set { this.showpageshadowField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public decimal pageopacity
    {
        get { return this.pageopacityField; }
        set { this.pageopacityField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public byte pagecheckerboard
    {
        get { return this.pagecheckerboardField; }
        set { this.pagecheckerboardField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public string deskcolor
    {
        get { return this.deskcolorField; }
        set { this.deskcolorField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        "document-units",
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public string documentunits
    {
        get { return this.documentunitsField; }
        set { this.documentunitsField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public decimal zoom
    {
        get { return this.zoomField; }
        set { this.zoomField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public decimal cx
    {
        get { return this.cxField; }
        set { this.cxField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public decimal cy
    {
        get { return this.cyField; }
        set { this.cyField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        "window-width",
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public ushort windowwidth
    {
        get { return this.windowwidthField; }
        set { this.windowwidthField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        "window-height",
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public ushort windowheight
    {
        get { return this.windowheightField; }
        set { this.windowheightField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        "window-x",
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public byte windowx
    {
        get { return this.windowxField; }
        set { this.windowxField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        "window-y",
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public sbyte windowy
    {
        get { return this.windowyField; }
        set { this.windowyField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        "window-maximized",
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public byte windowmaximized
    {
        get { return this.windowmaximizedField; }
        set { this.windowmaximizedField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        "current-layer",
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public string currentlayer
    {
        get { return this.currentlayerField; }
        set { this.currentlayerField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool showgrid
    {
        get { return this.showgridField; }
        set { this.showgridField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/svg"
)]
public partial class svgDefs
{
    private svgDefsLinearGradient linearGradientField;

    private string idField;

    /// <remarks/>
    public svgDefsLinearGradient linearGradient
    {
        get { return this.linearGradientField; }
        set { this.linearGradientField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get { return this.idField; }
        set { this.idField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/svg"
)]
public partial class svgDefsLinearGradient
{
    private svgDefsLinearGradientStop stopField;

    private string idField;

    private string swatchField;

    /// <remarks/>
    public svgDefsLinearGradientStop stop
    {
        get { return this.stopField; }
        set { this.stopField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get { return this.idField; }
        set { this.idField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public string swatch
    {
        get { return this.swatchField; }
        set { this.swatchField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/svg"
)]
public partial class svgDefsLinearGradientStop
{
    private string styleField;

    private byte offsetField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string style
    {
        get { return this.styleField; }
        set { this.styleField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte offset
    {
        get { return this.offsetField; }
        set { this.offsetField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get { return this.idField; }
        set { this.idField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/svg"
)]
public partial class svgG
{
    private svgGPath pathField;

    private svgGG gField;

    private string labelField;

    private string groupmodeField;

    private string idField;

    private string transformField;

    /// <remarks/>
    public svgGPath path
    {
        get { return this.pathField; }
        set { this.pathField = value; }
    }

    /// <remarks/>
    public svgGG g
    {
        get { return this.gField; }
        set { this.gField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public string label
    {
        get { return this.labelField; }
        set { this.labelField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://www.inkscape.org/namespaces/inkscape"
    )]
    public string groupmode
    {
        get { return this.groupmodeField; }
        set { this.groupmodeField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get { return this.idField; }
        set { this.idField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transform
    {
        get { return this.transformField; }
        set { this.transformField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/svg"
)]
public partial class svgGPath
{
    private string styleField;

    private string dField;

    private string idField;

    private string nodetypesField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string style
    {
        get { return this.styleField; }
        set { this.styleField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string d
    {
        get { return this.dField; }
        set { this.dField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get { return this.idField; }
        set { this.idField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(
        Form = System.Xml.Schema.XmlSchemaForm.Qualified,
        Namespace = "http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd"
    )]
    public string nodetypes
    {
        get { return this.nodetypesField; }
        set { this.nodetypesField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/svg"
)]
public partial class svgGG
{
    private svgGGCircle[] circleField;

    private svgGGEllipse[] ellipseField;

    private string idField;

    private string transformField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("circle")]
    public svgGGCircle[] circle
    {
        get { return this.circleField; }
        set { this.circleField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ellipse")]
    public svgGGEllipse[] ellipse
    {
        get { return this.ellipseField; }
        set { this.ellipseField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get { return this.idField; }
        set { this.idField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transform
    {
        get { return this.transformField; }
        set { this.transformField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/svg"
)]
public partial class svgGGCircle
{
    private string styleField;

    private string idField;

    private decimal cxField;

    private decimal cyField;

    private decimal rField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string style
    {
        get { return this.styleField; }
        set { this.styleField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get { return this.idField; }
        set { this.idField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal cx
    {
        get { return this.cxField; }
        set { this.cxField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal cy
    {
        get { return this.cyField; }
        set { this.cyField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal r
    {
        get { return this.rField; }
        set { this.rField = value; }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(
    AnonymousType = true,
    Namespace = "http://www.w3.org/2000/svg"
)]
public partial class svgGGEllipse
{
    private string styleField;

    private string idField;

    private decimal cxField;

    private decimal cyField;

    private decimal rxField;

    private decimal ryField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string style
    {
        get { return this.styleField; }
        set { this.styleField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get { return this.idField; }
        set { this.idField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal cx
    {
        get { return this.cxField; }
        set { this.cxField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal cy
    {
        get { return this.cyField; }
        set { this.cyField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal rx
    {
        get { return this.rxField; }
        set { this.rxField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ry
    {
        get { return this.ryField; }
        set { this.ryField = value; }
    }
}

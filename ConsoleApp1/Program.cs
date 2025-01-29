// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");
var order = new string[]
{
    "111111111111", //1
    "111111111110", //#1
    "111110111111", //2
    "111110111110", //#2
    "111110111101", //3
    "111110111100", //4
    "111110110100", //#4
    "111110111000", //5
    "111110110000", //#5
    "111110100100", //6
    "111110100000", //#6
    "111010100100", //7
    "111010100000", //+1
    "110010100100", //#+1
    "110010100000", //+2
    "100010100000", //#+2
    "000010100100", //+3
    "000010100000", //+4
    "000010000100", //#+4
    "000010000000", //+5
    "000000000000", //#+5
};
Console.WriteLine(order.Length);
Console.WriteLine(order.GroupBy(x => x).Count(x => x.Count() == 1));
var outputfolder = "d:/test/陶笛指法图标";
Directory.CreateDirectory(outputfolder);

var file = "D:\\Projects\\TaoDiStudy\\TaoDiStudy\\陶笛指法图标.svg";
var style =
    "fill:#000000;fill-opacity:1;fill-rule:evenodd;stroke:#000000;stroke-width:0.4;stroke-dasharray:none;stroke-opacity:1";
var style1 = "fill:#";
var style2 =
    ";fill-opacity:1;fill-rule:evenodd;stroke:#000000;stroke-width:0.4;stroke-dasharray:none;stroke-opacity:1";

// style1和style2中间填入一个#开头的6位16进制值表示的颜色RGB以替换原始style
var serializer = new XmlSerializer(typeof(svg));
var originfilestream = new FileStream(file , FileMode.Open);
var svg = serializer.Deserialize(originfilestream) as svg;
for (int index = 0 ; index < order.Length ; index++)
{
    for (int j = 0 ; j < order[index].Length ; j++)
    {
        var stylestring = order[index][j] switch
        {
            '1' => style1 + "000000" + style2,
            '0' => style1 + "ffffff" + style2,
            _ => throw new ArgumentException()
        };
        svg.g.g.circle[j].style = stylestring;
    }
    var newfile = Path.Combine(outputfolder , "taodi" + index + ".svg");
    using FileStream newfilestream = new FileStream(newfile , FileMode.Create);
    serializer.Serialize(newfilestream , svg);
}

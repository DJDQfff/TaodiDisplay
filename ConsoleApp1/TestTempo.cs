using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaodiZhifa;
using TaodiZhifa;

using static Core.Helper;

namespace ConsoleApp1;

internal class TestTempo
{
    internal void Run()
    {
        var ocarina = new OcarinaAC();

        var tempos = ocarina.yinjie.GetNextTempo(12);
        tempos.Insert(0, ocarina.yinjie);
        foreach (var tempo in tempos)
        {
            Console.WriteLine($"{tempo.GaoDiYin}\t{tempo.YinFu}");
        }
    }
}

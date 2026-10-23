using System.Runtime.CompilerServices;
using FileWheel.Core;

namespace FileWheel.Tests;

internal static class TestSetup
{
    /// <summary>Tests assert Czech messages and file names, whatever the machine's language.</summary>
    [ModuleInitializer]
    internal static void Init() => Loc.Current = Language.English;
}

public class LocalizationTests
{
    [Fact]
    public void English_labels_and_output_names()
    {
        try
        {
            Loc.Current = Language.English;
            var ops = FileWheel.Core.Operations.Catalog.Build();
            Assert.Equal("Compress", ops.Single(o => o.Id == "image.compress").Label);
            Assert.Equal("Trim", ops.Single(o => o.Id == "video.trim").Label);
            Assert.Equal("3 items", Loc.Items(3));
            Assert.DoesNotContain(ops, o => o.Label.Any(c => "ěščřžýáíéůúťďňĚŠČŘŽÝÁÍÉŮÚŤĎŇ".Contains(c)));
            Assert.DoesNotContain(ops, o => (o.Subtitle ?? "").Any(c => "ěščřžýáíéůúťďňĚŠČŘŽÝÁÍÉŮÚŤĎŇ".Contains(c)));
        }
        finally
        {
            Loc.Current = Language.English;
        }
    }

    [Fact]
    public void English_plurals()
    {
        Assert.Equal("1 item", Loc.Items(1));
        Assert.Equal("3 items", Loc.Items(3));
        Assert.Equal("5 items", Loc.Items(5));
    }
}

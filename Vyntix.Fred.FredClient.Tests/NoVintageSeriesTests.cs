﻿namespace LeaderAnalytics.Vyntix.Fred.FredClient.Tests;

[TestFixture(FredFileType.JSON)]
[TestFixture(FredFileType.XML)]
public class NoVintageSeriesTests : BaseTest
{
    public NoVintageSeriesTests(FredFileType fileType) : base(fileType)
    {
            
    }

    [Test]
    public async Task GetVintagesTest()
    {
        List<FredObservation> obs = await FredClient.GetNonVintageObservations("SP500");
    }
}
using GradeCalc;

namespace GradeCalc.Tests;

public class NewFeatureTests
{
    [Fact]
    public void FinalGrade_LabsFortyExamSixty()
    {
        double result = GradeCalculator.FinalGrade(new List<int> { 85, 80 }, 77);

        Assert.Equal(79.2, result, precision: 2);
    }

    [Fact]
    public void FinalGrade_RoundsToOneDecimal()
    {
        double result = GradeCalculator.FinalGrade(new List<int> { 81, 82, 82 }, 70);

        Assert.Equal(74.7, result, precision: 2);
    }
}

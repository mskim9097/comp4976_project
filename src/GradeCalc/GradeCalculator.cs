namespace GradeCalc;

/// <summary>
/// Helper methods for working out student grades in a course.
/// </summary>
public static class GradeCalculator
{
    /// <summary>
    /// Returns the average of the scores.
    /// Returns 0 if there are no scores.
    /// </summary>
    public static double Average(IReadOnlyList<int> scores)
    {
        if (scores.Count == 0)
        {
            return 0;
        }

        int total = 0;
        foreach (int score in scores)
        {
            total += score;
        }

        return total / scores.Count;
    }

    /// <summary>
    /// Converts a percent (0 to 100) to a letter grade.
    /// A = 90 and up, B = 80 and up, C = 70 and up, D = 60 and up, F = below 60.
    /// </summary>
    public static string ToLetter(double percent)
    {
        if (percent > 90)
        {
            return "A";
        }
        if (percent >= 80)
        {
            return "B";
        }
        if (percent >= 70)
        {
            return "C";
        }
        if (percent >= 60)
        {
            return "D";
        }
        return "F";
    }

    /// <summary>
    /// Takes 10 points off the score for each day the work is late.
    /// The score can never go below 0.
    /// </summary>
    public static double ApplyLatePenalty(double score, int daysLate)
    {
        if (daysLate <= 0)
        {
            return score;
        }

        return score - daysLate * 10;
    }

    /// <summary>
    /// Returns true if the percent is a passing grade (60 or more).
    /// </summary>
    public static bool IsPassing(double percent)
    {
        return percent >= 60;
    }
}

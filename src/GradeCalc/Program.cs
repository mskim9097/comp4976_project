using GradeCalc;

// A small report for three sample students.
var students = new List<(string Name, List<int> Scores, int DaysLate)>
{
    ("Alex",   new List<int> { 85, 80 }, 0),
    ("Jordan", new List<int> { 90, 90 }, 0),
    ("Sam",    new List<int> { 30, 20 }, 3),
};

Console.WriteLine("=== GradeCalc report ===");
Console.WriteLine();

foreach (var student in students)
{
    double average = GradeCalculator.Average(student.Scores);
    double final = GradeCalculator.ApplyLatePenalty(average, student.DaysLate);
    string letter = GradeCalculator.ToLetter(final);
    string result = GradeCalculator.IsPassing(final) ? "PASS" : "FAIL";

    Console.WriteLine($"{student.Name,-8} average: {average,5}  days late: {student.DaysLate}  final: {final,5}  letter: {letter}  {result}");
}

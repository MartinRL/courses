﻿namespace GetStartedWithCsharp;
public static class GuidedProject
{
    public static string Execute()
    {
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int gradeA = 4;
        int gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;

        int totalCreditHours = 0;
        totalCreditHours += course1Credit;
        totalCreditHours += course2Credit;
        totalCreditHours += course3Credit;
        totalCreditHours += course4Credit;
        totalCreditHours += course5Credit;

        int totalGradePoints = 0;
        totalGradePoints += course1Credit * course1Grade;
        totalGradePoints += course2Credit * course2Grade;
        totalGradePoints += course3Credit * course3Grade;
        totalGradePoints += course4Credit * course4Grade;
        totalGradePoints += course5Credit * course5Grade;

        decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

        using StringWriter sw = new ();
        sw.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
        sw.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
        sw.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
        sw.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
        sw.WriteLine($"{course5Name} {course5Grade} {course5Credit}");
        sw.Write($"Final GPA: {gradePointAverage}");

        return sw.ToString();
    }
}

public class GuidedProjectTests
{
    [Fact]
    public void VerifyGuidedProject() => Verify(GuidedProject.Execute()).ToTask().Wait();
}

namespace GradeLibrary
{
    public class GradeCalculator
    {
        public string GetGrade(double average)
        {
            if (average >= 80)
                return "HD";

            if (average >= 70)
                return "D";

            if (average >= 60)
                return "C";

            if (average >= 50)
                return "P";

            return "N";
        }
    }
}
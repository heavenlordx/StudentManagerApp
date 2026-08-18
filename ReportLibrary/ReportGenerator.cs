namespace ReportLibrary
{
    public class ReportGenerator
    {
        public string GenerateReport(
            string name,
            double average,
            string grade)
        {
            return
                $"Student: {name}\n" +
                $"Average: {average:F2}\n" +
                $"Grade: {grade}";
        }
    }
}
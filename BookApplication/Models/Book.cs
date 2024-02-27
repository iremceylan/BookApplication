namespace BookApplication.Models
{
    public class Book
    {
        public string Name { get; set; } = "";
        public string Author { get; set; } = "";
        public int PageNumber { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsHomeworkUploaded { get; set; }

        public string GetDueDateColor()
        {
            if (IsHomeworkUploaded)
            {
                return "green"; // Homework is uploaded on time
            }

            TimeSpan timeRemaining = DueDate - DateTime.Now;
            int daysRemaining = (int)timeRemaining.TotalDays;

            if (daysRemaining < 0)
            {
                return "red"; // Due date has passed and homework is not uploaded
            }
            else if (daysRemaining <= 7)
            {
                return "yellow"; // Less than or equal to 7 days remaining and homework is not uploaded
            }
            else
            {
                return "red"; // More than 7 days remaining and homework is not uploaded
            }
        }
    }
}

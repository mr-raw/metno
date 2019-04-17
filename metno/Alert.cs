using System;
using System.Drawing;

namespace metno
{
    public class Alert
    {
        public string Description { get; private set; }

        public string PubDate { get; private set; }

        public DateTime To { get; private set; }

        public DateTime From { get; private set; }

        public string Area { get; private set; }

        public string AlertType { get; private set; }

        public Color Level { get; private set; }

        // 07 April 09:00 UTC
        public Alert(MetAlertsDataTypes.Item input)
        {
            var textToSplit = input.Title;
            var splittedText = textToSplit.Split(',');
            AlertType = splittedText[0];
            Level = ConvertToColor(splittedText[1].Trim());
            Area = splittedText[2].Trim();
            try
            {
                DateTime.TryParseExact(splittedText[3].Split(new string[] { "til" }, StringSplitOptions.None)[0].Trim().Replace("UTC", string.Empty), "dd MMMM HH:mm K", null, System.Globalization.DateTimeStyles.AssumeUniversal, out DateTime fromDate);
                From = fromDate;
            }
            catch (IndexOutOfRangeException)
            {
            }

            try
            {
                DateTime.TryParseExact(splittedText[3].Split(new string[] { "til" }, StringSplitOptions.None)[1].Trim().Replace("UTC.", string.Empty), "dd MMMM HH:mm K", null, System.Globalization.DateTimeStyles.AssumeUniversal, out DateTime toDate);
                To = toDate;
            }
            catch (IndexOutOfRangeException)
            {
            }

            Description = input.Description;
            PubDate = input.PubDate;
        }

        private Color ConvertToColor(string input)
        {
            switch (input)
            {
                case "gult nivå":
                    return Color.Yellow;
                case "grønt nivå":
                    return Color.Green;
                case "rødt nivå":
                    return Color.Red;
                default:
                    return Color.White;
            }
        }
    }
}
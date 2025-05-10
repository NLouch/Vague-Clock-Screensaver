namespace VagueClockScreensaver
{
    // Class to work out the time and representi it in a more vague manner
    internal class VagueTime
    {
        private Dictionary<int, string> minsToWords = new Dictionary<int, string>{
            {0, "{{hour}}"},
            {1, "just gone {{hour}}"},
            {2, "just gone {{hour}}"},
            {3, "nearly five past {{hour}}"},
            {4, "nearly five past {{hour}}"},
            {5, "five past {{hour}}"},
            {6, "just gone five past {{hour}}"},
            {7, "just gone five past {{hour}}"},
            {8, "nearly ten past {{hour}}"},
            {9, "nearly ten past {{hour}}"},
            {10, "ten past {{hour}}"},
            {11, "just gone ten past {{hour}}"},
            {12, "just gone ten past {{hour}}"},
            {13, "nearly quarter past {{hour}}"},
            {14, "nearly quarter past {{hour}}"},
            {15, "quarter past {{hour}}"},
            {16, "just gone quarter past {{hour}}"},
            {17, "just gone quarter past {{hour}}"},
            {18, "nearly twenty past {{hour}}"},
            {19, "nearly twenty past {{hour}}"},
            {20, "twenty past {{hour}}"},
            {21, "just gone twenty past {{hour}}"},
            {22, "just gone twenty past {{hour}}"},
            {23, "nearly twenty five past {{hour}}"},
            {24, "nearly twenty five past {{hour}}"},
            {25, "twenty five past {{hour}}"},
            {26, "nearly half past {{hour}}"},
            {27, "nearly half past {{hour}}"},
            {28, "nearly half past {{hour}}"},
            {29, "nearly half past {{hour}}"},
            {30, "half past {{hour}}"},
            {31, "just gone half past {{hour}}"},
            {32, "just gone half past {{hour}}"},
            {33, "just gone half past {{hour}}"},
            {34, "just gone half past {{hour}}"},
            {35, "twenty five to {{hour}}"},
            {36, "just gone twenty five to {{hour}}"},
            {37, "just gone twenty five to {{hour}}"},
            {38, "nearly twenty to {{hour}}"},
            {39, "nearly twenty to {{hour}}"},
            {40, "twenty to {{hour}}"},
            {41, "just gone twenty to {{hour}}"},
            {42, "just gone twenty to {{hour}}"},
            {43, "nearly quarter to {{hour}}"},
            {44, "nearly quarter to {{hour}}"},
            {45, "quarter to {{hour}}"},
            {46, "just gone quarter to {{hour}}"},
            {47, "just gone quarter to {{hour}}"},
            {48, "nearly ten to {{hour}}"},
            {49, "nearly ten to {{hour}}"},
            {50, "ten to {{hour}}"},
            {51, "just gone ten to {{hour}}"},
            {52, "just gone ten to {{hour}}"},
            {53, "nearly five to {{hour}}"},
            {54, "nearly five to {{hour}}"},
            {55, "five to {{hour}}"},
            {56, "just gone five to {{hour}}"},
            {57, "just gone five to {{hour}}"},
            {58, "nearly {{hour}}"},
            {59, "nearly {{hour}}"}
        };

        private Dictionary<int, string> hoursToWords = new Dictionary<int, string>{
            {0, "twelve"},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "one"},
            {14, "two"},
            {15, "three"},
            {16, "four"},
            {17, "five"},
            {18, "six"},
            {19, "seven"},
            {20, "eight"},
            {21, "nine"},
            {22, "ten"},
            {23, "eleven"},
            {24, "twelve"},
        };

        public string GetMinuteBits(int minute)
        {
            return minsToWords[minute];
        }

        public string GetHourBits(int hour)
        {
            return hoursToWords[hour];
        }

        public DateTime GetDateTimeNow()
        {
            return DateTime.Now;
        }

        public string GetVagueTimeString()
        {
            string vagueTime = "";
            string shownTime = "";
            string shownHour = "";
            string suffix = "";
            int hourAdd = 0;

            DateTime time = GetDateTimeNow();

            // Get the bit that contains the minutes
            shownTime = GetMinuteBits(time.Minute);

            // If the time is referencing "to" the hour, or "nearly" the hour, reference the next hour
            if (shownTime.Contains(" to ") || time.Minute > 57) { hourAdd = 1; }

            // Turn the hour integer into words
            shownHour = GetHourBits(time.AddHours(hourAdd).Hour);

            // Deal with things like "midday" or "midnight"
            if (shownHour == "twelve")
            {
                if (time.AddHours(hourAdd).Hour == 12 && (time.Minute < 3 || time.Minute > 57))
                {
                    shownHour = "midday";
                }
                if (time.AddHours(hourAdd).Hour == 0 && (time.Minute < 3 || time.Minute > 57))
                {
                    shownHour = "midnight";
                }
            }

            // Replace the hour in the text string with what we have decided the hour should be represented by
            shownTime = shownTime.Replace("{{hour}}", shownHour);

            // Add a suffic part that represents the vague time of day
            if (time.Hour < 12)
            {
                suffix += "in the morning";
            }
            if (time.Hour >= 12 && time.Hour < 17)
            {
                suffix += "in the afternoon";
            }
            if (time.Hour >= 17 && time.Hour < 20)
            {
                suffix += "in the evening";
            }
            if (time.Hour >= 20 && time.Hour < 24)
            {
                suffix += "at night";
            }

            // Hide the suffix for midday or midnight, because nobody speaks like that
            if (shownTime.Contains("midday") || shownTime.Contains("midnight"))
            {
                suffix = "";
            }

            // Concatenate it all
            vagueTime = ("It's " + shownTime + " " + suffix).Trim().Replace("  ", " ").Replace("  ", " ").Replace("  ", " ");

            // Return it as a string
            return vagueTime;
        }
    }
}

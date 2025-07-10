using System;

namespace TurnUpPortalWeek3And4.Utilities
{
    public static class TestDataHelper
    {
        private static Random rnd = new Random();

        public static string RandomCode()
        {
            return "Code" + rnd.Next(1000, 9999);
        }

        public static string RandomDescription()
        {
            return "Description" + rnd.Next(1000, 9999);
        }

        public static string RandomPrice()
        {
            return rnd.Next(50, 500).ToString();
        }
    }
}
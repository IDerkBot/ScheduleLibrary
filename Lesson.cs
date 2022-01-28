using System;
using System.Collections.Generic;

namespace ScheduleLibrary
{
	public class Lesson
	{
		public static Dictionary<string, int> GetQuantityForWeeks(double percent, int lesson)
		{
			int countReady = 0;
			double chance = percent;
			int weekCount = 1;
			Dictionary<string, int> weeks = new Dictionary<string, int>();
			while (countReady < lesson)
			{
				int countLesson = (int)Math.Truncate(chance);
				if (countLesson >= 1) weeks.Add($"week{weekCount}", countLesson);
				else weeks.Add($"week{weekCount}", countLesson);

				if (chance > 1) chance = chance - Math.Truncate(chance) + percent;
				else chance += percent;

				countReady += countLesson;
				weekCount++;
			}
			return weeks;
		}
	}
}

using System;

namespace ScheduleLibrary
{
	public class Date
	{
		public static DateTime GetFirstSeptember()
		{
			if (DateTime.Now.Month < 8)
				return new DateTime(DateTime.Now.Year - 1, 9, 1);
			else
				return new DateTime(DateTime.Now.Year, 9, 1);
		}
		public static DateTime GetFistJanuary()
		{
			if (DateTime.Now.Month < 8)
				return new DateTime(DateTime.Now.Year, 1, 1);
			else
				return new DateTime(DateTime.Now.Year + 1, 1, 1);
		}
	}
}

using System;

class time{
	public static void Main(String [] args){
		DateTimeOffset utcTime = DateTimeOffset.UtcNow;
		
		TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
		TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
		TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
		
		// converting utc to respective timezones
		DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime,gmtZone);
		DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime,istZone);
		DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime,pstZone);
		
		//printing
		Console.WriteLine("GMT (Greenwich Mean Time): " + gmtTime.ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine("IST (Indian Standard Time): " + istTime.ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine("PST (Pacific Standard Time): " + pstTime.ToString("yyyy-MM-dd HH:mm:ss"));
	}
}
namespace MentorLake.Gtk3.GLib;

public class GTimeValHandle : BaseSafeHandle
{
}


public static class GTimeValHandleExtensions
{
	public static T Add<T>(this T time_, long microseconds) where T : GTimeValHandle
	{
		GTimeValExterns.g_time_val_add(time_, microseconds);
		return time_;
	}

	public static string ToIso8601(this GTimeValHandle time_)
	{
		return GTimeValExterns.g_time_val_to_iso8601(time_);
	}

	public static bool FromIso8601(string iso_date, out GTimeVal time_)
	{
		return GTimeValExterns.g_time_val_from_iso8601(iso_date, out time_);
	}

}
internal class GTimeValExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_time_val_add(GTimeValHandle time_, long microseconds);

	[DllImport(Libraries.GLib)]
	internal static extern string g_time_val_to_iso8601(GTimeValHandle time_);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_time_val_from_iso8601(string iso_date, out GTimeVal time_);

}

public struct GTimeVal
{
	public long tv_sec;
	public long tv_usec;
}

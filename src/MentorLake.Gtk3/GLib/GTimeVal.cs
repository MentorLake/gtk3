namespace MentorLake.GLib;

public class GTimeValHandle : BaseSafeHandle
{
}


public static class GTimeValExtensions
{
	public static void Add(this MentorLake.GLib.GTimeValHandle time_, long microseconds)
	{
		if (time_.IsInvalid || time_.IsClosed) throw new Exception("Invalid or closed handle (GTimeVal)");
		GTimeValExterns.g_time_val_add(time_, microseconds);
	}

	public static string ToIso8601(this MentorLake.GLib.GTimeValHandle time_)
	{
		if (time_.IsInvalid || time_.IsClosed) throw new Exception("Invalid or closed handle (GTimeVal)");
		return GTimeValExterns.g_time_val_to_iso8601(time_);
	}


	public static GTimeVal Dereference(this GTimeValHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTimeVal>(x.DangerousGetHandle());
}
internal class GTimeValExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_time_val_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle time_, long microseconds);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_time_val_to_iso8601([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle time_);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_time_val_from_iso8601(string iso_date, out MentorLake.GLib.GTimeVal time_);

}

public struct GTimeVal
{
	public long tv_sec;
	public long tv_usec;
	public static bool FromIso8601(string iso_date, out MentorLake.GLib.GTimeVal time_)
	{
		return GTimeValExterns.g_time_val_from_iso8601(iso_date, out time_);
	}

}

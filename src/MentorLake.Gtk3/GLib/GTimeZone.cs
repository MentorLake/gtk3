namespace MentorLake.GLib;

public class GTimeZoneHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GTimeZoneHandle New(string identifier)
	{
		return GTimeZoneExterns.g_time_zone_new(identifier);
	}

	public static MentorLake.GLib.GTimeZoneHandle NewIdentifier(string identifier)
	{
		return GTimeZoneExterns.g_time_zone_new_identifier(identifier);
	}

	public static MentorLake.GLib.GTimeZoneHandle NewLocal()
	{
		return GTimeZoneExterns.g_time_zone_new_local();
	}

	public static MentorLake.GLib.GTimeZoneHandle NewOffset(int seconds)
	{
		return GTimeZoneExterns.g_time_zone_new_offset(seconds);
	}

	public static MentorLake.GLib.GTimeZoneHandle NewUtc()
	{
		return GTimeZoneExterns.g_time_zone_new_utc();
	}

}


public static class GTimeZoneExtensions
{
	public static int AdjustTime(this MentorLake.GLib.GTimeZoneHandle tz, MentorLake.GLib.GTimeType type, ref long time_)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_adjust_time(tz, type, ref time_);
	}

	public static int FindInterval(this MentorLake.GLib.GTimeZoneHandle tz, MentorLake.GLib.GTimeType type, long time_)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_find_interval(tz, type, time_);
	}

	public static string GetAbbreviation(this MentorLake.GLib.GTimeZoneHandle tz, int interval)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_get_abbreviation(tz, interval);
	}

	public static string GetIdentifier(this MentorLake.GLib.GTimeZoneHandle tz)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_get_identifier(tz);
	}

	public static int GetOffset(this MentorLake.GLib.GTimeZoneHandle tz, int interval)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_get_offset(tz, interval);
	}

	public static bool IsDst(this MentorLake.GLib.GTimeZoneHandle tz, int interval)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_is_dst(tz, interval);
	}

	public static MentorLake.GLib.GTimeZoneHandle Ref(this MentorLake.GLib.GTimeZoneHandle tz)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		return GTimeZoneExterns.g_time_zone_ref(tz);
	}

	public static void Unref(this MentorLake.GLib.GTimeZoneHandle tz)
	{
		if (tz.IsInvalid) throw new Exception("Invalid handle (GTimeZone)");
		GTimeZoneExterns.g_time_zone_unref(tz);
	}


	public static GTimeZone Dereference(this GTimeZoneHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTimeZone>(x.DangerousGetHandle());
}
internal class GTimeZoneExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_new(string identifier);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_new_identifier(string identifier);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_new_local();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_new_offset(int seconds);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_new_utc();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_time_zone_adjust_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, MentorLake.GLib.GTimeType type, ref long time_);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_time_zone_find_interval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, MentorLake.GLib.GTimeType type, long time_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_time_zone_get_abbreviation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, int interval);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_time_zone_get_identifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_time_zone_get_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, int interval);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_time_zone_is_dst([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz, int interval);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))]
	internal static extern MentorLake.GLib.GTimeZoneHandle g_time_zone_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_time_zone_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeZoneHandle>))] MentorLake.GLib.GTimeZoneHandle tz);

}

public struct GTimeZone
{
}

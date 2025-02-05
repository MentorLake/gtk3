namespace MentorLake.Gtk3.Gio;

public interface GIconHandle
{
}

internal class GIconHandleImpl : BaseSafeHandle, GIconHandle
{
}

public static class GIconHandleExtensions
{
	public static bool Equal(this GIconHandle icon1, GIconHandle icon2)
	{
		return GIconExterns.g_icon_equal(icon1, icon2);
	}

	public static uint Hash(IntPtr icon)
	{
		return GIconExterns.g_icon_hash(icon);
	}

	public static GVariantHandle Serialize(this GIconHandle icon)
	{
		return GIconExterns.g_icon_serialize(icon);
	}

	public static string ToString(this GIconHandle icon)
	{
		return GIconExterns.g_icon_to_string(icon);
	}

	public static GIconHandle Deserialize(GVariantHandle value)
	{
		return GIconExterns.g_icon_deserialize(value);
	}

	public static GIconHandle NewForString(string str, out GErrorHandle error)
	{
		return GIconExterns.g_icon_new_for_string(str, out error);
	}

}

internal class GIconExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_icon_equal(GIconHandle icon1, GIconHandle icon2);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_icon_hash(IntPtr icon);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_icon_serialize(GIconHandle icon);

	[DllImport(Libraries.Gio)]
	internal static extern string g_icon_to_string(GIconHandle icon);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_icon_deserialize(GVariantHandle value);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_icon_new_for_string(string str, out GErrorHandle error);

}

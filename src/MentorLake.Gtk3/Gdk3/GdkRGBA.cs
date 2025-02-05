namespace MentorLake.Gtk3.Gdk3;

public class GdkRGBAHandle : BaseSafeHandle
{
}


public static class GdkRGBAHandleExtensions
{
	public static GdkRGBAHandle GdkRgbaCopy(this GdkRGBAHandle rgba)
	{
		return GdkRGBAExterns.gdk_rgba_copy(rgba);
	}

	public static bool GdkRgbaEqual(IntPtr p1, IntPtr p2)
	{
		return GdkRGBAExterns.gdk_rgba_equal(p1, p2);
	}

	public static T GdkRgbaFree<T>(this T rgba) where T : GdkRGBAHandle
	{
		GdkRGBAExterns.gdk_rgba_free(rgba);
		return rgba;
	}

	public static uint GdkRgbaHash(IntPtr p)
	{
		return GdkRGBAExterns.gdk_rgba_hash(p);
	}

	public static bool GdkRgbaParse(this GdkRGBAHandle rgba, string spec)
	{
		return GdkRGBAExterns.gdk_rgba_parse(rgba, spec);
	}

	public static string GdkRgbaToString(this GdkRGBAHandle rgba)
	{
		return GdkRGBAExterns.gdk_rgba_to_string(rgba);
	}

}
internal class GdkRGBAExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern GdkRGBAHandle gdk_rgba_copy(GdkRGBAHandle rgba);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_rgba_equal(IntPtr p1, IntPtr p2);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_rgba_free(GdkRGBAHandle rgba);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_rgba_hash(IntPtr p);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_rgba_parse(GdkRGBAHandle rgba, string spec);

	[DllImport(Libraries.Gdk3)]
	internal static extern string gdk_rgba_to_string(GdkRGBAHandle rgba);

}

public struct GdkRGBA
{
	public double red;
	public double green;
	public double blue;
	public double alpha;
}

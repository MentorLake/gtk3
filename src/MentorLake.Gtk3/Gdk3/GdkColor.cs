namespace MentorLake.Gtk3.Gdk3;

public class GdkColorHandle : BaseSafeHandle
{
}


public static class GdkColorHandleExtensions
{
	public static GdkColorHandle Copy(this GdkColorHandle color)
	{
		return GdkColorExterns.gdk_color_copy(color);
	}

	public static bool Equal(this GdkColorHandle colora, GdkColorHandle colorb)
	{
		return GdkColorExterns.gdk_color_equal(colora, colorb);
	}

	public static GdkColorHandle Free(this GdkColorHandle color)
	{
		GdkColorExterns.gdk_color_free(color);
		return color;
	}

	public static uint Hash(this GdkColorHandle color)
	{
		return GdkColorExterns.gdk_color_hash(color);
	}

	public static string ToString(this GdkColorHandle color)
	{
		return GdkColorExterns.gdk_color_to_string(color);
	}

}
internal class GdkColorExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern GdkColorHandle gdk_color_copy(GdkColorHandle color);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_color_equal(GdkColorHandle colora, GdkColorHandle colorb);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_color_free(GdkColorHandle color);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_color_hash(GdkColorHandle color);

	[DllImport(Libraries.Gdk3)]
	internal static extern string gdk_color_to_string(GdkColorHandle color);

}

public struct GdkColor
{
	public uint pixel;
	public ushort red;
	public ushort green;
	public ushort blue;
}

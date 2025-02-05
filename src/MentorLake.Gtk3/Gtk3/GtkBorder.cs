namespace MentorLake.Gtk3.Gtk3;

public class GtkBorderHandle : BaseSafeHandle
{
	public static GtkBorderHandle New()
	{
		return GtkBorderExterns.gtk_border_new();
	}

}


public static class GtkBorderHandleExtensions
{
	public static GtkBorderHandle Copy(this GtkBorderHandle border_)
	{
		return GtkBorderExterns.gtk_border_copy(border_);
	}

	public static T Free<T>(this T border_) where T : GtkBorderHandle
	{
		GtkBorderExterns.gtk_border_free(border_);
		return border_;
	}

}
internal class GtkBorderExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBorderHandle gtk_border_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBorderHandle gtk_border_copy(GtkBorderHandle border_);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_border_free(GtkBorderHandle border_);

}

public struct GtkBorder
{
	public short left;
	public short right;
	public short top;
	public short bottom;
}

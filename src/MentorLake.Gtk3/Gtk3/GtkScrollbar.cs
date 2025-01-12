namespace MentorLake.Gtk3.Gtk3;

public class GtkScrollbarHandle : GtkRangeHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkScrollbarHandle New(GtkOrientation orientation, GtkAdjustmentHandle adjustment)
	{
		return GtkScrollbarExterns.gtk_scrollbar_new(orientation, adjustment);
	}

}

public static class GtkScrollbarHandleExtensions
{
}

internal class GtkScrollbarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkScrollbarHandle gtk_scrollbar_new(GtkOrientation orientation, GtkAdjustmentHandle adjustment);

}

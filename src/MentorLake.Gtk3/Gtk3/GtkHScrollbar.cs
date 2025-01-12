namespace MentorLake.Gtk3.Gtk3;

public class GtkHScrollbarHandle : GtkScrollbarHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkHScrollbarHandle GtkHscrollbarNew(GtkAdjustmentHandle adjustment)
	{
		return GtkHScrollbarExterns.gtk_hscrollbar_new(adjustment);
	}

}

public static class GtkHScrollbarHandleExtensions
{
}

internal class GtkHScrollbarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkHScrollbarHandle gtk_hscrollbar_new(GtkAdjustmentHandle adjustment);

}

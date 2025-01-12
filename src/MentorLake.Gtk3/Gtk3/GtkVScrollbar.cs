namespace MentorLake.Gtk3.Gtk3;

public class GtkVScrollbarHandle : GtkScrollbarHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkVScrollbarHandle GtkVscrollbarNew(GtkAdjustmentHandle adjustment)
	{
		return GtkVScrollbarExterns.gtk_vscrollbar_new(adjustment);
	}

}

public static class GtkVScrollbarHandleExtensions
{
}

internal class GtkVScrollbarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkVScrollbarHandle gtk_vscrollbar_new(GtkAdjustmentHandle adjustment);

}

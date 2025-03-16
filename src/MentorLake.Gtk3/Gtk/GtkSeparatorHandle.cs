namespace MentorLake.Gtk;

public class GtkSeparatorHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkSeparatorHandle New(MentorLake.Gtk.GtkOrientation orientation)
	{
		return GtkSeparatorHandleExterns.gtk_separator_new(orientation);
	}

}

public static class GtkSeparatorHandleExtensions
{
}

internal class GtkSeparatorHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSeparatorHandle gtk_separator_new(MentorLake.Gtk.GtkOrientation orientation);

}

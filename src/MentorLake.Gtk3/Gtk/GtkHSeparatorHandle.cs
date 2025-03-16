namespace MentorLake.Gtk;

public class GtkHSeparatorHandle : GtkSeparatorHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkHSeparatorHandle New()
	{
		return GtkHSeparatorHandleExterns.gtk_hseparator_new();
	}

}

public static class GtkHSeparatorHandleExtensions
{
}

internal class GtkHSeparatorHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkHSeparatorHandle gtk_hseparator_new();

}

namespace MentorLake.Gtk3.Gtk3;

public class GtkSeparatorHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkSeparatorHandle New(GtkOrientation orientation)
	{
		return GtkSeparatorExterns.gtk_separator_new(orientation);
	}

}

public static class GtkSeparatorHandleExtensions
{
}

internal class GtkSeparatorExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSeparatorHandle gtk_separator_new(GtkOrientation orientation);

}

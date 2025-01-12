namespace MentorLake.Gtk3.Gtk3;

public class GtkHSeparatorHandle : GtkSeparatorHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkHSeparatorHandle GtkHseparatorNew()
	{
		return GtkHSeparatorExterns.gtk_hseparator_new();
	}

}

public static class GtkHSeparatorHandleExtensions
{
}

internal class GtkHSeparatorExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkHSeparatorHandle gtk_hseparator_new();

}

namespace MentorLake.Gtk3.Gtk3;

public class GtkPlugAccessibleHandle : GtkWindowAccessibleHandle, AtkComponentHandle, AtkWindowHandle
{
}

public static class GtkPlugAccessibleHandleExtensions
{
	public static string GetId(this GtkPlugAccessibleHandle plug)
	{
		return GtkPlugAccessibleExterns.gtk_plug_accessible_get_id(plug);
	}

}

internal class GtkPlugAccessibleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_plug_accessible_get_id(GtkPlugAccessibleHandle plug);

}

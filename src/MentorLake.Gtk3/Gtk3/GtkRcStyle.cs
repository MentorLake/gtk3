namespace MentorLake.Gtk3.Gtk3;

public class GtkRcStyleHandle : GObjectHandle
{
	public static GtkRcStyleHandle New()
	{
		return GtkRcStyleExterns.gtk_rc_style_new();
	}

}

public static class GtkRcStyleHandleExtensions
{
	public static GtkRcStyleHandle Copy(this GtkRcStyleHandle orig)
	{
		return GtkRcStyleExterns.gtk_rc_style_copy(orig);
	}

}

internal class GtkRcStyleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRcStyleHandle gtk_rc_style_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRcStyleHandle gtk_rc_style_copy(GtkRcStyleHandle orig);

}

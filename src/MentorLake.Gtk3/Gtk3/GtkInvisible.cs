namespace MentorLake.Gtk3.Gtk3;

public class GtkInvisibleHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkInvisibleHandle New()
	{
		return GtkInvisibleExterns.gtk_invisible_new();
	}

	public static GtkInvisibleHandle NewForScreen(GdkScreenHandle screen)
	{
		return GtkInvisibleExterns.gtk_invisible_new_for_screen(screen);
	}

}

public static class GtkInvisibleHandleExtensions
{
	public static GdkScreenHandle GetScreen(this GtkInvisibleHandle invisible)
	{
		return GtkInvisibleExterns.gtk_invisible_get_screen(invisible);
	}

	public static GtkInvisibleHandle SetScreen(this GtkInvisibleHandle invisible, GdkScreenHandle screen)
	{
		GtkInvisibleExterns.gtk_invisible_set_screen(invisible, screen);
		return invisible;
	}

}

internal class GtkInvisibleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkInvisibleHandle gtk_invisible_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkInvisibleHandle gtk_invisible_new_for_screen(GdkScreenHandle screen);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkScreenHandle gtk_invisible_get_screen(GtkInvisibleHandle invisible);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_invisible_set_screen(GtkInvisibleHandle invisible, GdkScreenHandle screen);

}

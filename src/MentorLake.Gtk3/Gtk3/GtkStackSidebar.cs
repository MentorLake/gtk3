namespace MentorLake.Gtk3.Gtk3;

public class GtkStackSidebarHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkStackSidebarHandle New()
	{
		return GtkStackSidebarExterns.gtk_stack_sidebar_new();
	}

}

public static class GtkStackSidebarHandleExtensions
{
	public static GtkStackHandle GetStack(this GtkStackSidebarHandle sidebar)
	{
		return GtkStackSidebarExterns.gtk_stack_sidebar_get_stack(sidebar);
	}

	public static GtkStackSidebarHandle SetStack(this GtkStackSidebarHandle sidebar, GtkStackHandle stack)
	{
		GtkStackSidebarExterns.gtk_stack_sidebar_set_stack(sidebar, stack);
		return sidebar;
	}

}

internal class GtkStackSidebarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStackSidebarHandle gtk_stack_sidebar_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStackHandle gtk_stack_sidebar_get_stack(GtkStackSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_sidebar_set_stack(GtkStackSidebarHandle sidebar, GtkStackHandle stack);

}

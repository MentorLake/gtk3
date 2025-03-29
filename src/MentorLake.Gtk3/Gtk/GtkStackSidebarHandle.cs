namespace MentorLake.Gtk;

public class GtkStackSidebarHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkStackSidebarHandle New()
	{
		return GtkStackSidebarHandleExterns.gtk_stack_sidebar_new();
	}

}

public static class GtkStackSidebarHandleExtensions
{
	public static MentorLake.Gtk.GtkStackHandle GetStack(this MentorLake.Gtk.GtkStackSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkStackSidebarHandle)");
		return GtkStackSidebarHandleExterns.gtk_stack_sidebar_get_stack(sidebar);
	}

	public static T SetStack<T>(this T sidebar, MentorLake.Gtk.GtkStackHandle stack) where T : GtkStackSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkStackSidebarHandle)");
		GtkStackSidebarHandleExterns.gtk_stack_sidebar_set_stack(sidebar, stack);
		return sidebar;
	}

}

internal class GtkStackSidebarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStackSidebarHandle gtk_stack_sidebar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStackHandle gtk_stack_sidebar_get_stack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackSidebarHandle>))] MentorLake.Gtk.GtkStackSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_sidebar_set_stack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackSidebarHandle>))] MentorLake.Gtk.GtkStackSidebarHandle sidebar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

}

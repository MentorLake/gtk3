namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkStackSidebar enables you to quickly and easily provide a
/// consistent "sidebar" object for your user interface.
/// </para>
/// <para>
/// In order to use a GtkStackSidebar, you simply use a GtkStack to
/// organize your UI flow, and add the sidebar to your sidebar area. You
/// can use gtk_stack_sidebar_set_stack() to connect the #GtkStackSidebar
/// to the #GtkStack.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkStackSidebar has a single CSS node with name stacksidebar and
/// style class .sidebar.
/// </para>
/// <para>
/// When circumstances require it, GtkStackSidebar adds the
/// .needs-attention style class to the widgets representing the stack
/// pages.
/// </para>
/// </summary>

public class GtkStackSidebarHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new sidebar.
/// </para>
/// </summary>

/// <return>
/// the new #GtkStackSidebar
/// </return>

	public static MentorLake.Gtk.GtkStackSidebarHandle New()
	{
		return GtkStackSidebarHandleExterns.gtk_stack_sidebar_new();
	}

}

public static class GtkStackSidebarHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the stack.
/// See gtk_stack_sidebar_set_stack().
/// </para>
/// </summary>

/// <param name="sidebar">
/// a #GtkStackSidebar
/// </param>
/// <return>
/// the associated #GtkStack or
///     %NULL if none has been set explicitly
/// </return>

	public static MentorLake.Gtk.GtkStackHandle GetStack(this MentorLake.Gtk.GtkStackSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkStackSidebarHandle)");
		return GtkStackSidebarHandleExterns.gtk_stack_sidebar_get_stack(sidebar);
	}

/// <summary>
/// <para>
/// Set the #GtkStack associated with this #GtkStackSidebar.
/// </para>
/// <para>
/// The sidebar widget will automatically update according to the order
/// (packing) and items within the given #GtkStack.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a #GtkStackSidebar
/// </param>
/// <param name="stack">
/// a #GtkStack
/// </param>

	public static T SetStack<T>(this T sidebar, MentorLake.Gtk.GtkStackHandle stack) where T : GtkStackSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkStackSidebarHandle)");
		GtkStackSidebarHandleExterns.gtk_stack_sidebar_set_stack(sidebar, stack);
		return sidebar;
	}

}

internal class GtkStackSidebarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStackSidebarHandle>))]
	internal static extern MentorLake.Gtk.GtkStackSidebarHandle gtk_stack_sidebar_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))]
	internal static extern MentorLake.Gtk.GtkStackHandle gtk_stack_sidebar_get_stack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackSidebarHandle>))] MentorLake.Gtk.GtkStackSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_sidebar_set_stack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackSidebarHandle>))] MentorLake.Gtk.GtkStackSidebarHandle sidebar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

}

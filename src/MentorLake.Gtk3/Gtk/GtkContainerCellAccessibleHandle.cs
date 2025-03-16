namespace MentorLake.Gtk;

public class GtkContainerCellAccessibleHandle : GtkCellAccessibleHandle, AtkActionHandle, AtkComponentHandle, AtkTableCellHandle
{
	public static MentorLake.Gtk.GtkContainerCellAccessibleHandle New()
	{
		return GtkContainerCellAccessibleHandleExterns.gtk_container_cell_accessible_new();
	}

}

public static class GtkContainerCellAccessibleHandleExtensions
{
	public static T AddChild<T>(this T container, MentorLake.Gtk.GtkCellAccessibleHandle child) where T : GtkContainerCellAccessibleHandle
	{
		GtkContainerCellAccessibleHandleExterns.gtk_container_cell_accessible_add_child(container, child);
		return container;
	}

	public static MentorLake.GLib.GListHandle GetChildren(this MentorLake.Gtk.GtkContainerCellAccessibleHandle container)
	{
		return GtkContainerCellAccessibleHandleExterns.gtk_container_cell_accessible_get_children(container);
	}

	public static T RemoveChild<T>(this T container, MentorLake.Gtk.GtkCellAccessibleHandle child) where T : GtkContainerCellAccessibleHandle
	{
		GtkContainerCellAccessibleHandleExterns.gtk_container_cell_accessible_remove_child(container, child);
		return container;
	}

}

internal class GtkContainerCellAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkContainerCellAccessibleHandle gtk_container_cell_accessible_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_cell_accessible_add_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerCellAccessibleHandle>))] MentorLake.Gtk.GtkContainerCellAccessibleHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_container_cell_accessible_get_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerCellAccessibleHandle>))] MentorLake.Gtk.GtkContainerCellAccessibleHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_cell_accessible_remove_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerCellAccessibleHandle>))] MentorLake.Gtk.GtkContainerCellAccessibleHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle child);

}

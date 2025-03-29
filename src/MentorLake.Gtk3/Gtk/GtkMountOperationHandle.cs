namespace MentorLake.Gtk;

public class GtkMountOperationHandle : GMountOperationHandle
{
	public static MentorLake.Gtk.GtkMountOperationHandle New(MentorLake.Gtk.GtkWindowHandle parent)
	{
		return GtkMountOperationHandleExterns.gtk_mount_operation_new(parent);
	}

}

public static class GtkMountOperationHandleExtensions
{
	public static MentorLake.Gtk.GtkWindowHandle GetParent(this MentorLake.Gtk.GtkMountOperationHandle op)
	{
		if (op.IsInvalid || op.IsClosed) throw new Exception("Invalid or closed handle (GtkMountOperationHandle)");
		return GtkMountOperationHandleExterns.gtk_mount_operation_get_parent(op);
	}

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkMountOperationHandle op)
	{
		if (op.IsInvalid || op.IsClosed) throw new Exception("Invalid or closed handle (GtkMountOperationHandle)");
		return GtkMountOperationHandleExterns.gtk_mount_operation_get_screen(op);
	}

	public static bool IsShowing(this MentorLake.Gtk.GtkMountOperationHandle op)
	{
		if (op.IsInvalid || op.IsClosed) throw new Exception("Invalid or closed handle (GtkMountOperationHandle)");
		return GtkMountOperationHandleExterns.gtk_mount_operation_is_showing(op);
	}

	public static T SetParent<T>(this T op, MentorLake.Gtk.GtkWindowHandle parent) where T : GtkMountOperationHandle
	{
		if (op.IsInvalid || op.IsClosed) throw new Exception("Invalid or closed handle (GtkMountOperationHandle)");
		GtkMountOperationHandleExterns.gtk_mount_operation_set_parent(op, parent);
		return op;
	}

	public static T SetScreen<T>(this T op, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkMountOperationHandle
	{
		if (op.IsInvalid || op.IsClosed) throw new Exception("Invalid or closed handle (GtkMountOperationHandle)");
		GtkMountOperationHandleExterns.gtk_mount_operation_set_screen(op, screen);
		return op;
	}

}

internal class GtkMountOperationHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMountOperationHandle gtk_mount_operation_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_mount_operation_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMountOperationHandle>))] MentorLake.Gtk.GtkMountOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkScreenHandle gtk_mount_operation_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMountOperationHandle>))] MentorLake.Gtk.GtkMountOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_mount_operation_is_showing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMountOperationHandle>))] MentorLake.Gtk.GtkMountOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_mount_operation_set_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMountOperationHandle>))] MentorLake.Gtk.GtkMountOperationHandle op, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_mount_operation_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMountOperationHandle>))] MentorLake.Gtk.GtkMountOperationHandle op, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

}

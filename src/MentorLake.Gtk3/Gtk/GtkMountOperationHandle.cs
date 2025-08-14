namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// This should not be accessed directly. Use the accessor functions below.
/// </para>
/// </summary>

public class GtkMountOperationHandle : GMountOperationHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkMountOperation
/// </para>
/// </summary>

/// <param name="parent">
/// transient parent of the window, or %NULL
/// </param>
/// <return>
/// a new #GtkMountOperation
/// </return>

	public static MentorLake.Gtk.GtkMountOperationHandle New(MentorLake.Gtk.GtkWindowHandle parent)
	{
		return GtkMountOperationHandleExterns.gtk_mount_operation_new(parent);
	}

}

public static class GtkMountOperationHandleExtensions
{
/// <summary>
/// <para>
/// Gets the transient parent used by the #GtkMountOperation
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkMountOperation
/// </param>
/// <return>
/// the transient parent for windows shown by @op
/// </return>

	public static MentorLake.Gtk.GtkWindowHandle GetParent(this MentorLake.Gtk.GtkMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkMountOperationHandle)");
		return GtkMountOperationHandleExterns.gtk_mount_operation_get_parent(op);
	}

/// <summary>
/// <para>
/// Gets the screen on which windows of the #GtkMountOperation
/// will be shown.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkMountOperation
/// </param>
/// <return>
/// the screen on which windows of @op are shown
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkMountOperationHandle)");
		return GtkMountOperationHandleExterns.gtk_mount_operation_get_screen(op);
	}

/// <summary>
/// <para>
/// Returns whether the #GtkMountOperation is currently displaying
/// a window.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkMountOperation
/// </param>
/// <return>
/// %TRUE if @op is currently displaying a window
/// </return>

	public static bool IsShowing(this MentorLake.Gtk.GtkMountOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkMountOperationHandle)");
		return GtkMountOperationHandleExterns.gtk_mount_operation_is_showing(op);
	}

/// <summary>
/// <para>
/// Sets the transient parent for windows shown by the
/// #GtkMountOperation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkMountOperation
/// </param>
/// <param name="parent">
/// transient parent of the window, or %NULL
/// </param>

	public static T SetParent<T>(this T op, MentorLake.Gtk.GtkWindowHandle parent) where T : GtkMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkMountOperationHandle)");
		GtkMountOperationHandleExterns.gtk_mount_operation_set_parent(op, parent);
		return op;
	}

/// <summary>
/// <para>
/// Sets the screen to show windows of the #GtkMountOperation on.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkMountOperation
/// </param>
/// <param name="screen">
/// a #GdkScreen
/// </param>

	public static T SetScreen<T>(this T op, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkMountOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkMountOperationHandle)");
		GtkMountOperationHandleExterns.gtk_mount_operation_set_screen(op, screen);
		return op;
	}

}

internal class GtkMountOperationHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMountOperationHandle>))]
	internal static extern MentorLake.Gtk.GtkMountOperationHandle gtk_mount_operation_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_mount_operation_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMountOperationHandle>))] MentorLake.Gtk.GtkMountOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gtk_mount_operation_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMountOperationHandle>))] MentorLake.Gtk.GtkMountOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_mount_operation_is_showing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMountOperationHandle>))] MentorLake.Gtk.GtkMountOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_mount_operation_set_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMountOperationHandle>))] MentorLake.Gtk.GtkMountOperationHandle op, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_mount_operation_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMountOperationHandle>))] MentorLake.Gtk.GtkMountOperationHandle op, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

}

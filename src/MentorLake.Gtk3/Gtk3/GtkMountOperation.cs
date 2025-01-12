namespace MentorLake.Gtk3.Gtk3;

public class GtkMountOperationHandle : GMountOperationHandle
{
	public static GtkMountOperationHandle New(GtkWindowHandle parent)
	{
		return GtkMountOperationExterns.gtk_mount_operation_new(parent);
	}

}

public static class GtkMountOperationHandleExtensions
{
	public static GtkWindowHandle GetParent(this GtkMountOperationHandle op)
	{
		return GtkMountOperationExterns.gtk_mount_operation_get_parent(op);
	}

	public static GdkScreenHandle GetScreen(this GtkMountOperationHandle op)
	{
		return GtkMountOperationExterns.gtk_mount_operation_get_screen(op);
	}

	public static bool IsShowing(this GtkMountOperationHandle op)
	{
		return GtkMountOperationExterns.gtk_mount_operation_is_showing(op);
	}

	public static GtkMountOperationHandle SetParent(this GtkMountOperationHandle op, GtkWindowHandle parent)
	{
		GtkMountOperationExterns.gtk_mount_operation_set_parent(op, parent);
		return op;
	}

	public static GtkMountOperationHandle SetScreen(this GtkMountOperationHandle op, GdkScreenHandle screen)
	{
		GtkMountOperationExterns.gtk_mount_operation_set_screen(op, screen);
		return op;
	}

}

internal class GtkMountOperationExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMountOperationHandle gtk_mount_operation_new(GtkWindowHandle parent);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWindowHandle gtk_mount_operation_get_parent(GtkMountOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkScreenHandle gtk_mount_operation_get_screen(GtkMountOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_mount_operation_is_showing(GtkMountOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_mount_operation_set_parent(GtkMountOperationHandle op, GtkWindowHandle parent);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_mount_operation_set_screen(GtkMountOperationHandle op, GdkScreenHandle screen);

}

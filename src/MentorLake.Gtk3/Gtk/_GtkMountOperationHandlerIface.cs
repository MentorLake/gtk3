namespace MentorLake.Gtk;

public class _GtkMountOperationHandlerIfaceHandle : BaseSafeHandle
{
}


public static class _GtkMountOperationHandlerIfaceExtensions
{

	public static _GtkMountOperationHandlerIface Dereference(this _GtkMountOperationHandlerIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<_GtkMountOperationHandlerIface>(x.DangerousGetHandle());
}
internal class _GtkMountOperationHandlerIfaceExterns
{
}

public struct _GtkMountOperationHandlerIface
{
	public GTypeInterface parent_iface;
	public IntPtr handle_ask_password;
	public IntPtr handle_ask_question;
	public IntPtr handle_close;
	public IntPtr handle_show_processes;
}

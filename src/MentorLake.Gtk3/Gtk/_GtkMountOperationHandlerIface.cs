namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Virtual table for the D-Bus interface &amp;lt;link linkend=&quot;gdbus-interface-org-Gtk-MountOperationHandler.top_of_page&quot;&amp;gt;org.Gtk.MountOperationHandler&amp;lt;/link&amp;gt;.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Virtual table for the D-Bus interface &amp;lt;link linkend=&quot;gdbus-interface-org-Gtk-MountOperationHandler.top_of_page&quot;&amp;gt;org.Gtk.MountOperationHandler&amp;lt;/link&amp;gt;.
/// </para>
/// </summary>

public struct _GtkMountOperationHandlerIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface parent_iface;
	/// <summary>
/// <para>
/// Handler for the #_GtkMountOperationHandler::handle-ask-password signal.
/// </para>
/// </summary>

public IntPtr handle_ask_password;
	/// <summary>
/// <para>
/// Handler for the #_GtkMountOperationHandler::handle-ask-question signal.
/// </para>
/// </summary>

public IntPtr handle_ask_question;
	/// <summary>
/// <para>
/// Handler for the #_GtkMountOperationHandler::handle-close signal.
/// </para>
/// </summary>

public IntPtr handle_close;
	/// <summary>
/// <para>
/// Handler for the #_GtkMountOperationHandler::handle-show-processes signal.
/// </para>
/// </summary>

public IntPtr handle_show_processes;
}

namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Virtual function table for the #GtkToolShell interface.
/// </para>
/// </summary>

public class GtkToolShellIfaceHandle : BaseSafeHandle
{
}


public static class GtkToolShellIfaceExtensions
{

	public static GtkToolShellIface Dereference(this GtkToolShellIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolShellIface>(x.DangerousGetHandle());
}
internal class GtkToolShellIfaceExterns
{
}

/// <summary>
/// <para>
/// Virtual function table for the #GtkToolShell interface.
/// </para>
/// </summary>

public struct GtkToolShellIface
{
	/// <summary>
/// <para>
/// mandatory implementation of gtk_tool_shell_get_icon_size().
/// </para>
/// </summary>

public IntPtr get_icon_size;
	/// <summary>
/// <para>
/// mandatory implementation of gtk_tool_shell_get_orientation().
/// </para>
/// </summary>

public IntPtr get_orientation;
	/// <summary>
/// <para>
/// mandatory implementation of gtk_tool_shell_get_style().
/// </para>
/// </summary>

public IntPtr get_style;
	/// <summary>
/// <para>
/// optional implementation of gtk_tool_shell_get_relief_style().
/// </para>
/// </summary>

public IntPtr get_relief_style;
	/// <summary>
/// <para>
/// optional implementation of gtk_tool_shell_rebuild_menu().
/// </para>
/// </summary>

public IntPtr rebuild_menu;
	/// <summary>
/// <para>
/// optional implementation of gtk_tool_shell_get_text_orientation().
/// </para>
/// </summary>

public IntPtr get_text_orientation;
	/// <summary>
/// <para>
/// optional implementation of gtk_tool_shell_get_text_alignment().
/// </para>
/// </summary>

public IntPtr get_text_alignment;
	/// <summary>
/// <para>
/// optional implementation of gtk_tool_shell_get_ellipsize_mode().
/// </para>
/// </summary>

public IntPtr get_ellipsize_mode;
	/// <summary>
/// <para>
/// optional implementation of gtk_tool_shell_get_text_size_group().
/// </para>
/// </summary>

public IntPtr get_text_size_group;
}

namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkToolShell interface allows container widgets to provide additional
/// information when embedding #GtkToolItem widgets.
/// </para>
/// </summary>

public interface GtkToolShellHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkToolShellHandleImpl : BaseSafeHandle, GtkToolShellHandle
{
}

public static class GtkToolShellHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the current ellipsize mode for the tool shell. Tool items must not
/// call this function directly, but rely on gtk_tool_item_get_ellipsize_mode()
/// instead.
/// </para>
/// </summary>

/// <param name="shell">
/// a #GtkToolShell
/// </param>
/// <return>
/// the current ellipsize mode of @shell
/// </return>

	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsizeMode(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		if (shell.IsInvalid) throw new Exception("Invalid handle (GtkToolShellHandle)");
		return GtkToolShellHandleExterns.gtk_tool_shell_get_ellipsize_mode(shell);
	}

/// <summary>
/// <para>
/// Retrieves the icon size for the tool shell. Tool items must not call this
/// function directly, but rely on gtk_tool_item_get_icon_size() instead.
/// </para>
/// </summary>

/// <param name="shell">
/// a #GtkToolShell
/// </param>
/// <return>
/// the current size (#GtkIconSize) for icons of @shell
/// </return>

	public static MentorLake.Gtk.GtkIconSize GetIconSize(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		if (shell.IsInvalid) throw new Exception("Invalid handle (GtkToolShellHandle)");
		return GtkToolShellHandleExterns.gtk_tool_shell_get_icon_size(shell);
	}

/// <summary>
/// <para>
/// Retrieves the current orientation for the tool shell. Tool items must not
/// call this function directly, but rely on gtk_tool_item_get_orientation()
/// instead.
/// </para>
/// </summary>

/// <param name="shell">
/// a #GtkToolShell
/// </param>
/// <return>
/// the current orientation of @shell
/// </return>

	public static MentorLake.Gtk.GtkOrientation GetOrientation(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		if (shell.IsInvalid) throw new Exception("Invalid handle (GtkToolShellHandle)");
		return GtkToolShellHandleExterns.gtk_tool_shell_get_orientation(shell);
	}

/// <summary>
/// <para>
/// Returns the relief style of buttons on @shell. Tool items must not call this
/// function directly, but rely on gtk_tool_item_get_relief_style() instead.
/// </para>
/// </summary>

/// <param name="shell">
/// a #GtkToolShell
/// </param>
/// <return>
/// The relief style of buttons on @shell.
/// </return>

	public static MentorLake.Gtk.GtkReliefStyle GetReliefStyle(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		if (shell.IsInvalid) throw new Exception("Invalid handle (GtkToolShellHandle)");
		return GtkToolShellHandleExterns.gtk_tool_shell_get_relief_style(shell);
	}

/// <summary>
/// <para>
/// Retrieves whether the tool shell has text, icons, or both. Tool items must
/// not call this function directly, but rely on gtk_tool_item_get_toolbar_style()
/// instead.
/// </para>
/// </summary>

/// <param name="shell">
/// a #GtkToolShell
/// </param>
/// <return>
/// the current style of @shell
/// </return>

	public static MentorLake.Gtk.GtkToolbarStyle GetStyle(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		if (shell.IsInvalid) throw new Exception("Invalid handle (GtkToolShellHandle)");
		return GtkToolShellHandleExterns.gtk_tool_shell_get_style(shell);
	}

/// <summary>
/// <para>
/// Retrieves the current text alignment for the tool shell. Tool items must not
/// call this function directly, but rely on gtk_tool_item_get_text_alignment()
/// instead.
/// </para>
/// </summary>

/// <param name="shell">
/// a #GtkToolShell
/// </param>
/// <return>
/// the current text alignment of @shell
/// </return>

	public static float GetTextAlignment(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		if (shell.IsInvalid) throw new Exception("Invalid handle (GtkToolShellHandle)");
		return GtkToolShellHandleExterns.gtk_tool_shell_get_text_alignment(shell);
	}

/// <summary>
/// <para>
/// Retrieves the current text orientation for the tool shell. Tool items must not
/// call this function directly, but rely on gtk_tool_item_get_text_orientation()
/// instead.
/// </para>
/// </summary>

/// <param name="shell">
/// a #GtkToolShell
/// </param>
/// <return>
/// the current text orientation of @shell
/// </return>

	public static MentorLake.Gtk.GtkOrientation GetTextOrientation(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		if (shell.IsInvalid) throw new Exception("Invalid handle (GtkToolShellHandle)");
		return GtkToolShellHandleExterns.gtk_tool_shell_get_text_orientation(shell);
	}

/// <summary>
/// <para>
/// Retrieves the current text size group for the tool shell. Tool items must not
/// call this function directly, but rely on gtk_tool_item_get_text_size_group()
/// instead.
/// </para>
/// </summary>

/// <param name="shell">
/// a #GtkToolShell
/// </param>
/// <return>
/// the current text size group of @shell
/// </return>

	public static MentorLake.Gtk.GtkSizeGroupHandle GetTextSizeGroup(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		if (shell.IsInvalid) throw new Exception("Invalid handle (GtkToolShellHandle)");
		return GtkToolShellHandleExterns.gtk_tool_shell_get_text_size_group(shell);
	}

/// <summary>
/// <para>
/// Calling this function signals the tool shell that the overflow menu item for
/// tool items have changed. If there is an overflow menu and if it is visible
/// when this function it called, the menu will be rebuilt.
/// </para>
/// <para>
/// Tool items must not call this function directly, but rely on
/// gtk_tool_item_rebuild_menu() instead.
/// </para>
/// </summary>

/// <param name="shell">
/// a #GtkToolShell
/// </param>

	public static T RebuildMenu<T>(this T shell) where T : GtkToolShellHandle
	{
		if (shell.IsInvalid) throw new Exception("Invalid handle (GtkToolShellHandle)");
		GtkToolShellHandleExterns.gtk_tool_shell_rebuild_menu(shell);
		return shell;
	}

}

internal class GtkToolShellHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoEllipsizeMode gtk_tool_shell_get_ellipsize_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolShellHandleImpl>))] MentorLake.Gtk.GtkToolShellHandle shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSize gtk_tool_shell_get_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolShellHandleImpl>))] MentorLake.Gtk.GtkToolShellHandle shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOrientation gtk_tool_shell_get_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolShellHandleImpl>))] MentorLake.Gtk.GtkToolShellHandle shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkReliefStyle gtk_tool_shell_get_relief_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolShellHandleImpl>))] MentorLake.Gtk.GtkToolShellHandle shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolbarStyle gtk_tool_shell_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolShellHandleImpl>))] MentorLake.Gtk.GtkToolShellHandle shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern float gtk_tool_shell_get_text_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolShellHandleImpl>))] MentorLake.Gtk.GtkToolShellHandle shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOrientation gtk_tool_shell_get_text_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolShellHandleImpl>))] MentorLake.Gtk.GtkToolShellHandle shell);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSizeGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkSizeGroupHandle gtk_tool_shell_get_text_size_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolShellHandleImpl>))] MentorLake.Gtk.GtkToolShellHandle shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_shell_rebuild_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolShellHandleImpl>))] MentorLake.Gtk.GtkToolShellHandle shell);

}

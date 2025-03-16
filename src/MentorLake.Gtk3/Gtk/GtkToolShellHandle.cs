namespace MentorLake.Gtk;

public interface GtkToolShellHandle
{
}

internal class GtkToolShellHandleImpl : BaseSafeHandle, GtkToolShellHandle
{
}

public static class GtkToolShellHandleExtensions
{
	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsizeMode(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		return GtkToolShellHandleExterns.gtk_tool_shell_get_ellipsize_mode(shell);
	}

	public static MentorLake.Gtk.GtkIconSize GetIconSize(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		return GtkToolShellHandleExterns.gtk_tool_shell_get_icon_size(shell);
	}

	public static MentorLake.Gtk.GtkOrientation GetOrientation(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		return GtkToolShellHandleExterns.gtk_tool_shell_get_orientation(shell);
	}

	public static MentorLake.Gtk.GtkReliefStyle GetReliefStyle(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		return GtkToolShellHandleExterns.gtk_tool_shell_get_relief_style(shell);
	}

	public static MentorLake.Gtk.GtkToolbarStyle GetStyle(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		return GtkToolShellHandleExterns.gtk_tool_shell_get_style(shell);
	}

	public static float GetTextAlignment(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		return GtkToolShellHandleExterns.gtk_tool_shell_get_text_alignment(shell);
	}

	public static MentorLake.Gtk.GtkOrientation GetTextOrientation(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		return GtkToolShellHandleExterns.gtk_tool_shell_get_text_orientation(shell);
	}

	public static MentorLake.Gtk.GtkSizeGroupHandle GetTextSizeGroup(this MentorLake.Gtk.GtkToolShellHandle shell)
	{
		return GtkToolShellHandleExterns.gtk_tool_shell_get_text_size_group(shell);
	}

	public static T RebuildMenu<T>(this T shell) where T : GtkToolShellHandle
	{
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
	internal static extern MentorLake.Gtk.GtkSizeGroupHandle gtk_tool_shell_get_text_size_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolShellHandleImpl>))] MentorLake.Gtk.GtkToolShellHandle shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_shell_rebuild_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolShellHandleImpl>))] MentorLake.Gtk.GtkToolShellHandle shell);

}

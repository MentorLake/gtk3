namespace MentorLake.Gtk3.Gtk3;

public interface GtkToolShellHandle
{
}

internal class GtkToolShellHandleImpl : BaseSafeHandle, GtkToolShellHandle
{
}

public static class GtkToolShellHandleExtensions
{
	public static PangoEllipsizeMode GetEllipsizeMode(this GtkToolShellHandle shell)
	{
		return GtkToolShellExterns.gtk_tool_shell_get_ellipsize_mode(shell);
	}

	public static GtkIconSize GetIconSize(this GtkToolShellHandle shell)
	{
		return GtkToolShellExterns.gtk_tool_shell_get_icon_size(shell);
	}

	public static GtkOrientation GetOrientation(this GtkToolShellHandle shell)
	{
		return GtkToolShellExterns.gtk_tool_shell_get_orientation(shell);
	}

	public static GtkReliefStyle GetReliefStyle(this GtkToolShellHandle shell)
	{
		return GtkToolShellExterns.gtk_tool_shell_get_relief_style(shell);
	}

	public static GtkToolbarStyle GetStyle(this GtkToolShellHandle shell)
	{
		return GtkToolShellExterns.gtk_tool_shell_get_style(shell);
	}

	public static float GetTextAlignment(this GtkToolShellHandle shell)
	{
		return GtkToolShellExterns.gtk_tool_shell_get_text_alignment(shell);
	}

	public static GtkOrientation GetTextOrientation(this GtkToolShellHandle shell)
	{
		return GtkToolShellExterns.gtk_tool_shell_get_text_orientation(shell);
	}

	public static GtkSizeGroupHandle GetTextSizeGroup(this GtkToolShellHandle shell)
	{
		return GtkToolShellExterns.gtk_tool_shell_get_text_size_group(shell);
	}

	public static GtkToolShellHandle RebuildMenu(this GtkToolShellHandle shell)
	{
		GtkToolShellExterns.gtk_tool_shell_rebuild_menu(shell);
		return shell;
	}

}

internal class GtkToolShellExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern PangoEllipsizeMode gtk_tool_shell_get_ellipsize_mode(GtkToolShellHandle shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSize gtk_tool_shell_get_icon_size(GtkToolShellHandle shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkOrientation gtk_tool_shell_get_orientation(GtkToolShellHandle shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkReliefStyle gtk_tool_shell_get_relief_style(GtkToolShellHandle shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolbarStyle gtk_tool_shell_get_style(GtkToolShellHandle shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern float gtk_tool_shell_get_text_alignment(GtkToolShellHandle shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkOrientation gtk_tool_shell_get_text_orientation(GtkToolShellHandle shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSizeGroupHandle gtk_tool_shell_get_text_size_group(GtkToolShellHandle shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_shell_rebuild_menu(GtkToolShellHandle shell);

}

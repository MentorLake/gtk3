namespace MentorLake.Gtk;

public class GtkTextAppearanceHandle : BaseSafeHandle
{
}


public static class GtkTextAppearanceExtensions
{

	public static GtkTextAppearance Dereference(this GtkTextAppearanceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextAppearance>(x.DangerousGetHandle());
}
internal class GtkTextAppearanceExterns
{
}

public struct GtkTextAppearance
{
	public GdkColor bg_color;
	public GdkColor fg_color;
	public int rise;
	public uint underline;
	public uint strikethrough;
	public uint draw_bg;
	public uint inside_selection;
	public uint is_text;
}

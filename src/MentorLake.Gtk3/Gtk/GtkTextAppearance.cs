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
	/// <summary>
/// <para>
/// Background #GdkColor.
/// </para>
/// </summary>

public GdkColor bg_color;
	/// <summary>
/// <para>
/// Foreground #GdkColor.
/// </para>
/// </summary>

public GdkColor fg_color;
	/// <summary>
/// <para>
/// Super/subscript rise, can be negative.
/// </para>
/// </summary>

public int rise;
	/// <summary>
/// <para>
/// #PangoUnderline
/// </para>
/// </summary>

public uint underline;
	/// <summary>
/// <para>
/// Strikethrough style
/// </para>
/// </summary>

public uint strikethrough;
	/// <summary>
/// <para>
/// Whether to use background-related values; this is
///   irrelevant for the values struct when in a tag, but is used for
///   the composite values struct; it’s true if any of the tags being
///   composited had background stuff set.
/// </para>
/// </summary>

public uint draw_bg;
	/// <summary>
/// <para>
/// This are only used when we are actually laying
///   out and rendering a paragraph; not when a #GtkTextAppearance is
///   part of a #GtkTextAttributes.
/// </para>
/// </summary>

public uint inside_selection;
	/// <summary>
/// <para>
/// This are only used when we are actually laying
///   out and rendering a paragraph; not when a #GtkTextAppearance is
///   part of a #GtkTextAttributes.
/// </para>
/// </summary>

public uint is_text;
}

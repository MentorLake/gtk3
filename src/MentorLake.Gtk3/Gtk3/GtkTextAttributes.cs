namespace MentorLake.Gtk3.Gtk3;

public class GtkTextAttributesHandle : BaseSafeHandle
{
	public static GtkTextAttributesHandle New()
	{
		return GtkTextAttributesExterns.gtk_text_attributes_new();
	}

}


public static class GtkTextAttributesHandleExtensions
{
	public static GtkTextAttributesHandle Copy(this GtkTextAttributesHandle src)
	{
		return GtkTextAttributesExterns.gtk_text_attributes_copy(src);
	}

	public static GtkTextAttributesHandle CopyValues(this GtkTextAttributesHandle src, GtkTextAttributesHandle dest)
	{
		GtkTextAttributesExterns.gtk_text_attributes_copy_values(src, dest);
		return src;
	}

	public static GtkTextAttributesHandle Ref(this GtkTextAttributesHandle values)
	{
		return GtkTextAttributesExterns.gtk_text_attributes_ref(values);
	}

	public static GtkTextAttributesHandle Unref(this GtkTextAttributesHandle values)
	{
		GtkTextAttributesExterns.gtk_text_attributes_unref(values);
		return values;
	}

}
internal class GtkTextAttributesExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextAttributesHandle gtk_text_attributes_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextAttributesHandle gtk_text_attributes_copy(GtkTextAttributesHandle src);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_attributes_copy_values(GtkTextAttributesHandle src, GtkTextAttributesHandle dest);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextAttributesHandle gtk_text_attributes_ref(GtkTextAttributesHandle values);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_text_attributes_unref(GtkTextAttributesHandle values);

}

public struct GtkTextAttributes
{
	public GtkTextAppearance appearance;
	public GtkJustification justification;
	public GtkTextDirection direction;
	public PangoFontDescriptionHandle font;
	public double font_scale;
	public int left_margin;
	public int right_margin;
	public int indent;
	public int pixels_above_lines;
	public int pixels_below_lines;
	public int pixels_inside_wrap;
	public PangoTabArrayHandle tabs;
	public GtkWrapMode wrap_mode;
	public PangoLanguageHandle language;
	public uint invisible;
	public uint bg_full_height;
	public uint editable;
	public uint no_fallback;
	public int letter_spacing;
}

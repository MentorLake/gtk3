namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Using #GtkTextAttributes directly should rarely be necessary.
/// It’s primarily useful with gtk_text_iter_get_attributes().
/// As with most GTK+ structs, the fields in this struct should only
/// be read, never modified directly.
/// </para>
/// </summary>

public class GtkTextAttributesHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a #GtkTextAttributes, which describes
/// a set of properties on some text.
/// </para>
/// </summary>

/// <return>
/// a new #GtkTextAttributes,
///     free with gtk_text_attributes_unref().
/// </return>

	public static MentorLake.Gtk.GtkTextAttributesHandle New()
	{
		return GtkTextAttributesExterns.gtk_text_attributes_new();
	}

}


public static class GtkTextAttributesExtensions
{
/// <summary>
/// <para>
/// Copies @src and returns a new #GtkTextAttributes.
/// </para>
/// </summary>

/// <param name="src">
/// a #GtkTextAttributes to be copied
/// </param>
/// <return>
/// a copy of @src,
///     free with gtk_text_attributes_unref()
/// </return>

	public static MentorLake.Gtk.GtkTextAttributesHandle Copy(this MentorLake.Gtk.GtkTextAttributesHandle src)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (GtkTextAttributes)");
		return GtkTextAttributesExterns.gtk_text_attributes_copy(src);
	}

/// <summary>
/// <para>
/// Copies the values from @src to @dest so that @dest has
/// the same values as @src. Frees existing values in @dest.
/// </para>
/// </summary>

/// <param name="src">
/// a #GtkTextAttributes
/// </param>
/// <param name="dest">
/// another #GtkTextAttributes
/// </param>

	public static void CopyValues(this MentorLake.Gtk.GtkTextAttributesHandle src, MentorLake.Gtk.GtkTextAttributesHandle dest)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (GtkTextAttributes)");
		GtkTextAttributesExterns.gtk_text_attributes_copy_values(src, dest);
	}

/// <summary>
/// <para>
/// Increments the reference count on @values.
/// </para>
/// </summary>

/// <param name="values">
/// a #GtkTextAttributes
/// </param>
/// <return>
/// the #GtkTextAttributes that were passed in
/// </return>

	public static MentorLake.Gtk.GtkTextAttributesHandle Ref(this MentorLake.Gtk.GtkTextAttributesHandle values)
	{
		if (values.IsInvalid) throw new Exception("Invalid handle (GtkTextAttributes)");
		return GtkTextAttributesExterns.gtk_text_attributes_ref(values);
	}

/// <summary>
/// <para>
/// Decrements the reference count on @values, freeing the structure
/// if the reference count reaches 0.
/// </para>
/// </summary>

/// <param name="values">
/// a #GtkTextAttributes
/// </param>

	public static void Unref(this MentorLake.Gtk.GtkTextAttributesHandle values)
	{
		if (values.IsInvalid) throw new Exception("Invalid handle (GtkTextAttributes)");
		GtkTextAttributesExterns.gtk_text_attributes_unref(values);
	}


	public static GtkTextAttributes Dereference(this GtkTextAttributesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextAttributes>(x.DangerousGetHandle());
}
internal class GtkTextAttributesExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))]
	internal static extern MentorLake.Gtk.GtkTextAttributesHandle gtk_text_attributes_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))]
	internal static extern MentorLake.Gtk.GtkTextAttributesHandle gtk_text_attributes_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))] MentorLake.Gtk.GtkTextAttributesHandle src);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_attributes_copy_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))] MentorLake.Gtk.GtkTextAttributesHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))] MentorLake.Gtk.GtkTextAttributesHandle dest);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))]
	internal static extern MentorLake.Gtk.GtkTextAttributesHandle gtk_text_attributes_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))] MentorLake.Gtk.GtkTextAttributesHandle values);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_attributes_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))] MentorLake.Gtk.GtkTextAttributesHandle values);

}

/// <summary>
/// <para>
/// Using #GtkTextAttributes directly should rarely be necessary.
/// It’s primarily useful with gtk_text_iter_get_attributes().
/// As with most GTK+ structs, the fields in this struct should only
/// be read, never modified directly.
/// </para>
/// </summary>

public struct GtkTextAttributes
{
	/// <summary>
/// <para>
/// #GtkTextAppearance for text.
/// </para>
/// </summary>

public GtkTextAppearance appearance;
	/// <summary>
/// <para>
/// #GtkJustification for text.
/// </para>
/// </summary>

public GtkJustification justification;
	/// <summary>
/// <para>
/// #GtkTextDirection for text.
/// </para>
/// </summary>

public GtkTextDirection direction;
	/// <summary>
/// <para>
/// #PangoFontDescription for text.
/// </para>
/// </summary>

public IntPtr font;
	/// <summary>
/// <para>
/// Font scale factor.
/// </para>
/// </summary>

public double font_scale;
	/// <summary>
/// <para>
/// Width of the left margin in pixels.
/// </para>
/// </summary>

public int left_margin;
	/// <summary>
/// <para>
/// Width of the right margin in pixels.
/// </para>
/// </summary>

public int right_margin;
	/// <summary>
/// <para>
/// Amount to indent the paragraph, in pixels.
/// </para>
/// </summary>

public int indent;
	/// <summary>
/// <para>
/// Pixels of blank space above paragraphs.
/// </para>
/// </summary>

public int pixels_above_lines;
	/// <summary>
/// <para>
/// Pixels of blank space below paragraphs.
/// </para>
/// </summary>

public int pixels_below_lines;
	/// <summary>
/// <para>
/// Pixels of blank space between wrapped lines in
///   a paragraph.
/// </para>
/// </summary>

public int pixels_inside_wrap;
	/// <summary>
/// <para>
/// Custom #PangoTabArray for this text.
/// </para>
/// </summary>

public IntPtr tabs;
	/// <summary>
/// <para>
/// #GtkWrapMode for text.
/// </para>
/// </summary>

public GtkWrapMode wrap_mode;
	/// <summary>
/// <para>
/// #PangoLanguage for text.
/// </para>
/// </summary>

public IntPtr language;
	/// <summary>
/// <para>
/// Hide the text.
/// </para>
/// </summary>

public uint invisible;
	/// <summary>
/// <para>
/// Background is fit to full line height rather than
///    baseline +/- ascent/descent (font height).
/// </para>
/// </summary>

public uint bg_full_height;
	/// <summary>
/// <para>
/// Can edit this text.
/// </para>
/// </summary>

public uint editable;
	/// <summary>
/// <para>
/// Whether to disable font fallback.
/// </para>
/// </summary>

public uint no_fallback;
	/// <summary>
/// <para>
/// Extra space to insert between graphemes, in Pango units
/// </para>
/// </summary>

public int letter_spacing;
}

namespace MentorLake.Gtk;


public class GtkFontSelectionHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkFontSelection.
/// </para>
/// </summary>

/// <return>
/// a new #GtkFontSelection
/// </return>

	public static MentorLake.Gtk.GtkFontSelectionHandle New()
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_new();
	}

}

public static class GtkFontSelectionHandleExtensions
{
/// <summary>
/// <para>
/// Gets the #PangoFontFace representing the selected font group
/// details (i.e. family, slant, weight, width, etc).
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <return>
/// A #PangoFontFace representing the
///     selected font group details. The returned object is owned by
///     @fontsel and must not be modified or freed.
/// </return>

	public static MentorLake.Pango.PangoFontFaceHandle GetFace(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_face(fontsel);
	}

/// <summary>
/// <para>
/// This returns the #GtkTreeView which lists all styles available for
/// the selected font. For example, “Regular”, “Bold”, etc.
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <return>
/// A #GtkWidget that is part of @fontsel
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetFaceList(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_face_list(fontsel);
	}

/// <summary>
/// <para>
/// Gets the #PangoFontFamily representing the selected font family.
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <return>
/// A #PangoFontFamily representing the
///     selected font family. Font families are a collection of font
///     faces. The returned object is owned by @fontsel and must not
///     be modified or freed.
/// </return>

	public static MentorLake.Pango.PangoFontFamilyHandle GetFamily(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_family(fontsel);
	}

/// <summary>
/// <para>
/// This returns the #GtkTreeView that lists font families, for
/// example, “Sans”, “Serif”, etc.
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <return>
/// A #GtkWidget that is part of @fontsel
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetFamilyList(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_family_list(fontsel);
	}

/// <summary>
/// <para>
/// Gets the currently-selected font name.
/// </para>
/// <para>
/// Note that this can be a different string than what you set with
/// gtk_font_selection_set_font_name(), as the font selection widget may
/// normalize font names and thus return a string with a different structure.
/// For example, “Helvetica Italic Bold 12” could be normalized to
/// “Helvetica Bold Italic 12”. Use pango_font_description_equal()
/// if you want to compare two font descriptions.
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <return>
/// A string with the name of the current font, or %NULL if
///     no font is selected. You must free this string with g_free().
/// </return>

	public static string GetFontName(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_font_name(fontsel);
	}

/// <summary>
/// <para>
/// This returns the #GtkEntry used to display the font as a preview.
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <return>
/// A #GtkWidget that is part of @fontsel
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetPreviewEntry(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_preview_entry(fontsel);
	}

/// <summary>
/// <para>
/// Gets the text displayed in the preview area.
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <return>
/// the text displayed in the preview area.
///     This string is owned by the widget and should not be
///     modified or freed
/// </return>

	public static string GetPreviewText(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_preview_text(fontsel);
	}

/// <summary>
/// <para>
/// The selected font size.
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <return>
/// A n integer representing the selected font size,
///     or -1 if no font size is selected.
/// </return>

	public static int GetSize(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_size(fontsel);
	}

/// <summary>
/// <para>
/// This returns the #GtkEntry used to allow the user to edit the font
/// number manually instead of selecting it from the list of font sizes.
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <return>
/// A #GtkWidget that is part of @fontsel
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetSizeEntry(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_size_entry(fontsel);
	}

/// <summary>
/// <para>
/// This returns the #GtkTreeView used to list font sizes.
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <return>
/// A #GtkWidget that is part of @fontsel
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetSizeList(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_size_list(fontsel);
	}

/// <summary>
/// <para>
/// Sets the currently-selected font.
/// </para>
/// <para>
/// Note that the @fontsel needs to know the screen in which it will appear
/// for this to work; this can be guaranteed by simply making sure that the
/// @fontsel is inserted in a toplevel window before you call this function.
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <param name="fontname">
/// a font name like “Helvetica 12” or “Times Bold 18”
/// </param>
/// <return>
/// %TRUE if the font could be set successfully; %FALSE if no
///     such font exists or if the @fontsel doesn’t belong to a particular
///     screen yet.
/// </return>

	public static bool SetFontName(this MentorLake.Gtk.GtkFontSelectionHandle fontsel, string fontname)
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		return GtkFontSelectionHandleExterns.gtk_font_selection_set_font_name(fontsel, fontname);
	}

/// <summary>
/// <para>
/// Sets the text displayed in the preview area.
/// The @text is used to show how the selected font looks.
/// </para>
/// </summary>

/// <param name="fontsel">
/// a #GtkFontSelection
/// </param>
/// <param name="text">
/// the text to display in the preview area
/// </param>

	public static T SetPreviewText<T>(this T fontsel, string text) where T : GtkFontSelectionHandle
	{
		if (fontsel.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionHandle)");
		GtkFontSelectionHandleExterns.gtk_font_selection_set_preview_text(fontsel, text);
		return fontsel;
	}

}

internal class GtkFontSelectionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))]
	internal static extern MentorLake.Gtk.GtkFontSelectionHandle gtk_font_selection_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))]
	internal static extern MentorLake.Pango.PangoFontFaceHandle gtk_font_selection_get_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_get_face_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))]
	internal static extern MentorLake.Pango.PangoFontFamilyHandle gtk_font_selection_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_get_family_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_selection_get_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_get_preview_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_selection_get_preview_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_font_selection_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_get_size_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_get_size_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_selection_set_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel, string fontname);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_selection_set_preview_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel, string text);

}

namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkFontChooser is an interface that can be implemented by widgets
/// displaying the list of fonts. In GTK+, the main objects
/// that implement this interface are #GtkFontChooserWidget,
/// #GtkFontChooserDialog and #GtkFontButton. The GtkFontChooser interface
/// has been introducted in GTK+ 3.2.
/// </para>
/// </summary>

public interface GtkFontChooserHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkFontChooserHandleImpl : BaseSafeHandle, GtkFontChooserHandle
{
}

public static class GtkFontChooserHandleExtensions
{
/// <summary>
/// <para>
/// Gets the currently-selected font name.
/// </para>
/// <para>
/// Note that this can be a different string than what you set with
/// gtk_font_chooser_set_font(), as the font chooser widget may
/// normalize font names and thus return a string with a different
/// structure. For example, “Helvetica Italic Bold 12” could be
/// normalized to “Helvetica Bold Italic 12”.
/// </para>
/// <para>
/// Use pango_font_description_equal() if you want to compare two
/// font descriptions.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <return>
/// A string with the name
///     of the current font, or %NULL if  no font is selected. You must
///     free this string with g_free().
/// </return>

	public static string GetFont(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font(fontchooser);
	}

/// <summary>
/// <para>
/// Gets the currently-selected font.
/// </para>
/// <para>
/// Note that this can be a different string than what you set with
/// gtk_font_chooser_set_font(), as the font chooser widget may
/// normalize font names and thus return a string with a different
/// structure. For example, “Helvetica Italic Bold 12” could be
/// normalized to “Helvetica Bold Italic 12”.
/// </para>
/// <para>
/// Use pango_font_description_equal() if you want to compare two
/// font descriptions.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <return>
/// A #PangoFontDescription for the
///     current font, or %NULL if  no font is selected.
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle GetFontDesc(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_desc(fontchooser);
	}

/// <summary>
/// <para>
/// Gets the #PangoFontFace representing the selected font group
/// details (i.e. family, slant, weight, width, etc).
/// </para>
/// <para>
/// If the selected font is not installed, returns %NULL.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <return>
/// A #PangoFontFace representing the
///     selected font group details, or %NULL. The returned object is owned by
///     @fontchooser and must not be modified or freed.
/// </return>

	public static MentorLake.Pango.PangoFontFaceHandle GetFontFace(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_face(fontchooser);
	}

/// <summary>
/// <para>
/// Gets the #PangoFontFamily representing the selected font family.
/// Font families are a collection of font faces.
/// </para>
/// <para>
/// If the selected font is not installed, returns %NULL.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <return>
/// A #PangoFontFamily representing the
///     selected font family, or %NULL. The returned object is owned by @fontchooser
///     and must not be modified or freed.
/// </return>

	public static MentorLake.Pango.PangoFontFamilyHandle GetFontFamily(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_family(fontchooser);
	}

/// <summary>
/// <para>
/// Gets the currently-selected font features.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <return>
/// the currently selected font features
/// </return>

	public static string GetFontFeatures(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_features(fontchooser);
	}

/// <summary>
/// <para>
/// Gets the custom font map of this font chooser widget,
/// or %NULL if it does not have one.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <return>
/// a #PangoFontMap, or %NULL
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle GetFontMap(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_map(fontchooser);
	}

/// <summary>
/// <para>
/// The selected font size.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <return>
/// A n integer representing the selected font size,
///     or -1 if no font size is selected.
/// </return>

	public static int GetFontSize(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_size(fontchooser);
	}

/// <summary>
/// <para>
/// Gets the language that is used for font features.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <return>
/// the currently selected language
/// </return>

	public static string GetLanguage(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_language(fontchooser);
	}

/// <summary>
/// <para>
/// Returns the current level of granularity for selecting fonts.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <return>
/// the current granularity level
/// </return>

	public static MentorLake.Gtk.GtkFontChooserLevel GetLevel(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_level(fontchooser);
	}

/// <summary>
/// <para>
/// Gets the text displayed in the preview area.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <return>
/// the text displayed in the
///     preview area
/// </return>

	public static string GetPreviewText(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_preview_text(fontchooser);
	}

/// <summary>
/// <para>
/// Returns whether the preview entry is shown or not.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <return>
/// %TRUE if the preview entry is shown
///     or %FALSE if it is hidden.
/// </return>

	public static bool GetShowPreviewEntry(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_show_preview_entry(fontchooser);
	}

/// <summary>
/// <para>
/// Adds a filter function that decides which fonts to display
/// in the font chooser.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <param name="filter">
/// a #GtkFontFilterFunc, or %NULL
/// </param>
/// <param name="user_data">
/// data to pass to @filter
/// </param>
/// <param name="destroy">
/// function to call to free @data when it is no longer needed
/// </param>

	public static T SetFilterFunc<T>(this T fontchooser, MentorLake.Gtk.GtkFontFilterFunc filter, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_filter_func(fontchooser, filter, user_data, destroy);
		return fontchooser;
	}

/// <summary>
/// <para>
/// Sets the currently-selected font.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <param name="fontname">
/// a font name like “Helvetica 12” or “Times Bold 18”
/// </param>

	public static T SetFont<T>(this T fontchooser, string fontname) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_font(fontchooser, fontname);
		return fontchooser;
	}

/// <summary>
/// <para>
/// Sets the currently-selected font from @font_desc.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <param name="font_desc">
/// a #PangoFontDescription
/// </param>

	public static T SetFontDesc<T>(this T fontchooser, MentorLake.Pango.PangoFontDescriptionHandle font_desc) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_font_desc(fontchooser, font_desc);
		return fontchooser;
	}

/// <summary>
/// <para>
/// Sets a custom font map to use for this font chooser widget.
/// A custom font map can be used to present application-specific
/// fonts instead of or in addition to the normal system fonts.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// FcConfig *config;
/// PangoFontMap *fontmap;
/// </para>
/// <para>
/// config = FcInitLoadConfigAndFonts ();
/// FcConfigAppFontAddFile (config, my_app_font_file);
/// </para>
/// <para>
/// fontmap = pango_cairo_font_map_new_for_font_type (CAIRO_FONT_TYPE_FT);
/// pango_fc_font_map_set_config (PANGO_FC_FONT_MAP (fontmap), config);
/// </para>
/// <para>
/// gtk_font_chooser_set_font_map (font_chooser, fontmap);
/// ]|
/// </para>
/// <para>
/// Note that other GTK+ widgets will only be able to use the application-specific
/// font if it is present in the font map they use:
/// </para>
/// <para>
/// |[
/// context = gtk_widget_get_pango_context (label);
/// pango_context_set_font_map (context, fontmap);
/// ]|
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <param name="fontmap">
/// a #PangoFontMap
/// </param>

	public static T SetFontMap<T>(this T fontchooser, MentorLake.Pango.PangoFontMapHandle fontmap) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_font_map(fontchooser, fontmap);
		return fontchooser;
	}

/// <summary>
/// <para>
/// Sets the language to use for font features.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <param name="language">
/// a language
/// </param>

	public static T SetLanguage<T>(this T fontchooser, string language) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_language(fontchooser, language);
		return fontchooser;
	}

/// <summary>
/// <para>
/// Sets the desired level of granularity for selecting fonts.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <param name="level">
/// the desired level of granularity
/// </param>

	public static T SetLevel<T>(this T fontchooser, MentorLake.Gtk.GtkFontChooserLevel level) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_level(fontchooser, level);
		return fontchooser;
	}

/// <summary>
/// <para>
/// Sets the text displayed in the preview area.
/// The @text is used to show how the selected font looks.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <param name="text">
/// the text to display in the preview area
/// </param>

	public static T SetPreviewText<T>(this T fontchooser, string text) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_preview_text(fontchooser, text);
		return fontchooser;
	}

/// <summary>
/// <para>
/// Shows or hides the editable preview entry.
/// </para>
/// </summary>

/// <param name="fontchooser">
/// a #GtkFontChooser
/// </param>
/// <param name="show_preview_entry">
/// whether to show the editable preview entry or not
/// </param>

	public static T SetShowPreviewEntry<T>(this T fontchooser, bool show_preview_entry) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid) throw new Exception("Invalid handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_show_preview_entry(fontchooser, show_preview_entry);
		return fontchooser;
	}

}

internal class GtkFontChooserHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_chooser_get_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle gtk_font_chooser_get_font_desc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))]
	internal static extern MentorLake.Pango.PangoFontFaceHandle gtk_font_chooser_get_font_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))]
	internal static extern MentorLake.Pango.PangoFontFamilyHandle gtk_font_chooser_get_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_chooser_get_font_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle gtk_font_chooser_get_font_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_font_chooser_get_font_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_chooser_get_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFontChooserLevel gtk_font_chooser_get_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_chooser_get_preview_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_chooser_get_show_preview_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_chooser_set_filter_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser, MentorLake.Gtk.GtkFontFilterFunc filter, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_chooser_set_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser, string fontname);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_chooser_set_font_desc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle font_desc);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_chooser_set_font_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_chooser_set_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser, string language);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_chooser_set_level([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser, MentorLake.Gtk.GtkFontChooserLevel level);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_chooser_set_preview_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_chooser_set_show_preview_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser, bool show_preview_entry);

}

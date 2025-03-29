namespace MentorLake.Gtk;

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
	public static string GetFont(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font(fontchooser);
	}

	public static MentorLake.Pango.PangoFontDescriptionHandle GetFontDesc(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_desc(fontchooser);
	}

	public static MentorLake.Pango.PangoFontFaceHandle GetFontFace(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_face(fontchooser);
	}

	public static MentorLake.Pango.PangoFontFamilyHandle GetFontFamily(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_family(fontchooser);
	}

	public static string GetFontFeatures(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_features(fontchooser);
	}

	public static MentorLake.Pango.PangoFontMapHandle GetFontMap(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_map(fontchooser);
	}

	public static int GetFontSize(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_font_size(fontchooser);
	}

	public static string GetLanguage(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_language(fontchooser);
	}

	public static MentorLake.Gtk.GtkFontChooserLevel GetLevel(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_level(fontchooser);
	}

	public static string GetPreviewText(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_preview_text(fontchooser);
	}

	public static bool GetShowPreviewEntry(this MentorLake.Gtk.GtkFontChooserHandle fontchooser)
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		return GtkFontChooserHandleExterns.gtk_font_chooser_get_show_preview_entry(fontchooser);
	}

	public static T SetFilterFunc<T>(this T fontchooser, MentorLake.Gtk.GtkFontFilterFunc filter, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_filter_func(fontchooser, filter, user_data, destroy);
		return fontchooser;
	}

	public static T SetFont<T>(this T fontchooser, string fontname) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_font(fontchooser, fontname);
		return fontchooser;
	}

	public static T SetFontDesc<T>(this T fontchooser, MentorLake.Pango.PangoFontDescriptionHandle font_desc) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_font_desc(fontchooser, font_desc);
		return fontchooser;
	}

	public static T SetFontMap<T>(this T fontchooser, MentorLake.Pango.PangoFontMapHandle fontmap) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_font_map(fontchooser, fontmap);
		return fontchooser;
	}

	public static T SetLanguage<T>(this T fontchooser, string language) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_language(fontchooser, language);
		return fontchooser;
	}

	public static T SetLevel<T>(this T fontchooser, MentorLake.Gtk.GtkFontChooserLevel level) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_level(fontchooser, level);
		return fontchooser;
	}

	public static T SetPreviewText<T>(this T fontchooser, string text) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
		GtkFontChooserHandleExterns.gtk_font_chooser_set_preview_text(fontchooser, text);
		return fontchooser;
	}

	public static T SetShowPreviewEntry<T>(this T fontchooser, bool show_preview_entry) where T : GtkFontChooserHandle
	{
		if (fontchooser.IsInvalid || fontchooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFontChooserHandle)");
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
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle gtk_font_chooser_get_font_desc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontFaceHandle gtk_font_chooser_get_font_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontFamilyHandle gtk_font_chooser_get_font_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_chooser_get_font_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle fontchooser);

	[DllImport(GtkLibrary.Name)]
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

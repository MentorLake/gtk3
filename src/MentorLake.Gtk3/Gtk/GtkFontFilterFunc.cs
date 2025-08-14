namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The type of function that is used for deciding what fonts get
/// shown in a #GtkFontChooser. See gtk_font_chooser_set_filter_func().
/// </para>
/// </summary>

/// <param name="family">
/// a #PangoFontFamily
/// </param>
/// <param name="face">
/// a #PangoFontFace belonging to @family
/// </param>
/// <param name="data">
/// user data passed to gtk_font_chooser_set_filter_func()
/// </param>
/// <return>
/// %TRUE if the font should be displayed
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkFontFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))] MentorLake.Pango.PangoFontFaceHandle face, IntPtr data);

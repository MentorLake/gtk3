namespace MentorLake.Gtk;


public class GtkFontSelectionDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkFontSelectionDialog.
/// </para>
/// </summary>

/// <param name="title">
/// the title of the dialog window
/// </param>
/// <return>
/// a new #GtkFontSelectionDialog
/// </return>

	public static MentorLake.Gtk.GtkFontSelectionDialogHandle New(string title)
	{
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_new(title);
	}

}

public static class GtkFontSelectionDialogHandleExtensions
{
/// <summary>
/// <para>
/// Gets the “Cancel” button.
/// </para>
/// </summary>

/// <param name="fsd">
/// a #GtkFontSelectionDialog
/// </param>
/// <return>
/// the #GtkWidget used in the dialog
///     for the “Cancel” button.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetCancelButton(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd)
	{
		if (fsd.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionDialogHandle)");
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_get_cancel_button(fsd);
	}

/// <summary>
/// <para>
/// Gets the currently-selected font name.
/// </para>
/// <para>
/// Note that this can be a different string than what you set with
/// gtk_font_selection_dialog_set_font_name(), as the font selection widget
/// may normalize font names and thus return a string with a different
/// structure. For example, “Helvetica Italic Bold 12” could be normalized
/// to “Helvetica Bold Italic 12”.  Use pango_font_description_equal()
/// if you want to compare two font descriptions.
/// </para>
/// </summary>

/// <param name="fsd">
/// a #GtkFontSelectionDialog
/// </param>
/// <return>
/// A string with the name of the current font, or %NULL if no
///     font is selected. You must free this string with g_free().
/// </return>

	public static string GetFontName(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd)
	{
		if (fsd.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionDialogHandle)");
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_get_font_name(fsd);
	}

/// <summary>
/// <para>
/// Retrieves the #GtkFontSelection widget embedded in the dialog.
/// </para>
/// </summary>

/// <param name="fsd">
/// a #GtkFontSelectionDialog
/// </param>
/// <return>
/// the embedded #GtkFontSelection
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetFontSelection(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd)
	{
		if (fsd.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionDialogHandle)");
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_get_font_selection(fsd);
	}

/// <summary>
/// <para>
/// Gets the “OK” button.
/// </para>
/// </summary>

/// <param name="fsd">
/// a #GtkFontSelectionDialog
/// </param>
/// <return>
/// the #GtkWidget used in the dialog
///     for the “OK” button.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetOkButton(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd)
	{
		if (fsd.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionDialogHandle)");
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_get_ok_button(fsd);
	}

/// <summary>
/// <para>
/// Gets the text displayed in the preview area.
/// </para>
/// </summary>

/// <param name="fsd">
/// a #GtkFontSelectionDialog
/// </param>
/// <return>
/// the text displayed in the preview area.
///     This string is owned by the widget and should not be
///     modified or freed
/// </return>

	public static string GetPreviewText(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd)
	{
		if (fsd.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionDialogHandle)");
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_get_preview_text(fsd);
	}

/// <summary>
/// <para>
/// Sets the currently selected font.
/// </para>
/// </summary>

/// <param name="fsd">
/// a #GtkFontSelectionDialog
/// </param>
/// <param name="fontname">
/// a font name like “Helvetica 12” or “Times Bold 18”
/// </param>
/// <return>
/// %TRUE if the font selected in @fsd is now the
///     @fontname specified, %FALSE otherwise.
/// </return>

	public static bool SetFontName(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd, string fontname)
	{
		if (fsd.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionDialogHandle)");
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_set_font_name(fsd, fontname);
	}

/// <summary>
/// <para>
/// Sets the text displayed in the preview area.
/// </para>
/// </summary>

/// <param name="fsd">
/// a #GtkFontSelectionDialog
/// </param>
/// <param name="text">
/// the text to display in the preview area
/// </param>

	public static T SetPreviewText<T>(this T fsd, string text) where T : GtkFontSelectionDialogHandle
	{
		if (fsd.IsInvalid) throw new Exception("Invalid handle (GtkFontSelectionDialogHandle)");
		GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_set_preview_text(fsd, text);
		return fsd;
	}

}

internal class GtkFontSelectionDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkFontSelectionDialogHandle gtk_font_selection_dialog_new(string title);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_dialog_get_cancel_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_selection_dialog_get_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_dialog_get_font_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_dialog_get_ok_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_selection_dialog_get_preview_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_selection_dialog_set_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd, string fontname);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_selection_dialog_set_preview_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd, string text);

}

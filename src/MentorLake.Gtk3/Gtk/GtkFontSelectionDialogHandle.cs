namespace MentorLake.Gtk;

public class GtkFontSelectionDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkFontSelectionDialogHandle New(string title)
	{
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_new(title);
	}

}

public static class GtkFontSelectionDialogHandleExtensions
{
	public static MentorLake.Gtk.GtkWidgetHandle GetCancelButton(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd)
	{
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_get_cancel_button(fsd);
	}

	public static string GetFontName(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd)
	{
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_get_font_name(fsd);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetFontSelection(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd)
	{
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_get_font_selection(fsd);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetOkButton(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd)
	{
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_get_ok_button(fsd);
	}

	public static string GetPreviewText(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd)
	{
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_get_preview_text(fsd);
	}

	public static bool SetFontName(this MentorLake.Gtk.GtkFontSelectionDialogHandle fsd, string fontname)
	{
		return GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_set_font_name(fsd, fontname);
	}

	public static T SetPreviewText<T>(this T fsd, string text) where T : GtkFontSelectionDialogHandle
	{
		GtkFontSelectionDialogHandleExterns.gtk_font_selection_dialog_set_preview_text(fsd, text);
		return fsd;
	}

}

internal class GtkFontSelectionDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFontSelectionDialogHandle gtk_font_selection_dialog_new(string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_dialog_get_cancel_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_selection_dialog_get_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_dialog_get_font_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_dialog_get_ok_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_selection_dialog_get_preview_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_selection_dialog_set_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd, string fontname);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_selection_dialog_set_preview_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionDialogHandle>))] MentorLake.Gtk.GtkFontSelectionDialogHandle fsd, string text);

}

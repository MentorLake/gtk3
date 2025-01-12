namespace MentorLake.Gtk3.Gtk3;

public class GtkFontSelectionDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkFontSelectionDialogHandle New(string title)
	{
		return GtkFontSelectionDialogExterns.gtk_font_selection_dialog_new(title);
	}

}

public static class GtkFontSelectionDialogHandleExtensions
{
	public static GtkWidgetHandle GetCancelButton(this GtkFontSelectionDialogHandle fsd)
	{
		return GtkFontSelectionDialogExterns.gtk_font_selection_dialog_get_cancel_button(fsd);
	}

	public static string GetFontName(this GtkFontSelectionDialogHandle fsd)
	{
		return GtkFontSelectionDialogExterns.gtk_font_selection_dialog_get_font_name(fsd);
	}

	public static GtkWidgetHandle GetFontSelection(this GtkFontSelectionDialogHandle fsd)
	{
		return GtkFontSelectionDialogExterns.gtk_font_selection_dialog_get_font_selection(fsd);
	}

	public static GtkWidgetHandle GetOkButton(this GtkFontSelectionDialogHandle fsd)
	{
		return GtkFontSelectionDialogExterns.gtk_font_selection_dialog_get_ok_button(fsd);
	}

	public static string GetPreviewText(this GtkFontSelectionDialogHandle fsd)
	{
		return GtkFontSelectionDialogExterns.gtk_font_selection_dialog_get_preview_text(fsd);
	}

	public static bool SetFontName(this GtkFontSelectionDialogHandle fsd, string fontname)
	{
		return GtkFontSelectionDialogExterns.gtk_font_selection_dialog_set_font_name(fsd, fontname);
	}

	public static T SetPreviewText<T>(this T fsd, string text) where T : GtkFontSelectionDialogHandle
	{
		GtkFontSelectionDialogExterns.gtk_font_selection_dialog_set_preview_text(fsd, text);
		return fsd;
	}

}

internal class GtkFontSelectionDialogExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFontSelectionDialogHandle gtk_font_selection_dialog_new(string title);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_font_selection_dialog_get_cancel_button(GtkFontSelectionDialogHandle fsd);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_font_selection_dialog_get_font_name(GtkFontSelectionDialogHandle fsd);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_font_selection_dialog_get_font_selection(GtkFontSelectionDialogHandle fsd);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_font_selection_dialog_get_ok_button(GtkFontSelectionDialogHandle fsd);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_selection_dialog_get_preview_text(GtkFontSelectionDialogHandle fsd);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_font_selection_dialog_set_font_name(GtkFontSelectionDialogHandle fsd, string fontname);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_selection_dialog_set_preview_text(GtkFontSelectionDialogHandle fsd, string text);

}

namespace MentorLake.Gtk3.Gtk3;

public interface GtkFileChooserHandle
{
}

internal class GtkFileChooserHandleImpl : BaseSafeHandle, GtkFileChooserHandle
{
}

public static class GtkFileChooserHandleExtensions
{
	public static T AddChoice<T>(this T chooser, string id, string label, string[] options, string[] option_labels) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_add_choice(chooser, id, label, options, option_labels);
		return chooser;
	}

	public static T AddFilter<T>(this T chooser, GtkFileFilterHandle filter) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_add_filter(chooser, filter);
		return chooser;
	}

	public static bool AddShortcutFolder(this GtkFileChooserHandle chooser, string folder, out GErrorHandle error)
	{
		return GtkFileChooserExterns.gtk_file_chooser_add_shortcut_folder(chooser, folder, out error);
	}

	public static bool AddShortcutFolderUri(this GtkFileChooserHandle chooser, string uri, out GErrorHandle error)
	{
		return GtkFileChooserExterns.gtk_file_chooser_add_shortcut_folder_uri(chooser, uri, out error);
	}

	public static GtkFileChooserAction GetAction(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_action(chooser);
	}

	public static string GetChoice(this GtkFileChooserHandle chooser, string id)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_choice(chooser, id);
	}

	public static bool GetCreateFolders(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_create_folders(chooser);
	}

	public static string GetCurrentFolder(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_current_folder(chooser);
	}

	public static GFileHandle GetCurrentFolderFile(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_current_folder_file(chooser);
	}

	public static string GetCurrentFolderUri(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_current_folder_uri(chooser);
	}

	public static string GetCurrentName(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_current_name(chooser);
	}

	public static bool GetDoOverwriteConfirmation(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_do_overwrite_confirmation(chooser);
	}

	public static GtkWidgetHandle GetExtraWidget(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_extra_widget(chooser);
	}

	public static GFileHandle GetFile(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_file(chooser);
	}

	public static string GetFilename(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_filename(chooser);
	}

	public static GSListHandle GetFilenames(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_filenames(chooser);
	}

	public static GSListHandle GetFiles(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_files(chooser);
	}

	public static GtkFileFilterHandle GetFilter(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_filter(chooser);
	}

	public static bool GetLocalOnly(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_local_only(chooser);
	}

	public static GFileHandle GetPreviewFile(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_preview_file(chooser);
	}

	public static string GetPreviewFilename(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_preview_filename(chooser);
	}

	public static string GetPreviewUri(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_preview_uri(chooser);
	}

	public static GtkWidgetHandle GetPreviewWidget(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_preview_widget(chooser);
	}

	public static bool GetPreviewWidgetActive(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_preview_widget_active(chooser);
	}

	public static bool GetSelectMultiple(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_select_multiple(chooser);
	}

	public static bool GetShowHidden(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_show_hidden(chooser);
	}

	public static string GetUri(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_uri(chooser);
	}

	public static GSListHandle GetUris(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_uris(chooser);
	}

	public static bool GetUsePreviewLabel(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_use_preview_label(chooser);
	}

	public static GSListHandle ListFilters(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_list_filters(chooser);
	}

	public static GSListHandle ListShortcutFolderUris(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_list_shortcut_folder_uris(chooser);
	}

	public static GSListHandle ListShortcutFolders(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_list_shortcut_folders(chooser);
	}

	public static T RemoveChoice<T>(this T chooser, string id) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_remove_choice(chooser, id);
		return chooser;
	}

	public static T RemoveFilter<T>(this T chooser, GtkFileFilterHandle filter) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_remove_filter(chooser, filter);
		return chooser;
	}

	public static bool RemoveShortcutFolder(this GtkFileChooserHandle chooser, string folder, out GErrorHandle error)
	{
		return GtkFileChooserExterns.gtk_file_chooser_remove_shortcut_folder(chooser, folder, out error);
	}

	public static bool RemoveShortcutFolderUri(this GtkFileChooserHandle chooser, string uri, out GErrorHandle error)
	{
		return GtkFileChooserExterns.gtk_file_chooser_remove_shortcut_folder_uri(chooser, uri, out error);
	}

	public static T SelectAll<T>(this T chooser) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_select_all(chooser);
		return chooser;
	}

	public static bool SelectFile(this GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error)
	{
		return GtkFileChooserExterns.gtk_file_chooser_select_file(chooser, file, out error);
	}

	public static bool SelectFilename(this GtkFileChooserHandle chooser, string filename)
	{
		return GtkFileChooserExterns.gtk_file_chooser_select_filename(chooser, filename);
	}

	public static bool SelectUri(this GtkFileChooserHandle chooser, string uri)
	{
		return GtkFileChooserExterns.gtk_file_chooser_select_uri(chooser, uri);
	}

	public static T SetAction<T>(this T chooser, GtkFileChooserAction action) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_action(chooser, action);
		return chooser;
	}

	public static T SetChoice<T>(this T chooser, string id, string option) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_choice(chooser, id, option);
		return chooser;
	}

	public static T SetCreateFolders<T>(this T chooser, bool create_folders) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_create_folders(chooser, create_folders);
		return chooser;
	}

	public static bool SetCurrentFolder(this GtkFileChooserHandle chooser, string filename)
	{
		return GtkFileChooserExterns.gtk_file_chooser_set_current_folder(chooser, filename);
	}

	public static bool SetCurrentFolderFile(this GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error)
	{
		return GtkFileChooserExterns.gtk_file_chooser_set_current_folder_file(chooser, file, out error);
	}

	public static bool SetCurrentFolderUri(this GtkFileChooserHandle chooser, string uri)
	{
		return GtkFileChooserExterns.gtk_file_chooser_set_current_folder_uri(chooser, uri);
	}

	public static T SetCurrentName<T>(this T chooser, string name) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_current_name(chooser, name);
		return chooser;
	}

	public static T SetDoOverwriteConfirmation<T>(this T chooser, bool do_overwrite_confirmation) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_do_overwrite_confirmation(chooser, do_overwrite_confirmation);
		return chooser;
	}

	public static T SetExtraWidget<T>(this T chooser, GtkWidgetHandle extra_widget) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_extra_widget(chooser, extra_widget);
		return chooser;
	}

	public static bool SetFile(this GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error)
	{
		return GtkFileChooserExterns.gtk_file_chooser_set_file(chooser, file, out error);
	}

	public static bool SetFilename(this GtkFileChooserHandle chooser, string filename)
	{
		return GtkFileChooserExterns.gtk_file_chooser_set_filename(chooser, filename);
	}

	public static T SetFilter<T>(this T chooser, GtkFileFilterHandle filter) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_filter(chooser, filter);
		return chooser;
	}

	public static T SetLocalOnly<T>(this T chooser, bool local_only) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_local_only(chooser, local_only);
		return chooser;
	}

	public static T SetPreviewWidget<T>(this T chooser, GtkWidgetHandle preview_widget) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_preview_widget(chooser, preview_widget);
		return chooser;
	}

	public static T SetPreviewWidgetActive<T>(this T chooser, bool active) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_preview_widget_active(chooser, active);
		return chooser;
	}

	public static T SetSelectMultiple<T>(this T chooser, bool select_multiple) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_select_multiple(chooser, select_multiple);
		return chooser;
	}

	public static T SetShowHidden<T>(this T chooser, bool show_hidden) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_show_hidden(chooser, show_hidden);
		return chooser;
	}

	public static bool SetUri(this GtkFileChooserHandle chooser, string uri)
	{
		return GtkFileChooserExterns.gtk_file_chooser_set_uri(chooser, uri);
	}

	public static T SetUsePreviewLabel<T>(this T chooser, bool use_label) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_set_use_preview_label(chooser, use_label);
		return chooser;
	}

	public static T UnselectAll<T>(this T chooser) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_unselect_all(chooser);
		return chooser;
	}

	public static T UnselectFile<T>(this T chooser, GFileHandle file) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_unselect_file(chooser, file);
		return chooser;
	}

	public static T UnselectFilename<T>(this T chooser, string filename) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_unselect_filename(chooser, filename);
		return chooser;
	}

	public static T UnselectUri<T>(this T chooser, string uri) where T : GtkFileChooserHandle
	{
		GtkFileChooserExterns.gtk_file_chooser_unselect_uri(chooser, uri);
		return chooser;
	}

}

internal class GtkFileChooserExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_add_choice(GtkFileChooserHandle chooser, string id, string label, string[] options, string[] option_labels);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_add_filter(GtkFileChooserHandle chooser, GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_add_shortcut_folder(GtkFileChooserHandle chooser, string folder, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_add_shortcut_folder_uri(GtkFileChooserHandle chooser, string uri, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFileChooserAction gtk_file_chooser_get_action(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_choice(GtkFileChooserHandle chooser, string id);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_get_create_folders(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_file_chooser_get_current_folder(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GFileHandle gtk_file_chooser_get_current_folder_file(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_file_chooser_get_current_folder_uri(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_file_chooser_get_current_name(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_get_do_overwrite_confirmation(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_file_chooser_get_extra_widget(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GFileHandle gtk_file_chooser_get_file(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_file_chooser_get_filename(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_file_chooser_get_filenames(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_file_chooser_get_files(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFileFilterHandle gtk_file_chooser_get_filter(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_get_local_only(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GFileHandle gtk_file_chooser_get_preview_file(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_file_chooser_get_preview_filename(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_file_chooser_get_preview_uri(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_file_chooser_get_preview_widget(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_get_preview_widget_active(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_get_select_multiple(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_get_show_hidden(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_file_chooser_get_uri(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_file_chooser_get_uris(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_get_use_preview_label(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_file_chooser_list_filters(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_file_chooser_list_shortcut_folder_uris(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_file_chooser_list_shortcut_folders(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_remove_choice(GtkFileChooserHandle chooser, string id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_remove_filter(GtkFileChooserHandle chooser, GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_remove_shortcut_folder(GtkFileChooserHandle chooser, string folder, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_remove_shortcut_folder_uri(GtkFileChooserHandle chooser, string uri, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_select_all(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_select_file(GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_select_filename(GtkFileChooserHandle chooser, string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_select_uri(GtkFileChooserHandle chooser, string uri);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_action(GtkFileChooserHandle chooser, GtkFileChooserAction action);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_choice(GtkFileChooserHandle chooser, string id, string option);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_create_folders(GtkFileChooserHandle chooser, bool create_folders);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_set_current_folder(GtkFileChooserHandle chooser, string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_set_current_folder_file(GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_set_current_folder_uri(GtkFileChooserHandle chooser, string uri);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_current_name(GtkFileChooserHandle chooser, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_do_overwrite_confirmation(GtkFileChooserHandle chooser, bool do_overwrite_confirmation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_extra_widget(GtkFileChooserHandle chooser, GtkWidgetHandle extra_widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_set_file(GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_set_filename(GtkFileChooserHandle chooser, string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_filter(GtkFileChooserHandle chooser, GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_local_only(GtkFileChooserHandle chooser, bool local_only);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_preview_widget(GtkFileChooserHandle chooser, GtkWidgetHandle preview_widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_preview_widget_active(GtkFileChooserHandle chooser, bool active);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_select_multiple(GtkFileChooserHandle chooser, bool select_multiple);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_show_hidden(GtkFileChooserHandle chooser, bool show_hidden);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_set_uri(GtkFileChooserHandle chooser, string uri);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_set_use_preview_label(GtkFileChooserHandle chooser, bool use_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_unselect_all(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_unselect_file(GtkFileChooserHandle chooser, GFileHandle file);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_unselect_filename(GtkFileChooserHandle chooser, string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_unselect_uri(GtkFileChooserHandle chooser, string uri);

}

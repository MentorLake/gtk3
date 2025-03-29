namespace MentorLake.Gtk;

public interface GtkFileChooserHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkFileChooserHandleImpl : BaseSafeHandle, GtkFileChooserHandle
{
}

public static class GtkFileChooserHandleExtensions
{
	public static T AddChoice<T>(this T chooser, string id, string label, string[] options, string[] option_labels) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_add_choice(chooser, id, label, options, option_labels);
		return chooser;
	}

	public static T AddFilter<T>(this T chooser, MentorLake.Gtk.GtkFileFilterHandle filter) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_add_filter(chooser, filter);
		return chooser;
	}

	public static bool AddShortcutFolder(this MentorLake.Gtk.GtkFileChooserHandle chooser, string folder)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_add_shortcut_folder(chooser, folder, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool AddShortcutFolderUri(this MentorLake.Gtk.GtkFileChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_add_shortcut_folder_uri(chooser, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gtk.GtkFileChooserAction GetAction(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_action(chooser);
	}

	public static string GetChoice(this MentorLake.Gtk.GtkFileChooserHandle chooser, string id)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_choice(chooser, id);
	}

	public static bool GetCreateFolders(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_create_folders(chooser);
	}

	public static string GetCurrentFolder(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_current_folder(chooser);
	}

	public static MentorLake.Gio.GFileHandle GetCurrentFolderFile(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_current_folder_file(chooser);
	}

	public static string GetCurrentFolderUri(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_current_folder_uri(chooser);
	}

	public static string GetCurrentName(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_current_name(chooser);
	}

	public static bool GetDoOverwriteConfirmation(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_do_overwrite_confirmation(chooser);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetExtraWidget(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_extra_widget(chooser);
	}

	public static MentorLake.Gio.GFileHandle GetFile(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_file(chooser);
	}

	public static string GetFilename(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_filename(chooser);
	}

	public static MentorLake.GLib.GSListHandle GetFilenames(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_filenames(chooser);
	}

	public static MentorLake.GLib.GSListHandle GetFiles(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_files(chooser);
	}

	public static MentorLake.Gtk.GtkFileFilterHandle GetFilter(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_filter(chooser);
	}

	public static bool GetLocalOnly(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_local_only(chooser);
	}

	public static MentorLake.Gio.GFileHandle GetPreviewFile(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_preview_file(chooser);
	}

	public static string GetPreviewFilename(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_preview_filename(chooser);
	}

	public static string GetPreviewUri(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_preview_uri(chooser);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetPreviewWidget(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_preview_widget(chooser);
	}

	public static bool GetPreviewWidgetActive(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_preview_widget_active(chooser);
	}

	public static bool GetSelectMultiple(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_select_multiple(chooser);
	}

	public static bool GetShowHidden(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_show_hidden(chooser);
	}

	public static string GetUri(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_uri(chooser);
	}

	public static MentorLake.GLib.GSListHandle GetUris(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_uris(chooser);
	}

	public static bool GetUsePreviewLabel(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_use_preview_label(chooser);
	}

	public static MentorLake.GLib.GSListHandle ListFilters(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_list_filters(chooser);
	}

	public static MentorLake.GLib.GSListHandle ListShortcutFolderUris(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_list_shortcut_folder_uris(chooser);
	}

	public static MentorLake.GLib.GSListHandle ListShortcutFolders(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_list_shortcut_folders(chooser);
	}

	public static T RemoveChoice<T>(this T chooser, string id) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_remove_choice(chooser, id);
		return chooser;
	}

	public static T RemoveFilter<T>(this T chooser, MentorLake.Gtk.GtkFileFilterHandle filter) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_remove_filter(chooser, filter);
		return chooser;
	}

	public static bool RemoveShortcutFolder(this MentorLake.Gtk.GtkFileChooserHandle chooser, string folder)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_remove_shortcut_folder(chooser, folder, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool RemoveShortcutFolderUri(this MentorLake.Gtk.GtkFileChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_remove_shortcut_folder_uri(chooser, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SelectAll<T>(this T chooser) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_select_all(chooser);
		return chooser;
	}

	public static bool SelectFile(this MentorLake.Gtk.GtkFileChooserHandle chooser, MentorLake.Gio.GFileHandle file)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_select_file(chooser, file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool SelectFilename(this MentorLake.Gtk.GtkFileChooserHandle chooser, string filename)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_select_filename(chooser, filename);
	}

	public static bool SelectUri(this MentorLake.Gtk.GtkFileChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_select_uri(chooser, uri);
	}

	public static T SetAction<T>(this T chooser, MentorLake.Gtk.GtkFileChooserAction action) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_action(chooser, action);
		return chooser;
	}

	public static T SetChoice<T>(this T chooser, string id, string option) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_choice(chooser, id, option);
		return chooser;
	}

	public static T SetCreateFolders<T>(this T chooser, bool create_folders) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_create_folders(chooser, create_folders);
		return chooser;
	}

	public static bool SetCurrentFolder(this MentorLake.Gtk.GtkFileChooserHandle chooser, string filename)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_set_current_folder(chooser, filename);
	}

	public static bool SetCurrentFolderFile(this MentorLake.Gtk.GtkFileChooserHandle chooser, MentorLake.Gio.GFileHandle file)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_set_current_folder_file(chooser, file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool SetCurrentFolderUri(this MentorLake.Gtk.GtkFileChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_set_current_folder_uri(chooser, uri);
	}

	public static T SetCurrentName<T>(this T chooser, string name) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_current_name(chooser, name);
		return chooser;
	}

	public static T SetDoOverwriteConfirmation<T>(this T chooser, bool do_overwrite_confirmation) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_do_overwrite_confirmation(chooser, do_overwrite_confirmation);
		return chooser;
	}

	public static T SetExtraWidget<T>(this T chooser, MentorLake.Gtk.GtkWidgetHandle extra_widget) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_extra_widget(chooser, extra_widget);
		return chooser;
	}

	public static bool SetFile(this MentorLake.Gtk.GtkFileChooserHandle chooser, MentorLake.Gio.GFileHandle file)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_set_file(chooser, file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool SetFilename(this MentorLake.Gtk.GtkFileChooserHandle chooser, string filename)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_set_filename(chooser, filename);
	}

	public static T SetFilter<T>(this T chooser, MentorLake.Gtk.GtkFileFilterHandle filter) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_filter(chooser, filter);
		return chooser;
	}

	public static T SetLocalOnly<T>(this T chooser, bool local_only) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_local_only(chooser, local_only);
		return chooser;
	}

	public static T SetPreviewWidget<T>(this T chooser, MentorLake.Gtk.GtkWidgetHandle preview_widget) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_preview_widget(chooser, preview_widget);
		return chooser;
	}

	public static T SetPreviewWidgetActive<T>(this T chooser, bool active) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_preview_widget_active(chooser, active);
		return chooser;
	}

	public static T SetSelectMultiple<T>(this T chooser, bool select_multiple) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_select_multiple(chooser, select_multiple);
		return chooser;
	}

	public static T SetShowHidden<T>(this T chooser, bool show_hidden) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_show_hidden(chooser, show_hidden);
		return chooser;
	}

	public static bool SetUri(this MentorLake.Gtk.GtkFileChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_set_uri(chooser, uri);
	}

	public static T SetUsePreviewLabel<T>(this T chooser, bool use_label) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_use_preview_label(chooser, use_label);
		return chooser;
	}

	public static T UnselectAll<T>(this T chooser) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_unselect_all(chooser);
		return chooser;
	}

	public static T UnselectFile<T>(this T chooser, MentorLake.Gio.GFileHandle file) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_unselect_file(chooser, file);
		return chooser;
	}

	public static T UnselectFilename<T>(this T chooser, string filename) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_unselect_filename(chooser, filename);
		return chooser;
	}

	public static T UnselectUri<T>(this T chooser, string uri) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid || chooser.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_unselect_uri(chooser, uri);
		return chooser;
	}

}

internal class GtkFileChooserHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_add_choice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string id, string label, string[] options, string[] option_labels);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_add_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_add_shortcut_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string folder, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_add_shortcut_folder_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFileChooserAction gtk_file_chooser_get_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_choice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string id);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_get_create_folders([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_current_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle gtk_file_chooser_get_current_folder_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_current_folder_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_current_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_get_do_overwrite_confirmation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_file_chooser_get_extra_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle gtk_file_chooser_get_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_file_chooser_get_filenames([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_file_chooser_get_files([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFileFilterHandle gtk_file_chooser_get_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_get_local_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle gtk_file_chooser_get_preview_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_preview_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_preview_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_file_chooser_get_preview_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_get_preview_widget_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_get_select_multiple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_get_show_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_file_chooser_get_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_get_use_preview_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_file_chooser_list_filters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_file_chooser_list_shortcut_folder_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_file_chooser_list_shortcut_folders([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_remove_choice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_remove_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_remove_shortcut_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string folder, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_remove_shortcut_folder_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_select_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_select_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_select_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string uri);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, MentorLake.Gtk.GtkFileChooserAction action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_choice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string id, string option);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_create_folders([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, bool create_folders);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_set_current_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_set_current_folder_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_set_current_folder_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string uri);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_current_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_do_overwrite_confirmation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, bool do_overwrite_confirmation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_extra_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle extra_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_set_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_set_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))] MentorLake.Gtk.GtkFileFilterHandle filter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_local_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, bool local_only);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_preview_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle preview_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_preview_widget_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, bool active);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_select_multiple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, bool select_multiple);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_show_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, bool show_hidden);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_set_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string uri);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_set_use_preview_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, bool use_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_unselect_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_unselect_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_unselect_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser, string uri);

}

namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkFileChooser is an interface that can be implemented by file
/// selection widgets.  In GTK+, the main objects that implement this
/// interface are #GtkFileChooserWidget, #GtkFileChooserDialog, and
/// #GtkFileChooserButton.  You do not need to write an object that
/// implements the #GtkFileChooser interface unless you are trying to
/// adapt an existing file selector to expose a standard programming
/// interface.
/// </para>
/// <para>
/// #GtkFileChooser allows for shortcuts to various places in the filesystem.
/// In the default implementation these are displayed in the left pane. It
/// may be a bit confusing at first that these shortcuts come from various
/// sources and in various flavours, so lets explain the terminology here:
/// </para>
/// <para>
/// - Bookmarks: are created by the user, by dragging folders from the
///   right pane to the left pane, or by using the “Add”. Bookmarks
///   can be renamed and deleted by the user.
/// </para>
/// <para>
/// - Shortcuts: can be provided by the application. For example, a Paint
///   program may want to add a shortcut for a Clipart folder. Shortcuts
///   cannot be modified by the user.
/// </para>
/// <para>
/// - Volumes: are provided by the underlying filesystem abstraction. They are
///   the “roots” of the filesystem.
/// </para>
/// <para>
/// # File Names and Encodings
/// </para>
/// <para>
/// When the user is finished selecting files in a
/// #GtkFileChooser, your program can get the selected names
/// either as filenames or as URIs.  For URIs, the normal escaping
/// rules are applied if the URI contains non-ASCII characters.
/// However, filenames are always returned in
/// the character set specified by the
/// `G_FILENAME_ENCODING` environment variable.
/// Please see the GLib documentation for more details about this
/// variable.
/// </para>
/// <para>
/// This means that while you can pass the result of
/// gtk_file_chooser_get_filename() to g_open() or g_fopen(),
/// you may not be able to directly set it as the text of a
/// #GtkLabel widget unless you convert it first to UTF-8,
/// which all GTK+ widgets expect. You should use g_filename_to_utf8()
/// to convert filenames into strings that can be passed to GTK+
/// widgets.
/// </para>
/// <para>
/// # Adding a Preview Widget
/// </para>
/// <para>
/// You can add a custom preview widget to a file chooser and then
/// get notification about when the preview needs to be updated.
/// To install a preview widget, use
/// gtk_file_chooser_set_preview_widget().  Then, connect to the
/// #GtkFileChooser::update-preview signal to get notified when
/// you need to update the contents of the preview.
/// </para>
/// <para>
/// Your callback should use
/// gtk_file_chooser_get_preview_filename() to see what needs
/// previewing.  Once you have generated the preview for the
/// corresponding file, you must call
/// gtk_file_chooser_set_preview_widget_active() with a boolean
/// flag that indicates whether your callback could successfully
/// generate a preview.
/// </para>
/// <para>
/// ## Example: Using a Preview Widget ## {#gtkfilechooser-preview}
/// <code>
/// {
/// {
///   GtkImage *preview;
/// 
///   ...
/// 
///   preview = gtk_image_new ();
/// 
///   gtk_file_chooser_set_preview_widget (my_file_chooser, preview);
///   g_signal_connect (my_file_chooser, &quot;update-preview&quot;,
/// 		    G_CALLBACK (update_preview_cb), preview);
/// }
/// 
/// static void
/// update_preview_cb (GtkFileChooser *file_chooser, gpointer data)
/// {
///   GtkWidget *preview;
///   char *filename;
///   GdkPixbuf *pixbuf;
///   gboolean have_preview;
/// 
///   preview = GTK_WIDGET (data);
///   filename = gtk_file_chooser_get_preview_filename (file_chooser);
/// 
///   pixbuf = gdk_pixbuf_new_from_file_at_size (filename, 128, 128, NULL);
///   have_preview = (pixbuf != NULL);
///   g_free (filename);
/// 
///   gtk_image_set_from_pixbuf (GTK_IMAGE (preview), pixbuf);
///   if (pixbuf)
///     g_object_unref (pixbuf);
/// 
///   gtk_file_chooser_set_preview_widget_active (file_chooser, have_preview);
/// }
/// </code>
/// # Adding Extra Widgets
/// </para>
/// <para>
/// You can add extra widgets to a file chooser to provide options
/// that are not present in the default design.  For example, you
/// can add a toggle button to give the user the option to open a
/// file in read-only mode.  You can use
/// gtk_file_chooser_set_extra_widget() to insert additional
/// widgets in a file chooser.
/// </para>
/// <para>
/// An example for adding extra widgets:
/// <code>
/// 
/// 
///   GtkWidget *toggle;
/// 
///   ...
/// 
///   toggle = gtk_check_button_new_with_label (&quot;Open file read-only&quot;);
///   gtk_widget_show (toggle);
///   gtk_file_chooser_set_extra_widget (my_file_chooser, toggle);
/// }
/// </code>
/// If you want to set more than one extra widget in the file
/// chooser, you can a container such as a #GtkBox or a #GtkGrid
/// and include your widgets in it.  Then, set the container as
/// the whole extra widget.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Adds a &apos;choice&apos; to the file chooser. This is typically implemented
/// as a combobox or, for boolean choices, as a checkbutton. You can select
/// a value using gtk_file_chooser_set_choice() before the dialog is shown,
/// and you can obtain the user-selected value in the ::response signal handler
/// using gtk_file_chooser_get_choice().
/// </para>
/// <para>
/// Compare gtk_file_chooser_set_extra_widget().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="id">
/// id for the added choice
/// </param>
/// <param name="label">
/// user-visible label for the added choice
/// </param>
/// <param name="options">
/// ids for the options of the choice, or %NULL for a boolean choice
/// </param>
/// <param name="option_labels">
/// user-visible labels for the options, must be the same length as @options
/// </param>

	public static T AddChoice<T>(this T chooser, string id, string label, string[] options, string[] option_labels) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_add_choice(chooser, id, label, options, option_labels);
		return chooser;
	}

/// <summary>
/// <para>
/// Adds @filter to the list of filters that the user can select between.
/// When a filter is selected, only files that are passed by that
/// filter are displayed.
/// </para>
/// <para>
/// Note that the @chooser takes ownership of the filter, so you have to
/// ref and sink it if you want to keep a reference.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="filter">
/// a #GtkFileFilter
/// </param>

	public static T AddFilter<T>(this T chooser, MentorLake.Gtk.GtkFileFilterHandle filter) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_add_filter(chooser, filter);
		return chooser;
	}

/// <summary>
/// <para>
/// Adds a folder to be displayed with the shortcut folders in a file chooser.
/// Note that shortcut folders do not get saved, as they are provided by the
/// application.  For example, you can use this to add a
/// “/usr/share/mydrawprogram/Clipart” folder to the volume list.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="folder">
/// filename of the folder to add
/// </param>
/// <return>
/// %TRUE if the folder could be added successfully, %FALSE
/// otherwise.  In the latter case, the @error will be set as appropriate.
/// </return>

	public static bool AddShortcutFolder(this MentorLake.Gtk.GtkFileChooserHandle chooser, string folder)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_add_shortcut_folder(chooser, folder, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Adds a folder URI to be displayed with the shortcut folders in a file
/// chooser.  Note that shortcut folders do not get saved, as they are provided
/// by the application.  For example, you can use this to add a
/// “file:///usr/share/mydrawprogram/Clipart” folder to the volume list.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="uri">
/// URI of the folder to add
/// </param>
/// <return>
/// %TRUE if the folder could be added successfully, %FALSE
/// otherwise.  In the latter case, the @error will be set as appropriate.
/// </return>

	public static bool AddShortcutFolderUri(this MentorLake.Gtk.GtkFileChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_add_shortcut_folder_uri(chooser, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the type of operation that the file chooser is performing; see
/// gtk_file_chooser_set_action().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// the action that the file selector is performing
/// </return>

	public static MentorLake.Gtk.GtkFileChooserAction GetAction(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_action(chooser);
	}

/// <summary>
/// <para>
/// Gets the currently selected option in the &apos;choice&apos; with the given ID.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="id">
/// the ID of the choice to get
/// </param>
/// <return>
/// the ID of the currenly selected option
/// </return>

	public static string GetChoice(this MentorLake.Gtk.GtkFileChooserHandle chooser, string id)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_choice(chooser, id);
	}

/// <summary>
/// <para>
/// Gets whether file choser will offer to create new folders.
/// See gtk_file_chooser_set_create_folders().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// %TRUE if the Create Folder button should be displayed.
/// </return>

	public static bool GetCreateFolders(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_create_folders(chooser);
	}

/// <summary>
/// <para>
/// Gets the current folder of @chooser as a local filename.
/// See gtk_file_chooser_set_current_folder().
/// </para>
/// <para>
/// Note that this is the folder that the file chooser is currently displaying
/// (e.g. &quot;/home/username/Documents&quot;), which is not the same
/// as the currently-selected folder if the chooser is in
/// %GTK_FILE_CHOOSER_ACTION_SELECT_FOLDER mode
/// (e.g. &quot;/home/username/Documents/selected-folder/&quot;.  To get the
/// currently-selected folder in that mode, use gtk_file_chooser_get_uri() as the
/// usual way to get the selection.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// the full path of the current
/// folder, or %NULL if the current path cannot be represented as a local
/// filename.  Free with g_free().  This function will also return
/// %NULL if the file chooser was unable to load the last folder that
/// was requested from it; for example, as would be for calling
/// gtk_file_chooser_set_current_folder() on a nonexistent folder.
/// </return>

	public static string GetCurrentFolder(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_current_folder(chooser);
	}

/// <summary>
/// <para>
/// Gets the current folder of @chooser as #GFile.
/// See gtk_file_chooser_get_current_folder_uri().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// the #GFile for the current folder.
/// </return>

	public static MentorLake.Gio.GFileHandle GetCurrentFolderFile(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_current_folder_file(chooser);
	}

/// <summary>
/// <para>
/// Gets the current folder of @chooser as an URI.
/// See gtk_file_chooser_set_current_folder_uri().
/// </para>
/// <para>
/// Note that this is the folder that the file chooser is currently displaying
/// (e.g. &quot;file:///home/username/Documents&quot;), which is not the same
/// as the currently-selected folder if the chooser is in
/// %GTK_FILE_CHOOSER_ACTION_SELECT_FOLDER mode
/// (e.g. &quot;file:///home/username/Documents/selected-folder/&quot;.  To get the
/// currently-selected folder in that mode, use gtk_file_chooser_get_uri() as the
/// usual way to get the selection.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// the URI for the current folder.
/// Free with g_free().  This function will also return %NULL if the file chooser
/// was unable to load the last folder that was requested from it; for example,
/// as would be for calling gtk_file_chooser_set_current_folder_uri() on a
/// nonexistent folder.
/// </return>

	public static string GetCurrentFolderUri(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_current_folder_uri(chooser);
	}

/// <summary>
/// <para>
/// Gets the current name in the file selector, as entered by the user in the
/// text entry for “Name”.
/// </para>
/// <para>
/// This is meant to be used in save dialogs, to get the currently typed filename
/// when the file itself does not exist yet.  For example, an application that
/// adds a custom extra widget to the file chooser for “file format” may want to
/// change the extension of the typed filename based on the chosen format, say,
/// from “.jpg” to “.png”.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// The raw text from the file chooser’s “Name” entry.  Free this with
/// g_free().  Note that this string is not a full pathname or URI; it is
/// whatever the contents of the entry are.  Note also that this string is in
/// UTF-8 encoding, which is not necessarily the system’s encoding for filenames.
/// </return>

	public static string GetCurrentName(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_current_name(chooser);
	}

/// <summary>
/// <para>
/// Queries whether a file chooser is set to confirm for overwriting when the user
/// types a file name that already exists.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// %TRUE if the file chooser will present a confirmation dialog;
/// %FALSE otherwise.
/// </return>

	public static bool GetDoOverwriteConfirmation(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_do_overwrite_confirmation(chooser);
	}

/// <summary>
/// <para>
/// Gets the current extra widget; see
/// gtk_file_chooser_set_extra_widget().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// the current extra widget, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetExtraWidget(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_extra_widget(chooser);
	}

/// <summary>
/// <para>
/// Gets the #GFile for the currently selected file in
/// the file selector. If multiple files are selected,
/// one of the files will be returned at random.
/// </para>
/// <para>
/// If the file chooser is in folder mode, this function returns the selected
/// folder.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// a selected #GFile. You own the returned file;
///     use g_object_unref() to release it.
/// </return>

	public static MentorLake.Gio.GFileHandle GetFile(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_file(chooser);
	}

/// <summary>
/// <para>
/// Gets the filename for the currently selected file in
/// the file selector. The filename is returned as an absolute path. If
/// multiple files are selected, one of the filenames will be returned at
/// random.
/// </para>
/// <para>
/// If the file chooser is in folder mode, this function returns the selected
/// folder.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// The currently selected filename,
///  or %NULL if no file is selected, or the selected file can&apos;t
///  be represented with a local filename. Free with g_free().
/// </return>

	public static string GetFilename(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_filename(chooser);
	}

/// <summary>
/// <para>
/// Lists all the selected files and subfolders in the current folder of
/// @chooser. The returned names are full absolute paths. If files in the current
/// folder cannot be represented as local filenames they will be ignored. (See
/// gtk_file_chooser_get_uris())
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// a #GSList
///    containing the filenames of all selected files and subfolders in
///    the current folder. Free the returned list with g_slist_free(),
///    and the filenames with g_free().
/// </return>

	public static MentorLake.GLib.GSListHandle GetFilenames(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_filenames(chooser);
	}

/// <summary>
/// <para>
/// Lists all the selected files and subfolders in the current folder of @chooser
/// as #GFile. An internal function, see gtk_file_chooser_get_uris().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// a #GSList
///   containing a #GFile for each selected file and subfolder in the
///   current folder.  Free the returned list with g_slist_free(), and
///   the files with g_object_unref().
/// </return>

	public static MentorLake.GLib.GSListHandle GetFiles(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_files(chooser);
	}

/// <summary>
/// <para>
/// Gets the current filter; see gtk_file_chooser_set_filter().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// the current filter, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkFileFilterHandle GetFilter(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_filter(chooser);
	}

/// <summary>
/// <para>
/// Gets whether only local files can be selected in the
/// file selector. See gtk_file_chooser_set_local_only()
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// %TRUE if only local files can be selected.
/// </return>

	public static bool GetLocalOnly(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_local_only(chooser);
	}

/// <summary>
/// <para>
/// Gets the #GFile that should be previewed in a custom preview
/// Internal function, see gtk_file_chooser_get_preview_uri().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// the #GFile for the file to preview,
///     or %NULL if no file is selected. Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GFileHandle GetPreviewFile(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_preview_file(chooser);
	}

/// <summary>
/// <para>
/// Gets the filename that should be previewed in a custom preview
/// widget. See gtk_file_chooser_set_preview_widget().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// the filename to preview, or %NULL if
///  no file is selected, or if the selected file cannot be represented
///  as a local filename. Free with g_free()
/// </return>

	public static string GetPreviewFilename(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_preview_filename(chooser);
	}

/// <summary>
/// <para>
/// Gets the URI that should be previewed in a custom preview
/// widget. See gtk_file_chooser_set_preview_widget().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// the URI for the file to preview,
///     or %NULL if no file is selected. Free with g_free().
/// </return>

	public static string GetPreviewUri(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_preview_uri(chooser);
	}

/// <summary>
/// <para>
/// Gets the current preview widget; see
/// gtk_file_chooser_set_preview_widget().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// the current preview widget, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetPreviewWidget(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_preview_widget(chooser);
	}

/// <summary>
/// <para>
/// Gets whether the preview widget set by gtk_file_chooser_set_preview_widget()
/// should be shown for the current filename. See
/// gtk_file_chooser_set_preview_widget_active().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// %TRUE if the preview widget is active for the current filename.
/// </return>

	public static bool GetPreviewWidgetActive(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_preview_widget_active(chooser);
	}

/// <summary>
/// <para>
/// Gets whether multiple files can be selected in the file
/// selector. See gtk_file_chooser_set_select_multiple().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// %TRUE if multiple files can be selected.
/// </return>

	public static bool GetSelectMultiple(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_select_multiple(chooser);
	}

/// <summary>
/// <para>
/// Gets whether hidden files and folders are displayed in the file selector.
/// See gtk_file_chooser_set_show_hidden().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// %TRUE if hidden files and folders are displayed.
/// </return>

	public static bool GetShowHidden(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_show_hidden(chooser);
	}

/// <summary>
/// <para>
/// Gets the URI for the currently selected file in
/// the file selector. If multiple files are selected,
/// one of the filenames will be returned at random.
/// </para>
/// <para>
/// If the file chooser is in folder mode, this function returns the selected
/// folder.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// The currently selected URI, or %NULL
///    if no file is selected. If gtk_file_chooser_set_local_only() is set to
///    %TRUE (the default) a local URI will be returned for any FUSE locations.
///    Free with g_free()
/// </return>

	public static string GetUri(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_uri(chooser);
	}

/// <summary>
/// <para>
/// Lists all the selected files and subfolders in the current folder of
/// @chooser. The returned names are full absolute URIs.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// a #GSList containing the URIs of all selected
///   files and subfolders in the current folder. Free the returned list
///   with g_slist_free(), and the filenames with g_free().
/// </return>

	public static MentorLake.GLib.GSListHandle GetUris(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_uris(chooser);
	}

/// <summary>
/// <para>
/// Gets whether a stock label should be drawn with the name of the previewed
/// file.  See gtk_file_chooser_set_use_preview_label().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// %TRUE if the file chooser is set to display a label with the
/// name of the previewed file, %FALSE otherwise.
/// </return>

	public static bool GetUsePreviewLabel(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_get_use_preview_label(chooser);
	}

/// <summary>
/// <para>
/// Lists the current set of user-selectable filters; see
/// gtk_file_chooser_add_filter(), gtk_file_chooser_remove_filter().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// a
///  #GSList containing the current set of user selectable filters. The
///  contents of the list are owned by GTK+, but you must free the list
///  itself with g_slist_free() when you are done with it.
/// </return>

	public static MentorLake.GLib.GSListHandle ListFilters(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_list_filters(chooser);
	}

/// <summary>
/// <para>
/// Queries the list of shortcut folders in the file chooser, as set by
/// gtk_file_chooser_add_shortcut_folder_uri().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// A list of
/// folder URIs, or %NULL if there are no shortcut folders.  Free the
/// returned list with g_slist_free(), and the URIs with g_free().
/// </return>

	public static MentorLake.GLib.GSListHandle ListShortcutFolderUris(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_list_shortcut_folder_uris(chooser);
	}

/// <summary>
/// <para>
/// Queries the list of shortcut folders in the file chooser, as set by
/// gtk_file_chooser_add_shortcut_folder().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <return>
/// A list
/// of folder filenames, or %NULL if there are no shortcut folders.
/// Free the returned list with g_slist_free(), and the filenames with
/// g_free().
/// </return>

	public static MentorLake.GLib.GSListHandle ListShortcutFolders(this MentorLake.Gtk.GtkFileChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_list_shortcut_folders(chooser);
	}

/// <summary>
/// <para>
/// Removes a &apos;choice&apos; that has been added with gtk_file_chooser_add_choice().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="id">
/// the ID of the choice to remove
/// </param>

	public static T RemoveChoice<T>(this T chooser, string id) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_remove_choice(chooser, id);
		return chooser;
	}

/// <summary>
/// <para>
/// Removes @filter from the list of filters that the user can select between.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="filter">
/// a #GtkFileFilter
/// </param>

	public static T RemoveFilter<T>(this T chooser, MentorLake.Gtk.GtkFileFilterHandle filter) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_remove_filter(chooser, filter);
		return chooser;
	}

/// <summary>
/// <para>
/// Removes a folder from a file chooser’s list of shortcut folders.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="folder">
/// filename of the folder to remove
/// </param>
/// <return>
/// %TRUE if the operation succeeds, %FALSE otherwise.
/// In the latter case, the @error will be set as appropriate.
/// 
/// See also: gtk_file_chooser_add_shortcut_folder()
/// </return>

	public static bool RemoveShortcutFolder(this MentorLake.Gtk.GtkFileChooserHandle chooser, string folder)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_remove_shortcut_folder(chooser, folder, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes a folder URI from a file chooser’s list of shortcut folders.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="uri">
/// URI of the folder to remove
/// </param>
/// <return>
/// %TRUE if the operation succeeds, %FALSE otherwise.
/// In the latter case, the @error will be set as appropriate.
/// 
/// See also: gtk_file_chooser_add_shortcut_folder_uri()
/// </return>

	public static bool RemoveShortcutFolderUri(this MentorLake.Gtk.GtkFileChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_remove_shortcut_folder_uri(chooser, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Selects all the files in the current folder of a file chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>

	public static T SelectAll<T>(this T chooser) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_select_all(chooser);
		return chooser;
	}

/// <summary>
/// <para>
/// Selects the file referred to by @file. An internal function. See
/// _gtk_file_chooser_select_uri().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="file">
/// the file to select
/// </param>
/// <return>
/// Not useful.
/// </return>

	public static bool SelectFile(this MentorLake.Gtk.GtkFileChooserHandle chooser, MentorLake.Gio.GFileHandle file)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_select_file(chooser, file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Selects a filename. If the file name isn’t in the current
/// folder of @chooser, then the current folder of @chooser will
/// be changed to the folder containing @filename.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="filename">
/// the filename to select
/// </param>
/// <return>
/// Not useful.
/// 
/// See also: gtk_file_chooser_set_filename()
/// </return>

	public static bool SelectFilename(this MentorLake.Gtk.GtkFileChooserHandle chooser, string filename)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_select_filename(chooser, filename);
	}

/// <summary>
/// <para>
/// Selects the file to by @uri. If the URI doesn’t refer to a
/// file in the current folder of @chooser, then the current folder of
/// @chooser will be changed to the folder containing @filename.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="uri">
/// the URI to select
/// </param>
/// <return>
/// Not useful.
/// </return>

	public static bool SelectUri(this MentorLake.Gtk.GtkFileChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_select_uri(chooser, uri);
	}

/// <summary>
/// <para>
/// Sets the type of operation that the chooser is performing; the
/// user interface is adapted to suit the selected action. For example,
/// an option to create a new folder might be shown if the action is
/// %GTK_FILE_CHOOSER_ACTION_SAVE but not if the action is
/// %GTK_FILE_CHOOSER_ACTION_OPEN.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="action">
/// the action that the file selector is performing
/// </param>

	public static T SetAction<T>(this T chooser, MentorLake.Gtk.GtkFileChooserAction action) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_action(chooser, action);
		return chooser;
	}

/// <summary>
/// <para>
/// Selects an option in a &apos;choice&apos; that has been added with
/// gtk_file_chooser_add_choice(). For a boolean choice, the
/// possible options are &quot;true&quot; and &quot;false&quot;.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="id">
/// the ID of the choice to set
/// </param>
/// <param name="option">
/// the ID of the option to select
/// </param>

	public static T SetChoice<T>(this T chooser, string id, string option) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_choice(chooser, id, option);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether file choser will offer to create new folders.
/// This is only relevant if the action is not set to be
/// %GTK_FILE_CHOOSER_ACTION_OPEN.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="create_folders">
/// %TRUE if the Create Folder button should be displayed
/// </param>

	public static T SetCreateFolders<T>(this T chooser, bool create_folders) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_create_folders(chooser, create_folders);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets the current folder for @chooser from a local filename.
/// The user will be shown the full contents of the current folder,
/// plus user interface elements for navigating to other folders.
/// </para>
/// <para>
/// In general, you should not use this function.  See the
/// [section on setting up a file chooser dialog][gtkfilechooserdialog-setting-up]
/// for the rationale behind this.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="filename">
/// the full path of the new current folder
/// </param>
/// <return>
/// Not useful.
/// </return>

	public static bool SetCurrentFolder(this MentorLake.Gtk.GtkFileChooserHandle chooser, string filename)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_set_current_folder(chooser, filename);
	}

/// <summary>
/// <para>
/// Sets the current folder for @chooser from a #GFile.
/// Internal function, see gtk_file_chooser_set_current_folder_uri().
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="file">
/// the #GFile for the new folder
/// </param>
/// <return>
/// %TRUE if the folder could be changed successfully, %FALSE
/// otherwise.
/// </return>

	public static bool SetCurrentFolderFile(this MentorLake.Gtk.GtkFileChooserHandle chooser, MentorLake.Gio.GFileHandle file)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_set_current_folder_file(chooser, file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the current folder for @chooser from an URI.
/// The user will be shown the full contents of the current folder,
/// plus user interface elements for navigating to other folders.
/// </para>
/// <para>
/// In general, you should not use this function.  See the
/// [section on setting up a file chooser dialog][gtkfilechooserdialog-setting-up]
/// for the rationale behind this.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="uri">
/// the URI for the new current folder
/// </param>
/// <return>
/// %TRUE if the folder could be changed successfully, %FALSE
/// otherwise.
/// </return>

	public static bool SetCurrentFolderUri(this MentorLake.Gtk.GtkFileChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_set_current_folder_uri(chooser, uri);
	}

/// <summary>
/// <para>
/// Sets the current name in the file selector, as if entered
/// by the user. Note that the name passed in here is a UTF-8
/// string rather than a filename. This function is meant for
/// such uses as a suggested name in a “Save As...” dialog.  You can
/// pass “Untitled.doc” or a similarly suitable suggestion for the @name.
/// </para>
/// <para>
/// If you want to preselect a particular existing file, you should use
/// gtk_file_chooser_set_filename() or gtk_file_chooser_set_uri() instead.
/// Please see the documentation for those functions for an example of using
/// gtk_file_chooser_set_current_name() as well.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="name">
/// the filename to use, as a UTF-8 string
/// </param>

	public static T SetCurrentName<T>(this T chooser, string name) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_current_name(chooser, name);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether a file chooser in %GTK_FILE_CHOOSER_ACTION_SAVE mode will present
/// a confirmation dialog if the user types a file name that already exists.  This
/// is %FALSE by default.
/// </para>
/// <para>
/// If set to %TRUE, the @chooser will emit the
/// #GtkFileChooser::confirm-overwrite signal when appropriate.
/// </para>
/// <para>
/// If all you need is the stock confirmation dialog, set this property to %TRUE.
/// You can override the way confirmation is done by actually handling the
/// #GtkFileChooser::confirm-overwrite signal; please refer to its documentation
/// for the details.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="do_overwrite_confirmation">
/// whether to confirm overwriting in save mode
/// </param>

	public static T SetDoOverwriteConfirmation<T>(this T chooser, bool do_overwrite_confirmation) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_do_overwrite_confirmation(chooser, do_overwrite_confirmation);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets an application-supplied widget to provide extra options to the user.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="extra_widget">
/// widget for extra options
/// </param>

	public static T SetExtraWidget<T>(this T chooser, MentorLake.Gtk.GtkWidgetHandle extra_widget) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_extra_widget(chooser, extra_widget);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets @file as the current filename for the file chooser, by changing
/// to the file’s parent folder and actually selecting the file in list.  If
/// the @chooser is in %GTK_FILE_CHOOSER_ACTION_SAVE mode, the file’s base name
/// will also appear in the dialog’s file name entry.
/// </para>
/// <para>
/// If the file name isn’t in the current folder of @chooser, then the current
/// folder of @chooser will be changed to the folder containing @filename. This
/// is equivalent to a sequence of gtk_file_chooser_unselect_all() followed by
/// gtk_file_chooser_select_filename().
/// </para>
/// <para>
/// Note that the file must exist, or nothing will be done except
/// for the directory change.
/// </para>
/// <para>
/// If you are implementing a save dialog,
/// you should use this function if you already have a file name to which the
/// user may save; for example, when the user opens an existing file and then
/// does Save As...  If you don’t have
/// a file name already — for example, if the user just created a new
/// file and is saving it for the first time, do not call this function.
/// Instead, use something similar to this:
/// <code>
/// if (document_is_new)
/// if (document_is_new)
///   {
///     // the user just created a new document
///     gtk_file_chooser_set_current_folder_file (chooser, default_file_for_saving);
///     gtk_file_chooser_set_current_name (chooser, &quot;Untitled document&quot;);
///   }
/// else
///   {
///     // the user edited an existing document
///     gtk_file_chooser_set_file (chooser, existing_file);
///   }
/// </code>
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="file">
/// the #GFile to set as current
/// </param>
/// <return>
/// Not useful.
/// </return>

	public static bool SetFile(this MentorLake.Gtk.GtkFileChooserHandle chooser, MentorLake.Gio.GFileHandle file)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		var externCallResult = GtkFileChooserHandleExterns.gtk_file_chooser_set_file(chooser, file, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @filename as the current filename for the file chooser, by changing to
/// the file’s parent folder and actually selecting the file in list; all other
/// files will be unselected.  If the @chooser is in
/// %GTK_FILE_CHOOSER_ACTION_SAVE mode, the file’s base name will also appear in
/// the dialog’s file name entry.
/// </para>
/// <para>
/// Note that the file must exist, or nothing will be done except
/// for the directory change.
/// </para>
/// <para>
/// You should use this function only when implementing a save
/// dialog for which you already have a file name to which
/// the user may save.  For example, when the user opens an existing file and
/// then does Save As... to save a copy or
/// a modified version.  If you don’t have a file name already — for
/// example, if the user just created a new file and is saving it for the first
/// time, do not call this function.  Instead, use something similar to this:
/// <code>
/// if (document_is_new)
/// if (document_is_new)
///   {
///     // the user just created a new document
///     gtk_file_chooser_set_current_name (chooser, &quot;Untitled document&quot;);
///   }
/// else
///   {
///     // the user edited an existing document
///     gtk_file_chooser_set_filename (chooser, existing_filename);
///   }
/// </code>
/// In the first case, the file chooser will present the user with useful suggestions
/// as to where to save his new file.  In the second case, the file’s existing location
/// is already known, so the file chooser will use it.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="filename">
/// the filename to set as current
/// </param>
/// <return>
/// Not useful.
/// </return>

	public static bool SetFilename(this MentorLake.Gtk.GtkFileChooserHandle chooser, string filename)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_set_filename(chooser, filename);
	}

/// <summary>
/// <para>
/// Sets the current filter; only the files that pass the
/// filter will be displayed. If the user-selectable list of filters
/// is non-empty, then the filter should be one of the filters
/// in that list. Setting the current filter when the list of
/// filters is empty is useful if you want to restrict the displayed
/// set of files without letting the user change it.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="filter">
/// a #GtkFileFilter
/// </param>

	public static T SetFilter<T>(this T chooser, MentorLake.Gtk.GtkFileFilterHandle filter) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_filter(chooser, filter);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether only local files can be selected in the
/// file selector. If @local_only is %TRUE (the default),
/// then the selected file or files are guaranteed to be
/// accessible through the operating systems native file
/// system and therefore the application only
/// needs to worry about the filename functions in
/// #GtkFileChooser, like gtk_file_chooser_get_filename(),
/// rather than the URI functions like
/// gtk_file_chooser_get_uri(),
/// </para>
/// <para>
/// On some systems non-native files may still be
/// available using the native filesystem via a userspace
/// filesystem (FUSE).
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="local_only">
/// %TRUE if only local files can be selected
/// </param>

	public static T SetLocalOnly<T>(this T chooser, bool local_only) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_local_only(chooser, local_only);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets an application-supplied widget to use to display a custom preview
/// of the currently selected file. To implement a preview, after setting the
/// preview widget, you connect to the #GtkFileChooser::update-preview
/// signal, and call gtk_file_chooser_get_preview_filename() or
/// gtk_file_chooser_get_preview_uri() on each change. If you can
/// display a preview of the new file, update your widget and
/// set the preview active using gtk_file_chooser_set_preview_widget_active().
/// Otherwise, set the preview inactive.
/// </para>
/// <para>
/// When there is no application-supplied preview widget, or the
/// application-supplied preview widget is not active, the file chooser
/// will display no preview at all.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="preview_widget">
/// widget for displaying preview.
/// </param>

	public static T SetPreviewWidget<T>(this T chooser, MentorLake.Gtk.GtkWidgetHandle preview_widget) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_preview_widget(chooser, preview_widget);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether the preview widget set by
/// gtk_file_chooser_set_preview_widget() should be shown for the
/// current filename. When @active is set to false, the file chooser
/// may display an internally generated preview of the current file
/// or it may display no preview at all. See
/// gtk_file_chooser_set_preview_widget() for more details.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="active">
/// whether to display the user-specified preview widget
/// </param>

	public static T SetPreviewWidgetActive<T>(this T chooser, bool active) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_preview_widget_active(chooser, active);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether multiple files can be selected in the file selector.  This is
/// only relevant if the action is set to be %GTK_FILE_CHOOSER_ACTION_OPEN or
/// %GTK_FILE_CHOOSER_ACTION_SELECT_FOLDER.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="select_multiple">
/// %TRUE if multiple files can be selected.
/// </param>

	public static T SetSelectMultiple<T>(this T chooser, bool select_multiple) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_select_multiple(chooser, select_multiple);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether hidden files and folders are displayed in the file selector.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="show_hidden">
/// %TRUE if hidden files and folders should be displayed.
/// </param>

	public static T SetShowHidden<T>(this T chooser, bool show_hidden) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_show_hidden(chooser, show_hidden);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets the file referred to by @uri as the current file for the file chooser,
/// by changing to the URI’s parent folder and actually selecting the URI in the
/// list.  If the @chooser is %GTK_FILE_CHOOSER_ACTION_SAVE mode, the URI’s base
/// name will also appear in the dialog’s file name entry.
/// </para>
/// <para>
/// Note that the URI must exist, or nothing will be done except for the
/// directory change.
/// </para>
/// <para>
/// You should use this function only when implementing a save
/// dialog for which you already have a file name to which
/// the user may save.  For example, when the user opens an existing file and then
/// does Save As... to save a copy or a
/// modified version.  If you don’t have a file name already — for example,
/// if the user just created a new file and is saving it for the first time, do
/// not call this function.  Instead, use something similar to this:
/// <code>
/// if (document_is_new)
/// if (document_is_new)
///   {
///     // the user just created a new document
///     gtk_file_chooser_set_current_name (chooser, &quot;Untitled document&quot;);
///   }
/// else
///   {
///     // the user edited an existing document
///     gtk_file_chooser_set_uri (chooser, existing_uri);
///   }
/// </code>
/// </para>
/// <para>
/// In the first case, the file chooser will present the user with useful suggestions
/// as to where to save his new file.  In the second case, the file’s existing location
/// is already known, so the file chooser will use it.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="uri">
/// the URI to set as current
/// </param>
/// <return>
/// Not useful.
/// </return>

	public static bool SetUri(this MentorLake.Gtk.GtkFileChooserHandle chooser, string uri)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		return GtkFileChooserHandleExterns.gtk_file_chooser_set_uri(chooser, uri);
	}

/// <summary>
/// <para>
/// Sets whether the file chooser should display a stock label with the name of
/// the file that is being previewed; the default is %TRUE.  Applications that
/// want to draw the whole preview area themselves should set this to %FALSE and
/// display the name themselves in their preview widget.
/// </para>
/// <para>
/// See also: gtk_file_chooser_set_preview_widget()
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="use_label">
/// whether to display a stock label with the name of the previewed file
/// </param>

	public static T SetUsePreviewLabel<T>(this T chooser, bool use_label) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_set_use_preview_label(chooser, use_label);
		return chooser;
	}

/// <summary>
/// <para>
/// Unselects all the files in the current folder of a file chooser.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>

	public static T UnselectAll<T>(this T chooser) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_unselect_all(chooser);
		return chooser;
	}

/// <summary>
/// <para>
/// Unselects the file referred to by @file. If the file is not in the current
/// directory, does not exist, or is otherwise not currently selected, does nothing.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="file">
/// a #GFile
/// </param>

	public static T UnselectFile<T>(this T chooser, MentorLake.Gio.GFileHandle file) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_unselect_file(chooser, file);
		return chooser;
	}

/// <summary>
/// <para>
/// Unselects a currently selected filename. If the filename
/// is not in the current directory, does not exist, or
/// is otherwise not currently selected, does nothing.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="filename">
/// the filename to unselect
/// </param>

	public static T UnselectFilename<T>(this T chooser, string filename) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
		GtkFileChooserHandleExterns.gtk_file_chooser_unselect_filename(chooser, filename);
		return chooser;
	}

/// <summary>
/// <para>
/// Unselects the file referred to by @uri. If the file
/// is not in the current directory, does not exist, or
/// is otherwise not currently selected, does nothing.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkFileChooser
/// </param>
/// <param name="uri">
/// the URI to unselect
/// </param>

	public static T UnselectUri<T>(this T chooser, string uri) where T : GtkFileChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserHandle)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_file_chooser_get_extra_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle gtk_file_chooser_get_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_file_chooser_get_filenames([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_file_chooser_get_files([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterHandle>))]
	internal static extern MentorLake.Gtk.GtkFileFilterHandle gtk_file_chooser_get_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_get_local_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle gtk_file_chooser_get_preview_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_preview_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_preview_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_file_chooser_get_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_get_use_preview_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_file_chooser_list_filters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_file_chooser_list_shortcut_folder_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
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

namespace MentorLake.GLib;

/// <summary>
/// <para>
/// `GBookmarkFile` lets you parse, edit or create files containing bookmarks.
/// </para>
/// <para>
/// Bookmarks refer to a URI, along with some meta-data about the resource
/// pointed by the URI like its MIME type, the application that is registering
/// the bookmark and the icon that should be used to represent the bookmark.
/// The data is stored using the
/// [Desktop Bookmark Specification](https://www.freedesktop.org/wiki/Specifications/desktop-bookmark-spec/).
/// </para>
/// <para>
/// The syntax of the bookmark files is described in detail inside the
/// Desktop Bookmark Specification, here is a quick summary: bookmark
/// files use a sub-class of the XML Bookmark Exchange Language
/// specification, consisting of valid UTF-8 encoded XML, under the
/// `&amp;lt;xbel&amp;gt;` root element; each bookmark is stored inside a
/// `&amp;lt;bookmark&amp;gt;` element, using its URI: no relative paths can
/// be used inside a bookmark file. The bookmark may have a user defined
/// title and description, to be used instead of the URI. Under the
/// `&amp;lt;metadata&amp;gt;` element, with its owner attribute set to
/// `http://freedesktop.org`, is stored the meta-data about a resource
/// pointed by its URI. The meta-data consists of the resource&apos;s MIME
/// type; the applications that have registered a bookmark; the groups
/// to which a bookmark belongs to; a visibility flag, used to set the
/// bookmark as &quot;private&quot; to the applications and groups that has it
/// registered; the URI and MIME type of an icon, to be used when
/// displaying the bookmark inside a GUI.
/// </para>
/// <para>
/// Here is an example of a bookmark file:
/// [bookmarks.xbel](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/glib/tests/bookmarks.xbel)
/// </para>
/// <para>
/// A bookmark file might contain more than one bookmark; each bookmark
/// is accessed through its URI.
/// </para>
/// <para>
/// The important caveat of bookmark files is that when you add a new
/// bookmark you must also add the application that is registering it, using
/// [method@GLib.BookmarkFile.add_application] or [method@GLib.BookmarkFile.set_application_info].
/// If a bookmark has no applications then it won&apos;t be dumped when creating
/// the on disk representation, using [method@GLib.BookmarkFile.to_data] or
/// [method@GLib.BookmarkFile.to_file].
/// </para>
/// </summary>

public class GBookmarkFileHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new empty #GBookmarkFile object.
/// </para>
/// <para>
/// Use g_bookmark_file_load_from_file(), g_bookmark_file_load_from_data()
/// or g_bookmark_file_load_from_data_dirs() to read an existing bookmark
/// file.
/// </para>
/// </summary>

/// <return>
/// an empty #GBookmarkFile
/// </return>

	public static MentorLake.GLib.GBookmarkFileHandle New()
	{
		return GBookmarkFileExterns.g_bookmark_file_new();
	}

}


public static class GBookmarkFileExtensions
{
/// <summary>
/// <para>
/// Adds the application with @name and @exec to the list of
/// applications that have registered a bookmark for @uri into
/// @bookmark.
/// </para>
/// <para>
/// Every bookmark inside a #GBookmarkFile must have at least an
/// application registered.  Each application must provide a name, a
/// command line useful for launching the bookmark, the number of times
/// the bookmark has been registered by the application and the last
/// time the application registered this bookmark.
/// </para>
/// <para>
/// If @name is %NULL, the name of the application will be the
/// same returned by g_get_application_name(); if @exec is %NULL, the
/// command line will be a composition of the program name as
/// returned by g_get_prgname() and the &quot;\%u&quot; modifier, which will be
/// expanded to the bookmark&apos;s URI.
/// </para>
/// <para>
/// This function will automatically take care of updating the
/// registrations count and timestamping in case an application
/// with the same @name had already registered a bookmark for
/// @uri inside @bookmark.
/// </para>
/// <para>
/// If no bookmark for @uri is found, one is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="name">
/// the name of the application registering the bookmark
///   or %NULL
/// </param>
/// <param name="exec">
/// command line to be used to launch the bookmark or %NULL
/// </param>

	public static void AddApplication(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_add_application(bookmark, uri, name, exec);
	}

/// <summary>
/// <para>
/// Adds @group to the list of groups to which the bookmark for @uri
/// belongs to.
/// </para>
/// <para>
/// If no bookmark for @uri is found then it is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="group">
/// the group name to be added
/// </param>

	public static void AddGroup(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_add_group(bookmark, uri, group);
	}

/// <summary>
/// <para>
/// Deeply copies a @bookmark #GBookmarkFile object to a new one.
/// </para>
/// </summary>

/// <param name="bookmark">
/// A #GBookmarkFile
/// </param>
/// <return>
/// the copy of @bookmark. Use
///   g_bookmark_free() when finished using it.
/// </return>

	public static MentorLake.GLib.GBookmarkFileHandle Copy(this MentorLake.GLib.GBookmarkFileHandle bookmark)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		return GBookmarkFileExterns.g_bookmark_file_copy(bookmark);
	}

/// <summary>
/// <para>
/// Frees a #GBookmarkFile.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>

	public static void Free(this MentorLake.GLib.GBookmarkFileHandle bookmark)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_free(bookmark);
	}

/// <summary>
/// <para>
/// Gets the time the bookmark for @uri was added to @bookmark
/// </para>
/// <para>
/// In the event the URI cannot be found, -1 is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// a timestamp
/// </return>

	public static long GetAdded(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_added(bookmark, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the time the bookmark for @uri was added to @bookmark
/// </para>
/// <para>
/// In the event the URI cannot be found, %NULL is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// a #GDateTime
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetAddedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_added_date_time(bookmark, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the registration information of @app_name for the bookmark for
/// @uri.  See g_bookmark_file_set_application_info() for more information about
/// the returned data.
/// </para>
/// <para>
/// The string returned in @app_exec must be freed.
/// </para>
/// <para>
/// In the event the URI cannot be found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.  In the
/// event that no application with name @app_name has registered a bookmark
/// for @uri,  %FALSE is returned and error is set to
/// %G_BOOKMARK_FILE_ERROR_APP_NOT_REGISTERED. In the event that unquoting
/// the command line fails, an error of the %G_SHELL_ERROR domain is
/// set and %FALSE is returned.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="name">
/// an application&apos;s name
/// </param>
/// <param name="exec">
/// return location for the command line of the application, or %NULL
/// </param>
/// <param name="count">
/// return location for the registration count, or %NULL
/// </param>
/// <param name="stamp">
/// return location for the last registration time, or %NULL
/// </param>
/// <return>
/// %TRUE on success.
/// </return>

	public static bool GetAppInfo(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, out string exec, out uint count, out long stamp)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_app_info(bookmark, uri, name, out exec, out count, out stamp, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the registration information of @app_name for the bookmark for
/// @uri.  See g_bookmark_file_set_application_info() for more information about
/// the returned data.
/// </para>
/// <para>
/// The string returned in @app_exec must be freed.
/// </para>
/// <para>
/// In the event the URI cannot be found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.  In the
/// event that no application with name @app_name has registered a bookmark
/// for @uri,  %FALSE is returned and error is set to
/// %G_BOOKMARK_FILE_ERROR_APP_NOT_REGISTERED. In the event that unquoting
/// the command line fails, an error of the %G_SHELL_ERROR domain is
/// set and %FALSE is returned.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="name">
/// an application&apos;s name
/// </param>
/// <param name="exec">
/// return location for the command line of the application, or %NULL
/// </param>
/// <param name="count">
/// return location for the registration count, or %NULL
/// </param>
/// <param name="stamp">
/// return location for the last registration time, or %NULL
/// </param>
/// <return>
/// %TRUE on success.
/// </return>

	public static bool GetApplicationInfo(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, out string exec, out uint count, out MentorLake.GLib.GDateTimeHandle stamp)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_application_info(bookmark, uri, name, out exec, out count, out stamp, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Retrieves the names of the applications that have registered the
/// bookmark for @uri.
/// </para>
/// <para>
/// In the event the URI cannot be found, %NULL is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="length">
/// return location of the length of the returned list, or %NULL
/// </param>
/// <return>
/// a newly allocated %NULL-terminated array of strings.
///   Use g_strfreev() to free it.
/// </return>

	public static string[] GetApplications(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out UIntPtr length)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_applications(bookmark, uri, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Retrieves the description of the bookmark for @uri.
/// </para>
/// <para>
/// In the event the URI cannot be found, %NULL is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// a newly allocated string or %NULL if the specified
///   URI cannot be found.
/// </return>

	public static string GetDescription(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_description(bookmark, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Retrieves the list of group names of the bookmark for @uri.
/// </para>
/// <para>
/// In the event the URI cannot be found, %NULL is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// <para>
/// The returned array is %NULL terminated, so @length may optionally
/// be %NULL.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="length">
/// return location for the length of the returned string, or %NULL
/// </param>
/// <return>
/// a newly allocated %NULL-terminated array of group names.
///   Use g_strfreev() to free it.
/// </return>

	public static string[] GetGroups(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out UIntPtr length)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_groups(bookmark, uri, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the icon of the bookmark for @uri.
/// </para>
/// <para>
/// In the event the URI cannot be found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="href">
/// return location for the icon&apos;s location or %NULL
/// </param>
/// <param name="mime_type">
/// return location for the icon&apos;s MIME type or %NULL
/// </param>
/// <return>
/// %TRUE if the icon for the bookmark for the URI was found.
///   You should free the returned strings.
/// </return>

	public static bool GetIcon(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out string href, out string mime_type)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_icon(bookmark, uri, out href, out mime_type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets whether the private flag of the bookmark for @uri is set.
/// </para>
/// <para>
/// In the event the URI cannot be found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.  In the
/// event that the private flag cannot be found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_INVALID_VALUE.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// %TRUE if the private flag is set, %FALSE otherwise.
/// </return>

	public static bool GetIsPrivate(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_is_private(bookmark, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Retrieves the MIME type of the resource pointed by @uri.
/// </para>
/// <para>
/// In the event the URI cannot be found, %NULL is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.  In the
/// event that the MIME type cannot be found, %NULL is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_INVALID_VALUE.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// a newly allocated string or %NULL if the specified
///   URI cannot be found.
/// </return>

	public static string GetMimeType(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_mime_type(bookmark, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the time when the bookmark for @uri was last modified.
/// </para>
/// <para>
/// In the event the URI cannot be found, -1 is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// a timestamp
/// </return>

	public static long GetModified(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_modified(bookmark, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the time when the bookmark for @uri was last modified.
/// </para>
/// <para>
/// In the event the URI cannot be found, %NULL is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// a #GDateTime
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetModifiedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_modified_date_time(bookmark, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the number of bookmarks inside @bookmark.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <return>
/// the number of bookmarks
/// </return>

	public static int GetSize(this MentorLake.GLib.GBookmarkFileHandle bookmark)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		return GBookmarkFileExterns.g_bookmark_file_get_size(bookmark);
	}

/// <summary>
/// <para>
/// Returns the title of the bookmark for @uri.
/// </para>
/// <para>
/// If @uri is %NULL, the title of @bookmark is returned.
/// </para>
/// <para>
/// In the event the URI cannot be found, %NULL is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI or %NULL
/// </param>
/// <return>
/// a newly allocated string or %NULL if the specified
///   URI cannot be found.
/// </return>

	public static string GetTitle(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_title(bookmark, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns all URIs of the bookmarks in the bookmark file @bookmark.
/// The array of returned URIs will be %NULL-terminated, so @length may
/// optionally be %NULL.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="length">
/// return location for the number of returned URIs, or %NULL
/// </param>
/// <return>
/// a newly allocated %NULL-terminated array of strings.
///   Use g_strfreev() to free it.
/// </return>

	public static string[] GetUris(this MentorLake.GLib.GBookmarkFileHandle bookmark, out UIntPtr length)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		return GBookmarkFileExterns.g_bookmark_file_get_uris(bookmark, out length);
	}

/// <summary>
/// <para>
/// Gets the time the bookmark for @uri was last visited.
/// </para>
/// <para>
/// In the event the URI cannot be found, -1 is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// a timestamp.
/// </return>

	public static long GetVisited(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_visited(bookmark, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the time the bookmark for @uri was last visited.
/// </para>
/// <para>
/// In the event the URI cannot be found, %NULL is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// a #GDateTime
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetVisitedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_get_visited_date_time(bookmark, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks whether the bookmark for @uri inside @bookmark has been
/// registered by application @name.
/// </para>
/// <para>
/// In the event the URI cannot be found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="name">
/// the name of the application
/// </param>
/// <return>
/// %TRUE if the application @name was found
/// </return>

	public static bool HasApplication(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_has_application(bookmark, uri, name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks whether @group appears in the list of groups to which
/// the bookmark for @uri belongs to.
/// </para>
/// <para>
/// In the event the URI cannot be found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="group">
/// the group name to be searched
/// </param>
/// <return>
/// %TRUE if @group was found.
/// </return>

	public static bool HasGroup(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_has_group(bookmark, uri, group, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Looks whether the desktop bookmark has an item with its URI set to @uri.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// %TRUE if @uri is inside @bookmark, %FALSE otherwise
/// </return>

	public static bool HasItem(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		return GBookmarkFileExterns.g_bookmark_file_has_item(bookmark, uri);
	}

/// <summary>
/// <para>
/// Loads a bookmark file from memory into an empty #GBookmarkFile
/// structure.  If the object cannot be created then @error is set to a
/// #GBookmarkFileError.
/// </para>
/// </summary>

/// <param name="bookmark">
/// an empty #GBookmarkFile struct
/// </param>
/// <param name="data">
/// desktop bookmarks
///    loaded in memory
/// </param>
/// <param name="length">
/// the length of @data in bytes
/// </param>
/// <return>
/// %TRUE if a desktop bookmark could be loaded.
/// </return>

	public static bool LoadFromData(this MentorLake.GLib.GBookmarkFileHandle bookmark, byte[] data, UIntPtr length)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_load_from_data(bookmark, data, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This function looks for a desktop bookmark file named @file in the
/// paths returned from g_get_user_data_dir() and g_get_system_data_dirs(),
/// loads the file into @bookmark and returns the file&apos;s full path in
/// @full_path.  If the file could not be loaded then @error is
/// set to either a #GFileError or #GBookmarkFileError.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="file">
/// a relative path to a filename to open and parse
/// </param>
/// <param name="full_path">
/// return location for a string
///    containing the full path of the file, or %NULL
/// </param>
/// <return>
/// %TRUE if a key file could be loaded, %FALSE otherwise
/// </return>

	public static bool LoadFromDataDirs(this MentorLake.GLib.GBookmarkFileHandle bookmark, string file, out string full_path)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_load_from_data_dirs(bookmark, file, out full_path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads a desktop bookmark file into an empty #GBookmarkFile structure.
/// If the file could not be loaded then @error is set to either a #GFileError
/// or #GBookmarkFileError.
/// </para>
/// </summary>

/// <param name="bookmark">
/// an empty #GBookmarkFile struct
/// </param>
/// <param name="filename">
/// the path of a filename to load, in the
///     GLib file name encoding
/// </param>
/// <return>
/// %TRUE if a desktop bookmark file could be loaded
/// </return>

	public static bool LoadFromFile(this MentorLake.GLib.GBookmarkFileHandle bookmark, string filename)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_load_from_file(bookmark, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Changes the URI of a bookmark item from @old_uri to @new_uri.  Any
/// existing bookmark for @new_uri will be overwritten.  If @new_uri is
/// %NULL, then the bookmark is removed.
/// </para>
/// <para>
/// In the event the URI cannot be found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="old_uri">
/// a valid URI
/// </param>
/// <param name="new_uri">
/// a valid URI, or %NULL
/// </param>
/// <return>
/// %TRUE if the URI was successfully changed
/// </return>

	public static bool MoveItem(this MentorLake.GLib.GBookmarkFileHandle bookmark, string old_uri, string new_uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_move_item(bookmark, old_uri, new_uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes application registered with @name from the list of applications
/// that have registered a bookmark for @uri inside @bookmark.
/// </para>
/// <para>
/// In the event the URI cannot be found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// In the event that no application with name @app_name has registered
/// a bookmark for @uri,  %FALSE is returned and error is set to
/// %G_BOOKMARK_FILE_ERROR_APP_NOT_REGISTERED.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="name">
/// the name of the application
/// </param>
/// <return>
/// %TRUE if the application was successfully removed.
/// </return>

	public static bool RemoveApplication(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_remove_application(bookmark, uri, name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes @group from the list of groups to which the bookmark
/// for @uri belongs to.
/// </para>
/// <para>
/// In the event the URI cannot be found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND.
/// In the event no group was defined, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_INVALID_VALUE.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="group">
/// the group name to be removed
/// </param>
/// <return>
/// %TRUE if @group was successfully removed.
/// </return>

	public static bool RemoveGroup(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_remove_group(bookmark, uri, group, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes the bookmark for @uri from the bookmark file @bookmark.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// %TRUE if the bookmark was removed successfully.
/// </return>

	public static bool RemoveItem(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_remove_item(bookmark, uri, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the time the bookmark for @uri was added into @bookmark.
/// </para>
/// <para>
/// If no bookmark for @uri is found then it is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="added">
/// a timestamp or -1 to use the current time
/// </param>

	public static void SetAdded(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long added)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_added(bookmark, uri, added);
	}

/// <summary>
/// <para>
/// Sets the time the bookmark for @uri was added into @bookmark.
/// </para>
/// <para>
/// If no bookmark for @uri is found then it is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="added">
/// a #GDateTime
/// </param>

	public static void SetAddedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, MentorLake.GLib.GDateTimeHandle added)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_added_date_time(bookmark, uri, added);
	}

/// <summary>
/// <para>
/// Sets the meta-data of application @name inside the list of
/// applications that have registered a bookmark for @uri inside
/// @bookmark.
/// </para>
/// <para>
/// You should rarely use this function; use g_bookmark_file_add_application()
/// and g_bookmark_file_remove_application() instead.
/// </para>
/// <para>
/// @name can be any UTF-8 encoded string used to identify an
/// application.
/// @exec can have one of these two modifiers: &quot;\%f&quot;, which will
/// be expanded as the local file name retrieved from the bookmark&apos;s
/// URI; &quot;\%u&quot;, which will be expanded as the bookmark&apos;s URI.
/// The expansion is done automatically when retrieving the stored
/// command line using the g_bookmark_file_get_application_info() function.
/// @count is the number of times the application has registered the
/// bookmark; if is &amp;lt; 0, the current registration count will be increased
/// by one, if is 0, the application with @name will be removed from
/// the list of registered applications.
/// @stamp is the Unix time of the last registration; if it is -1, the
/// current time will be used.
/// </para>
/// <para>
/// If you try to remove an application by setting its registration count to
/// zero, and no bookmark for @uri is found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND; similarly,
/// in the event that no application @name has registered a bookmark
/// for @uri,  %FALSE is returned and error is set to
/// %G_BOOKMARK_FILE_ERROR_APP_NOT_REGISTERED.  Otherwise, if no bookmark
/// for @uri is found, one is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="name">
/// an application&apos;s name
/// </param>
/// <param name="exec">
/// an application&apos;s command line
/// </param>
/// <param name="count">
/// the number of registrations done for this application
/// </param>
/// <param name="stamp">
/// the time of the last registration for this application
/// </param>
/// <return>
/// %TRUE if the application&apos;s meta-data was successfully
///   changed.
/// </return>

	public static bool SetAppInfo(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, long stamp)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_set_app_info(bookmark, uri, name, exec, count, stamp, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the meta-data of application @name inside the list of
/// applications that have registered a bookmark for @uri inside
/// @bookmark.
/// </para>
/// <para>
/// You should rarely use this function; use g_bookmark_file_add_application()
/// and g_bookmark_file_remove_application() instead.
/// </para>
/// <para>
/// @name can be any UTF-8 encoded string used to identify an
/// application.
/// @exec can have one of these two modifiers: &quot;\%f&quot;, which will
/// be expanded as the local file name retrieved from the bookmark&apos;s
/// URI; &quot;\%u&quot;, which will be expanded as the bookmark&apos;s URI.
/// The expansion is done automatically when retrieving the stored
/// command line using the g_bookmark_file_get_application_info() function.
/// @count is the number of times the application has registered the
/// bookmark; if is &amp;lt; 0, the current registration count will be increased
/// by one, if is 0, the application with @name will be removed from
/// the list of registered applications.
/// @stamp is the Unix time of the last registration.
/// </para>
/// <para>
/// If you try to remove an application by setting its registration count to
/// zero, and no bookmark for @uri is found, %FALSE is returned and
/// @error is set to %G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND; similarly,
/// in the event that no application @name has registered a bookmark
/// for @uri,  %FALSE is returned and error is set to
/// %G_BOOKMARK_FILE_ERROR_APP_NOT_REGISTERED.  Otherwise, if no bookmark
/// for @uri is found, one is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="name">
/// an application&apos;s name
/// </param>
/// <param name="exec">
/// an application&apos;s command line
/// </param>
/// <param name="count">
/// the number of registrations done for this application
/// </param>
/// <param name="stamp">
/// the time of the last registration for this application,
///    which may be %NULL if @count is 0
/// </param>
/// <return>
/// %TRUE if the application&apos;s meta-data was successfully
///   changed.
/// </return>

	public static bool SetApplicationInfo(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, MentorLake.GLib.GDateTimeHandle stamp)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_set_application_info(bookmark, uri, name, exec, count, stamp, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @description as the description of the bookmark for @uri.
/// </para>
/// <para>
/// If @uri is %NULL, the description of @bookmark is set.
/// </para>
/// <para>
/// If a bookmark for @uri cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI or %NULL
/// </param>
/// <param name="description">
/// a string
/// </param>

	public static void SetDescription(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string description)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_description(bookmark, uri, description);
	}

/// <summary>
/// <para>
/// Sets a list of group names for the item with URI @uri.  Each previously
/// set group name list is removed.
/// </para>
/// <para>
/// If @uri cannot be found then an item for it is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// an item&apos;s URI
/// </param>
/// <param name="groups">
/// an array of
///    group names, or %NULL to remove all groups
/// </param>
/// <param name="length">
/// number of group name values in @groups
/// </param>

	public static void SetGroups(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string[] groups, UIntPtr length)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_groups(bookmark, uri, groups, length);
	}

/// <summary>
/// <para>
/// Sets the icon for the bookmark for @uri. If @href is %NULL, unsets
/// the currently set icon. @href can either be a full URL for the icon
/// file or the icon name following the Icon Naming specification.
/// </para>
/// <para>
/// If no bookmark for @uri is found one is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="href">
/// the URI of the icon for the bookmark, or %NULL
/// </param>
/// <param name="mime_type">
/// the MIME type of the icon for the bookmark
/// </param>

	public static void SetIcon(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string href, string mime_type)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_icon(bookmark, uri, href, mime_type);
	}

/// <summary>
/// <para>
/// Sets the private flag of the bookmark for @uri.
/// </para>
/// <para>
/// If a bookmark for @uri cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="is_private">
/// %TRUE if the bookmark should be marked as private
/// </param>

	public static void SetIsPrivate(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, bool is_private)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_is_private(bookmark, uri, is_private);
	}

/// <summary>
/// <para>
/// Sets @mime_type as the MIME type of the bookmark for @uri.
/// </para>
/// <para>
/// If a bookmark for @uri cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="mime_type">
/// a MIME type
/// </param>

	public static void SetMimeType(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string mime_type)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_mime_type(bookmark, uri, mime_type);
	}

/// <summary>
/// <para>
/// Sets the last time the bookmark for @uri was last modified.
/// </para>
/// <para>
/// If no bookmark for @uri is found then it is created.
/// </para>
/// <para>
/// The &quot;modified&quot; time should only be set when the bookmark&apos;s meta-data
/// was actually changed.  Every function of #GBookmarkFile that
/// modifies a bookmark also changes the modification time, except for
/// g_bookmark_file_set_visited_date_time().
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="modified">
/// a timestamp or -1 to use the current time
/// </param>

	public static void SetModified(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long modified)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_modified(bookmark, uri, modified);
	}

/// <summary>
/// <para>
/// Sets the last time the bookmark for @uri was last modified.
/// </para>
/// <para>
/// If no bookmark for @uri is found then it is created.
/// </para>
/// <para>
/// The &quot;modified&quot; time should only be set when the bookmark&apos;s meta-data
/// was actually changed.  Every function of #GBookmarkFile that
/// modifies a bookmark also changes the modification time, except for
/// g_bookmark_file_set_visited_date_time().
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="modified">
/// a #GDateTime
/// </param>

	public static void SetModifiedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, MentorLake.GLib.GDateTimeHandle modified)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_modified_date_time(bookmark, uri, modified);
	}

/// <summary>
/// <para>
/// Sets @title as the title of the bookmark for @uri inside the
/// bookmark file @bookmark.
/// </para>
/// <para>
/// If @uri is %NULL, the title of @bookmark is set.
/// </para>
/// <para>
/// If a bookmark for @uri cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI or %NULL
/// </param>
/// <param name="title">
/// a UTF-8 encoded string
/// </param>

	public static void SetTitle(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string title)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_title(bookmark, uri, title);
	}

/// <summary>
/// <para>
/// Sets the time the bookmark for @uri was last visited.
/// </para>
/// <para>
/// If no bookmark for @uri is found then it is created.
/// </para>
/// <para>
/// The &quot;visited&quot; time should only be set if the bookmark was launched,
/// either using the command line retrieved by g_bookmark_file_get_application_info()
/// or by the default application for the bookmark&apos;s MIME type, retrieved
/// using g_bookmark_file_get_mime_type().  Changing the &quot;visited&quot; time
/// does not affect the &quot;modified&quot; time.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="visited">
/// a timestamp or -1 to use the current time
/// </param>

	public static void SetVisited(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long visited)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_visited(bookmark, uri, visited);
	}

/// <summary>
/// <para>
/// Sets the time the bookmark for @uri was last visited.
/// </para>
/// <para>
/// If no bookmark for @uri is found then it is created.
/// </para>
/// <para>
/// The &quot;visited&quot; time should only be set if the bookmark was launched,
/// either using the command line retrieved by g_bookmark_file_get_application_info()
/// or by the default application for the bookmark&apos;s MIME type, retrieved
/// using g_bookmark_file_get_mime_type().  Changing the &quot;visited&quot; time
/// does not affect the &quot;modified&quot; time.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="visited">
/// a #GDateTime
/// </param>

	public static void SetVisitedDateTime(this MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, MentorLake.GLib.GDateTimeHandle visited)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		GBookmarkFileExterns.g_bookmark_file_set_visited_date_time(bookmark, uri, visited);
	}

/// <summary>
/// <para>
/// This function outputs @bookmark as a string.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="length">
/// return location for the length of the returned string, or %NULL
/// </param>
/// <return>
/// 
///   a newly allocated string holding the contents of the #GBookmarkFile
/// </return>

	public static byte[] ToData(this MentorLake.GLib.GBookmarkFileHandle bookmark, out UIntPtr length)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_to_data(bookmark, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This function outputs @bookmark into a file.  The write process is
/// guaranteed to be atomic by using g_file_set_contents() internally.
/// </para>
/// </summary>

/// <param name="bookmark">
/// a #GBookmarkFile
/// </param>
/// <param name="filename">
/// path of the output file
/// </param>
/// <return>
/// %TRUE if the file was successfully written.
/// </return>

	public static bool ToFile(this MentorLake.GLib.GBookmarkFileHandle bookmark, string filename)
	{
		if (bookmark.IsInvalid) throw new Exception("Invalid handle (GBookmarkFile)");
		var externCallResult = GBookmarkFileExterns.g_bookmark_file_to_file(bookmark, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}


	public static GBookmarkFile Dereference(this GBookmarkFileHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GBookmarkFile>(x.DangerousGetHandle());
}
internal class GBookmarkFileExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))]
	internal static extern MentorLake.GLib.GBookmarkFileHandle g_bookmark_file_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_add_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_add_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))]
	internal static extern MentorLake.GLib.GBookmarkFileHandle g_bookmark_file_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_bookmark_file_get_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_bookmark_file_get_added_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_get_app_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, out string exec, out uint count, out long stamp, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_get_application_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, out string exec, out uint count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] out MentorLake.GLib.GDateTimeHandle stamp, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_bookmark_file_get_applications([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_bookmark_file_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_bookmark_file_get_groups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out string href, out string mime_type, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_get_is_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_bookmark_file_get_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_bookmark_file_get_modified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_bookmark_file_get_modified_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_bookmark_file_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_bookmark_file_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_bookmark_file_get_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_bookmark_file_get_visited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_bookmark_file_get_visited_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_has_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_has_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_has_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_load_from_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, byte[] data, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_load_from_data_dirs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string file, out string full_path, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_load_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_move_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string old_uri, string new_uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_remove_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_remove_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string group, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_remove_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long added);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_added_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle added);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_set_app_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, long stamp, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_set_application_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string name, string exec, int count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle stamp, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string description);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_groups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string[] groups, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string href, string mime_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_is_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, bool is_private);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string mime_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_modified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long modified);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_modified_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle modified);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, string title);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_visited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, long visited);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bookmark_file_set_visited_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle visited);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_bookmark_file_to_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bookmark_file_to_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBookmarkFileHandle>))] MentorLake.GLib.GBookmarkFileHandle bookmark, string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_bookmark_file_error_quark();

}

/// <summary>
/// <para>
/// `GBookmarkFile` lets you parse, edit or create files containing bookmarks.
/// </para>
/// <para>
/// Bookmarks refer to a URI, along with some meta-data about the resource
/// pointed by the URI like its MIME type, the application that is registering
/// the bookmark and the icon that should be used to represent the bookmark.
/// The data is stored using the
/// [Desktop Bookmark Specification](https://www.freedesktop.org/wiki/Specifications/desktop-bookmark-spec/).
/// </para>
/// <para>
/// The syntax of the bookmark files is described in detail inside the
/// Desktop Bookmark Specification, here is a quick summary: bookmark
/// files use a sub-class of the XML Bookmark Exchange Language
/// specification, consisting of valid UTF-8 encoded XML, under the
/// `&amp;lt;xbel&amp;gt;` root element; each bookmark is stored inside a
/// `&amp;lt;bookmark&amp;gt;` element, using its URI: no relative paths can
/// be used inside a bookmark file. The bookmark may have a user defined
/// title and description, to be used instead of the URI. Under the
/// `&amp;lt;metadata&amp;gt;` element, with its owner attribute set to
/// `http://freedesktop.org`, is stored the meta-data about a resource
/// pointed by its URI. The meta-data consists of the resource&apos;s MIME
/// type; the applications that have registered a bookmark; the groups
/// to which a bookmark belongs to; a visibility flag, used to set the
/// bookmark as &quot;private&quot; to the applications and groups that has it
/// registered; the URI and MIME type of an icon, to be used when
/// displaying the bookmark inside a GUI.
/// </para>
/// <para>
/// Here is an example of a bookmark file:
/// [bookmarks.xbel](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/glib/tests/bookmarks.xbel)
/// </para>
/// <para>
/// A bookmark file might contain more than one bookmark; each bookmark
/// is accessed through its URI.
/// </para>
/// <para>
/// The important caveat of bookmark files is that when you add a new
/// bookmark you must also add the application that is registering it, using
/// [method@GLib.BookmarkFile.add_application] or [method@GLib.BookmarkFile.set_application_info].
/// If a bookmark has no applications then it won&apos;t be dumped when creating
/// the on disk representation, using [method@GLib.BookmarkFile.to_data] or
/// [method@GLib.BookmarkFile.to_file].
/// </para>
/// </summary>

public struct GBookmarkFile
{


	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GBookmarkFileExterns.g_bookmark_file_error_quark();
	}

}

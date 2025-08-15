namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Stores information about a file system object referenced by a [iface@Gio.File].
/// </para>
/// <para>
/// Functionality for manipulating basic metadata for files. `GFileInfo`
/// implements methods for getting information that all files should
/// contain, and allows for manipulation of extended attributes.
/// </para>
/// <para>
/// See the [file attributes](file-attributes.html) document for more
/// information on how GIO handles file attributes.
/// </para>
/// <para>
/// To obtain a `GFileInfo` for a [iface@Gio.File], use
/// [method@Gio.File.query_info] (or its async variant). To obtain a `GFileInfo`
/// for a file input or output stream, use [method@Gio.FileInputStream.query_info]
/// or [method@Gio.FileOutputStream.query_info] (or their async variants).
/// </para>
/// <para>
/// To change the actual attributes of a file, you should then set the
/// attribute in the `GFileInfo` and call [method@Gio.File.set_attributes_from_info]
/// or [method@Gio.File.set_attributes_async] on a `GFile`.
/// </para>
/// <para>
/// However, not all attributes can be changed in the file. For instance,
/// the actual size of a file cannot be changed via [method@Gio.FileInfo.set_size].
/// You may call [method@Gio.File.query_settable_attributes] and
/// [method@Gio.File.query_writable_namespaces] to discover the settable attributes
/// of a particular file at runtime.
/// </para>
/// <para>
/// The direct accessors, such as [method@Gio.FileInfo.get_name], are slightly more
/// optimized than the generic attribute accessors, such as
/// [method@Gio.FileInfo.get_attribute_byte_string].This optimization will matter
/// only if calling the API in a tight loop.
/// </para>
/// <para>
/// It is an error to call these accessors without specifying their required file
/// attributes when creating the `GFileInfo`. Use
/// [method@Gio.FileInfo.has_attribute] or [method@Gio.FileInfo.list_attributes]
/// to check what attributes are specified for a `GFileInfo`.
/// </para>
/// <para>
/// [struct@Gio.FileAttributeMatcher] allows for searching through a `GFileInfo`
/// for attributes.
/// </para>
/// </summary>

public class GFileInfoHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new file info structure.
/// </para>
/// </summary>

/// <return>
/// a #GFileInfo.
/// </return>

	public static MentorLake.Gio.GFileInfoHandle New()
	{
		return GFileInfoHandleExterns.g_file_info_new();
	}

}

public static class GFileInfoHandleExtensions
{
/// <summary>
/// <para>
/// Clears the status information from @info.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>

	public static T ClearStatus<T>(this T info) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_clear_status(info);
		return info;
	}

/// <summary>
/// <para>
/// First clears all of the [GFileAttribute][gio-GFileAttribute] of @dest_info,
/// and then copies all of the file attributes from @src_info to @dest_info.
/// </para>
/// </summary>

/// <param name="src_info">
/// source to copy attributes from.
/// </param>
/// <param name="dest_info">
/// destination to copy attributes to.
/// </param>

	public static T CopyInto<T>(this T src_info, MentorLake.Gio.GFileInfoHandle dest_info) where T : GFileInfoHandle
	{
		if (src_info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_copy_into(src_info, dest_info);
		return src_info;
	}

/// <summary>
/// <para>
/// Duplicates a file info structure.
/// </para>
/// </summary>

/// <param name="other">
/// a #GFileInfo.
/// </param>
/// <return>
/// a duplicate #GFileInfo of @other.
/// </return>

	public static MentorLake.Gio.GFileInfoHandle Dup(this MentorLake.Gio.GFileInfoHandle other)
	{
		if (other.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_dup(other);
	}

/// <summary>
/// <para>
/// Gets the access time of the current @info and returns it as a
/// #GDateTime.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_TIME_ACCESS. If %G_FILE_ATTRIBUTE_TIME_ACCESS_USEC is
/// provided, the resulting #GDateTime will additionally have microsecond
/// precision.
/// </para>
/// <para>
/// If nanosecond precision is needed, %G_FILE_ATTRIBUTE_TIME_ACCESS_NSEC must
/// be queried separately using g_file_info_get_attribute_uint32().
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// access time, or %NULL if unknown
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetAccessDateTime(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_access_date_time(info);
	}

/// <summary>
/// <para>
/// Gets the value of an attribute, formatted as a string.
/// This escapes things as needed to make the string valid
/// UTF-8.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// a UTF-8 string associated with the given @attribute, or
///    %NULL if the attribute wasn’t set.
///    When you&apos;re done with the string it must be freed with g_free().
/// </return>

	public static string GetAttributeAsString(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_as_string(info, attribute);
	}

/// <summary>
/// <para>
/// Gets the value of a boolean attribute. If the attribute does not
/// contain a boolean value, %FALSE will be returned.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// the boolean value contained within the attribute.
/// </return>

	public static bool GetAttributeBoolean(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_boolean(info, attribute);
	}

/// <summary>
/// <para>
/// Gets the value of a byte string attribute. If the attribute does
/// not contain a byte string, %NULL will be returned.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// the contents of the @attribute value as a byte string, or
/// %NULL otherwise.
/// </return>

	public static string GetAttributeByteString(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_byte_string(info, attribute);
	}

/// <summary>
/// <para>
/// Gets the attribute type, value and status for an attribute key.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo
/// </param>
/// <param name="attribute">
/// a file attribute key
/// </param>
/// <param name="type">
/// return location for the attribute type, or %NULL
/// </param>
/// <param name="value_pp">
/// return location for the
///    attribute value, or %NULL; the attribute value will not be %NULL
/// </param>
/// <param name="status">
/// return location for the attribute status, or %NULL
/// </param>
/// <return>
/// %TRUE if @info has an attribute named @attribute,
///      %FALSE otherwise.
/// </return>

	public static bool GetAttributeData(this MentorLake.Gio.GFileInfoHandle info, string attribute, out MentorLake.Gio.GFileAttributeType type, out IntPtr value_pp, out MentorLake.Gio.GFileAttributeStatus status)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_data(info, attribute, out type, out value_pp, out status);
	}

/// <summary>
/// <para>
/// Gets the value of a byte string attribute as a file path.
/// </para>
/// <para>
/// If the attribute does not contain a byte string, `NULL` will be returned.
/// </para>
/// <para>
/// This function is meant to be used by language bindings that have specific
/// handling for Unix paths.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// the contents of the @attribute value as
/// a file path, or %NULL otherwise.
/// </return>

	public static string GetAttributeFilePath(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_file_path(info, attribute);
	}

/// <summary>
/// <para>
/// Gets a signed 32-bit integer contained within the attribute. If the
/// attribute does not contain a signed 32-bit integer, or is invalid,
/// 0 will be returned.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// a signed 32-bit integer from the attribute.
/// </return>

	public static int GetAttributeInt32(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_int32(info, attribute);
	}

/// <summary>
/// <para>
/// Gets a signed 64-bit integer contained within the attribute. If the
/// attribute does not contain a signed 64-bit integer, or is invalid,
/// 0 will be returned.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// a signed 64-bit integer from the attribute.
/// </return>

	public static long GetAttributeInt64(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_int64(info, attribute);
	}

/// <summary>
/// <para>
/// Gets the value of a #GObject attribute. If the attribute does
/// not contain a #GObject, %NULL will be returned.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// a #GObject associated with the given @attribute,
/// or %NULL otherwise.
/// </return>

	public static MentorLake.GObject.GObjectHandle GetAttributeObject(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_object(info, attribute);
	}

/// <summary>
/// <para>
/// Gets the attribute status for an attribute key.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo
/// </param>
/// <param name="attribute">
/// a file attribute key
/// </param>
/// <return>
/// a #GFileAttributeStatus for the given @attribute, or
///    %G_FILE_ATTRIBUTE_STATUS_UNSET if the key is invalid.
/// </return>

	public static MentorLake.Gio.GFileAttributeStatus GetAttributeStatus(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_status(info, attribute);
	}

/// <summary>
/// <para>
/// Gets the value of a string attribute. If the attribute does
/// not contain a string, %NULL will be returned.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// the contents of the @attribute value as a UTF-8 string,
/// or %NULL otherwise.
/// </return>

	public static string GetAttributeString(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_string(info, attribute);
	}

/// <summary>
/// <para>
/// Gets the value of a stringv attribute. If the attribute does
/// not contain a stringv, %NULL will be returned.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// the contents of the @attribute value as a stringv,
/// or %NULL otherwise. Do not free. These returned strings are UTF-8.
/// </return>

	public static string[] GetAttributeStringv(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_stringv(info, attribute);
	}

/// <summary>
/// <para>
/// Gets the attribute type for an attribute key.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// a #GFileAttributeType for the given @attribute, or
/// %G_FILE_ATTRIBUTE_TYPE_INVALID if the key is not set.
/// </return>

	public static MentorLake.Gio.GFileAttributeType GetAttributeType(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_type(info, attribute);
	}

/// <summary>
/// <para>
/// Gets an unsigned 32-bit integer contained within the attribute. If the
/// attribute does not contain an unsigned 32-bit integer, or is invalid,
/// 0 will be returned.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// an unsigned 32-bit integer from the attribute.
/// </return>

	public static uint GetAttributeUint32(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_uint32(info, attribute);
	}

/// <summary>
/// <para>
/// Gets a unsigned 64-bit integer contained within the attribute. If the
/// attribute does not contain an unsigned 64-bit integer, or is invalid,
/// 0 will be returned.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// a unsigned 64-bit integer from the attribute.
/// </return>

	public static ulong GetAttributeUint64(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_attribute_uint64(info, attribute);
	}

/// <summary>
/// <para>
/// Gets the file&apos;s content type.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_CONTENT_TYPE.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// a string containing the file&apos;s content type,
/// or %NULL if unknown.
/// </return>

	public static string GetContentType(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_content_type(info);
	}

/// <summary>
/// <para>
/// Gets the creation time of the current @info and returns it as a
/// #GDateTime.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_TIME_CREATED. If %G_FILE_ATTRIBUTE_TIME_CREATED_USEC is
/// provided, the resulting #GDateTime will additionally have microsecond
/// precision.
/// </para>
/// <para>
/// If nanosecond precision is needed, %G_FILE_ATTRIBUTE_TIME_CREATED_NSEC must
/// be queried separately using g_file_info_get_attribute_uint32().
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// creation time, or %NULL if unknown
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetCreationDateTime(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_creation_date_time(info);
	}

/// <summary>
/// <para>
/// Returns the #GDateTime representing the deletion date of the file, as
/// available in %G_FILE_ATTRIBUTE_TRASH_DELETION_DATE. If the
/// %G_FILE_ATTRIBUTE_TRASH_DELETION_DATE attribute is unset, %NULL is returned.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// a #GDateTime, or %NULL.
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetDeletionDate(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_deletion_date(info);
	}

/// <summary>
/// <para>
/// Gets a display name for a file. This is guaranteed to always be set.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_DISPLAY_NAME.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// a string containing the display name.
/// </return>

	public static string GetDisplayName(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_display_name(info);
	}

/// <summary>
/// <para>
/// Gets the edit name for a file.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_EDIT_NAME.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// a string containing the edit name.
/// </return>

	public static string GetEditName(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_edit_name(info);
	}

/// <summary>
/// <para>
/// Gets the [entity tag](iface.File.html#entity-tags) for a given
/// #GFileInfo. See %G_FILE_ATTRIBUTE_ETAG_VALUE.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_ETAG_VALUE.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// a string containing the value of the &quot;etag:value&quot; attribute.
/// </return>

	public static string GetEtag(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_etag(info);
	}

/// <summary>
/// <para>
/// Gets a file&apos;s type (whether it is a regular file, symlink, etc).
/// This is different from the file&apos;s content type, see g_file_info_get_content_type().
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_TYPE.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// a #GFileType for the given file.
/// </return>

	public static MentorLake.Gio.GFileType GetFileType(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_file_type(info);
	}

/// <summary>
/// <para>
/// Gets the icon for a file.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_ICON.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// #GIcon for the given @info.
/// </return>

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_icon(info);
	}

/// <summary>
/// <para>
/// Checks if a file is a backup file.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_IS_BACKUP.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// %TRUE if file is a backup file, %FALSE otherwise.
/// </return>

	public static bool GetIsBackup(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_is_backup(info);
	}

/// <summary>
/// <para>
/// Checks if a file is hidden.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_IS_HIDDEN.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// %TRUE if the file is a hidden file, %FALSE otherwise.
/// </return>

	public static bool GetIsHidden(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_is_hidden(info);
	}

/// <summary>
/// <para>
/// Checks if a file is a symlink.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_IS_SYMLINK.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// %TRUE if the given @info is a symlink.
/// </return>

	public static bool GetIsSymlink(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_is_symlink(info);
	}

/// <summary>
/// <para>
/// Gets the modification time of the current @info and returns it as a
/// #GDateTime.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_TIME_MODIFIED. If %G_FILE_ATTRIBUTE_TIME_MODIFIED_USEC is
/// provided, the resulting #GDateTime will additionally have microsecond
/// precision.
/// </para>
/// <para>
/// If nanosecond precision is needed, %G_FILE_ATTRIBUTE_TIME_MODIFIED_NSEC must
/// be queried separately using g_file_info_get_attribute_uint32().
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// modification time, or %NULL if unknown
/// </return>

	public static MentorLake.GLib.GDateTimeHandle GetModificationDateTime(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_modification_date_time(info);
	}

/// <summary>
/// <para>
/// Gets the modification time of the current @info and sets it
/// in @result.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_TIME_MODIFIED. If %G_FILE_ATTRIBUTE_TIME_MODIFIED_USEC is
/// provided it will be used too.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="result">
/// a #GTimeVal.
/// </param>

	public static T GetModificationTime<T>(this T info, out MentorLake.GLib.GTimeVal result) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_get_modification_time(info, out result);
		return info;
	}

/// <summary>
/// <para>
/// Gets the name for a file. This is guaranteed to always be set.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_NAME.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// a string containing the file name.
/// </return>

	public static string GetName(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_name(info);
	}

/// <summary>
/// <para>
/// Gets the file&apos;s size (in bytes). The size is retrieved through the value of
/// the %G_FILE_ATTRIBUTE_STANDARD_SIZE attribute and is converted
/// from #guint64 to #goffset before returning the result.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_SIZE.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// a #goffset containing the file&apos;s size (in bytes).
/// </return>

	public static int GetSize(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_size(info);
	}

/// <summary>
/// <para>
/// Gets the value of the sort_order attribute from the #GFileInfo.
/// See %G_FILE_ATTRIBUTE_STANDARD_SORT_ORDER.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_SORT_ORDER.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// a #gint32 containing the value of the &quot;standard::sort_order&quot; attribute.
/// </return>

	public static int GetSortOrder(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_sort_order(info);
	}

/// <summary>
/// <para>
/// Gets the symbolic icon for a file.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_SYMBOLIC_ICON.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// #GIcon for the given @info.
/// </return>

	public static MentorLake.Gio.GIconHandle GetSymbolicIcon(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_symbolic_icon(info);
	}

/// <summary>
/// <para>
/// Gets the symlink target for a given #GFileInfo.
/// </para>
/// <para>
/// It is an error to call this if the #GFileInfo does not contain
/// %G_FILE_ATTRIBUTE_STANDARD_SYMLINK_TARGET.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <return>
/// a string containing the symlink target.
/// </return>

	public static string GetSymlinkTarget(this MentorLake.Gio.GFileInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_get_symlink_target(info);
	}

/// <summary>
/// <para>
/// Checks if a file info structure has an attribute named @attribute.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// %TRUE if @info has an attribute named @attribute,
///     %FALSE otherwise.
/// </return>

	public static bool HasAttribute(this MentorLake.Gio.GFileInfoHandle info, string attribute)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_has_attribute(info, attribute);
	}

/// <summary>
/// <para>
/// Checks if a file info structure has an attribute in the
/// specified @name_space.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="name_space">
/// a file attribute namespace.
/// </param>
/// <return>
/// %TRUE if @info has an attribute in @name_space,
///     %FALSE otherwise.
/// </return>

	public static bool HasNamespace(this MentorLake.Gio.GFileInfoHandle info, string name_space)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_has_namespace(info, name_space);
	}

/// <summary>
/// <para>
/// Lists the file info structure&apos;s attributes.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="name_space">
/// a file attribute key&apos;s namespace, or %NULL to list
///   all attributes.
/// </param>
/// <return>
/// a
/// null-terminated array of strings of all of the possible attribute
/// types for the given @name_space, or %NULL on error.
/// </return>

	public static string[] ListAttributes(this MentorLake.Gio.GFileInfoHandle info, string name_space)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_list_attributes(info, name_space);
	}

/// <summary>
/// <para>
/// Removes all cases of @attribute from @info if it exists.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>

	public static T RemoveAttribute<T>(this T info, string attribute) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_remove_attribute(info, attribute);
		return info;
	}

/// <summary>
/// <para>
/// Sets the %G_FILE_ATTRIBUTE_TIME_ACCESS and
/// %G_FILE_ATTRIBUTE_TIME_ACCESS_USEC attributes in the file info to the
/// given date/time value.
/// </para>
/// <para>
/// %G_FILE_ATTRIBUTE_TIME_ACCESS_NSEC will be cleared.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="atime">
/// a #GDateTime.
/// </param>

	public static T SetAccessDateTime<T>(this T info, MentorLake.GLib.GDateTimeHandle atime) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_access_date_time(info, atime);
		return info;
	}

/// <summary>
/// <para>
/// Sets the @attribute to contain the given value, if possible. To unset the
/// attribute, use %G_FILE_ATTRIBUTE_TYPE_INVALID for @type.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <param name="type">
/// a #GFileAttributeType
/// </param>
/// <param name="value_p">
/// pointer to the value
/// </param>

	public static T SetAttribute<T>(this T info, string attribute, MentorLake.Gio.GFileAttributeType type, IntPtr value_p) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute(info, attribute, type, value_p);
		return info;
	}

/// <summary>
/// <para>
/// Sets the @attribute to contain the given @attr_value,
/// if possible.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <param name="attr_value">
/// a boolean value.
/// </param>

	public static T SetAttributeBoolean<T>(this T info, string attribute, bool attr_value) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute_boolean(info, attribute, attr_value);
		return info;
	}

/// <summary>
/// <para>
/// Sets the @attribute to contain the given @attr_value,
/// if possible.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <param name="attr_value">
/// a byte string.
/// </param>

	public static T SetAttributeByteString<T>(this T info, string attribute, string attr_value) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute_byte_string(info, attribute, attr_value);
		return info;
	}

/// <summary>
/// <para>
/// Sets the @attribute to contain the given @attr_value,
/// if possible.
/// </para>
/// <para>
/// This function is meant to be used by language bindings that have specific
/// handling for Unix paths.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <param name="attr_value">
/// a file path.
/// </param>

	public static T SetAttributeFilePath<T>(this T info, string attribute, string attr_value) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute_file_path(info, attribute, attr_value);
		return info;
	}

/// <summary>
/// <para>
/// Sets the @attribute to contain the given @attr_value,
/// if possible.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <param name="attr_value">
/// a signed 32-bit integer
/// </param>

	public static T SetAttributeInt32<T>(this T info, string attribute, int attr_value) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute_int32(info, attribute, attr_value);
		return info;
	}

/// <summary>
/// <para>
/// Sets the @attribute to contain the given @attr_value,
/// if possible.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// attribute name to set.
/// </param>
/// <param name="attr_value">
/// int64 value to set attribute to.
/// </param>

	public static T SetAttributeInt64<T>(this T info, string attribute, long attr_value) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute_int64(info, attribute, attr_value);
		return info;
	}

/// <summary>
/// <para>
/// Sets @mask on @info to match specific attribute types.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="mask">
/// a #GFileAttributeMatcher.
/// </param>

	public static T SetAttributeMask<T>(this T info, MentorLake.Gio.GFileAttributeMatcherHandle mask) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute_mask(info, mask);
		return info;
	}

/// <summary>
/// <para>
/// Sets the @attribute to contain the given @attr_value,
/// if possible.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <param name="attr_value">
/// a #GObject.
/// </param>

	public static T SetAttributeObject<T>(this T info, string attribute, MentorLake.GObject.GObjectHandle attr_value) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute_object(info, attribute, attr_value);
		return info;
	}

/// <summary>
/// <para>
/// Sets the attribute status for an attribute key. This is only
/// needed by external code that implement g_file_set_attributes_from_info()
/// or similar functions.
/// </para>
/// <para>
/// The attribute must exist in @info for this to work. Otherwise %FALSE
/// is returned and @info is unchanged.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo
/// </param>
/// <param name="attribute">
/// a file attribute key
/// </param>
/// <param name="status">
/// a #GFileAttributeStatus
/// </param>
/// <return>
/// %TRUE if the status was changed, %FALSE if the key was not set.
/// </return>

	public static bool SetAttributeStatus(this MentorLake.Gio.GFileInfoHandle info, string attribute, MentorLake.Gio.GFileAttributeStatus status)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		return GFileInfoHandleExterns.g_file_info_set_attribute_status(info, attribute, status);
	}

/// <summary>
/// <para>
/// Sets the @attribute to contain the given @attr_value,
/// if possible.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <param name="attr_value">
/// a UTF-8 string.
/// </param>

	public static T SetAttributeString<T>(this T info, string attribute, string attr_value) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute_string(info, attribute, attr_value);
		return info;
	}

/// <summary>
/// <para>
/// Sets the @attribute to contain the given @attr_value,
/// if possible.
/// </para>
/// <para>
/// Sinze: 2.22
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key
/// </param>
/// <param name="attr_value">
/// a %NULL
///   terminated array of UTF-8 strings.
/// </param>

	public static T SetAttributeStringv<T>(this T info, string attribute, string[] attr_value) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute_stringv(info, attribute, attr_value);
		return info;
	}

/// <summary>
/// <para>
/// Sets the @attribute to contain the given @attr_value,
/// if possible.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <param name="attr_value">
/// an unsigned 32-bit integer.
/// </param>

	public static T SetAttributeUint32<T>(this T info, string attribute, uint attr_value) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute_uint32(info, attribute, attr_value);
		return info;
	}

/// <summary>
/// <para>
/// Sets the @attribute to contain the given @attr_value,
/// if possible.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <param name="attr_value">
/// an unsigned 64-bit integer.
/// </param>

	public static T SetAttributeUint64<T>(this T info, string attribute, ulong attr_value) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_attribute_uint64(info, attribute, attr_value);
		return info;
	}

/// <summary>
/// <para>
/// Sets the content type attribute for a given #GFileInfo.
/// See %G_FILE_ATTRIBUTE_STANDARD_CONTENT_TYPE.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="content_type">
/// a content type. See [GContentType][gio-GContentType]
/// </param>

	public static T SetContentType<T>(this T info, string content_type) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_content_type(info, content_type);
		return info;
	}

/// <summary>
/// <para>
/// Sets the %G_FILE_ATTRIBUTE_TIME_CREATED and
/// %G_FILE_ATTRIBUTE_TIME_CREATED_USEC attributes in the file info to the
/// given date/time value.
/// </para>
/// <para>
/// %G_FILE_ATTRIBUTE_TIME_CREATED_NSEC will be cleared.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="creation_time">
/// a #GDateTime.
/// </param>

	public static T SetCreationDateTime<T>(this T info, MentorLake.GLib.GDateTimeHandle creation_time) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_creation_date_time(info, creation_time);
		return info;
	}

/// <summary>
/// <para>
/// Sets the display name for the current #GFileInfo.
/// See %G_FILE_ATTRIBUTE_STANDARD_DISPLAY_NAME.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="display_name">
/// a string containing a display name.
/// </param>

	public static T SetDisplayName<T>(this T info, string display_name) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_display_name(info, display_name);
		return info;
	}

/// <summary>
/// <para>
/// Sets the edit name for the current file.
/// See %G_FILE_ATTRIBUTE_STANDARD_EDIT_NAME.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="edit_name">
/// a string containing an edit name.
/// </param>

	public static T SetEditName<T>(this T info, string edit_name) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_edit_name(info, edit_name);
		return info;
	}

/// <summary>
/// <para>
/// Sets the file type in a #GFileInfo to @type.
/// See %G_FILE_ATTRIBUTE_STANDARD_TYPE.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="type">
/// a #GFileType.
/// </param>

	public static T SetFileType<T>(this T info, MentorLake.Gio.GFileType type) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_file_type(info, type);
		return info;
	}

/// <summary>
/// <para>
/// Sets the icon for a given #GFileInfo.
/// See %G_FILE_ATTRIBUTE_STANDARD_ICON.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="icon">
/// a #GIcon.
/// </param>

	public static T SetIcon<T>(this T info, MentorLake.Gio.GIconHandle icon) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_icon(info, icon);
		return info;
	}

/// <summary>
/// <para>
/// Sets the &quot;is_hidden&quot; attribute in a #GFileInfo according to @is_hidden.
/// See %G_FILE_ATTRIBUTE_STANDARD_IS_HIDDEN.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="is_hidden">
/// a #gboolean.
/// </param>

	public static T SetIsHidden<T>(this T info, bool is_hidden) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_is_hidden(info, is_hidden);
		return info;
	}

/// <summary>
/// <para>
/// Sets the &quot;is_symlink&quot; attribute in a #GFileInfo according to @is_symlink.
/// See %G_FILE_ATTRIBUTE_STANDARD_IS_SYMLINK.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="is_symlink">
/// a #gboolean.
/// </param>

	public static T SetIsSymlink<T>(this T info, bool is_symlink) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_is_symlink(info, is_symlink);
		return info;
	}

/// <summary>
/// <para>
/// Sets the %G_FILE_ATTRIBUTE_TIME_MODIFIED and
/// %G_FILE_ATTRIBUTE_TIME_MODIFIED_USEC attributes in the file info to the
/// given date/time value.
/// </para>
/// <para>
/// %G_FILE_ATTRIBUTE_TIME_MODIFIED_NSEC will be cleared.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="mtime">
/// a #GDateTime.
/// </param>

	public static T SetModificationDateTime<T>(this T info, MentorLake.GLib.GDateTimeHandle mtime) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_modification_date_time(info, mtime);
		return info;
	}

/// <summary>
/// <para>
/// Sets the %G_FILE_ATTRIBUTE_TIME_MODIFIED and
/// %G_FILE_ATTRIBUTE_TIME_MODIFIED_USEC attributes in the file info to the
/// given time value.
/// </para>
/// <para>
/// %G_FILE_ATTRIBUTE_TIME_MODIFIED_NSEC will be cleared.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="mtime">
/// a #GTimeVal.
/// </param>

	public static T SetModificationTime<T>(this T info, MentorLake.GLib.GTimeValHandle mtime) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_modification_time(info, mtime);
		return info;
	}

/// <summary>
/// <para>
/// Sets the name attribute for the current #GFileInfo.
/// See %G_FILE_ATTRIBUTE_STANDARD_NAME.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="name">
/// a string containing a name.
/// </param>

	public static T SetName<T>(this T info, string name) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_name(info, name);
		return info;
	}

/// <summary>
/// <para>
/// Sets the %G_FILE_ATTRIBUTE_STANDARD_SIZE attribute in the file info
/// to the given size.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="size">
/// a #goffset containing the file&apos;s size.
/// </param>

	public static T SetSize<T>(this T info, int size) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_size(info, size);
		return info;
	}

/// <summary>
/// <para>
/// Sets the sort order attribute in the file info structure. See
/// %G_FILE_ATTRIBUTE_STANDARD_SORT_ORDER.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="sort_order">
/// a sort order integer.
/// </param>

	public static T SetSortOrder<T>(this T info, int sort_order) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_sort_order(info, sort_order);
		return info;
	}

/// <summary>
/// <para>
/// Sets the symbolic icon for a given #GFileInfo.
/// See %G_FILE_ATTRIBUTE_STANDARD_SYMBOLIC_ICON.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="icon">
/// a #GIcon.
/// </param>

	public static T SetSymbolicIcon<T>(this T info, MentorLake.Gio.GIconHandle icon) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_symbolic_icon(info, icon);
		return info;
	}

/// <summary>
/// <para>
/// Sets the %G_FILE_ATTRIBUTE_STANDARD_SYMLINK_TARGET attribute in the file info
/// to the given symlink target.
/// </para>
/// </summary>

/// <param name="info">
/// a #GFileInfo.
/// </param>
/// <param name="symlink_target">
/// a static string containing a path to a symlink target.
/// </param>

	public static T SetSymlinkTarget<T>(this T info, string symlink_target) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_set_symlink_target(info, symlink_target);
		return info;
	}

/// <summary>
/// <para>
/// Unsets a mask set by g_file_info_set_attribute_mask(), if one
/// is set.
/// </para>
/// </summary>

/// <param name="info">
/// #GFileInfo.
/// </param>

	public static T UnsetAttributeMask<T>(this T info) where T : GFileInfoHandle
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GFileInfoHandle)");
		GFileInfoHandleExterns.g_file_info_unset_attribute_mask(info);
		return info;
	}

}

internal class GFileInfoHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_info_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_clear_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_copy_into([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle src_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle dest_info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_info_dup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle other);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_file_info_get_access_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_attribute_as_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_get_attribute_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_attribute_byte_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_get_attribute_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, out MentorLake.Gio.GFileAttributeType type, out IntPtr value_pp, out MentorLake.Gio.GFileAttributeStatus status);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_attribute_file_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_file_info_get_attribute_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern long g_file_info_get_attribute_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_file_info_get_attribute_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileAttributeStatus g_file_info_get_attribute_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_attribute_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_file_info_get_attribute_stringv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileAttributeType g_file_info_get_attribute_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_file_info_get_attribute_uint32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern ulong g_file_info_get_attribute_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_file_info_get_creation_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_file_info_get_deletion_date([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_edit_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_etag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileType g_file_info_get_file_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_file_info_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_get_is_backup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_get_is_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_get_is_symlink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle g_file_info_get_modification_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_get_modification_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, out MentorLake.GLib.GTimeVal result);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_file_info_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_file_info_get_sort_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_file_info_get_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_info_get_symlink_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_has_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_has_namespace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string name_space);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_file_info_list_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string name_space);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_remove_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_access_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle atime);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, MentorLake.Gio.GFileAttributeType type, IntPtr value_p);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, bool attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_byte_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, string attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_file_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, string attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, int attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, long attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_mask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))] MentorLake.Gio.GFileAttributeMatcherHandle mask);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_info_set_attribute_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, MentorLake.Gio.GFileAttributeStatus status);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, string attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_stringv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, string[] attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_uint32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, uint attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_attribute_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string attribute, ulong attr_value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string content_type);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_creation_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle creation_time);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string display_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_edit_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string edit_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_file_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, MentorLake.Gio.GFileType type);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_is_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, bool is_hidden);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_is_symlink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, bool is_symlink);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_modification_date_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle mtime);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_modification_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle mtime);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, int size);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_sort_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, int sort_order);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_symbolic_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_set_symlink_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info, string symlink_target);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_info_unset_attribute_mask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))] MentorLake.Gio.GFileInfoHandle info);

}

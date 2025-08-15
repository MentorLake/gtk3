namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This is an opaque structure type.  You may not access it directly.
/// </para>
/// </summary>

public class GSettingsSchemaSourceHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Attempts to create a new schema source corresponding to the contents
/// of the given directory.
/// </para>
/// <para>
/// This function is not required for normal uses of #GSettings but it
/// may be useful to authors of plugin management systems.
/// </para>
/// <para>
/// The directory should contain a file called `gschemas.compiled` as
/// produced by the [glib-compile-schemas][glib-compile-schemas] tool.
/// </para>
/// <para>
/// If @trusted is %TRUE then `gschemas.compiled` is trusted not to be
/// corrupted. This assumption has a performance advantage, but can result
/// in crashes or inconsistent behaviour in the case of a corrupted file.
/// Generally, you should set @trusted to %TRUE for files installed by the
/// system and to %FALSE for files in the home directory.
/// </para>
/// <para>
/// In either case, an empty file or some types of corruption in the file will
/// result in %G_FILE_ERROR_INVAL being returned.
/// </para>
/// <para>
/// If @parent is non-%NULL then there are two effects.
/// </para>
/// <para>
/// First, if g_settings_schema_source_lookup() is called with the
/// @recursive flag set to %TRUE and the schema can not be found in the
/// source, the lookup will recurse to the parent.
/// </para>
/// <para>
/// Second, any references to other schemas specified within this
/// source (ie: `child` or `extends`) references may be resolved
/// from the @parent.
/// </para>
/// <para>
/// For this second reason, except in very unusual situations, the
/// @parent should probably be given as the default schema source, as
/// returned by g_settings_schema_source_get_default().
/// </para>
/// </summary>

/// <param name="directory">
/// the filename of a directory
/// </param>
/// <param name="parent">
/// a #GSettingsSchemaSource, or %NULL
/// </param>
/// <param name="trusted">
/// %TRUE, if the directory is trusted
/// </param>

	public static MentorLake.Gio.GSettingsSchemaSourceHandle NewFromDirectory(string directory, MentorLake.Gio.GSettingsSchemaSourceHandle parent, bool trusted)
	{
		var externCallResult = GSettingsSchemaSourceExterns.g_settings_schema_source_new_from_directory(directory, parent, trusted, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}


public static class GSettingsSchemaSourceExtensions
{
/// <summary>
/// <para>
/// Lists the schemas in a given source.
/// </para>
/// <para>
/// If @recursive is %TRUE then include parent sources.  If %FALSE then
/// only include the schemas from one source (ie: one directory).  You
/// probably want %TRUE.
/// </para>
/// <para>
/// Non-relocatable schemas are those for which you can call
/// g_settings_new().  Relocatable schemas are those for which you must
/// use g_settings_new_with_path().
/// </para>
/// <para>
/// Do not call this function from normal programs.  This is designed for
/// use by database editors, commandline tools, etc.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSettingsSchemaSource
/// </param>
/// <param name="recursive">
/// if we should recurse
/// </param>
/// <param name="non_relocatable">
/// the
///   list of non-relocatable schemas, in no defined order
/// </param>
/// <param name="relocatable">
/// the list
///   of relocatable schemas, in no defined order
/// </param>

	public static void ListSchemas(this MentorLake.Gio.GSettingsSchemaSourceHandle source, bool recursive, out string[] non_relocatable, out string[] relocatable)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaSource)");
		GSettingsSchemaSourceExterns.g_settings_schema_source_list_schemas(source, recursive, out non_relocatable, out relocatable);
	}

/// <summary>
/// <para>
/// Looks up a schema with the identifier @schema_id in @source.
/// </para>
/// <para>
/// This function is not required for normal uses of #GSettings but it
/// may be useful to authors of plugin management systems or to those who
/// want to introspect the content of schemas.
/// </para>
/// <para>
/// If the schema isn&apos;t found directly in @source and @recursive is %TRUE
/// then the parent sources will also be checked.
/// </para>
/// <para>
/// If the schema isn&apos;t found, %NULL is returned.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSettingsSchemaSource
/// </param>
/// <param name="schema_id">
/// a schema ID
/// </param>
/// <param name="recursive">
/// %TRUE if the lookup should be recursive
/// </param>
/// <return>
/// a new #GSettingsSchema
/// </return>

	public static MentorLake.Gio.GSettingsSchemaHandle Lookup(this MentorLake.Gio.GSettingsSchemaSourceHandle source, string schema_id, bool recursive)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaSource)");
		return GSettingsSchemaSourceExterns.g_settings_schema_source_lookup(source, schema_id, recursive);
	}

/// <summary>
/// <para>
/// Increase the reference count of @source, returning a new reference.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSettingsSchemaSource
/// </param>
/// <return>
/// a new reference to @source
/// </return>

	public static MentorLake.Gio.GSettingsSchemaSourceHandle Ref(this MentorLake.Gio.GSettingsSchemaSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaSource)");
		return GSettingsSchemaSourceExterns.g_settings_schema_source_ref(source);
	}

/// <summary>
/// <para>
/// Decrease the reference count of @source, possibly freeing it.
/// </para>
/// </summary>

/// <param name="source">
/// a #GSettingsSchemaSource
/// </param>

	public static void Unref(this MentorLake.Gio.GSettingsSchemaSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaSource)");
		GSettingsSchemaSourceExterns.g_settings_schema_source_unref(source);
	}


	public static GSettingsSchemaSource Dereference(this GSettingsSchemaSourceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSettingsSchemaSource>(x.DangerousGetHandle());
}
internal class GSettingsSchemaSourceExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaSourceHandle>))]
	internal static extern MentorLake.Gio.GSettingsSchemaSourceHandle g_settings_schema_source_new_from_directory(string directory, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaSourceHandle>))] MentorLake.Gio.GSettingsSchemaSourceHandle parent, bool trusted, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_schema_source_list_schemas([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaSourceHandle>))] MentorLake.Gio.GSettingsSchemaSourceHandle source, bool recursive, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out string[] non_relocatable, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out string[] relocatable);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))]
	internal static extern MentorLake.Gio.GSettingsSchemaHandle g_settings_schema_source_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaSourceHandle>))] MentorLake.Gio.GSettingsSchemaSourceHandle source, string schema_id, bool recursive);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaSourceHandle>))]
	internal static extern MentorLake.Gio.GSettingsSchemaSourceHandle g_settings_schema_source_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaSourceHandle>))] MentorLake.Gio.GSettingsSchemaSourceHandle source);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_schema_source_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaSourceHandle>))] MentorLake.Gio.GSettingsSchemaSourceHandle source);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaSourceHandle>))]
	internal static extern MentorLake.Gio.GSettingsSchemaSourceHandle g_settings_schema_source_get_default();

}

/// <summary>
/// <para>
/// This is an opaque structure type.  You may not access it directly.
/// </para>
/// </summary>

public struct GSettingsSchemaSource
{
/// <summary>
/// <para>
/// Gets the default system schema source.
/// </para>
/// <para>
/// This function is not required for normal uses of #GSettings but it
/// may be useful to authors of plugin management systems or to those who
/// want to introspect the content of schemas.
/// </para>
/// <para>
/// If no schemas are installed, %NULL will be returned.
/// </para>
/// <para>
/// The returned source may actually consist of multiple schema sources
/// from different directories, depending on which directories were given
/// in `XDG_DATA_DIRS` and `GSETTINGS_SCHEMA_DIR`. For this reason, all
/// lookups performed against the default source should probably be done
/// recursively.
/// </para>
/// </summary>

/// <return>
/// the default schema source
/// </return>

	public static MentorLake.Gio.GSettingsSchemaSourceHandle GetDefault()
	{
		return GSettingsSchemaSourceExterns.g_settings_schema_source_get_default();
	}

}

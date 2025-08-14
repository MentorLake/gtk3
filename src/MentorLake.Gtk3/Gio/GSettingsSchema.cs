namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The [struct@Gio.SettingsSchemaSource] and `GSettingsSchema` APIs provide a
/// mechanism for advanced control over the loading of schemas and a
/// mechanism for introspecting their content.
/// </para>
/// <para>
/// Plugin loading systems that wish to provide plugins a way to access
/// settings face the problem of how to make the schemas for these
/// settings visible to GSettings.  Typically, a plugin will want to ship
/// the schema along with itself and it won't be installed into the
/// standard system directories for schemas.
/// </para>
/// <para>
/// [struct@Gio.SettingsSchemaSource] provides a mechanism for dealing with this
/// by allowing the creation of a new ‘schema source’ from which schemas can
/// be acquired.  This schema source can then become part of the metadata
/// associated with the plugin and queried whenever the plugin requires
/// access to some settings.
/// </para>
/// <para>
/// Consider the following example:
/// </para>
/// <para>
/// ```c
/// typedef struct
/// {
///    …
///    GSettingsSchemaSource *schema_source;
///    …
/// } Plugin;
/// </para>
/// <para>
/// Plugin *
/// initialise_plugin (const gchar *dir)
/// {
///   Plugin *plugin;
/// </para>
/// <para>
///   …
/// </para>
/// <para>
///   plugin->schema_source =
///     g_settings_schema_source_new_from_directory (dir,
///       g_settings_schema_source_get_default (), FALSE, NULL);
/// </para>
/// <para>
///   …
/// </para>
/// <para>
///   return plugin;
/// }
/// </para>
/// <para>
/// …
/// </para>
/// <para>
/// GSettings *
/// plugin_get_settings (Plugin      *plugin,
///                      const gchar *schema_id)
/// {
///   GSettingsSchema *schema;
/// </para>
/// <para>
///   if (schema_id == NULL)
///     schema_id = plugin->identifier;
/// </para>
/// <para>
///   schema = g_settings_schema_source_lookup (plugin->schema_source,
///                                             schema_id, FALSE);
/// </para>
/// <para>
///   if (schema == NULL)
///     {
///       … disable the plugin or abort, etc …
///     }
/// </para>
/// <para>
///   return g_settings_new_full (schema, NULL, NULL);
/// }
/// ```
/// </para>
/// <para>
/// The code above shows how hooks should be added to the code that
/// initialises (or enables) the plugin to create the schema source and
/// how an API can be added to the plugin system to provide a convenient
/// way for the plugin to access its settings, using the schemas that it
/// ships.
/// </para>
/// <para>
/// From the standpoint of the plugin, it would need to ensure that it
/// ships a gschemas.compiled file as part of itself, and then simply do
/// the following:
/// </para>
/// <para>
/// ```c
/// {
///   GSettings *settings;
///   gint some_value;
/// </para>
/// <para>
///   settings = plugin_get_settings (self, NULL);
///   some_value = g_settings_get_int (settings, "some-value");
///   …
/// }
/// ```
/// </para>
/// <para>
/// It's also possible that the plugin system expects the schema source
/// files (ie: `.gschema.xml` files) instead of a `gschemas.compiled` file.
/// In that case, the plugin loading system must compile the schemas for
/// itself before attempting to create the settings source.
/// </para>
/// </summary>

public class GSettingsSchemaHandle : BaseSafeHandle
{
}


public static class GSettingsSchemaExtensions
{
/// <summary>
/// <para>
/// Get the ID of @schema.
/// </para>
/// </summary>

/// <param name="schema">
/// a #GSettingsSchema
/// </param>
/// <return>
/// the ID
/// </return>

	public static string GetId(this MentorLake.Gio.GSettingsSchemaHandle schema)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_get_id(schema);
	}

/// <summary>
/// <para>
/// Gets the key named @name from @schema.
/// </para>
/// <para>
/// It is a programmer error to request a key that does not exist.  See
/// g_settings_schema_list_keys().
/// </para>
/// </summary>

/// <param name="schema">
/// a #GSettingsSchema
/// </param>
/// <param name="name">
/// the name of a key
/// </param>
/// <return>
/// the #GSettingsSchemaKey for @name
/// </return>

	public static MentorLake.Gio.GSettingsSchemaKeyHandle GetKey(this MentorLake.Gio.GSettingsSchemaHandle schema, string name)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_get_key(schema, name);
	}

/// <summary>
/// <para>
/// Gets the path associated with @schema, or %NULL.
/// </para>
/// <para>
/// Schemas may be single-instance or relocatable.  Single-instance
/// schemas correspond to exactly one set of keys in the backend
/// database: those located at the path returned by this function.
/// </para>
/// <para>
/// Relocatable schemas can be referenced by other schemas and can
/// therefore describe multiple sets of keys at different locations.  For
/// relocatable schemas, this function will return %NULL.
/// </para>
/// </summary>

/// <param name="schema">
/// a #GSettingsSchema
/// </param>
/// <return>
/// the path of the schema, or %NULL
/// </return>

	public static string GetPath(this MentorLake.Gio.GSettingsSchemaHandle schema)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_get_path(schema);
	}

/// <summary>
/// <para>
/// Checks if @schema has a key named @name.
/// </para>
/// </summary>

/// <param name="schema">
/// a #GSettingsSchema
/// </param>
/// <param name="name">
/// the name of a key
/// </param>
/// <return>
/// %TRUE if such a key exists
/// </return>

	public static bool HasKey(this MentorLake.Gio.GSettingsSchemaHandle schema, string name)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_has_key(schema, name);
	}

/// <summary>
/// <para>
/// Gets the list of children in @schema.
/// </para>
/// <para>
/// You should free the return value with g_strfreev() when you are done
/// with it.
/// </para>
/// </summary>

/// <param name="schema">
/// a #GSettingsSchema
/// </param>
/// <return>
/// a list of
///    the children on @settings, in no defined order
/// </return>

	public static string[] ListChildren(this MentorLake.Gio.GSettingsSchemaHandle schema)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_list_children(schema);
	}

/// <summary>
/// <para>
/// Introspects the list of keys on @schema.
/// </para>
/// <para>
/// You should probably not be calling this function from "normal" code
/// (since you should already know what keys are in your schema).  This
/// function is intended for introspection reasons.
/// </para>
/// </summary>

/// <param name="schema">
/// a #GSettingsSchema
/// </param>
/// <return>
/// a list
///   of the keys on @schema, in no defined order
/// </return>

	public static string[] ListKeys(this MentorLake.Gio.GSettingsSchemaHandle schema)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_list_keys(schema);
	}

/// <summary>
/// <para>
/// Increase the reference count of @schema, returning a new reference.
/// </para>
/// </summary>

/// <param name="schema">
/// a #GSettingsSchema
/// </param>
/// <return>
/// a new reference to @schema
/// </return>

	public static MentorLake.Gio.GSettingsSchemaHandle Ref(this MentorLake.Gio.GSettingsSchemaHandle schema)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_ref(schema);
	}

/// <summary>
/// <para>
/// Decrease the reference count of @schema, possibly freeing it.
/// </para>
/// </summary>

/// <param name="schema">
/// a #GSettingsSchema
/// </param>

	public static void Unref(this MentorLake.Gio.GSettingsSchemaHandle schema)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		GSettingsSchemaExterns.g_settings_schema_unref(schema);
	}


	public static GSettingsSchema Dereference(this GSettingsSchemaHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSettingsSchema>(x.DangerousGetHandle());
}
internal class GSettingsSchemaExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_settings_schema_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))] MentorLake.Gio.GSettingsSchemaHandle schema);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaKeyHandle>))]
	internal static extern MentorLake.Gio.GSettingsSchemaKeyHandle g_settings_schema_get_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))] MentorLake.Gio.GSettingsSchemaHandle schema, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_settings_schema_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))] MentorLake.Gio.GSettingsSchemaHandle schema);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_schema_has_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))] MentorLake.Gio.GSettingsSchemaHandle schema, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_settings_schema_list_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))] MentorLake.Gio.GSettingsSchemaHandle schema);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_settings_schema_list_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))] MentorLake.Gio.GSettingsSchemaHandle schema);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))]
	internal static extern MentorLake.Gio.GSettingsSchemaHandle g_settings_schema_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))] MentorLake.Gio.GSettingsSchemaHandle schema);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_schema_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))] MentorLake.Gio.GSettingsSchemaHandle schema);

}

/// <summary>
/// <para>
/// The [struct@Gio.SettingsSchemaSource] and `GSettingsSchema` APIs provide a
/// mechanism for advanced control over the loading of schemas and a
/// mechanism for introspecting their content.
/// </para>
/// <para>
/// Plugin loading systems that wish to provide plugins a way to access
/// settings face the problem of how to make the schemas for these
/// settings visible to GSettings.  Typically, a plugin will want to ship
/// the schema along with itself and it won't be installed into the
/// standard system directories for schemas.
/// </para>
/// <para>
/// [struct@Gio.SettingsSchemaSource] provides a mechanism for dealing with this
/// by allowing the creation of a new ‘schema source’ from which schemas can
/// be acquired.  This schema source can then become part of the metadata
/// associated with the plugin and queried whenever the plugin requires
/// access to some settings.
/// </para>
/// <para>
/// Consider the following example:
/// </para>
/// <para>
/// ```c
/// typedef struct
/// {
///    …
///    GSettingsSchemaSource *schema_source;
///    …
/// } Plugin;
/// </para>
/// <para>
/// Plugin *
/// initialise_plugin (const gchar *dir)
/// {
///   Plugin *plugin;
/// </para>
/// <para>
///   …
/// </para>
/// <para>
///   plugin->schema_source =
///     g_settings_schema_source_new_from_directory (dir,
///       g_settings_schema_source_get_default (), FALSE, NULL);
/// </para>
/// <para>
///   …
/// </para>
/// <para>
///   return plugin;
/// }
/// </para>
/// <para>
/// …
/// </para>
/// <para>
/// GSettings *
/// plugin_get_settings (Plugin      *plugin,
///                      const gchar *schema_id)
/// {
///   GSettingsSchema *schema;
/// </para>
/// <para>
///   if (schema_id == NULL)
///     schema_id = plugin->identifier;
/// </para>
/// <para>
///   schema = g_settings_schema_source_lookup (plugin->schema_source,
///                                             schema_id, FALSE);
/// </para>
/// <para>
///   if (schema == NULL)
///     {
///       … disable the plugin or abort, etc …
///     }
/// </para>
/// <para>
///   return g_settings_new_full (schema, NULL, NULL);
/// }
/// ```
/// </para>
/// <para>
/// The code above shows how hooks should be added to the code that
/// initialises (or enables) the plugin to create the schema source and
/// how an API can be added to the plugin system to provide a convenient
/// way for the plugin to access its settings, using the schemas that it
/// ships.
/// </para>
/// <para>
/// From the standpoint of the plugin, it would need to ensure that it
/// ships a gschemas.compiled file as part of itself, and then simply do
/// the following:
/// </para>
/// <para>
/// ```c
/// {
///   GSettings *settings;
///   gint some_value;
/// </para>
/// <para>
///   settings = plugin_get_settings (self, NULL);
///   some_value = g_settings_get_int (settings, "some-value");
///   …
/// }
/// ```
/// </para>
/// <para>
/// It's also possible that the plugin system expects the schema source
/// files (ie: `.gschema.xml` files) instead of a `gschemas.compiled` file.
/// In that case, the plugin loading system must compile the schemas for
/// itself before attempting to create the settings source.
/// </para>
/// </summary>

public struct GSettingsSchema
{
}

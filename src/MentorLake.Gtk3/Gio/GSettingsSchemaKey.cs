namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GSettingsSchemaKey is an opaque data structure and can only be accessed
/// using the following functions.
/// </para>
/// </summary>

public class GSettingsSchemaKeyHandle : BaseSafeHandle
{
}


public static class GSettingsSchemaKeyExtensions
{
/// <summary>
/// <para>
/// Gets the default value for @key.
/// </para>
/// <para>
/// Note that this is the default value according to the schema.  System
/// administrator defaults and lockdown are not visible via this API.
/// </para>
/// </summary>

/// <param name="key">
/// a #GSettingsSchemaKey
/// </param>
/// <return>
/// the default value for the key
/// </return>

	public static MentorLake.GLib.GVariantHandle GetDefaultValue(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_default_value(key);
	}

/// <summary>
/// <para>
/// Gets the description for @key.
/// </para>
/// <para>
/// If no description has been provided in the schema for @key, returns
/// %NULL.
/// </para>
/// <para>
/// The description can be one sentence to several paragraphs in length.
/// Paragraphs are delimited with a double newline.  Descriptions can be
/// translated and the value returned from this function is is the
/// current locale.
/// </para>
/// <para>
/// This function is slow.  The summary and description information for
/// the schemas is not stored in the compiled schema database so this
/// function has to parse all of the source XML files in the schema
/// directory.
/// </para>
/// </summary>

/// <param name="key">
/// a #GSettingsSchemaKey
/// </param>
/// <return>
/// the description for @key, or %NULL
/// </return>

	public static string GetDescription(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_description(key);
	}

/// <summary>
/// <para>
/// Gets the name of @key.
/// </para>
/// </summary>

/// <param name="key">
/// a #GSettingsSchemaKey
/// </param>
/// <return>
/// the name of @key.
/// </return>

	public static string GetName(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_name(key);
	}

/// <summary>
/// <para>
/// Queries the range of a key.
/// </para>
/// <para>
/// This function will return a #GVariant that fully describes the range
/// of values that are valid for @key.
/// </para>
/// <para>
/// The type of #GVariant returned is `(sv)`. The string describes
/// the type of range restriction in effect. The type and meaning of
/// the value contained in the variant depends on the string.
/// </para>
/// <para>
/// If the string is `'type'` then the variant contains an empty array.
/// The element type of that empty array is the expected type of value
/// and all values of that type are valid.
/// </para>
/// <para>
/// If the string is `'enum'` then the variant contains an array
/// enumerating the possible values. Each item in the array is
/// a possible valid value and no other values are valid.
/// </para>
/// <para>
/// If the string is `'flags'` then the variant contains an array. Each
/// item in the array is a value that may appear zero or one times in an
/// array to be used as the value for this key. For example, if the
/// variant contained the array `['x', 'y']` then the valid values for
/// the key would be `[]`, `['x']`, `['y']`, `['x', 'y']` and
/// `['y', 'x']`.
/// </para>
/// <para>
/// Finally, if the string is `'range'` then the variant contains a pair
/// of like-typed values -- the minimum and maximum permissible values
/// for this key.
/// </para>
/// <para>
/// This information should not be used by normal programs.  It is
/// considered to be a hint for introspection purposes.  Normal programs
/// should already know what is permitted by their own schema.  The
/// format may change in any way in the future -- but particularly, new
/// forms may be added to the possibilities described above.
/// </para>
/// <para>
/// You should free the returned value with g_variant_unref() when it is
/// no longer needed.
/// </para>
/// </summary>

/// <param name="key">
/// a #GSettingsSchemaKey
/// </param>
/// <return>
/// a #GVariant describing the range
/// </return>

	public static MentorLake.GLib.GVariantHandle GetRange(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_range(key);
	}

/// <summary>
/// <para>
/// Gets the summary for @key.
/// </para>
/// <para>
/// If no summary has been provided in the schema for @key, returns
/// %NULL.
/// </para>
/// <para>
/// The summary is a short description of the purpose of the key; usually
/// one short sentence.  Summaries can be translated and the value
/// returned from this function is is the current locale.
/// </para>
/// <para>
/// This function is slow.  The summary and description information for
/// the schemas is not stored in the compiled schema database so this
/// function has to parse all of the source XML files in the schema
/// directory.
/// </para>
/// </summary>

/// <param name="key">
/// a #GSettingsSchemaKey
/// </param>
/// <return>
/// the summary for @key, or %NULL
/// </return>

	public static string GetSummary(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_summary(key);
	}

/// <summary>
/// <para>
/// Gets the #GVariantType of @key.
/// </para>
/// </summary>

/// <param name="key">
/// a #GSettingsSchemaKey
/// </param>
/// <return>
/// the type of @key
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle GetValueType(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_value_type(key);
	}

/// <summary>
/// <para>
/// Checks if the given @value is within the
/// permitted range for @key.
/// </para>
/// <para>
/// It is a programmer error if @value is not of the correct type — you
/// must check for this first.
/// </para>
/// </summary>

/// <param name="key">
/// a #GSettingsSchemaKey
/// </param>
/// <param name="value">
/// the value to check
/// </param>
/// <return>
/// %TRUE if @value is valid for @key
/// </return>

	public static bool RangeCheck(this MentorLake.Gio.GSettingsSchemaKeyHandle key, MentorLake.GLib.GVariantHandle value)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_range_check(key, value);
	}

/// <summary>
/// <para>
/// Increase the reference count of @key, returning a new reference.
/// </para>
/// </summary>

/// <param name="key">
/// a #GSettingsSchemaKey
/// </param>
/// <return>
/// a new reference to @key
/// </return>

	public static MentorLake.Gio.GSettingsSchemaKeyHandle Ref(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_ref(key);
	}

/// <summary>
/// <para>
/// Decrease the reference count of @key, possibly freeing it.
/// </para>
/// </summary>

/// <param name="key">
/// a #GSettingsSchemaKey
/// </param>

	public static void Unref(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		GSettingsSchemaKeyExterns.g_settings_schema_key_unref(key);
	}


	public static GSettingsSchemaKey Dereference(this GSettingsSchemaKeyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSettingsSchemaKey>(x.DangerousGetHandle());
}
internal class GSettingsSchemaKeyExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_settings_schema_key_get_default_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaKeyHandle>))] MentorLake.Gio.GSettingsSchemaKeyHandle key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_settings_schema_key_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaKeyHandle>))] MentorLake.Gio.GSettingsSchemaKeyHandle key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_settings_schema_key_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaKeyHandle>))] MentorLake.Gio.GSettingsSchemaKeyHandle key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_settings_schema_key_get_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaKeyHandle>))] MentorLake.Gio.GSettingsSchemaKeyHandle key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_settings_schema_key_get_summary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaKeyHandle>))] MentorLake.Gio.GSettingsSchemaKeyHandle key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_settings_schema_key_get_value_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaKeyHandle>))] MentorLake.Gio.GSettingsSchemaKeyHandle key);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_schema_key_range_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaKeyHandle>))] MentorLake.Gio.GSettingsSchemaKeyHandle key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaKeyHandle>))]
	internal static extern MentorLake.Gio.GSettingsSchemaKeyHandle g_settings_schema_key_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaKeyHandle>))] MentorLake.Gio.GSettingsSchemaKeyHandle key);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_schema_key_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaKeyHandle>))] MentorLake.Gio.GSettingsSchemaKeyHandle key);

}

/// <summary>
/// <para>
/// #GSettingsSchemaKey is an opaque data structure and can only be accessed
/// using the following functions.
/// </para>
/// </summary>

public struct GSettingsSchemaKey
{
}

namespace MentorLake.Gio;

public class GSettingsSchemaKeyHandle : BaseSafeHandle
{
}


public static class GSettingsSchemaKeyExtensions
{
	public static MentorLake.GLib.GVariantHandle GetDefaultValue(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_default_value(key);
	}

	public static string GetDescription(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_description(key);
	}

	public static string GetName(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_name(key);
	}

	public static MentorLake.GLib.GVariantHandle GetRange(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_range(key);
	}

	public static string GetSummary(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_summary(key);
	}

	public static MentorLake.GLib.GVariantTypeHandle GetValueType(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_get_value_type(key);
	}

	public static bool RangeCheck(this MentorLake.Gio.GSettingsSchemaKeyHandle key, MentorLake.GLib.GVariantHandle value)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_range_check(key, value);
	}

	public static MentorLake.Gio.GSettingsSchemaKeyHandle Ref(this MentorLake.Gio.GSettingsSchemaKeyHandle key)
	{
		if (key.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaKey)");
		return GSettingsSchemaKeyExterns.g_settings_schema_key_ref(key);
	}

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

public struct GSettingsSchemaKey
{
}

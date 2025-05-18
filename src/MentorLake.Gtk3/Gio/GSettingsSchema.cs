namespace MentorLake.Gio;

public class GSettingsSchemaHandle : BaseSafeHandle
{
}


public static class GSettingsSchemaExtensions
{
	public static string GetId(this MentorLake.Gio.GSettingsSchemaHandle schema)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_get_id(schema);
	}

	public static MentorLake.Gio.GSettingsSchemaKeyHandle GetKey(this MentorLake.Gio.GSettingsSchemaHandle schema, string name)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_get_key(schema, name);
	}

	public static string GetPath(this MentorLake.Gio.GSettingsSchemaHandle schema)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_get_path(schema);
	}

	public static bool HasKey(this MentorLake.Gio.GSettingsSchemaHandle schema, string name)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_has_key(schema, name);
	}

	public static string[] ListChildren(this MentorLake.Gio.GSettingsSchemaHandle schema)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_list_children(schema);
	}

	public static string[] ListKeys(this MentorLake.Gio.GSettingsSchemaHandle schema)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_list_keys(schema);
	}

	public static MentorLake.Gio.GSettingsSchemaHandle Ref(this MentorLake.Gio.GSettingsSchemaHandle schema)
	{
		if (schema.IsInvalid) throw new Exception("Invalid handle (GSettingsSchema)");
		return GSettingsSchemaExterns.g_settings_schema_ref(schema);
	}

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

public struct GSettingsSchema
{
}

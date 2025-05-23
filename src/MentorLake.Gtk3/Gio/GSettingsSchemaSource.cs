namespace MentorLake.Gio;

public class GSettingsSchemaSourceHandle : BaseSafeHandle
{
	public static MentorLake.Gio.GSettingsSchemaSourceHandle NewFromDirectory(string directory, MentorLake.Gio.GSettingsSchemaSourceHandle parent, bool trusted)
	{
		var externCallResult = GSettingsSchemaSourceExterns.g_settings_schema_source_new_from_directory(directory, parent, trusted, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}


public static class GSettingsSchemaSourceExtensions
{
	public static void ListSchemas(this MentorLake.Gio.GSettingsSchemaSourceHandle source, bool recursive, out string[] non_relocatable, out string[] relocatable)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaSource)");
		GSettingsSchemaSourceExterns.g_settings_schema_source_list_schemas(source, recursive, out non_relocatable, out relocatable);
	}

	public static MentorLake.Gio.GSettingsSchemaHandle Lookup(this MentorLake.Gio.GSettingsSchemaSourceHandle source, string schema_id, bool recursive)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaSource)");
		return GSettingsSchemaSourceExterns.g_settings_schema_source_lookup(source, schema_id, recursive);
	}

	public static MentorLake.Gio.GSettingsSchemaSourceHandle Ref(this MentorLake.Gio.GSettingsSchemaSourceHandle source)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GSettingsSchemaSource)");
		return GSettingsSchemaSourceExterns.g_settings_schema_source_ref(source);
	}

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
	internal static extern void g_settings_schema_source_list_schemas([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaSourceHandle>))] MentorLake.Gio.GSettingsSchemaSourceHandle source, bool recursive, out string[] non_relocatable, out string[] relocatable);

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

public struct GSettingsSchemaSource
{
	public static MentorLake.Gio.GSettingsSchemaSourceHandle GetDefault()
	{
		return GSettingsSchemaSourceExterns.g_settings_schema_source_get_default();
	}

}

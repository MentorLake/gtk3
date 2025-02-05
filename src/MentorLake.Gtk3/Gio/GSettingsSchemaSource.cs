namespace MentorLake.Gtk3.Gio;

public class GSettingsSchemaSourceHandle : BaseSafeHandle
{
	public static GSettingsSchemaSourceHandle NewFromDirectory(string directory, GSettingsSchemaSourceHandle parent, bool trusted, out GErrorHandle error)
	{
		return GSettingsSchemaSourceExterns.g_settings_schema_source_new_from_directory(directory, parent, trusted, out error);
	}

}


public static class GSettingsSchemaSourceHandleExtensions
{
	public static T ListSchemas<T>(this T source, bool recursive, out string[] non_relocatable, out string[] relocatable) where T : GSettingsSchemaSourceHandle
	{
		GSettingsSchemaSourceExterns.g_settings_schema_source_list_schemas(source, recursive, out non_relocatable, out relocatable);
		return source;
	}

	public static GSettingsSchemaHandle Lookup(this GSettingsSchemaSourceHandle source, string schema_id, bool recursive)
	{
		return GSettingsSchemaSourceExterns.g_settings_schema_source_lookup(source, schema_id, recursive);
	}

	public static GSettingsSchemaSourceHandle Ref(this GSettingsSchemaSourceHandle source)
	{
		return GSettingsSchemaSourceExterns.g_settings_schema_source_ref(source);
	}

	public static T Unref<T>(this T source) where T : GSettingsSchemaSourceHandle
	{
		GSettingsSchemaSourceExterns.g_settings_schema_source_unref(source);
		return source;
	}

	public static GSettingsSchemaSourceHandle GetDefault()
	{
		return GSettingsSchemaSourceExterns.g_settings_schema_source_get_default();
	}

}
internal class GSettingsSchemaSourceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSettingsSchemaSourceHandle g_settings_schema_source_new_from_directory(string directory, GSettingsSchemaSourceHandle parent, bool trusted, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_schema_source_list_schemas(GSettingsSchemaSourceHandle source, bool recursive, out string[] non_relocatable, out string[] relocatable);

	[DllImport(Libraries.Gio)]
	internal static extern GSettingsSchemaHandle g_settings_schema_source_lookup(GSettingsSchemaSourceHandle source, string schema_id, bool recursive);

	[DllImport(Libraries.Gio)]
	internal static extern GSettingsSchemaSourceHandle g_settings_schema_source_ref(GSettingsSchemaSourceHandle source);

	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_schema_source_unref(GSettingsSchemaSourceHandle source);

	[DllImport(Libraries.Gio)]
	internal static extern GSettingsSchemaSourceHandle g_settings_schema_source_get_default();

}

public struct GSettingsSchemaSource
{
}

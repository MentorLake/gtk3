namespace MentorLake.Gtk3.Gtk3;

public class GtkBuilderHandle : GObjectHandle
{
	public static GtkBuilderHandle New()
	{
		return GtkBuilderExterns.gtk_builder_new();
	}

	public static GtkBuilderHandle NewFromFile(string filename)
	{
		return GtkBuilderExterns.gtk_builder_new_from_file(filename);
	}

	public static GtkBuilderHandle NewFromResource(string resource_path)
	{
		return GtkBuilderExterns.gtk_builder_new_from_resource(resource_path);
	}

	public static GtkBuilderHandle NewFromString(string @string, UIntPtr length)
	{
		return GtkBuilderExterns.gtk_builder_new_from_string(@string, length);
	}

}

public static class GtkBuilderHandleExtensions
{
	public static GtkBuilderHandle AddCallbackSymbol(this GtkBuilderHandle builder, string callback_name, IntPtr callback_symbol)
	{
		GtkBuilderExterns.gtk_builder_add_callback_symbol(builder, callback_name, callback_symbol);
		return builder;
	}

	public static GtkBuilderHandle AddCallbackSymbols(this GtkBuilderHandle builder, string first_callback_name, IntPtr first_callback_symbol, IntPtr @__arglist)
	{
		GtkBuilderExterns.gtk_builder_add_callback_symbols(builder, first_callback_name, first_callback_symbol, @__arglist);
		return builder;
	}

	public static uint AddFromFile(this GtkBuilderHandle builder, string filename, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_from_file(builder, filename, out error);
	}

	public static uint AddFromResource(this GtkBuilderHandle builder, string resource_path, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_from_resource(builder, resource_path, out error);
	}

	public static uint AddFromString(this GtkBuilderHandle builder, string buffer, UIntPtr length, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_from_string(builder, buffer, length, out error);
	}

	public static uint AddObjectsFromFile(this GtkBuilderHandle builder, string filename, string[] object_ids, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_objects_from_file(builder, filename, object_ids, out error);
	}

	public static uint AddObjectsFromResource(this GtkBuilderHandle builder, string resource_path, string[] object_ids, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_objects_from_resource(builder, resource_path, object_ids, out error);
	}

	public static uint AddObjectsFromString(this GtkBuilderHandle builder, string buffer, UIntPtr length, string[] object_ids, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_add_objects_from_string(builder, buffer, length, object_ids, out error);
	}

	public static GtkBuilderHandle ConnectSignals(this GtkBuilderHandle builder, IntPtr user_data)
	{
		GtkBuilderExterns.gtk_builder_connect_signals(builder, user_data);
		return builder;
	}

	public static GtkBuilderHandle ConnectSignalsFull(this GtkBuilderHandle builder, GtkBuilderConnectFunc func, IntPtr user_data)
	{
		GtkBuilderExterns.gtk_builder_connect_signals_full(builder, func, user_data);
		return builder;
	}

	public static GtkBuilderHandle ExposeObject(this GtkBuilderHandle builder, string name, GObjectHandle @object)
	{
		GtkBuilderExterns.gtk_builder_expose_object(builder, name, @object);
		return builder;
	}

	public static uint ExtendWithTemplate(this GtkBuilderHandle builder, GtkWidgetHandle widget, GType template_type, string buffer, UIntPtr length, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_extend_with_template(builder, widget, template_type, buffer, length, out error);
	}

	public static GtkApplicationHandle GetApplication(this GtkBuilderHandle builder)
	{
		return GtkBuilderExterns.gtk_builder_get_application(builder);
	}

	public static GObjectHandle GetObject(this GtkBuilderHandle builder, string name)
	{
		return GtkBuilderExterns.gtk_builder_get_object(builder, name);
	}

	public static GSListHandle GetObjects(this GtkBuilderHandle builder)
	{
		return GtkBuilderExterns.gtk_builder_get_objects(builder);
	}

	public static string GetTranslationDomain(this GtkBuilderHandle builder)
	{
		return GtkBuilderExterns.gtk_builder_get_translation_domain(builder);
	}

	public static GType GetTypeFromName(this GtkBuilderHandle builder, string type_name)
	{
		return GtkBuilderExterns.gtk_builder_get_type_from_name(builder, type_name);
	}

	public static IntPtr LookupCallbackSymbol(this GtkBuilderHandle builder, string callback_name)
	{
		return GtkBuilderExterns.gtk_builder_lookup_callback_symbol(builder, callback_name);
	}

	public static GtkBuilderHandle SetApplication(this GtkBuilderHandle builder, GtkApplicationHandle application)
	{
		GtkBuilderExterns.gtk_builder_set_application(builder, application);
		return builder;
	}

	public static GtkBuilderHandle SetTranslationDomain(this GtkBuilderHandle builder, string domain)
	{
		GtkBuilderExterns.gtk_builder_set_translation_domain(builder, domain);
		return builder;
	}

	public static bool ValueFromString(this GtkBuilderHandle builder, GParamSpecHandle pspec, string @string, out GValue value, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_value_from_string(builder, pspec, @string, out value, out error);
	}

	public static bool ValueFromStringType(this GtkBuilderHandle builder, GType type, string @string, out GValue value, out GErrorHandle error)
	{
		return GtkBuilderExterns.gtk_builder_value_from_string_type(builder, type, @string, out value, out error);
	}

}

internal class GtkBuilderExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBuilderHandle gtk_builder_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBuilderHandle gtk_builder_new_from_file(string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBuilderHandle gtk_builder_new_from_resource(string resource_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBuilderHandle gtk_builder_new_from_string(string @string, UIntPtr length);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_builder_add_callback_symbol(GtkBuilderHandle builder, string callback_name, IntPtr callback_symbol);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_builder_add_callback_symbols(GtkBuilderHandle builder, string first_callback_name, IntPtr first_callback_symbol, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_builder_add_from_file(GtkBuilderHandle builder, string filename, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_builder_add_from_resource(GtkBuilderHandle builder, string resource_path, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_builder_add_from_string(GtkBuilderHandle builder, string buffer, UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_builder_add_objects_from_file(GtkBuilderHandle builder, string filename, string[] object_ids, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_builder_add_objects_from_resource(GtkBuilderHandle builder, string resource_path, string[] object_ids, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_builder_add_objects_from_string(GtkBuilderHandle builder, string buffer, UIntPtr length, string[] object_ids, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_builder_connect_signals(GtkBuilderHandle builder, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_builder_connect_signals_full(GtkBuilderHandle builder, GtkBuilderConnectFunc func, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_builder_expose_object(GtkBuilderHandle builder, string name, GObjectHandle @object);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_builder_extend_with_template(GtkBuilderHandle builder, GtkWidgetHandle widget, GType template_type, string buffer, UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkApplicationHandle gtk_builder_get_application(GtkBuilderHandle builder);

	[DllImport(Libraries.Gtk3)]
	internal static extern GObjectHandle gtk_builder_get_object(GtkBuilderHandle builder, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_builder_get_objects(GtkBuilderHandle builder);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_builder_get_translation_domain(GtkBuilderHandle builder);

	[DllImport(Libraries.Gtk3)]
	internal static extern GType gtk_builder_get_type_from_name(GtkBuilderHandle builder, string type_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_builder_lookup_callback_symbol(GtkBuilderHandle builder, string callback_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_builder_set_application(GtkBuilderHandle builder, GtkApplicationHandle application);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_builder_set_translation_domain(GtkBuilderHandle builder, string domain);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_builder_value_from_string(GtkBuilderHandle builder, GParamSpecHandle pspec, string @string, out GValue value, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_builder_value_from_string_type(GtkBuilderHandle builder, GType type, string @string, out GValue value, out GErrorHandle error);

}

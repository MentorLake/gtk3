namespace MentorLake.Gtk;

public class GtkBuilderHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkBuilderHandle New()
	{
		return GtkBuilderHandleExterns.gtk_builder_new();
	}

	public static MentorLake.Gtk.GtkBuilderHandle NewFromFile(string filename)
	{
		return GtkBuilderHandleExterns.gtk_builder_new_from_file(filename);
	}

	public static MentorLake.Gtk.GtkBuilderHandle NewFromResource(string resource_path)
	{
		return GtkBuilderHandleExterns.gtk_builder_new_from_resource(resource_path);
	}

	public static MentorLake.Gtk.GtkBuilderHandle NewFromString(string @string, UIntPtr length)
	{
		return GtkBuilderHandleExterns.gtk_builder_new_from_string(@string, length);
	}

}

public static class GtkBuilderHandleExtensions
{
	public static T AddCallbackSymbol<T>(this T builder, string callback_name, MentorLake.GObject.GCallback callback_symbol) where T : GtkBuilderHandle
	{
		GtkBuilderHandleExterns.gtk_builder_add_callback_symbol(builder, callback_name, callback_symbol);
		return builder;
	}

	public static T AddCallbackSymbols<T>(this T builder, string first_callback_name, MentorLake.GObject.GCallback first_callback_symbol, IntPtr @__arglist) where T : GtkBuilderHandle
	{
		GtkBuilderHandleExterns.gtk_builder_add_callback_symbols(builder, first_callback_name, first_callback_symbol, @__arglist);
		return builder;
	}

	public static uint AddFromFile(this MentorLake.Gtk.GtkBuilderHandle builder, string filename)
	{
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_from_file(builder, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint AddFromResource(this MentorLake.Gtk.GtkBuilderHandle builder, string resource_path)
	{
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_from_resource(builder, resource_path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint AddFromString(this MentorLake.Gtk.GtkBuilderHandle builder, string buffer, UIntPtr length)
	{
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_from_string(builder, buffer, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint AddObjectsFromFile(this MentorLake.Gtk.GtkBuilderHandle builder, string filename, string[] object_ids)
	{
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_objects_from_file(builder, filename, object_ids, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint AddObjectsFromResource(this MentorLake.Gtk.GtkBuilderHandle builder, string resource_path, string[] object_ids)
	{
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_objects_from_resource(builder, resource_path, object_ids, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint AddObjectsFromString(this MentorLake.Gtk.GtkBuilderHandle builder, string buffer, UIntPtr length, string[] object_ids)
	{
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_objects_from_string(builder, buffer, length, object_ids, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ConnectSignals<T>(this T builder, IntPtr user_data) where T : GtkBuilderHandle
	{
		GtkBuilderHandleExterns.gtk_builder_connect_signals(builder, user_data);
		return builder;
	}

	public static T ConnectSignalsFull<T>(this T builder, MentorLake.Gtk.GtkBuilderConnectFunc func, IntPtr user_data) where T : GtkBuilderHandle
	{
		GtkBuilderHandleExterns.gtk_builder_connect_signals_full(builder, func, user_data);
		return builder;
	}

	public static T ExposeObject<T>(this T builder, string name, MentorLake.GObject.GObjectHandle @object) where T : GtkBuilderHandle
	{
		GtkBuilderHandleExterns.gtk_builder_expose_object(builder, name, @object);
		return builder;
	}

	public static uint ExtendWithTemplate(this MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType template_type, string buffer, UIntPtr length)
	{
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_extend_with_template(builder, widget, template_type, buffer, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gtk.GtkApplicationHandle GetApplication(this MentorLake.Gtk.GtkBuilderHandle builder)
	{
		return GtkBuilderHandleExterns.gtk_builder_get_application(builder);
	}

	public static MentorLake.GObject.GObjectHandle GetObject(this MentorLake.Gtk.GtkBuilderHandle builder, string name)
	{
		return GtkBuilderHandleExterns.gtk_builder_get_object(builder, name);
	}

	public static MentorLake.GLib.GSListHandle GetObjects(this MentorLake.Gtk.GtkBuilderHandle builder)
	{
		return GtkBuilderHandleExterns.gtk_builder_get_objects(builder);
	}

	public static string GetTranslationDomain(this MentorLake.Gtk.GtkBuilderHandle builder)
	{
		return GtkBuilderHandleExterns.gtk_builder_get_translation_domain(builder);
	}

	public static MentorLake.GObject.GType GetTypeFromName(this MentorLake.Gtk.GtkBuilderHandle builder, string type_name)
	{
		return GtkBuilderHandleExterns.gtk_builder_get_type_from_name(builder, type_name);
	}

	public static MentorLake.GObject.GCallback LookupCallbackSymbol(this MentorLake.Gtk.GtkBuilderHandle builder, string callback_name)
	{
		return GtkBuilderHandleExterns.gtk_builder_lookup_callback_symbol(builder, callback_name);
	}

	public static T SetApplication<T>(this T builder, MentorLake.Gtk.GtkApplicationHandle application) where T : GtkBuilderHandle
	{
		GtkBuilderHandleExterns.gtk_builder_set_application(builder, application);
		return builder;
	}

	public static T SetTranslationDomain<T>(this T builder, string domain) where T : GtkBuilderHandle
	{
		GtkBuilderHandleExterns.gtk_builder_set_translation_domain(builder, domain);
		return builder;
	}

	public static bool ValueFromString(this MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GParamSpecHandle pspec, string @string, out MentorLake.GObject.GValue value)
	{
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_value_from_string(builder, pspec, @string, out value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool ValueFromStringType(this MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GType type, string @string, out MentorLake.GObject.GValue value)
	{
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_value_from_string_type(builder, type, @string, out value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GtkBuilderHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBuilderHandle gtk_builder_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBuilderHandle gtk_builder_new_from_file(string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBuilderHandle gtk_builder_new_from_resource(string resource_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBuilderHandle gtk_builder_new_from_string(string @string, UIntPtr length);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_add_callback_symbol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string callback_name, MentorLake.GObject.GCallback callback_symbol);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_add_callback_symbols([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string first_callback_name, MentorLake.GObject.GCallback first_callback_symbol, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_from_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string resource_path, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string buffer, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_objects_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string filename, string[] object_ids, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_objects_from_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string resource_path, string[] object_ids, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_objects_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string buffer, UIntPtr length, string[] object_ids, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_connect_signals([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_connect_signals_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.Gtk.GtkBuilderConnectFunc func, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_expose_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_extend_with_template([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType template_type, string buffer, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkApplicationHandle gtk_builder_get_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle gtk_builder_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_builder_get_objects([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_builder_get_translation_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType gtk_builder_get_type_from_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string type_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GCallback gtk_builder_lookup_callback_symbol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string callback_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_set_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_set_translation_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string domain);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_builder_value_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, string @string, out MentorLake.GObject.GValue value, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_builder_value_from_string_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GType type, string @string, out MentorLake.GObject.GValue value, out MentorLake.GLib.GErrorHandle error);

}

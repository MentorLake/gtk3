namespace MentorLake.Gtk;

public interface GtkBuildableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkBuildableHandleImpl : BaseSafeHandle, GtkBuildableHandle
{
}

public static class GtkBuildableHandleExtensions
{
	public static T AddChild<T>(this T buildable, MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GObjectHandle child, string type) where T : GtkBuildableHandle
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		GtkBuildableHandleExterns.gtk_buildable_add_child(buildable, builder, child, type);
		return buildable;
	}

	public static MentorLake.GObject.GObjectHandle ConstructChild(this MentorLake.Gtk.GtkBuildableHandle buildable, MentorLake.Gtk.GtkBuilderHandle builder, string name)
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		return GtkBuildableHandleExterns.gtk_buildable_construct_child(buildable, builder, name);
	}

	public static T CustomFinished<T>(this T buildable, MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GObjectHandle child, string tagname, IntPtr data) where T : GtkBuildableHandle
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		GtkBuildableHandleExterns.gtk_buildable_custom_finished(buildable, builder, child, tagname, data);
		return buildable;
	}

	public static T CustomTagEnd<T>(this T buildable, MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GObjectHandle child, string tagname, IntPtr data) where T : GtkBuildableHandle
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		GtkBuildableHandleExterns.gtk_buildable_custom_tag_end(buildable, builder, child, tagname, data);
		return buildable;
	}

	public static bool CustomTagStart(this MentorLake.Gtk.GtkBuildableHandle buildable, MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GObjectHandle child, string tagname, out MentorLake.GLib.GMarkupParser parser, out IntPtr data)
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		return GtkBuildableHandleExterns.gtk_buildable_custom_tag_start(buildable, builder, child, tagname, out parser, out data);
	}

	public static MentorLake.GObject.GObjectHandle GetInternalChild(this MentorLake.Gtk.GtkBuildableHandle buildable, MentorLake.Gtk.GtkBuilderHandle builder, string childname)
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		return GtkBuildableHandleExterns.gtk_buildable_get_internal_child(buildable, builder, childname);
	}

	public static string GetName(this MentorLake.Gtk.GtkBuildableHandle buildable)
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		return GtkBuildableHandleExterns.gtk_buildable_get_name(buildable);
	}

	public static T ParserFinished<T>(this T buildable, MentorLake.Gtk.GtkBuilderHandle builder) where T : GtkBuildableHandle
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		GtkBuildableHandleExterns.gtk_buildable_parser_finished(buildable, builder);
		return buildable;
	}

	public static T SetBuildableProperty<T>(this T buildable, MentorLake.Gtk.GtkBuilderHandle builder, string name, MentorLake.GObject.GValueHandle value) where T : GtkBuildableHandle
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		GtkBuildableHandleExterns.gtk_buildable_set_buildable_property(buildable, builder, name, value);
		return buildable;
	}

	public static T SetName<T>(this T buildable, string name) where T : GtkBuildableHandle
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		GtkBuildableHandleExterns.gtk_buildable_set_name(buildable, name);
		return buildable;
	}

}

internal class GtkBuildableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_buildable_add_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuildableHandleImpl>))] MentorLake.Gtk.GtkBuildableHandle buildable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle child, string type);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle gtk_buildable_construct_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuildableHandleImpl>))] MentorLake.Gtk.GtkBuildableHandle buildable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_buildable_custom_finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuildableHandleImpl>))] MentorLake.Gtk.GtkBuildableHandle buildable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle child, string tagname, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_buildable_custom_tag_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuildableHandleImpl>))] MentorLake.Gtk.GtkBuildableHandle buildable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle child, string tagname, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_buildable_custom_tag_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuildableHandleImpl>))] MentorLake.Gtk.GtkBuildableHandle buildable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle child, string tagname, out MentorLake.GLib.GMarkupParser parser, out IntPtr data);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle gtk_buildable_get_internal_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuildableHandleImpl>))] MentorLake.Gtk.GtkBuildableHandle buildable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string childname);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_buildable_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuildableHandleImpl>))] MentorLake.Gtk.GtkBuildableHandle buildable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_buildable_parser_finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuildableHandleImpl>))] MentorLake.Gtk.GtkBuildableHandle buildable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_buildable_set_buildable_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuildableHandleImpl>))] MentorLake.Gtk.GtkBuildableHandle buildable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_buildable_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuildableHandleImpl>))] MentorLake.Gtk.GtkBuildableHandle buildable, string name);

}

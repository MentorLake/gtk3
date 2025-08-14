namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkBuildable allows objects to extend and customize their deserialization
/// from [GtkBuilder UI descriptions][BUILDER-UI].
/// The interface includes methods for setting names and properties of objects,
/// parsing custom tags and constructing child objects.
/// </para>
/// <para>
/// The GtkBuildable interface is implemented by all widgets and
/// many of the non-widget objects that are provided by GTK+. The
/// main user of this interface is #GtkBuilder. There should be
/// very little need for applications to call any of these functions directly.
/// </para>
/// <para>
/// An object only needs to implement this interface if it needs to extend the
/// #GtkBuilder format or run any extra routines at deserialization time.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Adds a child to @buildable. @type is an optional string
/// describing how the child should be added.
/// </para>
/// </summary>

/// <param name="buildable">
/// a #GtkBuildable
/// </param>
/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="child">
/// child to add
/// </param>
/// <param name="type">
/// kind of child or %NULL
/// </param>

	public static T AddChild<T>(this T buildable, MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GObjectHandle child, string type) where T : GtkBuildableHandle
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		GtkBuildableHandleExterns.gtk_buildable_add_child(buildable, builder, child, type);
		return buildable;
	}

/// <summary>
/// <para>
/// Constructs a child of @buildable with the name @name.
/// </para>
/// <para>
/// #GtkBuilder calls this function if a “constructor” has been
/// specified in the UI definition.
/// </para>
/// </summary>

/// <param name="buildable">
/// A #GtkBuildable
/// </param>
/// <param name="builder">
/// #GtkBuilder used to construct this object
/// </param>
/// <param name="name">
/// name of child to construct
/// </param>
/// <return>
/// the constructed child
/// </return>

	public static MentorLake.GObject.GObjectHandle ConstructChild(this MentorLake.Gtk.GtkBuildableHandle buildable, MentorLake.Gtk.GtkBuilderHandle builder, string name)
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		return GtkBuildableHandleExterns.gtk_buildable_construct_child(buildable, builder, name);
	}

/// <summary>
/// <para>
/// This is similar to gtk_buildable_parser_finished() but is
/// called once for each custom tag handled by the @buildable.
/// </para>
/// </summary>

/// <param name="buildable">
/// a #GtkBuildable
/// </param>
/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="child">
/// child object or %NULL for non-child tags
/// </param>
/// <param name="tagname">
/// the name of the tag
/// </param>
/// <param name="data">
/// user data created in custom_tag_start
/// </param>

	public static T CustomFinished<T>(this T buildable, MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GObjectHandle child, string tagname, IntPtr data) where T : GtkBuildableHandle
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		GtkBuildableHandleExterns.gtk_buildable_custom_finished(buildable, builder, child, tagname, data);
		return buildable;
	}

/// <summary>
/// <para>
/// This is called at the end of each custom element handled by
/// the buildable.
/// </para>
/// </summary>

/// <param name="buildable">
/// A #GtkBuildable
/// </param>
/// <param name="builder">
/// #GtkBuilder used to construct this object
/// </param>
/// <param name="child">
/// child object or %NULL for non-child tags
/// </param>
/// <param name="tagname">
/// name of tag
/// </param>
/// <param name="data">
/// user data that will be passed in to parser functions
/// </param>

	public static T CustomTagEnd<T>(this T buildable, MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GObjectHandle child, string tagname, IntPtr data) where T : GtkBuildableHandle
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		GtkBuildableHandleExterns.gtk_buildable_custom_tag_end(buildable, builder, child, tagname, data);
		return buildable;
	}

/// <summary>
/// <para>
/// This is called for each unknown element under `<child>`.
/// </para>
/// </summary>

/// <param name="buildable">
/// a #GtkBuildable
/// </param>
/// <param name="builder">
/// a #GtkBuilder used to construct this object
/// </param>
/// <param name="child">
/// child object or %NULL for non-child tags
/// </param>
/// <param name="tagname">
/// name of tag
/// </param>
/// <param name="parser">
/// a #GMarkupParser to fill in
/// </param>
/// <param name="data">
/// return location for user data that will be passed in
///   to parser functions
/// </param>
/// <return>
/// %TRUE if a object has a custom implementation, %FALSE
///          if it doesn't.
/// </return>

	public static bool CustomTagStart(this MentorLake.Gtk.GtkBuildableHandle buildable, MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GObjectHandle child, string tagname, out MentorLake.GLib.GMarkupParser parser, out IntPtr data)
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		return GtkBuildableHandleExterns.gtk_buildable_custom_tag_start(buildable, builder, child, tagname, out parser, out data);
	}

/// <summary>
/// <para>
/// Get the internal child called @childname of the @buildable object.
/// </para>
/// </summary>

/// <param name="buildable">
/// a #GtkBuildable
/// </param>
/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="childname">
/// name of child
/// </param>
/// <return>
/// the internal child of the buildable object
/// </return>

	public static MentorLake.GObject.GObjectHandle GetInternalChild(this MentorLake.Gtk.GtkBuildableHandle buildable, MentorLake.Gtk.GtkBuilderHandle builder, string childname)
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		return GtkBuildableHandleExterns.gtk_buildable_get_internal_child(buildable, builder, childname);
	}

/// <summary>
/// <para>
/// Gets the name of the @buildable object.
/// </para>
/// <para>
/// #GtkBuilder sets the name based on the
/// [GtkBuilder UI definition][BUILDER-UI]
/// used to construct the @buildable.
/// </para>
/// </summary>

/// <param name="buildable">
/// a #GtkBuildable
/// </param>
/// <return>
/// the name set with gtk_buildable_set_name()
/// </return>

	public static string GetName(this MentorLake.Gtk.GtkBuildableHandle buildable)
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		return GtkBuildableHandleExterns.gtk_buildable_get_name(buildable);
	}

/// <summary>
/// <para>
/// Called when the builder finishes the parsing of a
/// [GtkBuilder UI definition][BUILDER-UI].
/// Note that this will be called once for each time
/// gtk_builder_add_from_file() or gtk_builder_add_from_string()
/// is called on a builder.
/// </para>
/// </summary>

/// <param name="buildable">
/// a #GtkBuildable
/// </param>
/// <param name="builder">
/// a #GtkBuilder
/// </param>

	public static T ParserFinished<T>(this T buildable, MentorLake.Gtk.GtkBuilderHandle builder) where T : GtkBuildableHandle
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		GtkBuildableHandleExterns.gtk_buildable_parser_finished(buildable, builder);
		return buildable;
	}

/// <summary>
/// <para>
/// Sets the property name @name to @value on the @buildable object.
/// </para>
/// </summary>

/// <param name="buildable">
/// a #GtkBuildable
/// </param>
/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="name">
/// name of property
/// </param>
/// <param name="value">
/// value of property
/// </param>

	public static T SetBuildableProperty<T>(this T buildable, MentorLake.Gtk.GtkBuilderHandle builder, string name, MentorLake.GObject.GValueHandle value) where T : GtkBuildableHandle
	{
		if (buildable.IsInvalid) throw new Exception("Invalid handle (GtkBuildableHandle)");
		GtkBuildableHandleExterns.gtk_buildable_set_buildable_property(buildable, builder, name, value);
		return buildable;
	}

/// <summary>
/// <para>
/// Sets the name of the @buildable object.
/// </para>
/// </summary>

/// <param name="buildable">
/// a #GtkBuildable
/// </param>
/// <param name="name">
/// name to set
/// </param>

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

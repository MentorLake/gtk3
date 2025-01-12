namespace MentorLake.Gtk3.Gtk3;

public interface GtkBuildableHandle
{
}

internal class GtkBuildableHandleImpl : BaseSafeHandle, GtkBuildableHandle
{
}

public static class GtkBuildableHandleExtensions
{
	public static GtkBuildableHandle AddChild(this GtkBuildableHandle buildable, GtkBuilderHandle builder, GObjectHandle child, string type)
	{
		GtkBuildableExterns.gtk_buildable_add_child(buildable, builder, child, type);
		return buildable;
	}

	public static GObjectHandle ConstructChild(this GtkBuildableHandle buildable, GtkBuilderHandle builder, string name)
	{
		return GtkBuildableExterns.gtk_buildable_construct_child(buildable, builder, name);
	}

	public static GtkBuildableHandle CustomFinished(this GtkBuildableHandle buildable, GtkBuilderHandle builder, GObjectHandle child, string tagname, IntPtr data)
	{
		GtkBuildableExterns.gtk_buildable_custom_finished(buildable, builder, child, tagname, data);
		return buildable;
	}

	public static GtkBuildableHandle CustomTagEnd(this GtkBuildableHandle buildable, GtkBuilderHandle builder, GObjectHandle child, string tagname, ref IntPtr data)
	{
		GtkBuildableExterns.gtk_buildable_custom_tag_end(buildable, builder, child, tagname, ref data);
		return buildable;
	}

	public static bool CustomTagStart(this GtkBuildableHandle buildable, GtkBuilderHandle builder, GObjectHandle child, string tagname, out GMarkupParser parser, out IntPtr data)
	{
		return GtkBuildableExterns.gtk_buildable_custom_tag_start(buildable, builder, child, tagname, out parser, out data);
	}

	public static GObjectHandle GetInternalChild(this GtkBuildableHandle buildable, GtkBuilderHandle builder, string childname)
	{
		return GtkBuildableExterns.gtk_buildable_get_internal_child(buildable, builder, childname);
	}

	public static string GetName(this GtkBuildableHandle buildable)
	{
		return GtkBuildableExterns.gtk_buildable_get_name(buildable);
	}

	public static GtkBuildableHandle ParserFinished(this GtkBuildableHandle buildable, GtkBuilderHandle builder)
	{
		GtkBuildableExterns.gtk_buildable_parser_finished(buildable, builder);
		return buildable;
	}

	public static GtkBuildableHandle SetBuildableProperty(this GtkBuildableHandle buildable, GtkBuilderHandle builder, string name, GValueHandle value)
	{
		GtkBuildableExterns.gtk_buildable_set_buildable_property(buildable, builder, name, value);
		return buildable;
	}

	public static GtkBuildableHandle SetName(this GtkBuildableHandle buildable, string name)
	{
		GtkBuildableExterns.gtk_buildable_set_name(buildable, name);
		return buildable;
	}

}

internal class GtkBuildableExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_buildable_add_child(GtkBuildableHandle buildable, GtkBuilderHandle builder, GObjectHandle child, string type);

	[DllImport(Libraries.Gtk3)]
	internal static extern GObjectHandle gtk_buildable_construct_child(GtkBuildableHandle buildable, GtkBuilderHandle builder, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_buildable_custom_finished(GtkBuildableHandle buildable, GtkBuilderHandle builder, GObjectHandle child, string tagname, IntPtr data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_buildable_custom_tag_end(GtkBuildableHandle buildable, GtkBuilderHandle builder, GObjectHandle child, string tagname, ref IntPtr data);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_buildable_custom_tag_start(GtkBuildableHandle buildable, GtkBuilderHandle builder, GObjectHandle child, string tagname, out GMarkupParser parser, out IntPtr data);

	[DllImport(Libraries.Gtk3)]
	internal static extern GObjectHandle gtk_buildable_get_internal_child(GtkBuildableHandle buildable, GtkBuilderHandle builder, string childname);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_buildable_get_name(GtkBuildableHandle buildable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_buildable_parser_finished(GtkBuildableHandle buildable, GtkBuilderHandle builder);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_buildable_set_buildable_property(GtkBuildableHandle buildable, GtkBuilderHandle builder, string name, GValueHandle value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_buildable_set_name(GtkBuildableHandle buildable, string name);

}

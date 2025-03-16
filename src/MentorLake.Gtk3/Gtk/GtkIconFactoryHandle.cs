namespace MentorLake.Gtk;

public class GtkIconFactoryHandle : GObjectHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkIconFactoryHandle New()
	{
		return GtkIconFactoryHandleExterns.gtk_icon_factory_new();
	}

	public static MentorLake.Gtk.GtkIconSetHandle LookupDefault(string stock_id)
	{
		return GtkIconFactoryHandleExterns.gtk_icon_factory_lookup_default(stock_id);
	}

}

public static class GtkIconFactoryHandleExtensions
{
	public static T Add<T>(this T factory, string stock_id, MentorLake.Gtk.GtkIconSetHandle icon_set) where T : GtkIconFactoryHandle
	{
		GtkIconFactoryHandleExterns.gtk_icon_factory_add(factory, stock_id, icon_set);
		return factory;
	}

	public static T AddDefault<T>(this T factory) where T : GtkIconFactoryHandle
	{
		GtkIconFactoryHandleExterns.gtk_icon_factory_add_default(factory);
		return factory;
	}

	public static MentorLake.Gtk.GtkIconSetHandle Lookup(this MentorLake.Gtk.GtkIconFactoryHandle factory, string stock_id)
	{
		return GtkIconFactoryHandleExterns.gtk_icon_factory_lookup(factory, stock_id);
	}

	public static T RemoveDefault<T>(this T factory) where T : GtkIconFactoryHandle
	{
		GtkIconFactoryHandleExterns.gtk_icon_factory_remove_default(factory);
		return factory;
	}

}

internal class GtkIconFactoryHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconFactoryHandle gtk_icon_factory_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_factory_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconFactoryHandle>))] MentorLake.Gtk.GtkIconFactoryHandle factory, string stock_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_factory_add_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconFactoryHandle>))] MentorLake.Gtk.GtkIconFactoryHandle factory);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_icon_factory_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconFactoryHandle>))] MentorLake.Gtk.GtkIconFactoryHandle factory, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_factory_remove_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconFactoryHandle>))] MentorLake.Gtk.GtkIconFactoryHandle factory);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_icon_factory_lookup_default(string stock_id);

}

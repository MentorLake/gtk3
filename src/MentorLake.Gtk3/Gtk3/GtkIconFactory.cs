namespace MentorLake.Gtk3.Gtk3;

public class GtkIconFactoryHandle : GObjectHandle, GtkBuildableHandle
{
	public static GtkIconFactoryHandle New()
	{
		return GtkIconFactoryExterns.gtk_icon_factory_new();
	}

	public static GtkIconSetHandle LookupDefault(string stock_id)
	{
		return GtkIconFactoryExterns.gtk_icon_factory_lookup_default(stock_id);
	}

}

public static class GtkIconFactoryHandleExtensions
{
	public static T Add<T>(this T factory, string stock_id, GtkIconSetHandle icon_set) where T : GtkIconFactoryHandle
	{
		GtkIconFactoryExterns.gtk_icon_factory_add(factory, stock_id, icon_set);
		return factory;
	}

	public static T AddDefault<T>(this T factory) where T : GtkIconFactoryHandle
	{
		GtkIconFactoryExterns.gtk_icon_factory_add_default(factory);
		return factory;
	}

	public static GtkIconSetHandle Lookup(this GtkIconFactoryHandle factory, string stock_id)
	{
		return GtkIconFactoryExterns.gtk_icon_factory_lookup(factory, stock_id);
	}

	public static T RemoveDefault<T>(this T factory) where T : GtkIconFactoryHandle
	{
		GtkIconFactoryExterns.gtk_icon_factory_remove_default(factory);
		return factory;
	}

}

internal class GtkIconFactoryExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconFactoryHandle gtk_icon_factory_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_factory_add(GtkIconFactoryHandle factory, string stock_id, GtkIconSetHandle icon_set);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_factory_add_default(GtkIconFactoryHandle factory);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSetHandle gtk_icon_factory_lookup(GtkIconFactoryHandle factory, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_factory_remove_default(GtkIconFactoryHandle factory);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSetHandle gtk_icon_factory_lookup_default(string stock_id);

}

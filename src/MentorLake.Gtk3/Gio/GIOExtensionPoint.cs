namespace MentorLake.Gtk3.Gio;

public class GIOExtensionPointHandle : BaseSafeHandle
{
}


public static class GIOExtensionPointHandleExtensions
{
	public static GIOExtensionHandle GIoExtensionPointGetExtensionByName(this GIOExtensionPointHandle extension_point, string name)
	{
		return GIOExtensionPointExterns.g_io_extension_point_get_extension_by_name(extension_point, name);
	}

	public static GListHandle GIoExtensionPointGetExtensions(this GIOExtensionPointHandle extension_point)
	{
		return GIOExtensionPointExterns.g_io_extension_point_get_extensions(extension_point);
	}

	public static GType GIoExtensionPointGetRequiredType(this GIOExtensionPointHandle extension_point)
	{
		return GIOExtensionPointExterns.g_io_extension_point_get_required_type(extension_point);
	}

	public static T GIoExtensionPointSetRequiredType<T>(this T extension_point, GType type) where T : GIOExtensionPointHandle
	{
		GIOExtensionPointExterns.g_io_extension_point_set_required_type(extension_point, type);
		return extension_point;
	}

	public static GIOExtensionHandle GIoExtensionPointImplement(string extension_point_name, GType type, string extension_name, int priority)
	{
		return GIOExtensionPointExterns.g_io_extension_point_implement(extension_point_name, type, extension_name, priority);
	}

	public static GIOExtensionPointHandle GIoExtensionPointLookup(string name)
	{
		return GIOExtensionPointExterns.g_io_extension_point_lookup(name);
	}

	public static GIOExtensionPointHandle GIoExtensionPointRegister(string name)
	{
		return GIOExtensionPointExterns.g_io_extension_point_register(name);
	}

}
internal class GIOExtensionPointExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GIOExtensionHandle g_io_extension_point_get_extension_by_name(GIOExtensionPointHandle extension_point, string name);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_io_extension_point_get_extensions(GIOExtensionPointHandle extension_point);

	[DllImport(Libraries.Gio)]
	internal static extern GType g_io_extension_point_get_required_type(GIOExtensionPointHandle extension_point);

	[DllImport(Libraries.Gio)]
	internal static extern void g_io_extension_point_set_required_type(GIOExtensionPointHandle extension_point, GType type);

	[DllImport(Libraries.Gio)]
	internal static extern GIOExtensionHandle g_io_extension_point_implement(string extension_point_name, GType type, string extension_name, int priority);

	[DllImport(Libraries.Gio)]
	internal static extern GIOExtensionPointHandle g_io_extension_point_lookup(string name);

	[DllImport(Libraries.Gio)]
	internal static extern GIOExtensionPointHandle g_io_extension_point_register(string name);

}

public struct GIOExtensionPoint
{
}

namespace MentorLake.Gio;

public class GIOExtensionPointHandle : BaseSafeHandle
{
}


public static class GIOExtensionPointExtensions
{
	public static MentorLake.Gio.GIOExtensionHandle GetExtensionByName(this MentorLake.Gio.GIOExtensionPointHandle extension_point, string name)
	{
		if (extension_point.IsInvalid || extension_point.IsClosed) throw new Exception("Invalid or closed handle (GIOExtensionPoint)");
		return GIOExtensionPointExterns.g_io_extension_point_get_extension_by_name(extension_point, name);
	}

	public static MentorLake.GLib.GListHandle GetExtensions(this MentorLake.Gio.GIOExtensionPointHandle extension_point)
	{
		if (extension_point.IsInvalid || extension_point.IsClosed) throw new Exception("Invalid or closed handle (GIOExtensionPoint)");
		return GIOExtensionPointExterns.g_io_extension_point_get_extensions(extension_point);
	}

	public static MentorLake.GObject.GType GetRequiredType(this MentorLake.Gio.GIOExtensionPointHandle extension_point)
	{
		if (extension_point.IsInvalid || extension_point.IsClosed) throw new Exception("Invalid or closed handle (GIOExtensionPoint)");
		return GIOExtensionPointExterns.g_io_extension_point_get_required_type(extension_point);
	}

	public static void SetRequiredType(this MentorLake.Gio.GIOExtensionPointHandle extension_point, MentorLake.GObject.GType type)
	{
		if (extension_point.IsInvalid || extension_point.IsClosed) throw new Exception("Invalid or closed handle (GIOExtensionPoint)");
		GIOExtensionPointExterns.g_io_extension_point_set_required_type(extension_point, type);
	}


	public static GIOExtensionPoint Dereference(this GIOExtensionPointHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOExtensionPoint>(x.DangerousGetHandle());
}
internal class GIOExtensionPointExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOExtensionHandle g_io_extension_point_get_extension_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))] MentorLake.Gio.GIOExtensionPointHandle extension_point, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_io_extension_point_get_extensions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))] MentorLake.Gio.GIOExtensionPointHandle extension_point);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_io_extension_point_get_required_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))] MentorLake.Gio.GIOExtensionPointHandle extension_point);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_extension_point_set_required_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))] MentorLake.Gio.GIOExtensionPointHandle extension_point, MentorLake.GObject.GType type);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOExtensionHandle g_io_extension_point_implement(string extension_point_name, MentorLake.GObject.GType type, string extension_name, int priority);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOExtensionPointHandle g_io_extension_point_lookup(string name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOExtensionPointHandle g_io_extension_point_register(string name);

}

public struct GIOExtensionPoint
{
	public static MentorLake.Gio.GIOExtensionHandle Implement(string extension_point_name, MentorLake.GObject.GType type, string extension_name, int priority)
	{
		return GIOExtensionPointExterns.g_io_extension_point_implement(extension_point_name, type, extension_name, priority);
	}

	public static MentorLake.Gio.GIOExtensionPointHandle Lookup(string name)
	{
		return GIOExtensionPointExterns.g_io_extension_point_lookup(name);
	}

	public static MentorLake.Gio.GIOExtensionPointHandle Register(string name)
	{
		return GIOExtensionPointExterns.g_io_extension_point_register(name);
	}

}

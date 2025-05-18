namespace MentorLake.Gio;

public class GIOExtensionHandle : BaseSafeHandle
{
}


public static class GIOExtensionExtensions
{
	public static string GetName(this MentorLake.Gio.GIOExtensionHandle extension)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (GIOExtension)");
		return GIOExtensionExterns.g_io_extension_get_name(extension);
	}

	public static int GetPriority(this MentorLake.Gio.GIOExtensionHandle extension)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (GIOExtension)");
		return GIOExtensionExterns.g_io_extension_get_priority(extension);
	}

	public static MentorLake.GObject.GType GetType(this MentorLake.Gio.GIOExtensionHandle extension)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (GIOExtension)");
		return GIOExtensionExterns.g_io_extension_get_type(extension);
	}

	public static MentorLake.GObject.GTypeClassHandle RefClass(this MentorLake.Gio.GIOExtensionHandle extension)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (GIOExtension)");
		return GIOExtensionExterns.g_io_extension_ref_class(extension);
	}


	public static GIOExtension Dereference(this GIOExtensionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOExtension>(x.DangerousGetHandle());
}
internal class GIOExtensionExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_io_extension_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionHandle>))] MentorLake.Gio.GIOExtensionHandle extension);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_io_extension_get_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionHandle>))] MentorLake.Gio.GIOExtensionHandle extension);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_io_extension_get_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionHandle>))] MentorLake.Gio.GIOExtensionHandle extension);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))]
	internal static extern MentorLake.GObject.GTypeClassHandle g_io_extension_ref_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionHandle>))] MentorLake.Gio.GIOExtensionHandle extension);

}

public struct GIOExtension
{
}

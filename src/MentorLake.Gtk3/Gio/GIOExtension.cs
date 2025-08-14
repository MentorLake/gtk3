namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GIOExtension is an opaque data structure and can only be accessed
/// using the following functions.
/// </para>
/// </summary>

public class GIOExtensionHandle : BaseSafeHandle
{
}


public static class GIOExtensionExtensions
{
/// <summary>
/// <para>
/// Gets the name under which @extension was registered.
/// </para>
/// <para>
/// Note that the same type may be registered as extension
/// for multiple extension points, under different names.
/// </para>
/// </summary>

/// <param name="extension">
/// a #GIOExtension
/// </param>
/// <return>
/// the name of @extension.
/// </return>

	public static string GetName(this MentorLake.Gio.GIOExtensionHandle extension)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (GIOExtension)");
		return GIOExtensionExterns.g_io_extension_get_name(extension);
	}

/// <summary>
/// <para>
/// Gets the priority with which @extension was registered.
/// </para>
/// </summary>

/// <param name="extension">
/// a #GIOExtension
/// </param>
/// <return>
/// the priority of @extension
/// </return>

	public static int GetPriority(this MentorLake.Gio.GIOExtensionHandle extension)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (GIOExtension)");
		return GIOExtensionExterns.g_io_extension_get_priority(extension);
	}

/// <summary>
/// <para>
/// Gets the type associated with @extension.
/// </para>
/// </summary>

/// <param name="extension">
/// a #GIOExtension
/// </param>
/// <return>
/// the type of @extension
/// </return>

	public static MentorLake.GObject.GType GetType(this MentorLake.Gio.GIOExtensionHandle extension)
	{
		if (extension.IsInvalid) throw new Exception("Invalid handle (GIOExtension)");
		return GIOExtensionExterns.g_io_extension_get_type(extension);
	}

/// <summary>
/// <para>
/// Gets a reference to the class for the type that is
/// associated with @extension.
/// </para>
/// </summary>

/// <param name="extension">
/// a #GIOExtension
/// </param>
/// <return>
/// the #GTypeClass for the type of @extension
/// </return>

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

/// <summary>
/// <para>
/// #GIOExtension is an opaque data structure and can only be accessed
/// using the following functions.
/// </para>
/// </summary>

public struct GIOExtension
{
}

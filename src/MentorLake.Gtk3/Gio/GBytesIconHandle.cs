namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GBytesIcon` specifies an image held in memory in a common format (usually
/// PNG) to be used as icon.
/// </para>
/// </summary>

public class GBytesIconHandle : GObjectHandle, GIconHandle, GLoadableIconHandle
{
/// <summary>
/// <para>
/// Creates a new icon for a bytes.
/// </para>
/// <para>
/// This cannot fail, but loading and interpreting the bytes may fail later on
/// (for example, if g_loadable_icon_load() is called) if the image is invalid.
/// </para>
/// </summary>

/// <param name="bytes">
/// a #GBytes.
/// </param>
/// <return>
/// a #GIcon for the given
///   @bytes.
/// </return>

	public static MentorLake.Gio.GBytesIconHandle New(MentorLake.GLib.GBytesHandle bytes)
	{
		return GBytesIconHandleExterns.g_bytes_icon_new(bytes);
	}

}

public static class GBytesIconHandleExtensions
{
/// <summary>
/// <para>
/// Gets the #GBytes associated with the given @icon.
/// </para>
/// </summary>

/// <param name="icon">
/// a #GIcon.
/// </param>
/// <return>
/// a #GBytes.
/// </return>

	public static MentorLake.GLib.GBytesHandle GetBytes(this MentorLake.Gio.GBytesIconHandle icon)
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GBytesIconHandle)");
		return GBytesIconHandleExterns.g_bytes_icon_get_bytes(icon);
	}

}

internal class GBytesIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GBytesIconHandle>))]
	internal static extern MentorLake.Gio.GBytesIconHandle g_bytes_icon_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_bytes_icon_get_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GBytesIconHandle>))] MentorLake.Gio.GBytesIconHandle icon);

}

namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GFileIcon` specifies an icon by pointing to an image file
/// to be used as icon.
/// </para>
/// <para>
/// It implements [iface@Gio.LoadableIcon].
/// </para>
/// </summary>

public class GFileIconHandle : GObjectHandle, GIconHandle, GLoadableIconHandle
{
/// <summary>
/// <para>
/// Creates a new icon for a file.
/// </para>
/// </summary>

/// <param name="file">
/// a #GFile.
/// </param>
/// <return>
/// a #GIcon for the given
///   @file, or %NULL on error.
/// </return>

	public static MentorLake.Gio.GFileIconHandle New(MentorLake.Gio.GFileHandle file)
	{
		return GFileIconHandleExterns.g_file_icon_new(file);
	}

}

public static class GFileIconHandleExtensions
{
/// <summary>
/// <para>
/// Gets the #GFile associated with the given @icon.
/// </para>
/// </summary>

/// <param name="icon">
/// a #GIcon.
/// </param>
/// <return>
/// a #GFile.
/// </return>

	public static MentorLake.Gio.GFileHandle GetFile(this MentorLake.Gio.GFileIconHandle icon)
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GFileIconHandle)");
		return GFileIconHandleExterns.g_file_icon_get_file(icon);
	}

}

internal class GFileIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GFileIconHandle>))]
	internal static extern MentorLake.Gio.GFileIconHandle g_file_icon_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_file_icon_get_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIconHandle>))] MentorLake.Gio.GFileIconHandle icon);

}

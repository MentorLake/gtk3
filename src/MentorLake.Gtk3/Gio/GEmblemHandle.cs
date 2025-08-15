namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GEmblem` is an implementation of [iface@Gio.Icon] that supports
/// having an emblem, which is an icon with additional properties.
/// It can than be added to a [class@Gio.EmblemedIcon].
/// </para>
/// <para>
/// Currently, only metainformation about the emblem&apos;s origin is
/// supported. More may be added in the future.
/// </para>
/// </summary>

public class GEmblemHandle : GObjectHandle, GIconHandle
{
/// <summary>
/// <para>
/// Creates a new emblem for @icon.
/// </para>
/// </summary>

/// <param name="icon">
/// a GIcon containing the icon.
/// </param>
/// <return>
/// a new #GEmblem.
/// </return>

	public static MentorLake.Gio.GEmblemHandle New(MentorLake.Gio.GIconHandle icon)
	{
		return GEmblemHandleExterns.g_emblem_new(icon);
	}

/// <summary>
/// <para>
/// Creates a new emblem for @icon.
/// </para>
/// </summary>

/// <param name="icon">
/// a GIcon containing the icon.
/// </param>
/// <param name="origin">
/// a GEmblemOrigin enum defining the emblem&apos;s origin
/// </param>
/// <return>
/// a new #GEmblem.
/// </return>

	public static MentorLake.Gio.GEmblemHandle NewWithOrigin(MentorLake.Gio.GIconHandle icon, MentorLake.Gio.GEmblemOrigin origin)
	{
		return GEmblemHandleExterns.g_emblem_new_with_origin(icon, origin);
	}

}

public static class GEmblemHandleExtensions
{
/// <summary>
/// <para>
/// Gives back the icon from @emblem.
/// </para>
/// </summary>

/// <param name="emblem">
/// a #GEmblem from which the icon should be extracted.
/// </param>
/// <return>
/// a #GIcon. The returned object belongs to
///          the emblem and should not be modified or freed.
/// </return>

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GEmblemHandle emblem)
	{
		if (emblem.IsInvalid) throw new Exception("Invalid handle (GEmblemHandle)");
		return GEmblemHandleExterns.g_emblem_get_icon(emblem);
	}

/// <summary>
/// <para>
/// Gets the origin of the emblem.
/// </para>
/// </summary>

/// <param name="emblem">
/// a #GEmblem
/// </param>
/// <return>
/// the origin of the emblem
/// </return>

	public static MentorLake.Gio.GEmblemOrigin GetOrigin(this MentorLake.Gio.GEmblemHandle emblem)
	{
		if (emblem.IsInvalid) throw new Exception("Invalid handle (GEmblemHandle)");
		return GEmblemHandleExterns.g_emblem_get_origin(emblem);
	}

}

internal class GEmblemHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GEmblemHandle>))]
	internal static extern MentorLake.Gio.GEmblemHandle g_emblem_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GEmblemHandle>))]
	internal static extern MentorLake.Gio.GEmblemHandle g_emblem_new_with_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, MentorLake.Gio.GEmblemOrigin origin);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_emblem_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemHandle>))] MentorLake.Gio.GEmblemHandle emblem);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GEmblemOrigin g_emblem_get_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemHandle>))] MentorLake.Gio.GEmblemHandle emblem);

}

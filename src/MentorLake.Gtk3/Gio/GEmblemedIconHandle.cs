namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GEmblemedIcon` is an implementation of [iface@Gio.Icon] that supports
/// adding an emblem to an icon. Adding multiple emblems to an
/// icon is ensured via [method@Gio.EmblemedIcon.add_emblem].
/// </para>
/// <para>
/// Note that `GEmblemedIcon` allows no control over the position
/// of the emblems. See also [class@Gio.Emblem] for more information.
/// </para>
/// </summary>

public class GEmblemedIconHandle : GObjectHandle, GIconHandle
{
/// <summary>
/// <para>
/// Creates a new emblemed icon for @icon with the emblem @emblem.
/// </para>
/// </summary>

/// <param name="icon">
/// a #GIcon
/// </param>
/// <param name="emblem">
/// a #GEmblem, or %NULL
/// </param>
/// <return>
/// a new #GIcon
/// </return>

	public static MentorLake.Gio.GEmblemedIconHandle New(MentorLake.Gio.GIconHandle icon, MentorLake.Gio.GEmblemHandle emblem)
	{
		return GEmblemedIconHandleExterns.g_emblemed_icon_new(icon, emblem);
	}

}

public static class GEmblemedIconHandleExtensions
{
/// <summary>
/// <para>
/// Adds @emblem to the #GList of #GEmblems.
/// </para>
/// </summary>

/// <param name="emblemed">
/// a #GEmblemedIcon
/// </param>
/// <param name="emblem">
/// a #GEmblem
/// </param>

	public static T AddEmblem<T>(this T emblemed, MentorLake.Gio.GEmblemHandle emblem) where T : GEmblemedIconHandle
	{
		if (emblemed.IsInvalid) throw new Exception("Invalid handle (GEmblemedIconHandle)");
		GEmblemedIconHandleExterns.g_emblemed_icon_add_emblem(emblemed, emblem);
		return emblemed;
	}

/// <summary>
/// <para>
/// Removes all the emblems from @icon.
/// </para>
/// </summary>

/// <param name="emblemed">
/// a #GEmblemedIcon
/// </param>

	public static T ClearEmblems<T>(this T emblemed) where T : GEmblemedIconHandle
	{
		if (emblemed.IsInvalid) throw new Exception("Invalid handle (GEmblemedIconHandle)");
		GEmblemedIconHandleExterns.g_emblemed_icon_clear_emblems(emblemed);
		return emblemed;
	}

/// <summary>
/// <para>
/// Gets the list of emblems for the @icon.
/// </para>
/// </summary>

/// <param name="emblemed">
/// a #GEmblemedIcon
/// </param>
/// <return>
/// a #GList of
///     #GEmblems that is owned by @emblemed
/// </return>

	public static MentorLake.GLib.GListHandle GetEmblems(this MentorLake.Gio.GEmblemedIconHandle emblemed)
	{
		if (emblemed.IsInvalid) throw new Exception("Invalid handle (GEmblemedIconHandle)");
		return GEmblemedIconHandleExterns.g_emblemed_icon_get_emblems(emblemed);
	}

/// <summary>
/// <para>
/// Gets the main icon for @emblemed.
/// </para>
/// </summary>

/// <param name="emblemed">
/// a #GEmblemedIcon
/// </param>
/// <return>
/// a #GIcon that is owned by @emblemed
/// </return>

	public static MentorLake.Gio.GIconHandle GetIcon(this MentorLake.Gio.GEmblemedIconHandle emblemed)
	{
		if (emblemed.IsInvalid) throw new Exception("Invalid handle (GEmblemedIconHandle)");
		return GEmblemedIconHandleExterns.g_emblemed_icon_get_icon(emblemed);
	}

}

internal class GEmblemedIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GEmblemedIconHandle>))]
	internal static extern MentorLake.Gio.GEmblemedIconHandle g_emblemed_icon_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemHandle>))] MentorLake.Gio.GEmblemHandle emblem);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_emblemed_icon_add_emblem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemedIconHandle>))] MentorLake.Gio.GEmblemedIconHandle emblemed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemHandle>))] MentorLake.Gio.GEmblemHandle emblem);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_emblemed_icon_clear_emblems([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemedIconHandle>))] MentorLake.Gio.GEmblemedIconHandle emblemed);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_emblemed_icon_get_emblems([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemedIconHandle>))] MentorLake.Gio.GEmblemedIconHandle emblemed);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle g_emblemed_icon_get_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GEmblemedIconHandle>))] MentorLake.Gio.GEmblemedIconHandle emblemed);

}

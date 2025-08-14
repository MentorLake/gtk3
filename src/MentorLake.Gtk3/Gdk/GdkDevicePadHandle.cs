namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// #GdkDevicePad is an interface implemented by devices of type
/// %GDK_SOURCE_TABLET_PAD, it allows querying the features provided
/// by the pad device.
/// </para>
/// <para>
/// Tablet pads may contain one or more groups, each containing a subset
/// of the buttons/rings/strips available. gdk_device_pad_get_n_groups()
/// can be used to obtain the number of groups, gdk_device_pad_get_n_features()
/// and gdk_device_pad_get_feature_group() can be combined to find out the
/// number of buttons/rings/strips the device has, and how are they grouped.
/// </para>
/// <para>
/// Each of those groups have different modes, which may be used to map
/// each individual pad feature to multiple actions. Only one mode is
/// effective (current) for each given group, different groups may have
/// different current modes. The number of available modes in a group can
/// be found out through gdk_device_pad_get_group_n_modes(), and the current
/// mode for a given group will be notified through the #GdkEventPadGroupMode
/// event.
/// </para>
/// </summary>

public interface GdkDevicePadHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GdkDevicePadHandleImpl : BaseSafeHandle, GdkDevicePadHandle
{
}

public static class GdkDevicePadHandleExtensions
{
/// <summary>
/// <para>
/// Returns the group the given @feature and @idx belong to,
/// or -1 if feature/index do not exist in @pad.
/// </para>
/// </summary>

/// <param name="pad">
/// a #GdkDevicePad
/// </param>
/// <param name="feature">
/// the feature type to get the group from
/// </param>
/// <param name="feature_idx">
/// the index of the feature to get the group from
/// </param>
/// <return>
/// The group number of the queried pad feature.
/// </return>

	public static int GetFeatureGroup(this MentorLake.Gdk.GdkDevicePadHandle pad, MentorLake.Gdk.GdkDevicePadFeature feature, int feature_idx)
	{
		if (pad.IsInvalid) throw new Exception("Invalid handle (GdkDevicePadHandle)");
		return GdkDevicePadHandleExterns.gdk_device_pad_get_feature_group(pad, feature, feature_idx);
	}

/// <summary>
/// <para>
/// Returns the number of modes that @group may have.
/// </para>
/// </summary>

/// <param name="pad">
/// a #GdkDevicePad
/// </param>
/// <param name="group_idx">
/// group to get the number of available modes from
/// </param>
/// <return>
/// The number of modes available in @group.
/// </return>

	public static int GetGroupNModes(this MentorLake.Gdk.GdkDevicePadHandle pad, int group_idx)
	{
		if (pad.IsInvalid) throw new Exception("Invalid handle (GdkDevicePadHandle)");
		return GdkDevicePadHandleExterns.gdk_device_pad_get_group_n_modes(pad, group_idx);
	}

/// <summary>
/// <para>
/// Returns the number of features a tablet pad has.
/// </para>
/// </summary>

/// <param name="pad">
/// a #GdkDevicePad
/// </param>
/// <param name="feature">
/// a pad feature
/// </param>
/// <return>
/// The amount of elements of type @feature that this pad has.
/// </return>

	public static int GetNFeatures(this MentorLake.Gdk.GdkDevicePadHandle pad, MentorLake.Gdk.GdkDevicePadFeature feature)
	{
		if (pad.IsInvalid) throw new Exception("Invalid handle (GdkDevicePadHandle)");
		return GdkDevicePadHandleExterns.gdk_device_pad_get_n_features(pad, feature);
	}

/// <summary>
/// <para>
/// Returns the number of groups this pad device has. Pads have
/// at least one group. A pad group is a subcollection of
/// buttons/strip/rings that is affected collectively by a same
/// current mode.
/// </para>
/// </summary>

/// <param name="pad">
/// a #GdkDevicePad
/// </param>
/// <return>
/// The number of button/ring/strip groups in the pad.
/// </return>

	public static int GetNGroups(this MentorLake.Gdk.GdkDevicePadHandle pad)
	{
		if (pad.IsInvalid) throw new Exception("Invalid handle (GdkDevicePadHandle)");
		return GdkDevicePadHandleExterns.gdk_device_pad_get_n_groups(pad);
	}

}

internal class GdkDevicePadHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_device_pad_get_feature_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDevicePadHandleImpl>))] MentorLake.Gdk.GdkDevicePadHandle pad, MentorLake.Gdk.GdkDevicePadFeature feature, int feature_idx);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_device_pad_get_group_n_modes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDevicePadHandleImpl>))] MentorLake.Gdk.GdkDevicePadHandle pad, int group_idx);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_device_pad_get_n_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDevicePadHandleImpl>))] MentorLake.Gdk.GdkDevicePadHandle pad, MentorLake.Gdk.GdkDevicePadFeature feature);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_device_pad_get_n_groups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDevicePadHandleImpl>))] MentorLake.Gdk.GdkDevicePadHandle pad);

}

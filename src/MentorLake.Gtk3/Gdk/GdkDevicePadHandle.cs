namespace MentorLake.Gdk;

public interface GdkDevicePadHandle
{
}

internal class GdkDevicePadHandleImpl : BaseSafeHandle, GdkDevicePadHandle
{
}

public static class GdkDevicePadHandleExtensions
{
	public static int GetFeatureGroup(this MentorLake.Gdk.GdkDevicePadHandle pad, MentorLake.Gdk.GdkDevicePadFeature feature, int feature_idx)
	{
		return GdkDevicePadHandleExterns.gdk_device_pad_get_feature_group(pad, feature, feature_idx);
	}

	public static int GetGroupNModes(this MentorLake.Gdk.GdkDevicePadHandle pad, int group_idx)
	{
		return GdkDevicePadHandleExterns.gdk_device_pad_get_group_n_modes(pad, group_idx);
	}

	public static int GetNFeatures(this MentorLake.Gdk.GdkDevicePadHandle pad, MentorLake.Gdk.GdkDevicePadFeature feature)
	{
		return GdkDevicePadHandleExterns.gdk_device_pad_get_n_features(pad, feature);
	}

	public static int GetNGroups(this MentorLake.Gdk.GdkDevicePadHandle pad)
	{
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

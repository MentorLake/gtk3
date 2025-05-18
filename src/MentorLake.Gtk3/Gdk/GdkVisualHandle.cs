namespace MentorLake.Gdk;

public class GdkVisualHandle : GObjectHandle
{
	public static MentorLake.Gdk.GdkVisualHandle GetBest()
	{
		return GdkVisualHandleExterns.gdk_visual_get_best();
	}

	public static int GetBestDepth()
	{
		return GdkVisualHandleExterns.gdk_visual_get_best_depth();
	}

	public static MentorLake.Gdk.GdkVisualType GetBestType()
	{
		return GdkVisualHandleExterns.gdk_visual_get_best_type();
	}

	public static MentorLake.Gdk.GdkVisualHandle GetBestWithBoth(int depth, MentorLake.Gdk.GdkVisualType visual_type)
	{
		return GdkVisualHandleExterns.gdk_visual_get_best_with_both(depth, visual_type);
	}

	public static MentorLake.Gdk.GdkVisualHandle GetBestWithDepth(int depth)
	{
		return GdkVisualHandleExterns.gdk_visual_get_best_with_depth(depth);
	}

	public static MentorLake.Gdk.GdkVisualHandle GetBestWithType(MentorLake.Gdk.GdkVisualType visual_type)
	{
		return GdkVisualHandleExterns.gdk_visual_get_best_with_type(visual_type);
	}

	public static MentorLake.Gdk.GdkVisualHandle GetSystem()
	{
		return GdkVisualHandleExterns.gdk_visual_get_system();
	}

}

public static class GdkVisualHandleExtensions
{
	public static int GetBitsPerRgb(this MentorLake.Gdk.GdkVisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		return GdkVisualHandleExterns.gdk_visual_get_bits_per_rgb(visual);
	}

	public static T GetBluePixelDetails<T>(this T visual, out uint mask, out int shift, out int precision) where T : GdkVisualHandle
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		GdkVisualHandleExterns.gdk_visual_get_blue_pixel_details(visual, out mask, out shift, out precision);
		return visual;
	}

	public static MentorLake.Gdk.GdkByteOrder GetByteOrder(this MentorLake.Gdk.GdkVisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		return GdkVisualHandleExterns.gdk_visual_get_byte_order(visual);
	}

	public static int GetColormapSize(this MentorLake.Gdk.GdkVisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		return GdkVisualHandleExterns.gdk_visual_get_colormap_size(visual);
	}

	public static int GetDepth(this MentorLake.Gdk.GdkVisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		return GdkVisualHandleExterns.gdk_visual_get_depth(visual);
	}

	public static T GetGreenPixelDetails<T>(this T visual, out uint mask, out int shift, out int precision) where T : GdkVisualHandle
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		GdkVisualHandleExterns.gdk_visual_get_green_pixel_details(visual, out mask, out shift, out precision);
		return visual;
	}

	public static T GetRedPixelDetails<T>(this T visual, out uint mask, out int shift, out int precision) where T : GdkVisualHandle
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		GdkVisualHandleExterns.gdk_visual_get_red_pixel_details(visual, out mask, out shift, out precision);
		return visual;
	}

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gdk.GdkVisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		return GdkVisualHandleExterns.gdk_visual_get_screen(visual);
	}

	public static MentorLake.Gdk.GdkVisualType GetVisualType(this MentorLake.Gdk.GdkVisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		return GdkVisualHandleExterns.gdk_visual_get_visual_type(visual);
	}

}

internal class GdkVisualHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_visual_get_bits_per_rgb([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))] MentorLake.Gdk.GdkVisualHandle visual);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_visual_get_blue_pixel_details([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))] MentorLake.Gdk.GdkVisualHandle visual, out uint mask, out int shift, out int precision);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkByteOrder gdk_visual_get_byte_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))] MentorLake.Gdk.GdkVisualHandle visual);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_visual_get_colormap_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))] MentorLake.Gdk.GdkVisualHandle visual);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_visual_get_depth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))] MentorLake.Gdk.GdkVisualHandle visual);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_visual_get_green_pixel_details([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))] MentorLake.Gdk.GdkVisualHandle visual, out uint mask, out int shift, out int precision);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_visual_get_red_pixel_details([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))] MentorLake.Gdk.GdkVisualHandle visual, out uint mask, out int shift, out int precision);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gdk_visual_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))] MentorLake.Gdk.GdkVisualHandle visual);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkVisualType gdk_visual_get_visual_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))] MentorLake.Gdk.GdkVisualHandle visual);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))]
	internal static extern MentorLake.Gdk.GdkVisualHandle gdk_visual_get_best();

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_visual_get_best_depth();

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkVisualType gdk_visual_get_best_type();

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))]
	internal static extern MentorLake.Gdk.GdkVisualHandle gdk_visual_get_best_with_both(int depth, MentorLake.Gdk.GdkVisualType visual_type);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))]
	internal static extern MentorLake.Gdk.GdkVisualHandle gdk_visual_get_best_with_depth(int depth);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))]
	internal static extern MentorLake.Gdk.GdkVisualHandle gdk_visual_get_best_with_type(MentorLake.Gdk.GdkVisualType visual_type);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))]
	internal static extern MentorLake.Gdk.GdkVisualHandle gdk_visual_get_system();

}

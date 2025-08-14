namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A #GdkVisual contains information about
/// a particular visual.
/// </para>
/// </summary>

public class GdkVisualHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Get the visual with the most available colors for the default
/// GDK screen. The return value should not be freed.
/// </para>
/// </summary>

/// <return>
/// best visual
/// </return>

	public static MentorLake.Gdk.GdkVisualHandle GetBest()
	{
		return GdkVisualHandleExterns.gdk_visual_get_best();
	}

/// <summary>
/// <para>
/// Get the best available depth for the default GDK screen.  “Best”
/// means “largest,” i.e. 32 preferred over 24 preferred over 8 bits
/// per pixel.
/// </para>
/// </summary>

/// <return>
/// best available depth
/// </return>

	public static int GetBestDepth()
	{
		return GdkVisualHandleExterns.gdk_visual_get_best_depth();
	}

/// <summary>
/// <para>
/// Return the best available visual type for the default GDK screen.
/// </para>
/// </summary>

/// <return>
/// best visual type
/// </return>

	public static MentorLake.Gdk.GdkVisualType GetBestType()
	{
		return GdkVisualHandleExterns.gdk_visual_get_best_type();
	}

/// <summary>
/// <para>
/// Combines gdk_visual_get_best_with_depth() and
/// gdk_visual_get_best_with_type().
/// </para>
/// </summary>

/// <param name="depth">
/// a bit depth
/// </param>
/// <param name="visual_type">
/// a visual type
/// </param>
/// <return>
/// best visual with both @depth
///     and @visual_type, or %NULL if none
/// </return>

	public static MentorLake.Gdk.GdkVisualHandle GetBestWithBoth(int depth, MentorLake.Gdk.GdkVisualType visual_type)
	{
		return GdkVisualHandleExterns.gdk_visual_get_best_with_both(depth, visual_type);
	}

/// <summary>
/// <para>
/// Get the best visual with depth @depth for the default GDK screen.
/// Color visuals and visuals with mutable colormaps are preferred
/// over grayscale or fixed-colormap visuals. The return value should
/// not be freed. %NULL may be returned if no visual supports @depth.
/// </para>
/// </summary>

/// <param name="depth">
/// a bit depth
/// </param>
/// <return>
/// best visual for the given depth
/// </return>

	public static MentorLake.Gdk.GdkVisualHandle GetBestWithDepth(int depth)
	{
		return GdkVisualHandleExterns.gdk_visual_get_best_with_depth(depth);
	}

/// <summary>
/// <para>
/// Get the best visual of the given @visual_type for the default GDK screen.
/// Visuals with higher color depths are considered better. The return value
/// should not be freed. %NULL may be returned if no visual has type
/// @visual_type.
/// </para>
/// </summary>

/// <param name="visual_type">
/// a visual type
/// </param>
/// <return>
/// best visual of the given type
/// </return>

	public static MentorLake.Gdk.GdkVisualHandle GetBestWithType(MentorLake.Gdk.GdkVisualType visual_type)
	{
		return GdkVisualHandleExterns.gdk_visual_get_best_with_type(visual_type);
	}

/// <summary>
/// <para>
/// Get the system’s default visual for the default GDK screen.
/// This is the visual for the root window of the display.
/// The return value should not be freed.
/// </para>
/// </summary>

/// <return>
/// system visual
/// </return>

	public static MentorLake.Gdk.GdkVisualHandle GetSystem()
	{
		return GdkVisualHandleExterns.gdk_visual_get_system();
	}

}

public static class GdkVisualHandleExtensions
{
/// <summary>
/// <para>
/// Returns the number of significant bits per red, green and blue value.
/// </para>
/// <para>
/// Not all GDK backend provide a meaningful value for this function.
/// </para>
/// </summary>

/// <param name="visual">
/// a #GdkVisual
/// </param>
/// <return>
/// The number of significant bits per color value for @visual.
/// </return>

	public static int GetBitsPerRgb(this MentorLake.Gdk.GdkVisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		return GdkVisualHandleExterns.gdk_visual_get_bits_per_rgb(visual);
	}

/// <summary>
/// <para>
/// Obtains values that are needed to calculate blue pixel values in TrueColor
/// and DirectColor. The “mask” is the significant bits within the pixel.
/// The “shift” is the number of bits left we must shift a primary for it
/// to be in position (according to the "mask"). Finally, "precision" refers
/// to how much precision the pixel value contains for a particular primary.
/// </para>
/// </summary>

/// <param name="visual">
/// a #GdkVisual
/// </param>
/// <param name="mask">
/// A pointer to a #guint32 to be filled in, or %NULL
/// </param>
/// <param name="shift">
/// A pointer to a #gint to be filled in, or %NULL
/// </param>
/// <param name="precision">
/// A pointer to a #gint to be filled in, or %NULL
/// </param>

	public static T GetBluePixelDetails<T>(this T visual, out uint mask, out int shift, out int precision) where T : GdkVisualHandle
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		GdkVisualHandleExterns.gdk_visual_get_blue_pixel_details(visual, out mask, out shift, out precision);
		return visual;
	}

/// <summary>
/// <para>
/// Returns the byte order of this visual.
/// </para>
/// <para>
/// The information returned by this function is only relevant
/// when working with XImages, and not all backends return
/// meaningful information for this.
/// </para>
/// </summary>

/// <param name="visual">
/// A #GdkVisual.
/// </param>
/// <return>
/// A #GdkByteOrder stating the byte order of @visual.
/// </return>

	public static MentorLake.Gdk.GdkByteOrder GetByteOrder(this MentorLake.Gdk.GdkVisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		return GdkVisualHandleExterns.gdk_visual_get_byte_order(visual);
	}

/// <summary>
/// <para>
/// Returns the size of a colormap for this visual.
/// </para>
/// <para>
/// You have to use platform-specific APIs to manipulate colormaps.
/// </para>
/// </summary>

/// <param name="visual">
/// A #GdkVisual.
/// </param>
/// <return>
/// The size of a colormap that is suitable for @visual.
/// </return>

	public static int GetColormapSize(this MentorLake.Gdk.GdkVisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		return GdkVisualHandleExterns.gdk_visual_get_colormap_size(visual);
	}

/// <summary>
/// <para>
/// Returns the bit depth of this visual.
/// </para>
/// </summary>

/// <param name="visual">
/// A #GdkVisual.
/// </param>
/// <return>
/// The bit depth of this visual.
/// </return>

	public static int GetDepth(this MentorLake.Gdk.GdkVisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		return GdkVisualHandleExterns.gdk_visual_get_depth(visual);
	}

/// <summary>
/// <para>
/// Obtains values that are needed to calculate green pixel values in TrueColor
/// and DirectColor. The “mask” is the significant bits within the pixel.
/// The “shift” is the number of bits left we must shift a primary for it
/// to be in position (according to the "mask"). Finally, "precision" refers
/// to how much precision the pixel value contains for a particular primary.
/// </para>
/// </summary>

/// <param name="visual">
/// a #GdkVisual
/// </param>
/// <param name="mask">
/// A pointer to a #guint32 to be filled in, or %NULL
/// </param>
/// <param name="shift">
/// A pointer to a #gint to be filled in, or %NULL
/// </param>
/// <param name="precision">
/// A pointer to a #gint to be filled in, or %NULL
/// </param>

	public static T GetGreenPixelDetails<T>(this T visual, out uint mask, out int shift, out int precision) where T : GdkVisualHandle
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		GdkVisualHandleExterns.gdk_visual_get_green_pixel_details(visual, out mask, out shift, out precision);
		return visual;
	}

/// <summary>
/// <para>
/// Obtains values that are needed to calculate red pixel values in TrueColor
/// and DirectColor. The “mask” is the significant bits within the pixel.
/// The “shift” is the number of bits left we must shift a primary for it
/// to be in position (according to the "mask"). Finally, "precision" refers
/// to how much precision the pixel value contains for a particular primary.
/// </para>
/// </summary>

/// <param name="visual">
/// A #GdkVisual
/// </param>
/// <param name="mask">
/// A pointer to a #guint32 to be filled in, or %NULL
/// </param>
/// <param name="shift">
/// A pointer to a #gint to be filled in, or %NULL
/// </param>
/// <param name="precision">
/// A pointer to a #gint to be filled in, or %NULL
/// </param>

	public static T GetRedPixelDetails<T>(this T visual, out uint mask, out int shift, out int precision) where T : GdkVisualHandle
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		GdkVisualHandleExterns.gdk_visual_get_red_pixel_details(visual, out mask, out shift, out precision);
		return visual;
	}

/// <summary>
/// <para>
/// Gets the screen to which this visual belongs
/// </para>
/// </summary>

/// <param name="visual">
/// a #GdkVisual
/// </param>
/// <return>
/// the screen to which this visual belongs.
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gdk.GdkVisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkVisualHandle)");
		return GdkVisualHandleExterns.gdk_visual_get_screen(visual);
	}

/// <summary>
/// <para>
/// Returns the type of visual this is (PseudoColor, TrueColor, etc).
/// </para>
/// </summary>

/// <param name="visual">
/// A #GdkVisual.
/// </param>
/// <return>
/// A #GdkVisualType stating the type of @visual.
/// </return>

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

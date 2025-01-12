namespace MentorLake.Gtk3.Gdk3;

public class GdkVisualHandle : GObjectHandle
{
	public static GdkVisualHandle GetBest()
	{
		return GdkVisualExterns.gdk_visual_get_best();
	}

	public static int GetBestDepth()
	{
		return GdkVisualExterns.gdk_visual_get_best_depth();
	}

	public static GdkVisualType GetBestType()
	{
		return GdkVisualExterns.gdk_visual_get_best_type();
	}

	public static GdkVisualHandle GetBestWithBoth(int depth, GdkVisualType visual_type)
	{
		return GdkVisualExterns.gdk_visual_get_best_with_both(depth, visual_type);
	}

	public static GdkVisualHandle GetBestWithDepth(int depth)
	{
		return GdkVisualExterns.gdk_visual_get_best_with_depth(depth);
	}

	public static GdkVisualHandle GetBestWithType(GdkVisualType visual_type)
	{
		return GdkVisualExterns.gdk_visual_get_best_with_type(visual_type);
	}

	public static GdkVisualHandle GetSystem()
	{
		return GdkVisualExterns.gdk_visual_get_system();
	}

}

public static class GdkVisualHandleExtensions
{
	public static int GetBitsPerRgb(this GdkVisualHandle visual)
	{
		return GdkVisualExterns.gdk_visual_get_bits_per_rgb(visual);
	}

	public static GdkVisualHandle GetBluePixelDetails(this GdkVisualHandle visual, out uint mask, out int shift, out int precision)
	{
		GdkVisualExterns.gdk_visual_get_blue_pixel_details(visual, out mask, out shift, out precision);
		return visual;
	}

	public static GdkByteOrder GetByteOrder(this GdkVisualHandle visual)
	{
		return GdkVisualExterns.gdk_visual_get_byte_order(visual);
	}

	public static int GetColormapSize(this GdkVisualHandle visual)
	{
		return GdkVisualExterns.gdk_visual_get_colormap_size(visual);
	}

	public static int GetDepth(this GdkVisualHandle visual)
	{
		return GdkVisualExterns.gdk_visual_get_depth(visual);
	}

	public static GdkVisualHandle GetGreenPixelDetails(this GdkVisualHandle visual, out uint mask, out int shift, out int precision)
	{
		GdkVisualExterns.gdk_visual_get_green_pixel_details(visual, out mask, out shift, out precision);
		return visual;
	}

	public static GdkVisualHandle GetRedPixelDetails(this GdkVisualHandle visual, out uint mask, out int shift, out int precision)
	{
		GdkVisualExterns.gdk_visual_get_red_pixel_details(visual, out mask, out shift, out precision);
		return visual;
	}

	public static GdkScreenHandle GetScreen(this GdkVisualHandle visual)
	{
		return GdkVisualExterns.gdk_visual_get_screen(visual);
	}

	public static GdkVisualType GetVisualType(this GdkVisualHandle visual)
	{
		return GdkVisualExterns.gdk_visual_get_visual_type(visual);
	}

}

internal class GdkVisualExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_visual_get_bits_per_rgb(GdkVisualHandle visual);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_visual_get_blue_pixel_details(GdkVisualHandle visual, out uint mask, out int shift, out int precision);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkByteOrder gdk_visual_get_byte_order(GdkVisualHandle visual);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_visual_get_colormap_size(GdkVisualHandle visual);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_visual_get_depth(GdkVisualHandle visual);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_visual_get_green_pixel_details(GdkVisualHandle visual, out uint mask, out int shift, out int precision);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_visual_get_red_pixel_details(GdkVisualHandle visual, out uint mask, out int shift, out int precision);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkScreenHandle gdk_visual_get_screen(GdkVisualHandle visual);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkVisualType gdk_visual_get_visual_type(GdkVisualHandle visual);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkVisualHandle gdk_visual_get_best();

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_visual_get_best_depth();

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkVisualType gdk_visual_get_best_type();

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkVisualHandle gdk_visual_get_best_with_both(int depth, GdkVisualType visual_type);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkVisualHandle gdk_visual_get_best_with_depth(int depth);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkVisualHandle gdk_visual_get_best_with_type(GdkVisualType visual_type);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkVisualHandle gdk_visual_get_system();

}

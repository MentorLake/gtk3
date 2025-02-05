namespace MentorLake.Gtk3.Pango;

public class PangoTabArrayHandle : BaseSafeHandle
{
	public static PangoTabArrayHandle New(int initial_size, bool positions_in_pixels)
	{
		return PangoTabArrayExterns.pango_tab_array_new(initial_size, positions_in_pixels);
	}

	public static PangoTabArrayHandle NewWithPositions(int size, bool positions_in_pixels, PangoTabAlign first_alignment, int first_position, IntPtr @__arglist)
	{
		return PangoTabArrayExterns.pango_tab_array_new_with_positions(size, positions_in_pixels, first_alignment, first_position, @__arglist);
	}

}


public static class PangoTabArrayHandleExtensions
{
	public static PangoTabArrayHandle Copy(this PangoTabArrayHandle src)
	{
		return PangoTabArrayExterns.pango_tab_array_copy(src);
	}

	public static T Free<T>(this T tab_array) where T : PangoTabArrayHandle
	{
		PangoTabArrayExterns.pango_tab_array_free(tab_array);
		return tab_array;
	}

	public static char GetDecimalPoint(this PangoTabArrayHandle tab_array, int tab_index)
	{
		return PangoTabArrayExterns.pango_tab_array_get_decimal_point(tab_array, tab_index);
	}

	public static bool GetPositionsInPixels(this PangoTabArrayHandle tab_array)
	{
		return PangoTabArrayExterns.pango_tab_array_get_positions_in_pixels(tab_array);
	}

	public static int GetSize(this PangoTabArrayHandle tab_array)
	{
		return PangoTabArrayExterns.pango_tab_array_get_size(tab_array);
	}

	public static T GetTab<T>(this T tab_array, int tab_index, out PangoTabAlign alignment, out int location) where T : PangoTabArrayHandle
	{
		PangoTabArrayExterns.pango_tab_array_get_tab(tab_array, tab_index, out alignment, out location);
		return tab_array;
	}

	public static T GetTabs<T>(this T tab_array, out PangoTabAlign[] alignments, out int[] locations) where T : PangoTabArrayHandle
	{
		PangoTabArrayExterns.pango_tab_array_get_tabs(tab_array, out alignments, out locations);
		return tab_array;
	}

	public static T Resize<T>(this T tab_array, int new_size) where T : PangoTabArrayHandle
	{
		PangoTabArrayExterns.pango_tab_array_resize(tab_array, new_size);
		return tab_array;
	}

	public static T SetDecimalPoint<T>(this T tab_array, int tab_index, char decimal_point) where T : PangoTabArrayHandle
	{
		PangoTabArrayExterns.pango_tab_array_set_decimal_point(tab_array, tab_index, decimal_point);
		return tab_array;
	}

	public static T SetPositionsInPixels<T>(this T tab_array, bool positions_in_pixels) where T : PangoTabArrayHandle
	{
		PangoTabArrayExterns.pango_tab_array_set_positions_in_pixels(tab_array, positions_in_pixels);
		return tab_array;
	}

	public static T SetTab<T>(this T tab_array, int tab_index, PangoTabAlign alignment, int location) where T : PangoTabArrayHandle
	{
		PangoTabArrayExterns.pango_tab_array_set_tab(tab_array, tab_index, alignment, location);
		return tab_array;
	}

	public static T Sort<T>(this T tab_array) where T : PangoTabArrayHandle
	{
		PangoTabArrayExterns.pango_tab_array_sort(tab_array);
		return tab_array;
	}

	public static string ToString(this PangoTabArrayHandle tab_array)
	{
		return PangoTabArrayExterns.pango_tab_array_to_string(tab_array);
	}

	public static PangoTabArrayHandle FromString(string text)
	{
		return PangoTabArrayExterns.pango_tab_array_from_string(text);
	}

}
internal class PangoTabArrayExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoTabArrayHandle pango_tab_array_new(int initial_size, bool positions_in_pixels);

	[DllImport(Libraries.Pango)]
	internal static extern PangoTabArrayHandle pango_tab_array_new_with_positions(int size, bool positions_in_pixels, PangoTabAlign first_alignment, int first_position, IntPtr @__arglist);

	[DllImport(Libraries.Pango)]
	internal static extern PangoTabArrayHandle pango_tab_array_copy(PangoTabArrayHandle src);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_tab_array_free(PangoTabArrayHandle tab_array);

	[DllImport(Libraries.Pango)]
	internal static extern char pango_tab_array_get_decimal_point(PangoTabArrayHandle tab_array, int tab_index);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_tab_array_get_positions_in_pixels(PangoTabArrayHandle tab_array);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_tab_array_get_size(PangoTabArrayHandle tab_array);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_tab_array_get_tab(PangoTabArrayHandle tab_array, int tab_index, out PangoTabAlign alignment, out int location);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_tab_array_get_tabs(PangoTabArrayHandle tab_array, out PangoTabAlign[] alignments, out int[] locations);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_tab_array_resize(PangoTabArrayHandle tab_array, int new_size);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_tab_array_set_decimal_point(PangoTabArrayHandle tab_array, int tab_index, char decimal_point);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_tab_array_set_positions_in_pixels(PangoTabArrayHandle tab_array, bool positions_in_pixels);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_tab_array_set_tab(PangoTabArrayHandle tab_array, int tab_index, PangoTabAlign alignment, int location);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_tab_array_sort(PangoTabArrayHandle tab_array);

	[DllImport(Libraries.Pango)]
	internal static extern string pango_tab_array_to_string(PangoTabArrayHandle tab_array);

	[DllImport(Libraries.Pango)]
	internal static extern PangoTabArrayHandle pango_tab_array_from_string(string text);

}

public struct PangoTabArray
{
}

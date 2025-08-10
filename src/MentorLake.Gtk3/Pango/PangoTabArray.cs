namespace MentorLake.Pango;

public class PangoTabArrayHandle : BaseSafeHandle
{
	public static MentorLake.Pango.PangoTabArrayHandle New(int initial_size, bool positions_in_pixels)
	{
		return PangoTabArrayExterns.pango_tab_array_new(initial_size, positions_in_pixels);
	}

	public static MentorLake.Pango.PangoTabArrayHandle NewWithPositions(int size, bool positions_in_pixels, MentorLake.Pango.PangoTabAlign first_alignment, int first_position, IntPtr @__arglist)
	{
		return PangoTabArrayExterns.pango_tab_array_new_with_positions(size, positions_in_pixels, first_alignment, first_position, @__arglist);
	}

}


public static class PangoTabArrayExtensions
{
	public static MentorLake.Pango.PangoTabArrayHandle Copy(this MentorLake.Pango.PangoTabArrayHandle src)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		return PangoTabArrayExterns.pango_tab_array_copy(src);
	}

	public static void Free(this MentorLake.Pango.PangoTabArrayHandle tab_array)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_free(tab_array);
	}

	public static char GetDecimalPoint(this MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		return PangoTabArrayExterns.pango_tab_array_get_decimal_point(tab_array, tab_index);
	}

	public static bool GetPositionsInPixels(this MentorLake.Pango.PangoTabArrayHandle tab_array)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		return PangoTabArrayExterns.pango_tab_array_get_positions_in_pixels(tab_array);
	}

	public static int GetSize(this MentorLake.Pango.PangoTabArrayHandle tab_array)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		return PangoTabArrayExterns.pango_tab_array_get_size(tab_array);
	}

	public static void GetTab(this MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index, out MentorLake.Pango.PangoTabAlign alignment, out int location)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_get_tab(tab_array, tab_index, out alignment, out location);
	}

	public static void GetTabs(this MentorLake.Pango.PangoTabArrayHandle tab_array, out MentorLake.Pango.PangoTabAlign[] alignments, out int[] locations)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_get_tabs(tab_array, out alignments, out locations);
	}

	public static void Resize(this MentorLake.Pango.PangoTabArrayHandle tab_array, int new_size)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_resize(tab_array, new_size);
	}

	public static void SetDecimalPoint(this MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index, char decimal_point)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_set_decimal_point(tab_array, tab_index, decimal_point);
	}

	public static void SetPositionsInPixels(this MentorLake.Pango.PangoTabArrayHandle tab_array, bool positions_in_pixels)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_set_positions_in_pixels(tab_array, positions_in_pixels);
	}

	public static void SetTab(this MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index, MentorLake.Pango.PangoTabAlign alignment, int location)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_set_tab(tab_array, tab_index, alignment, location);
	}

	public static void Sort(this MentorLake.Pango.PangoTabArrayHandle tab_array)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_sort(tab_array);
	}

	public static string ToString(this MentorLake.Pango.PangoTabArrayHandle tab_array)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		return PangoTabArrayExterns.pango_tab_array_to_string(tab_array);
	}


	public static PangoTabArray Dereference(this PangoTabArrayHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoTabArray>(x.DangerousGetHandle());
}
internal class PangoTabArrayExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))]
	internal static extern MentorLake.Pango.PangoTabArrayHandle pango_tab_array_new(int initial_size, bool positions_in_pixels);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))]
	internal static extern MentorLake.Pango.PangoTabArrayHandle pango_tab_array_new_with_positions(int size, bool positions_in_pixels, MentorLake.Pango.PangoTabAlign first_alignment, int first_position, IntPtr @__arglist);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))]
	internal static extern MentorLake.Pango.PangoTabArrayHandle pango_tab_array_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle src);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_tab_array_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array);

	[DllImport(PangoLibrary.Name)]
	internal static extern char pango_tab_array_get_decimal_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_tab_array_get_positions_in_pixels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_tab_array_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_tab_array_get_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index, out MentorLake.Pango.PangoTabAlign alignment, out int location);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_tab_array_get_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out MentorLake.Pango.PangoTabAlign[] alignments, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out int[] locations);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_tab_array_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array, int new_size);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_tab_array_set_decimal_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index, char decimal_point);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_tab_array_set_positions_in_pixels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array, bool positions_in_pixels);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_tab_array_set_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index, MentorLake.Pango.PangoTabAlign alignment, int location);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_tab_array_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_tab_array_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tab_array);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))]
	internal static extern MentorLake.Pango.PangoTabArrayHandle pango_tab_array_from_string(string text);

}

public struct PangoTabArray
{
	public static MentorLake.Pango.PangoTabArrayHandle FromString(string text)
	{
		return PangoTabArrayExterns.pango_tab_array_from_string(text);
	}

}

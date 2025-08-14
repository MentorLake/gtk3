namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoTabArray` contains an array of tab stops.
/// </para>
/// <para>
/// `PangoTabArray` can be used to set tab stops in a `PangoLayout`.
/// Each tab stop has an alignment, a position, and optionally
/// a character to use as decimal point.
/// </para>
/// </summary>

public class PangoTabArrayHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates an array of @initial_size tab stops.
/// </para>
/// <para>
/// Tab stops are specified in pixel units if @positions_in_pixels is %TRUE,
/// otherwise in Pango units. All stops are initially at position 0.
/// </para>
/// </summary>

/// <param name="initial_size">
/// Initial number of tab stops to allocate, can be 0
/// </param>
/// <param name="positions_in_pixels">
/// whether positions are in pixel units
/// </param>
/// <return>
/// the newly allocated `PangoTabArray`, which should
///   be freed with [method@Pango.TabArray.free].
/// </return>

	public static MentorLake.Pango.PangoTabArrayHandle New(int initial_size, bool positions_in_pixels)
	{
		return PangoTabArrayExterns.pango_tab_array_new(initial_size, positions_in_pixels);
	}

/// <summary>
/// <para>
/// Creates a `PangoTabArray` and allows you to specify the alignment
/// and position of each tab stop.
/// </para>
/// <para>
/// You **must** provide an alignment and position for @size tab stops.
/// </para>
/// </summary>

/// <param name="size">
/// number of tab stops in the array
/// </param>
/// <param name="positions_in_pixels">
/// whether positions are in pixel units
/// </param>
/// <param name="first_alignment">
/// alignment of first tab stop
/// </param>
/// <param name="first_position">
/// position of first tab stop
/// </param>
/// <param name="@__arglist">
/// additional alignment/position pairs
/// </param>
/// <return>
/// the newly allocated `PangoTabArray`, which should
///   be freed with [method@Pango.TabArray.free].
/// </return>

	public static MentorLake.Pango.PangoTabArrayHandle NewWithPositions(int size, bool positions_in_pixels, MentorLake.Pango.PangoTabAlign first_alignment, int first_position, IntPtr @__arglist)
	{
		return PangoTabArrayExterns.pango_tab_array_new_with_positions(size, positions_in_pixels, first_alignment, first_position, @__arglist);
	}

}


public static class PangoTabArrayExtensions
{
/// <summary>
/// <para>
/// Copies a `PangoTabArray`.
/// </para>
/// </summary>

/// <param name="src">
/// `PangoTabArray` to copy
/// </param>
/// <return>
/// the newly allocated `PangoTabArray`, which should
///   be freed with [method@Pango.TabArray.free].
/// </return>

	public static MentorLake.Pango.PangoTabArrayHandle Copy(this MentorLake.Pango.PangoTabArrayHandle src)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		return PangoTabArrayExterns.pango_tab_array_copy(src);
	}

/// <summary>
/// <para>
/// Frees a tab array and associated resources.
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>

	public static void Free(this MentorLake.Pango.PangoTabArrayHandle tab_array)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_free(tab_array);
	}

/// <summary>
/// <para>
/// Gets the Unicode character to use as decimal point.
/// </para>
/// <para>
/// This is only relevant for tabs with %PANGO_TAB_DECIMAL alignment,
/// which align content at the first occurrence of the decimal point
/// character.
/// </para>
/// <para>
/// The default value of 0 means that Pango will use the
/// decimal point according to the current locale.
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>
/// <param name="tab_index">
/// the index of a tab stop
/// </param>

	public static char GetDecimalPoint(this MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		return PangoTabArrayExterns.pango_tab_array_get_decimal_point(tab_array, tab_index);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the tab positions are in pixels,
/// %FALSE if they are in Pango units.
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>
/// <return>
/// whether positions are in pixels.
/// </return>

	public static bool GetPositionsInPixels(this MentorLake.Pango.PangoTabArrayHandle tab_array)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		return PangoTabArrayExterns.pango_tab_array_get_positions_in_pixels(tab_array);
	}

/// <summary>
/// <para>
/// Gets the number of tab stops in @tab_array.
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>
/// <return>
/// the number of tab stops in the array.
/// </return>

	public static int GetSize(this MentorLake.Pango.PangoTabArrayHandle tab_array)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		return PangoTabArrayExterns.pango_tab_array_get_size(tab_array);
	}

/// <summary>
/// <para>
/// Gets the alignment and position of a tab stop.
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>
/// <param name="tab_index">
/// tab stop index
/// </param>
/// <param name="alignment">
/// location to store alignment
/// </param>
/// <param name="location">
/// location to store tab position
/// </param>

	public static void GetTab(this MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index, out MentorLake.Pango.PangoTabAlign alignment, out int location)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_get_tab(tab_array, tab_index, out alignment, out location);
	}

/// <summary>
/// <para>
/// If non-%NULL, @alignments and @locations are filled with allocated
/// arrays.
/// </para>
/// <para>
/// The arrays are of length [method@Pango.TabArray.get_size].
/// You must free the returned array.
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>
/// <param name="alignments">
/// location to store an array of tab
///   stop alignments
/// </param>
/// <param name="locations">
/// location to store an array
///   of tab positions
/// </param>

	public static void GetTabs(this MentorLake.Pango.PangoTabArrayHandle tab_array, out MentorLake.Pango.PangoTabAlign[] alignments, out int[] locations)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_get_tabs(tab_array, out alignments, out locations);
	}

/// <summary>
/// <para>
/// Resizes a tab array.
/// </para>
/// <para>
/// You must subsequently initialize any tabs
/// that were added as a result of growing the array.
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>
/// <param name="new_size">
/// new size of the array
/// </param>

	public static void Resize(this MentorLake.Pango.PangoTabArrayHandle tab_array, int new_size)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_resize(tab_array, new_size);
	}

/// <summary>
/// <para>
/// Sets the Unicode character to use as decimal point.
/// </para>
/// <para>
/// This is only relevant for tabs with %PANGO_TAB_DECIMAL alignment,
/// which align content at the first occurrence of the decimal point
/// character.
/// </para>
/// <para>
/// By default, Pango uses the decimal point according
/// to the current locale.
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>
/// <param name="tab_index">
/// the index of a tab stop
/// </param>
/// <param name="decimal_point">
/// the decimal point to use
/// </param>

	public static void SetDecimalPoint(this MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index, char decimal_point)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_set_decimal_point(tab_array, tab_index, decimal_point);
	}

/// <summary>
/// <para>
/// Sets whether positions in this array are specified in
/// pixels.
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>
/// <param name="positions_in_pixels">
/// whether positions are in pixels
/// </param>

	public static void SetPositionsInPixels(this MentorLake.Pango.PangoTabArrayHandle tab_array, bool positions_in_pixels)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_set_positions_in_pixels(tab_array, positions_in_pixels);
	}

/// <summary>
/// <para>
/// Sets the alignment and location of a tab stop.
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>
/// <param name="tab_index">
/// the index of a tab stop
/// </param>
/// <param name="alignment">
/// tab alignment
/// </param>
/// <param name="location">
/// tab location in Pango units
/// </param>

	public static void SetTab(this MentorLake.Pango.PangoTabArrayHandle tab_array, int tab_index, MentorLake.Pango.PangoTabAlign alignment, int location)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_set_tab(tab_array, tab_index, alignment, location);
	}

/// <summary>
/// <para>
/// Utility function to ensure that the tab stops are in increasing order.
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>

	public static void Sort(this MentorLake.Pango.PangoTabArrayHandle tab_array)
	{
		if (tab_array.IsInvalid) throw new Exception("Invalid handle (PangoTabArray)");
		PangoTabArrayExterns.pango_tab_array_sort(tab_array);
	}

/// <summary>
/// <para>
/// Serializes a `PangoTabArray` to a string.
/// </para>
/// <para>
/// In the resulting string, serialized tabs are separated by newlines or commas.
/// </para>
/// <para>
/// Individual tabs are serialized to a string of the form
/// </para>
/// <para>
///     [ALIGNMENT:]POSITION[:DECIMAL_POINT]
/// </para>
/// <para>
/// Where ALIGNMENT is one of _left_, _right_, _center_ or _decimal_, and
/// POSITION is the position of the tab, optionally followed by the unit _px_.
/// If ALIGNMENT is omitted, it defaults to _left_. If ALIGNMENT is _decimal_,
/// the DECIMAL_POINT character may be specified as a Unicode codepoint.
/// </para>
/// <para>
/// Note that all tabs in the array must use the same unit.
/// </para>
/// <para>
/// A typical example:
/// </para>
/// <para>
///     100px 200px center:300px right:400px
/// </para>
/// </summary>

/// <param name="tab_array">
/// a `PangoTabArray`
/// </param>
/// <return>
/// a newly allocated string
/// </return>

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

/// <summary>
/// <para>
/// A `PangoTabArray` contains an array of tab stops.
/// </para>
/// <para>
/// `PangoTabArray` can be used to set tab stops in a `PangoLayout`.
/// Each tab stop has an alignment, a position, and optionally
/// a character to use as decimal point.
/// </para>
/// </summary>

public struct PangoTabArray
{
/// <summary>
/// <para>
/// Deserializes a `PangoTabArray` from a string.
/// </para>
/// <para>
/// This is the counterpart to [method@Pango.TabArray.to_string].
/// See that functions for details about the format.
/// </para>
/// </summary>

/// <param name="text">
/// a string
/// </param>
/// <return>
/// a new `PangoTabArray`
/// </return>

	public static MentorLake.Pango.PangoTabArrayHandle FromString(string text)
	{
		return PangoTabArrayExterns.pango_tab_array_from_string(text);
	}

}

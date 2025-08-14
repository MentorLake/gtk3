namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoScriptIter` is used to iterate through a string
/// and identify ranges in different scripts.
/// </para>
/// </summary>

public class PangoScriptIterHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Create a new `PangoScriptIter`, used to break a string of
/// Unicode text into runs by Unicode script.
/// </para>
/// <para>
/// No copy is made of @text, so the caller needs to make
/// sure it remains valid until the iterator is freed with
/// [method@Pango.ScriptIter.free].
/// </para>
/// </summary>

/// <param name="text">
/// a UTF-8 string
/// </param>
/// <param name="length">
/// length of @text, or -1 if @text is nul-terminated
/// </param>
/// <return>
/// the new script iterator, initialized
///  to point at the first range in the text, which should be
///  freed with [method@Pango.ScriptIter.free]. If the string is
///  empty, it will point at an empty range.
/// </return>

	public static MentorLake.Pango.PangoScriptIterHandle New(string text, int length)
	{
		return PangoScriptIterExterns.pango_script_iter_new(text, length);
	}

}


public static class PangoScriptIterExtensions
{
/// <summary>
/// <para>
/// Frees a `PangoScriptIter`.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoScriptIter`
/// </param>

	public static void Free(this MentorLake.Pango.PangoScriptIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoScriptIter)");
		PangoScriptIterExterns.pango_script_iter_free(iter);
	}

/// <summary>
/// <para>
/// Gets information about the range to which @iter currently points.
/// </para>
/// <para>
/// The range is the set of locations p where *start <= p < *end.
/// (That is, it doesn't include the character stored at *end)
/// </para>
/// <para>
/// Note that while the type of the @script argument is declared
/// as `PangoScript`, as of Pango 1.18, this function simply returns
/// `GUnicodeScript` values. Callers must be prepared to handle unknown
/// values.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoScriptIter`
/// </param>
/// <param name="start">
/// location to store start position of the range
/// </param>
/// <param name="end">
/// location to store end position of the range
/// </param>
/// <param name="script">
/// location to store script for range
/// </param>

	public static void GetRange(this MentorLake.Pango.PangoScriptIterHandle iter, out string start, out string end, out MentorLake.Pango.PangoScript script)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoScriptIter)");
		PangoScriptIterExterns.pango_script_iter_get_range(iter, out start, out end, out script);
	}

/// <summary>
/// <para>
/// Advances a `PangoScriptIter` to the next range.
/// </para>
/// <para>
/// If @iter is already at the end, it is left unchanged
/// and %FALSE is returned.
/// </para>
/// </summary>

/// <param name="iter">
/// a `PangoScriptIter`
/// </param>
/// <return>
/// %TRUE if @iter was successfully advanced
/// </return>

	public static bool Next(this MentorLake.Pango.PangoScriptIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (PangoScriptIter)");
		return PangoScriptIterExterns.pango_script_iter_next(iter);
	}


	public static PangoScriptIter Dereference(this PangoScriptIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoScriptIter>(x.DangerousGetHandle());
}
internal class PangoScriptIterExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoScriptIterHandle>))]
	internal static extern MentorLake.Pango.PangoScriptIterHandle pango_script_iter_new(string text, int length);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_script_iter_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoScriptIterHandle>))] MentorLake.Pango.PangoScriptIterHandle iter);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_script_iter_get_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoScriptIterHandle>))] MentorLake.Pango.PangoScriptIterHandle iter, out string start, out string end, out MentorLake.Pango.PangoScript script);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_script_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoScriptIterHandle>))] MentorLake.Pango.PangoScriptIterHandle iter);

}

/// <summary>
/// <para>
/// A `PangoScriptIter` is used to iterate through a string
/// and identify ranges in different scripts.
/// </para>
/// </summary>

public struct PangoScriptIter
{
}

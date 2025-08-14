namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_bool_t is used for boolean values. Returns of type
/// #cairo_bool_t will always be either 0 or 1, but testing against
/// these values explicitly is not encouraged; just use the
/// value as a boolean condition.
/// </para>
/// <para>
/// <informalexample><programlisting>
///  if (cairo_in_stroke (cr, x, y)) {
///      /<!-- -->* do something *<!-- -->/
///  }
/// </programlisting></informalexample>
/// </para>
/// </summary>

public struct cairo_bool_t
{
	public int Value;
}

public class cairo_bool_tHandle : BaseSafeHandle
{
}

public static class cairo_bool_tHandleExtensions
{
	public static cairo_bool_t Dereference(this cairo_bool_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_bool_t>(x.DangerousGetHandle());
	public static int DereferenceValue(this cairo_bool_tHandle x) => x.Dereference().Value;
}

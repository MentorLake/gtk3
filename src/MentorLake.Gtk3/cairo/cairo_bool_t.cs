namespace MentorLake.cairo;

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

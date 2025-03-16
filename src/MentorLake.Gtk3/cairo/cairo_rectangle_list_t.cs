namespace MentorLake.cairo;

public class cairo_rectangle_list_tHandle : BaseSafeHandle
{
}


public static class cairo_rectangle_list_tExtensions
{

	public static cairo_rectangle_list_t Dereference(this cairo_rectangle_list_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_rectangle_list_t>(x.DangerousGetHandle());
}
internal class cairo_rectangle_list_tExterns
{
}

public struct cairo_rectangle_list_t
{
	public cairo_status_t status;
	public IntPtr rectangles;
	public int num_rectangles;
}

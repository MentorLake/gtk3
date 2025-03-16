namespace MentorLake.cairo;

public class cairo_path_tHandle : BaseSafeHandle
{
}


public static class cairo_path_tExtensions
{

	public static cairo_path_t Dereference(this cairo_path_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_path_t>(x.DangerousGetHandle());
}
internal class cairo_path_tExterns
{
}

public struct cairo_path_t
{
	public cairo_status_t status;
	public IntPtr data;
	public int num_data;
}

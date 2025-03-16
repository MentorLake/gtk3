namespace MentorLake.cairo;

public class cairo_text_cluster_tHandle : BaseSafeHandle
{
}


public static class cairo_text_cluster_tExtensions
{

	public static cairo_text_cluster_t Dereference(this cairo_text_cluster_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_text_cluster_t>(x.DangerousGetHandle());
}
internal class cairo_text_cluster_tExterns
{
}

public struct cairo_text_cluster_t
{
	public int num_bytes;
	public int num_glyphs;
}

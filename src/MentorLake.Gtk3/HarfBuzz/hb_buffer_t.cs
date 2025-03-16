namespace MentorLake.HarfBuzz;

public class hb_buffer_tHandle : BaseSafeHandle
{
}


public static class hb_buffer_tExtensions
{

	public static hb_buffer_t Dereference(this hb_buffer_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_buffer_t>(x.DangerousGetHandle());
}
internal class hb_buffer_tExterns
{
}

public struct hb_buffer_t
{
}

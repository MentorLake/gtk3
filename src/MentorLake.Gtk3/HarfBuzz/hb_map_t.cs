namespace MentorLake.HarfBuzz;

public class hb_map_tHandle : BaseSafeHandle
{
}


public static class hb_map_tExtensions
{

	public static hb_map_t Dereference(this hb_map_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_map_t>(x.DangerousGetHandle());
}
internal class hb_map_tExterns
{
}

public struct hb_map_t
{
}

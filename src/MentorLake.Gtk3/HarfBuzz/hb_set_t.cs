namespace MentorLake.HarfBuzz;

public class hb_set_tHandle : BaseSafeHandle
{
}


public static class hb_set_tExtensions
{

	public static hb_set_t Dereference(this hb_set_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_set_t>(x.DangerousGetHandle());
}
internal class hb_set_tExterns
{
}

public struct hb_set_t
{
}

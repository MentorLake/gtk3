namespace MentorLake.HarfBuzz;

public struct hb_position_t
{
	public int Value;
}

public class hb_position_tHandle : BaseSafeHandle
{
}

public static class hb_position_tHandleExtensions
{
	public static hb_position_t Dereference(this hb_position_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_position_t>(x.DangerousGetHandle());
	public static int DereferenceValue(this hb_position_tHandle x) => x.Dereference().Value;
}

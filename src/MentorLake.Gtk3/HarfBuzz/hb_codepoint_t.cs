namespace MentorLake.HarfBuzz;

public struct hb_codepoint_t
{
	public uint Value;
}

public class hb_codepoint_tHandle : BaseSafeHandle
{
}

public static class hb_codepoint_tHandleExtensions
{
	public static hb_codepoint_t Dereference(this hb_codepoint_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_codepoint_t>(x.DangerousGetHandle());
	public static uint DereferenceValue(this hb_codepoint_tHandle x) => x.Dereference().Value;
}

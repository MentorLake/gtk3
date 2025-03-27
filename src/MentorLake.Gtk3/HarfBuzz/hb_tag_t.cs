namespace MentorLake.HarfBuzz;

public struct hb_tag_t
{
	public uint Value;
}

public class hb_tag_tHandle : BaseSafeHandle
{
}

public static class hb_tag_tHandleExtensions
{
	public static hb_tag_t Dereference(this hb_tag_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_tag_t>(x.DangerousGetHandle());
	public static uint DereferenceValue(this hb_tag_tHandle x) => x.Dereference().Value;
}

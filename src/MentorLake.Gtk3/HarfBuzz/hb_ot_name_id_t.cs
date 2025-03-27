namespace MentorLake.HarfBuzz;

public struct hb_ot_name_id_t
{
	public uint Value;
}

public class hb_ot_name_id_tHandle : BaseSafeHandle
{
}

public static class hb_ot_name_id_tHandleExtensions
{
	public static hb_ot_name_id_t Dereference(this hb_ot_name_id_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_name_id_t>(x.DangerousGetHandle());
	public static uint DereferenceValue(this hb_ot_name_id_tHandle x) => x.Dereference().Value;
}

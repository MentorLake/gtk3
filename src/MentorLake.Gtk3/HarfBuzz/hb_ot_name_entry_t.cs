namespace MentorLake.HarfBuzz;

public class hb_ot_name_entry_tHandle : BaseSafeHandle
{
}


public static class hb_ot_name_entry_tExtensions
{

	public static hb_ot_name_entry_t Dereference(this hb_ot_name_entry_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_name_entry_t>(x.DangerousGetHandle());
}
internal class hb_ot_name_entry_tExterns
{
}

public struct hb_ot_name_entry_t
{
	public hb_ot_name_id_t name_id;
	public hb_language_t language;
}

namespace MentorLake.HarfBuzz;

public class hb_ot_math_kern_entry_tHandle : BaseSafeHandle
{
}


public static class hb_ot_math_kern_entry_tExtensions
{

	public static hb_ot_math_kern_entry_t Dereference(this hb_ot_math_kern_entry_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_math_kern_entry_t>(x.DangerousGetHandle());
}
internal class hb_ot_math_kern_entry_tExterns
{
}

public struct hb_ot_math_kern_entry_t
{
	public hb_position_t max_correction_height;
	public hb_position_t kern_value;
}

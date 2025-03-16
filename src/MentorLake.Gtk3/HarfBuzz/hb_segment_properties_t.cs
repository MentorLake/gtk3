namespace MentorLake.HarfBuzz;

public class hb_segment_properties_tHandle : BaseSafeHandle
{
}


public static class hb_segment_properties_tExtensions
{

	public static hb_segment_properties_t Dereference(this hb_segment_properties_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_segment_properties_t>(x.DangerousGetHandle());
}
internal class hb_segment_properties_tExterns
{
}

public struct hb_segment_properties_t
{
	public hb_direction_t direction;
	public hb_script_t script;
	public hb_language_t language;
}

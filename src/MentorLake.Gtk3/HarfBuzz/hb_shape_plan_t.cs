namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for holding a shaping plan.
/// </para>
/// <para>
/// Shape plans contain information about how HarfBuzz will shape a
/// particular text segment, based on the segment&apos;s properties and the
/// capabilities in the font face in use.
/// </para>
/// <para>
/// Shape plans can be queried about how shaping will perform, given a set
/// of specific input parameters (script, language, direction, features,
/// etc.).
/// </para>
/// </summary>

public class hb_shape_plan_tHandle : BaseSafeHandle
{
}


public static class hb_shape_plan_tExtensions
{

	public static hb_shape_plan_t Dereference(this hb_shape_plan_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_shape_plan_t>(x.DangerousGetHandle());
}
internal class hb_shape_plan_tExterns
{
}

/// <summary>
/// <para>
/// Data type for holding a shaping plan.
/// </para>
/// <para>
/// Shape plans contain information about how HarfBuzz will shape a
/// particular text segment, based on the segment&apos;s properties and the
/// capabilities in the font face in use.
/// </para>
/// <para>
/// Shape plans can be queried about how shaping will perform, given a set
/// of specific input parameters (script, language, direction, features,
/// etc.).
/// </para>
/// </summary>

public struct hb_shape_plan_t
{
}

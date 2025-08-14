namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for holding font faces.
/// </para>
/// </summary>

public class hb_face_tHandle : BaseSafeHandle
{
}


public static class hb_face_tExtensions
{

	public static hb_face_t Dereference(this hb_face_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_face_t>(x.DangerousGetHandle());
}
internal class hb_face_tExterns
{
}

/// <summary>
/// <para>
/// Data type for holding font faces.
/// </para>
/// </summary>

public struct hb_face_t
{
}

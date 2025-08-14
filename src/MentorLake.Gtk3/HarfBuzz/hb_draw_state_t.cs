namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Current drawing state.
/// </para>
/// </summary>

public class hb_draw_state_tHandle : BaseSafeHandle
{
}


public static class hb_draw_state_tExtensions
{

	public static hb_draw_state_t Dereference(this hb_draw_state_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_draw_state_t>(x.DangerousGetHandle());
}
internal class hb_draw_state_tExterns
{
}

/// <summary>
/// <para>
/// Current drawing state.
/// </para>
/// </summary>

public struct hb_draw_state_t
{
	/// <summary>
/// <para>
/// Whether there is an open path
/// </para>
/// </summary>

public hb_bool_t path_open;
	/// <summary>
/// <para>
/// X component of the start of current path
/// </para>
/// </summary>

public float path_start_x;
	/// <summary>
/// <para>
/// Y component of the start of current path
/// </para>
/// </summary>

public float path_start_y;
	/// <summary>
/// <para>
/// X component of current point
/// </para>
/// </summary>

public float current_x;
	/// <summary>
/// <para>
/// Y component of current point
/// </para>
/// </summary>

public float current_y;
}

namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Glyph draw callbacks.
/// </para>
/// <para>
/// #hb_draw_move_to_func_t, #hb_draw_line_to_func_t and
/// #hb_draw_cubic_to_func_t calls are necessary to be defined but we translate
/// #hb_draw_quadratic_to_func_t calls to #hb_draw_cubic_to_func_t if the
/// callback isn&apos;t defined.
/// </para>
/// </summary>

public class hb_draw_funcs_tHandle : BaseSafeHandle
{
}


public static class hb_draw_funcs_tExtensions
{

	public static hb_draw_funcs_t Dereference(this hb_draw_funcs_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_draw_funcs_t>(x.DangerousGetHandle());
}
internal class hb_draw_funcs_tExterns
{
}

/// <summary>
/// <para>
/// Glyph draw callbacks.
/// </para>
/// <para>
/// #hb_draw_move_to_func_t, #hb_draw_line_to_func_t and
/// #hb_draw_cubic_to_func_t calls are necessary to be defined but we translate
/// #hb_draw_quadratic_to_func_t calls to #hb_draw_cubic_to_func_t if the
/// callback isn&apos;t defined.
/// </para>
/// </summary>

public struct hb_draw_funcs_t
{
}

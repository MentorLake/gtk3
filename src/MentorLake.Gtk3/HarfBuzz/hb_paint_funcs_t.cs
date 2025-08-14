namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Glyph paint callbacks.
/// </para>
/// <para>
/// The callbacks assume that the caller maintains a stack
/// of current transforms, clips and intermediate surfaces,
/// as evidenced by the pairs of push/pop callbacks. The
/// push/pop calls will be properly nested, so it is fine
/// to store the different kinds of object on a single stack.
/// </para>
/// <para>
/// Not all callbacks are required for all kinds of glyphs.
/// For rendering COLRv0 or non-color outline glyphs, the
/// gradient callbacks are not needed, and the composite
/// callback only needs to handle simple alpha compositing
/// (#HB_PAINT_COMPOSITE_MODE_SRC_OVER).
/// </para>
/// <para>
/// The paint-image callback is only needed for glyphs
/// with image blobs in the CBDT, sbix or SVG tables.
/// </para>
/// <para>
/// The custom-palette-color callback is only necessary if
/// you want to override colors from the font palette with
/// custom colors.
/// </para>
/// </summary>

public class hb_paint_funcs_tHandle : BaseSafeHandle
{
}


public static class hb_paint_funcs_tExtensions
{

	public static hb_paint_funcs_t Dereference(this hb_paint_funcs_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_paint_funcs_t>(x.DangerousGetHandle());
}
internal class hb_paint_funcs_tExterns
{
}

/// <summary>
/// <para>
/// Glyph paint callbacks.
/// </para>
/// <para>
/// The callbacks assume that the caller maintains a stack
/// of current transforms, clips and intermediate surfaces,
/// as evidenced by the pairs of push/pop callbacks. The
/// push/pop calls will be properly nested, so it is fine
/// to store the different kinds of object on a single stack.
/// </para>
/// <para>
/// Not all callbacks are required for all kinds of glyphs.
/// For rendering COLRv0 or non-color outline glyphs, the
/// gradient callbacks are not needed, and the composite
/// callback only needs to handle simple alpha compositing
/// (#HB_PAINT_COMPOSITE_MODE_SRC_OVER).
/// </para>
/// <para>
/// The paint-image callback is only needed for glyphs
/// with image blobs in the CBDT, sbix or SVG tables.
/// </para>
/// <para>
/// The custom-palette-color callback is only necessary if
/// you want to override colors from the font palette with
/// custom colors.
/// </para>
/// </summary>

public struct hb_paint_funcs_t
{
}

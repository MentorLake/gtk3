namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Information about a color stop on a color line.
/// </para>
/// <para>
/// Color lines typically have offsets ranging between 0 and 1,
/// but that is not required.
/// </para>
/// <para>
/// Note: despite @color being unpremultiplied here, interpolation in
/// gradients shall happen in premultiplied space. See the OpenType spec
/// [COLR](https://learn.microsoft.com/en-us/typography/opentype/spec/colr)
/// section for details.
/// </para>
/// </summary>

public class hb_color_stop_tHandle : BaseSafeHandle
{
}


public static class hb_color_stop_tExtensions
{

	public static hb_color_stop_t Dereference(this hb_color_stop_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_color_stop_t>(x.DangerousGetHandle());
}
internal class hb_color_stop_tExterns
{
}

/// <summary>
/// <para>
/// Information about a color stop on a color line.
/// </para>
/// <para>
/// Color lines typically have offsets ranging between 0 and 1,
/// but that is not required.
/// </para>
/// <para>
/// Note: despite @color being unpremultiplied here, interpolation in
/// gradients shall happen in premultiplied space. See the OpenType spec
/// [COLR](https://learn.microsoft.com/en-us/typography/opentype/spec/colr)
/// section for details.
/// </para>
/// </summary>

public struct hb_color_stop_t
{
	/// <summary>
/// <para>
/// the offset of the color stop
/// </para>
/// </summary>

public float offset;
	/// <summary>
/// <para>
/// whether the color is the foreground
/// </para>
/// </summary>

public hb_bool_t is_foreground;
	/// <summary>
/// <para>
/// the color, unpremultiplied
/// </para>
/// </summary>

public hb_color_t color;
}

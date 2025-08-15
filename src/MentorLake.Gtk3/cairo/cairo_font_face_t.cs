namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A #cairo_font_face_t specifies all aspects of a font other
/// than the size or font matrix (a font matrix is used to distort
/// a font by shearing it or scaling it unequally in the two
/// directions) . A font face can be set on a #cairo_t by using
/// cairo_set_font_face(); the size and font matrix are set with
/// cairo_set_font_size() and cairo_set_font_matrix().
/// </para>
/// <para>
/// There are various types of font faces, depending on the
/// &amp;lt;firstterm&amp;gt;font backend&amp;lt;/firstterm&amp;gt; they use. The type of a
/// font face can be queried using cairo_font_face_get_type().
/// </para>
/// <para>
/// Memory management of #cairo_font_face_t is done with
/// cairo_font_face_reference() and cairo_font_face_destroy().
/// </para>
/// </summary>

public class cairo_font_face_tHandle : BaseSafeHandle
{
}


public static class cairo_font_face_tExtensions
{

	public static cairo_font_face_t Dereference(this cairo_font_face_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_font_face_t>(x.DangerousGetHandle());
}
internal class cairo_font_face_tExterns
{
}

/// <summary>
/// <para>
/// A #cairo_font_face_t specifies all aspects of a font other
/// than the size or font matrix (a font matrix is used to distort
/// a font by shearing it or scaling it unequally in the two
/// directions) . A font face can be set on a #cairo_t by using
/// cairo_set_font_face(); the size and font matrix are set with
/// cairo_set_font_size() and cairo_set_font_matrix().
/// </para>
/// <para>
/// There are various types of font faces, depending on the
/// &amp;lt;firstterm&amp;gt;font backend&amp;lt;/firstterm&amp;gt; they use. The type of a
/// font face can be queried using cairo_font_face_get_type().
/// </para>
/// <para>
/// Memory management of #cairo_font_face_t is done with
/// cairo_font_face_reference() and cairo_font_face_destroy().
/// </para>
/// </summary>

public struct cairo_font_face_t
{
}

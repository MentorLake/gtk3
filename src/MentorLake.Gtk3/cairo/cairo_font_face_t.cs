namespace MentorLake.cairo;

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

public struct cairo_font_face_t
{
}

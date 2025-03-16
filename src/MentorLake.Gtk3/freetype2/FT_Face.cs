namespace MentorLake.freetype2;

public class FT_FaceHandle : BaseSafeHandle
{
}


public static class FT_FaceExtensions
{

	public static FT_Face Dereference(this FT_FaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<FT_Face>(x.DangerousGetHandle());
}
internal class FT_FaceExterns
{
}

public struct FT_Face
{
}

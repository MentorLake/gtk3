namespace MentorLake.freetype2;


public class FT_BitmapHandle : BaseSafeHandle
{
}


public static class FT_BitmapExtensions
{

	public static FT_Bitmap Dereference(this FT_BitmapHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<FT_Bitmap>(x.DangerousGetHandle());
}
internal class FT_BitmapExterns
{
}


public struct FT_Bitmap
{
}

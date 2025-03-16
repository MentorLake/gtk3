namespace MentorLake.freetype2;

public class FT_LibraryHandle : BaseSafeHandle
{
}


public static class FT_LibraryExtensions
{

	public static FT_Library Dereference(this FT_LibraryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<FT_Library>(x.DangerousGetHandle());
}
internal class FT_LibraryExterns
{
}

public struct FT_Library
{
}

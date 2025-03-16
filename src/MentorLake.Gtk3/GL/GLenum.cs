namespace MentorLake.GL;

public class GLenumHandle : BaseSafeHandle
{
}


public static class GLenumExtensions
{

	public static GLenum Dereference(this GLenumHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLenum>(x.DangerousGetHandle());
}
internal class GLenumExterns
{
}

public struct GLenum
{
}

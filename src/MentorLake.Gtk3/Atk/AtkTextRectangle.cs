namespace MentorLake.Atk;

public class AtkTextRectangleHandle : BaseSafeHandle
{
}


public static class AtkTextRectangleExtensions
{

	public static AtkTextRectangle Dereference(this AtkTextRectangleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkTextRectangle>(x.DangerousGetHandle());
}
internal class AtkTextRectangleExterns
{
}

public struct AtkTextRectangle
{
	public int x;
	public int y;
	public int width;
	public int height;
}

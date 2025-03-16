namespace MentorLake.Atk;

public class AtkRectangleHandle : BaseSafeHandle
{
}


public static class AtkRectangleExtensions
{

	public static AtkRectangle Dereference(this AtkRectangleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkRectangle>(x.DangerousGetHandle());
}
internal class AtkRectangleExterns
{
}

public struct AtkRectangle
{
	public int x;
	public int y;
	public int width;
	public int height;
}

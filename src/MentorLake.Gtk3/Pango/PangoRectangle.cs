namespace MentorLake.Pango;

public class PangoRectangleHandle : BaseSafeHandle
{
}


public static class PangoRectangleExtensions
{

	public static PangoRectangle Dereference(this PangoRectangleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoRectangle>(x.DangerousGetHandle());
}
internal class PangoRectangleExterns
{
}

public struct PangoRectangle
{
	public int x;
	public int y;
	public int width;
	public int height;
}

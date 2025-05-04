namespace MentorLake.Gdk;

public class GdkTimeCoordHandle : BaseSafeHandle
{
}


public static class GdkTimeCoordExtensions
{

	public static GdkTimeCoord Dereference(this GdkTimeCoordHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkTimeCoord>(x.DangerousGetHandle());
}
internal class GdkTimeCoordExterns
{
}

public struct GdkTimeCoord
{
	public uint time;
	[MarshalAs(UnmanagedType.ByValArray)] public double[] axes;
}

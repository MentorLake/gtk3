namespace MentorLake.Gdk;


public class GdkEventSequenceHandle : BaseSafeHandle
{
}


public static class GdkEventSequenceExtensions
{

	public static GdkEventSequence Dereference(this GdkEventSequenceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventSequence>(x.DangerousGetHandle());
}
internal class GdkEventSequenceExterns
{
}


public struct GdkEventSequence
{
}

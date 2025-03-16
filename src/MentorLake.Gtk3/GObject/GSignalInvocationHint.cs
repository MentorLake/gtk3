namespace MentorLake.GObject;

public class GSignalInvocationHintHandle : BaseSafeHandle
{
}


public static class GSignalInvocationHintExtensions
{

	public static GSignalInvocationHint Dereference(this GSignalInvocationHintHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSignalInvocationHint>(x.DangerousGetHandle());
}
internal class GSignalInvocationHintExterns
{
}

public struct GSignalInvocationHint
{
	public uint signal_id;
	public GQuark detail;
	public GSignalFlags run_type;
}

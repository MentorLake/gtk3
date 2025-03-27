namespace MentorLake.GObject;

public struct GSignalCMarshaller
{
	public MentorLake.GObject.GClosureMarshal Value;
}

public class GSignalCMarshallerHandle : BaseSafeHandle
{
}

public static class GSignalCMarshallerHandleExtensions
{
	public static GSignalCMarshaller Dereference(this GSignalCMarshallerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSignalCMarshaller>(x.DangerousGetHandle());
	public static MentorLake.GObject.GClosureMarshal DereferenceValue(this GSignalCMarshallerHandle x) => x.Dereference().Value;
}

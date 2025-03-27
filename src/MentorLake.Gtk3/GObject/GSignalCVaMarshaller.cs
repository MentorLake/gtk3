namespace MentorLake.GObject;

public struct GSignalCVaMarshaller
{
	public MentorLake.GObject.GVaClosureMarshal Value;
}

public class GSignalCVaMarshallerHandle : BaseSafeHandle
{
}

public static class GSignalCVaMarshallerHandleExtensions
{
	public static GSignalCVaMarshaller Dereference(this GSignalCVaMarshallerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSignalCVaMarshaller>(x.DangerousGetHandle());
	public static MentorLake.GObject.GVaClosureMarshal DereferenceValue(this GSignalCVaMarshallerHandle x) => x.Dereference().Value;
}

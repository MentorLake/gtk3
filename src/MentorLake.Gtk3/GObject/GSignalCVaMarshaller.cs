namespace MentorLake.GObject;

/// <summary>
/// <para>
/// This is the signature of va_list marshaller functions, an optional
/// marshaller that can be used in some situations to avoid
/// marshalling the signal argument into GValues.
/// </para>
/// </summary>

public struct GSignalCVaMarshaller
{
	public MentorLake.GObject.GVaClosureMarshal Value;
}

/// <summary>
/// <para>
/// This is the signature of va_list marshaller functions, an optional
/// marshaller that can be used in some situations to avoid
/// marshalling the signal argument into GValues.
/// </para>
/// </summary>

public class GSignalCVaMarshallerHandle : BaseSafeHandle
{
}

public static class GSignalCVaMarshallerHandleExtensions
{
	public static GSignalCVaMarshaller Dereference(this GSignalCVaMarshallerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSignalCVaMarshaller>(x.DangerousGetHandle());
	public static MentorLake.GObject.GVaClosureMarshal DereferenceValue(this GSignalCVaMarshallerHandle x) => x.Dereference().Value;
}

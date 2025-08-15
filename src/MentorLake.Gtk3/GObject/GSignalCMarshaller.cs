namespace MentorLake.GObject;

/// <summary>
/// <para>
/// This is the signature of marshaller functions, required to marshall
/// arrays of parameter values to signal emissions into C language callback
/// invocations.
/// </para>
/// <para>
/// It is merely an alias to #GClosureMarshal since the #GClosure mechanism
/// takes over responsibility of actual function invocation for the signal
/// system.
/// </para>
/// </summary>

public struct GSignalCMarshaller
{
	public MentorLake.GObject.GClosureMarshal Value;
}

/// <summary>
/// <para>
/// This is the signature of marshaller functions, required to marshall
/// arrays of parameter values to signal emissions into C language callback
/// invocations.
/// </para>
/// <para>
/// It is merely an alias to #GClosureMarshal since the #GClosure mechanism
/// takes over responsibility of actual function invocation for the signal
/// system.
/// </para>
/// </summary>

public class GSignalCMarshallerHandle : BaseSafeHandle
{
}

public static class GSignalCMarshallerHandleExtensions
{
	public static GSignalCMarshaller Dereference(this GSignalCMarshallerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSignalCMarshaller>(x.DangerousGetHandle());
	public static MentorLake.GObject.GClosureMarshal DereferenceValue(this GSignalCMarshallerHandle x) => x.Dereference().Value;
}

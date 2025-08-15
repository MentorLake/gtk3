namespace MentorLake.Atk;


public class AtkImplementorHandle : BaseSafeHandle
{
}


public static class AtkImplementorExtensions
{
/// <summary>
/// <para>
/// Gets a reference to an object&apos;s #AtkObject implementation, if
/// the object implements #AtkObjectIface
/// </para>
/// </summary>

/// <param name="implementor">
/// The #GObject instance which should implement #AtkImplementorIface
/// if a non-null return value is required.
/// </param>
/// <return>
/// a reference to an object&apos;s #AtkObject
/// implementation
/// </return>

	public static MentorLake.Atk.AtkObjectHandle RefAccessible(this MentorLake.Atk.AtkImplementorHandle implementor)
	{
		if (implementor.IsInvalid) throw new Exception("Invalid handle (AtkImplementor)");
		return AtkImplementorExterns.atk_implementor_ref_accessible(implementor);
	}


	public static AtkImplementor Dereference(this AtkImplementorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkImplementor>(x.DangerousGetHandle());
}
internal class AtkImplementorExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_implementor_ref_accessible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImplementorHandle>))] MentorLake.Atk.AtkImplementorHandle implementor);

}


public struct AtkImplementor
{
}

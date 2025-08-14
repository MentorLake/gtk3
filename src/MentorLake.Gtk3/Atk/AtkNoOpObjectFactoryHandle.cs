namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The AtkObjectFactory which creates an AtkNoOpObject.
/// </para>
/// <para>
/// The AtkObjectFactory which creates an AtkNoOpObject. An instance of
/// this is created by an AtkRegistry if no factory type has not been
/// specified to create an accessible object of a particular type.
/// </para>
/// </summary>

public class AtkNoOpObjectFactoryHandle : AtkObjectFactoryHandle
{
/// <summary>
/// <para>
/// Creates an instance of an #AtkObjectFactory which generates primitive
/// (non-functioning) #AtkObjects.
/// </para>
/// </summary>

/// <return>
/// an instance of an #AtkObjectFactory
/// </return>

	public static MentorLake.Atk.AtkNoOpObjectFactoryHandle New()
	{
		return AtkNoOpObjectFactoryHandleExterns.atk_no_op_object_factory_new();
	}

}

public static class AtkNoOpObjectFactoryHandleExtensions
{
}

internal class AtkNoOpObjectFactoryHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkNoOpObjectFactoryHandle>))]
	internal static extern MentorLake.Atk.AtkNoOpObjectFactoryHandle atk_no_op_object_factory_new();

}

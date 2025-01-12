namespace MentorLake.Gtk3.Atk;

public class AtkNoOpObjectFactoryHandle : AtkObjectFactoryHandle
{
	public static AtkNoOpObjectFactoryHandle New()
	{
		return AtkNoOpObjectFactoryExterns.atk_no_op_object_factory_new();
	}

}

public static class AtkNoOpObjectFactoryHandleExtensions
{
}

internal class AtkNoOpObjectFactoryExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkNoOpObjectFactoryHandle atk_no_op_object_factory_new();

}

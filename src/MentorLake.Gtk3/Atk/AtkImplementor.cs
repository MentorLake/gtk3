namespace MentorLake.Gtk3.Atk;

public class AtkImplementorHandle : BaseSafeHandle
{
}


public static class AtkImplementorHandleExtensions
{
	public static AtkObjectHandle RefAccessible(this AtkImplementorHandle implementor)
	{
		return AtkImplementorExterns.atk_implementor_ref_accessible(implementor);
	}

}
internal class AtkImplementorExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_implementor_ref_accessible(AtkImplementorHandle implementor);

}

public struct AtkImplementor
{
}

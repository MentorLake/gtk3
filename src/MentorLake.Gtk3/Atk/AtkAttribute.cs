namespace MentorLake.Gtk3.Atk;

public class AtkAttributeHandle : BaseSafeHandle
{
}


public static class AtkAttributeHandleExtensions
{
	public static void SetFree(AtkAttributeSetHandle attrib_set)
	{
		AtkAttributeExterns.atk_attribute_set_free(attrib_set);
	}

}
internal class AtkAttributeExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern void atk_attribute_set_free(AtkAttributeSetHandle attrib_set);

}

public struct AtkAttribute
{
	public string name;
	public string value;
}

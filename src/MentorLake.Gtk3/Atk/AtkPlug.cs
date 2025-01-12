namespace MentorLake.Gtk3.Atk;

public class AtkPlugHandle : AtkObjectHandle, AtkComponentHandle
{
	public static AtkPlugHandle New()
	{
		return AtkPlugExterns.atk_plug_new();
	}

}

public static class AtkPlugHandleExtensions
{
	public static string GetId(this AtkPlugHandle plug)
	{
		return AtkPlugExterns.atk_plug_get_id(plug);
	}

	public static T SetChild<T>(this T plug, AtkObjectHandle child) where T : AtkPlugHandle
	{
		AtkPlugExterns.atk_plug_set_child(plug, child);
		return plug;
	}

}

internal class AtkPlugExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkPlugHandle atk_plug_new();

	[DllImport(Libraries.Atk)]
	internal static extern string atk_plug_get_id(AtkPlugHandle plug);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_plug_set_child(AtkPlugHandle plug, AtkObjectHandle child);

}

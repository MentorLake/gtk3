namespace MentorLake.Gio;

public class GPropertyActionHandle : GObjectHandle, GActionHandle
{
	public static MentorLake.Gio.GPropertyActionHandle New(string name, MentorLake.GObject.GObjectHandle @object, string property_name)
	{
		return GPropertyActionHandleExterns.g_property_action_new(name, @object, property_name);
	}

}

public static class GPropertyActionHandleExtensions
{
}

internal class GPropertyActionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GPropertyActionHandle>))]
	internal static extern MentorLake.Gio.GPropertyActionHandle g_property_action_new(string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property_name);

}

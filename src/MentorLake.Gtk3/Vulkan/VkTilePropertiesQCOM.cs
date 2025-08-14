namespace MentorLake.Vulkan;


public class VkTilePropertiesQCOMHandle : BaseSafeHandle
{
}


public static class VkTilePropertiesQCOMExtensions
{

	public static VkTilePropertiesQCOM Dereference(this VkTilePropertiesQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTilePropertiesQCOM>(x.DangerousGetHandle());
}
internal class VkTilePropertiesQCOMExterns
{
}


public struct VkTilePropertiesQCOM
{
}

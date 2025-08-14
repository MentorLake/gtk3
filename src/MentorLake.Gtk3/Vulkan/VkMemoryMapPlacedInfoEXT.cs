namespace MentorLake.Vulkan;


public class VkMemoryMapPlacedInfoEXTHandle : BaseSafeHandle
{
}


public static class VkMemoryMapPlacedInfoEXTExtensions
{

	public static VkMemoryMapPlacedInfoEXT Dereference(this VkMemoryMapPlacedInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryMapPlacedInfoEXT>(x.DangerousGetHandle());
}
internal class VkMemoryMapPlacedInfoEXTExterns
{
}


public struct VkMemoryMapPlacedInfoEXT
{
}

namespace MentorLake.Vulkan;


public class VkDeviceMemoryOverallocationCreateInfoAMDHandle : BaseSafeHandle
{
}


public static class VkDeviceMemoryOverallocationCreateInfoAMDExtensions
{

	public static VkDeviceMemoryOverallocationCreateInfoAMD Dereference(this VkDeviceMemoryOverallocationCreateInfoAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceMemoryOverallocationCreateInfoAMD>(x.DangerousGetHandle());
}
internal class VkDeviceMemoryOverallocationCreateInfoAMDExterns
{
}


public struct VkDeviceMemoryOverallocationCreateInfoAMD
{
}

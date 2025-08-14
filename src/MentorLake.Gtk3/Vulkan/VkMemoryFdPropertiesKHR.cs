namespace MentorLake.Vulkan;


public class VkMemoryFdPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryFdPropertiesKHRExtensions
{

	public static VkMemoryFdPropertiesKHR Dereference(this VkMemoryFdPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryFdPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkMemoryFdPropertiesKHRExterns
{
}


public struct VkMemoryFdPropertiesKHR
{
}

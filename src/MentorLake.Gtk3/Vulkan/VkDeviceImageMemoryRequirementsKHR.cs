namespace MentorLake.Vulkan;

public class VkDeviceImageMemoryRequirementsKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceImageMemoryRequirementsKHRExtensions
{

	public static VkDeviceImageMemoryRequirementsKHR Dereference(this VkDeviceImageMemoryRequirementsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceImageMemoryRequirementsKHR>(x.DangerousGetHandle());
}
internal class VkDeviceImageMemoryRequirementsKHRExterns
{
}

public struct VkDeviceImageMemoryRequirementsKHR
{
}

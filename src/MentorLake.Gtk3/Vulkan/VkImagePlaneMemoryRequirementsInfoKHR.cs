namespace MentorLake.Vulkan;

public class VkImagePlaneMemoryRequirementsInfoKHRHandle : BaseSafeHandle
{
}


public static class VkImagePlaneMemoryRequirementsInfoKHRExtensions
{

	public static VkImagePlaneMemoryRequirementsInfoKHR Dereference(this VkImagePlaneMemoryRequirementsInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImagePlaneMemoryRequirementsInfoKHR>(x.DangerousGetHandle());
}
internal class VkImagePlaneMemoryRequirementsInfoKHRExterns
{
}

public struct VkImagePlaneMemoryRequirementsInfoKHR
{
}

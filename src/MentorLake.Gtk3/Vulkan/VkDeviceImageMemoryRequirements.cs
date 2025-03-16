namespace MentorLake.Vulkan;

public class VkDeviceImageMemoryRequirementsHandle : BaseSafeHandle
{
}


public static class VkDeviceImageMemoryRequirementsExtensions
{

	public static VkDeviceImageMemoryRequirements Dereference(this VkDeviceImageMemoryRequirementsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceImageMemoryRequirements>(x.DangerousGetHandle());
}
internal class VkDeviceImageMemoryRequirementsExterns
{
}

public struct VkDeviceImageMemoryRequirements
{
}

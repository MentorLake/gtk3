namespace MentorLake.Vulkan;


public class VkPhysicalDeviceImageAlignmentControlPropertiesMESAHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageAlignmentControlPropertiesMESAExtensions
{

	public static VkPhysicalDeviceImageAlignmentControlPropertiesMESA Dereference(this VkPhysicalDeviceImageAlignmentControlPropertiesMESAHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageAlignmentControlPropertiesMESA>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageAlignmentControlPropertiesMESAExterns
{
}


public struct VkPhysicalDeviceImageAlignmentControlPropertiesMESA
{
}

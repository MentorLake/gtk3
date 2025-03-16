namespace MentorLake.Vulkan;

public class VkPhysicalDeviceCopyMemoryIndirectPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCopyMemoryIndirectPropertiesNVExtensions
{

	public static VkPhysicalDeviceCopyMemoryIndirectPropertiesNV Dereference(this VkPhysicalDeviceCopyMemoryIndirectPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCopyMemoryIndirectPropertiesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCopyMemoryIndirectPropertiesNVExterns
{
}

public struct VkPhysicalDeviceCopyMemoryIndirectPropertiesNV
{
}

namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSparsePropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSparsePropertiesExtensions
{

	public static VkPhysicalDeviceSparseProperties Dereference(this VkPhysicalDeviceSparsePropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSparseProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSparsePropertiesExterns
{
}

public struct VkPhysicalDeviceSparseProperties
{
}

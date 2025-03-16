namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSamplerFilterMinmaxPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSamplerFilterMinmaxPropertiesExtensions
{

	public static VkPhysicalDeviceSamplerFilterMinmaxProperties Dereference(this VkPhysicalDeviceSamplerFilterMinmaxPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSamplerFilterMinmaxProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSamplerFilterMinmaxPropertiesExterns
{
}

public struct VkPhysicalDeviceSamplerFilterMinmaxProperties
{
}

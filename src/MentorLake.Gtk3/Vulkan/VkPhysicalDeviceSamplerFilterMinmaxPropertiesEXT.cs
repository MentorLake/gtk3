namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXTExtensions
{

	public static VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT Dereference(this VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT
{
}

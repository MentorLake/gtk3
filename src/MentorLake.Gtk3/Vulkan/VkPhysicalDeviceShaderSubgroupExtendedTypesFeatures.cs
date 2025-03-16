namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesExtensions
{

	public static VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures Dereference(this VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesExterns
{
}

public struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
{
}

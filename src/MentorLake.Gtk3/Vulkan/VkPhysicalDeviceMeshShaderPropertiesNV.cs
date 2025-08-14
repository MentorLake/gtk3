namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMeshShaderPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMeshShaderPropertiesNVExtensions
{

	public static VkPhysicalDeviceMeshShaderPropertiesNV Dereference(this VkPhysicalDeviceMeshShaderPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMeshShaderPropertiesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMeshShaderPropertiesNVExterns
{
}


public struct VkPhysicalDeviceMeshShaderPropertiesNV
{
}

namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMeshShaderPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMeshShaderPropertiesEXTExtensions
{

	public static VkPhysicalDeviceMeshShaderPropertiesEXT Dereference(this VkPhysicalDeviceMeshShaderPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMeshShaderPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMeshShaderPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceMeshShaderPropertiesEXT
{
}

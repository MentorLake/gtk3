namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVertexAttributeDivisorPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVertexAttributeDivisorPropertiesEXTExtensions
{

	public static VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT Dereference(this VkPhysicalDeviceVertexAttributeDivisorPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVertexAttributeDivisorPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
{
}

namespace MentorLake.Vulkan;


public class VkDescriptorGetInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDescriptorGetInfoEXTExtensions
{

	public static VkDescriptorGetInfoEXT Dereference(this VkDescriptorGetInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorGetInfoEXT>(x.DangerousGetHandle());
}
internal class VkDescriptorGetInfoEXTExterns
{
}


public struct VkDescriptorGetInfoEXT
{
}

namespace MentorLake.Vulkan;


public class VkDescriptorDataEXTHandle : BaseSafeHandle
{
}


public static class VkDescriptorDataEXTExtensions
{

	public static VkDescriptorDataEXT Dereference(this VkDescriptorDataEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorDataEXT>(x.DangerousGetHandle());
}
internal class VkDescriptorDataEXTExterns
{
}


public struct VkDescriptorDataEXT
{
}

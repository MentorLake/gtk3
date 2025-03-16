namespace MentorLake.Vulkan;

public class VkMutableDescriptorTypeListEXTHandle : BaseSafeHandle
{
}


public static class VkMutableDescriptorTypeListEXTExtensions
{

	public static VkMutableDescriptorTypeListEXT Dereference(this VkMutableDescriptorTypeListEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMutableDescriptorTypeListEXT>(x.DangerousGetHandle());
}
internal class VkMutableDescriptorTypeListEXTExterns
{
}

public struct VkMutableDescriptorTypeListEXT
{
}

namespace MentorLake.Vulkan;

public class VkMultiDrawIndexedInfoEXTHandle : BaseSafeHandle
{
}


public static class VkMultiDrawIndexedInfoEXTExtensions
{

	public static VkMultiDrawIndexedInfoEXT Dereference(this VkMultiDrawIndexedInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMultiDrawIndexedInfoEXT>(x.DangerousGetHandle());
}
internal class VkMultiDrawIndexedInfoEXTExterns
{
}

public struct VkMultiDrawIndexedInfoEXT
{
}

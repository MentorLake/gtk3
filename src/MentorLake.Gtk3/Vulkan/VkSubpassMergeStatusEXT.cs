namespace MentorLake.Vulkan;

public class VkSubpassMergeStatusEXTHandle : BaseSafeHandle
{
}


public static class VkSubpassMergeStatusEXTExtensions
{

	public static VkSubpassMergeStatusEXT Dereference(this VkSubpassMergeStatusEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassMergeStatusEXT>(x.DangerousGetHandle());
}
internal class VkSubpassMergeStatusEXTExterns
{
}

public struct VkSubpassMergeStatusEXT
{
}

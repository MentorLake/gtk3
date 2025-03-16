namespace MentorLake.Vulkan;

public class VkSubpassContentsHandle : BaseSafeHandle
{
}


public static class VkSubpassContentsExtensions
{

	public static VkSubpassContents Dereference(this VkSubpassContentsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassContents>(x.DangerousGetHandle());
}
internal class VkSubpassContentsExterns
{
}

public struct VkSubpassContents
{
}

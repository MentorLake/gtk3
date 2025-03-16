namespace MentorLake.Vulkan;

public class VkSubpassDependencyHandle : BaseSafeHandle
{
}


public static class VkSubpassDependencyExtensions
{

	public static VkSubpassDependency Dereference(this VkSubpassDependencyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassDependency>(x.DangerousGetHandle());
}
internal class VkSubpassDependencyExterns
{
}

public struct VkSubpassDependency
{
}

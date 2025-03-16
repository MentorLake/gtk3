namespace MentorLake.Vulkan;

public class VkSubpassDescriptionHandle : BaseSafeHandle
{
}


public static class VkSubpassDescriptionExtensions
{

	public static VkSubpassDescription Dereference(this VkSubpassDescriptionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassDescription>(x.DangerousGetHandle());
}
internal class VkSubpassDescriptionExterns
{
}

public struct VkSubpassDescription
{
}

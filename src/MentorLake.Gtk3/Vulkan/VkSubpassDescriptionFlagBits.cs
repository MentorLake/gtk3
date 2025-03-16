namespace MentorLake.Vulkan;

public class VkSubpassDescriptionFlagBitsHandle : BaseSafeHandle
{
}


public static class VkSubpassDescriptionFlagBitsExtensions
{

	public static VkSubpassDescriptionFlagBits Dereference(this VkSubpassDescriptionFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassDescriptionFlagBits>(x.DangerousGetHandle());
}
internal class VkSubpassDescriptionFlagBitsExterns
{
}

public struct VkSubpassDescriptionFlagBits
{
}

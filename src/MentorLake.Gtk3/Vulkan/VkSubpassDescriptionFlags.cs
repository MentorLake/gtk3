namespace MentorLake.Vulkan;

public class VkSubpassDescriptionFlagsHandle : BaseSafeHandle
{
}


public static class VkSubpassDescriptionFlagsExtensions
{

	public static VkSubpassDescriptionFlags Dereference(this VkSubpassDescriptionFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassDescriptionFlags>(x.DangerousGetHandle());
}
internal class VkSubpassDescriptionFlagsExterns
{
}

public struct VkSubpassDescriptionFlags
{
}

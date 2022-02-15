using static ExtensionMethods.Extensions.Target;

namespace ExtensionMethods.Extensions
{
    public static class TargetExtension
    {
        internal static void ExtendInternal(this InternalTarget internalTarget)
        {

        }

        /*
        internal static void ExtendInternalProtected(this InternalTarget.ProtectedSubClass internalTarget)
        {

        }
        */

        public static string GetStandardizedId(this Target target)
        {
            return target.GetId().ToUpper();
        }
    }
}
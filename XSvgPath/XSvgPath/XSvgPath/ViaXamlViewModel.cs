using System.Reflection;

namespace XSvgPath
{
    public class ViaXamlViewModel
    {
        public Assembly SvgAssembly => typeof(App).GetTypeInfo().Assembly;

        public string CoolMaskSvgPath => "XSvgPath.Images.CoolMask.svg";

        public string ElvisSvgPath => "XSvgPath.Images.Elvis.svg";

        public string TigerSvgPath => "XSvgPath.Images.tiger.svg";

        public string ErulisseuiinSpaceshipPackPath => "XSvgPath.Images.ErulisseuiinSpaceshipPack.svg";
    }
}

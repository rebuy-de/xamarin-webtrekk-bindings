using System;
using XamarinWebtrekkBindings;

namespace WebtrekkSample
{
    public class Webtrekk
    {
        private static readonly Lazy<Webtrekk> lazy =
            new Lazy<Webtrekk>(() => new Webtrekk());

        public static Webtrekk Instance { get { return lazy.Value; } }

        private WebtrekkProxy webtrekkProxy;

        private Webtrekk()
        {
        }

        public WebtrekkProxy GetWebtrekkProxy()
        {
            webtrekkProxy = new WebtrekkProxy();

            return webtrekkProxy;
        }
    }
}
